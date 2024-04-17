<#
.SYNOPSIS
    Runs a .NET flavoured build process.
.DESCRIPTION
    This script was scaffolded using a template from the Endjin.RecommendedPractices.Build PowerShell module.
    It uses the InvokeBuild module to orchestrate an opinonated software build process for .NET solutions.
.EXAMPLE
    PS C:\> ./build.ps1
    Downloads any missing module dependencies (Endjin.RecommendedPractices.Build & InvokeBuild) and executes
    the build process.
.PARAMETER Tasks
    Optionally override the default task executed as the entry-point of the build.
.PARAMETER Configuration
    The build configuration, defaults to 'Release'.
.PARAMETER BuildRepositoryUri
    Optional URI that supports pulling MSBuild logic from a web endpoint (e.g. a GitHub blob).
.PARAMETER SourcesDir
    The path where the source code to be built is located, defaults to the current working directory.
.PARAMETER CoverageDir
    The output path for the test coverage data, if run.
.PARAMETER TestReportTypes
    The test report format that should be generated by the test report generator, if run.
.PARAMETER PackagesDir
    The output path for any packages produced as part of the build.
.PARAMETER LogLevel
    The logging verbosity.
.PARAMETER Clean
    When true, the .NET solution will be cleaned and all output/intermediate folders deleted.
.PARAMETER BuildModulePath
    The path to import the Endjin.RecommendedPractices.Build module from. This is useful when
    testing pre-release versions of the Endjin.RecommendedPractices.Build that are not yet
    available in the PowerShell Gallery.
.PARAMETER BuildModuleVersion
    The version of the Endjin.RecommendedPractices.Build module to import. This is useful when
    testing pre-release versions of the Endjin.RecommendedPractices.Build that are not yet
    available in the PowerShell Gallery.
.PARAMETER InvokeBuildModuleVersion
    The version of the InvokeBuild module to be used.
#>
[CmdletBinding()]
param (
    [Parameter(Position=0)]
    [string[]] $Tasks = @("."),

    [Parameter()]
    [string] $Configuration = "Release",

    [Parameter()]
    [string] $BuildRepositoryUri = "",

    [Parameter()]
    [string] $SourcesDir = $PWD,

    [Parameter()]
    [string] $CoverageDir = "_codeCoverage",

    [Parameter()]
    [string] $TestReportTypes = "Cobertura",

    [Parameter()]
    [string] $PackagesDir = "_packages",

    [Parameter()]
    [ValidateSet("quiet","minimal","normal","detailed")]
    [string] $LogLevel = "minimal",

    [Parameter()]
    [switch] $Clean,

    [Parameter()]
    [string] $BuildModulePath,

    [Parameter()]
    [version] $BuildModuleVersion = "1.5.5",

    [Parameter()]
    [version] $InvokeBuildModuleVersion = "5.10.3"
)

$ErrorActionPreference = $ErrorActionPreference ? $ErrorActionPreference : 'Stop'
$InformationPreference = 'Continue'

$here = Split-Path -Parent $PSCommandPath

#region InvokeBuild setup
if (!(Get-Module -ListAvailable InvokeBuild)) {
    Install-Module InvokeBuild -RequiredVersion $InvokeBuildModuleVersion -Scope CurrentUser -Force -Repository PSGallery
}
Import-Module InvokeBuild
# This handles calling the build engine when this file is run like a normal PowerShell script
# (i.e. avoids the need to have another script to setup the InvokeBuild environment and issue the 'Invoke-Build' command )
if ($MyInvocation.ScriptName -notlike '*Invoke-Build.ps1') {
    try {
        Invoke-Build $Tasks $MyInvocation.MyCommand.Path @PSBoundParameters
    }
    catch {
        $_.ScriptStackTrace
        throw
    }
    return
}
#endregion

#region Import shared tasks and initialise build framework
if (!($BuildModulePath)) {
    if (!(Get-Module -ListAvailable Endjin.RecommendedPractices.Build | ? { $_.Version -eq $BuildModuleVersion })) {
        Write-Information "Installing 'Endjin.RecommendedPractices.Build' module..."
        Install-Module Endjin.RecommendedPractices.Build -RequiredVersion $BuildModuleVersion -Scope CurrentUser -Force -Repository PSGallery
    }
    $BuildModulePath = "Endjin.RecommendedPractices.Build"
}
else {
    Write-Information "BuildModulePath: $BuildModulePath"
}
Import-Module $BuildModulePath -RequiredVersion $BuildModuleVersion -Force

# Load the build process & tasks
. Endjin.RecommendedPractices.Build.tasks
#endregion


#
# Build process control options
#
$SkipInit = $false
$SkipVersion = $false
$SkipBuild = $false
$CleanBuild = $Clean
$SkipTest = $false
$SkipTestReport = $false
$SkipPackage = $false
$SkipAnalysis = $false


#
# Build process configuration
#
$SolutionToBuild = (Resolve-Path (Join-Path $here ".\Solutions\Corvus.JsonSchema.sln")).Path
$ProjectsToPublish = @(
    # "Solutions/MySolution/MyWebSite/MyWebSite.csproj"
)
$NuSpecFilesToPackage = @(
    # "Solutions/MySolution/MyProject/MyProject.nuspec"
)

#
# Specify files to exclude from code coverage
# This option is for excluding generated code
# - Use file path or directory path with globbing (e.g dir1/*.cs)
# - Use single or multiple paths (separated by comma) (e.g. **/dir1/class1.cs,**/dir2/*.cs,**/dir3/**/*.cs)
#
# NOTE: These exclusions suppress errors from the test report tool caused by a mismatch of relative paths
#       between the code generation and the test report tooling.
$ExcludeFilesFromCodeCoverage = "**/*.tt,**/*.g.cs,**/Generators/CodeGenerator.cs,**/Generators/CodeGenerator.Validate.cs"

#
# Update to the latest report generator versions
#
$ReportGeneratorToolVersion = "5.1.10"
$CovenantVersion = "0.19.0"


# Synopsis: Build, Test and Package
task . FullBuild


# build extensibility tasks
task RunFirst {}
task PreInit {}
task PostInit {}
task PreVersion {}
task PostVersion {}
task PreBuild {
    Write-Host "Initialising submodule"
    exec { & git submodule init }
    exec { & git submodule update }
}
task PostBuild {}
task PreTest {
    # Blunt attempt to mitigate issues from the huge build logs produced when running the Specs
    if ($IsRunningOnBuildServer) {
        $script:LogLevelBackup = $LogLevel
        $script:LogLevel = "quiet"
    }

    # if ($IsLinux) {
        $script:AdditionalTestArgs += @("--framework", "net8.0")
    # }

    Write-Host "DEBUG: Show compiled specs assemblies:"
    gci Solutions/Corvus.Json.Specs/bin/$Configuration -Filter *.Specs.dll -Recurse | Out-String | Write-Host
}
task PostTest {
    # Revert back to original logging level
    if ($IsRunningOnBuildServer) {
        $script:LogLevel = $LogLevelBackup
    }
}
task PreTestReport {}
task PostTestReport {}
task PreAnalysis {}
task PostAnalysis {}
task PrePackage {}
task PostPackage {}
task PrePublish {}
task PostPublish {}
task RunLast {}

# Override the default testing task so we can optionally override the target framework
$AdditionalTestArgs = @()
task RunTests -If {!$SkipTest -and $SolutionToBuild} {
    # Only setup the default CI/CD platform test loggers if they haven't already been customised
    if ($DotNetTestLoggers.Count -eq 0 -and $DotNetTestLogger -eq $_defaultDotNetTestLogger) {
        if ($script:IsAzureDevOps) {
            Write-Build Green "Configuring Azure Pipelines test logger"
            $DotNetTestLogger = "AzurePipelines"
        }
        elseif ($script:IsGitHubActions) {
            Write-Build Green "Configuring GitHub Actions test logger"
            $DotNetTestLogger = "GitHubActions"
        }    
    }

    # Workaround $PSScriptRoot not resolving to the module location, when overridden here
    $moduleDir = Split-Path -Parent (Get-Module Endjin.RecommendedPractices.Build | Select-Object -ExpandProperty Path)
    Write-Build Magenta "ModuleDir: $moduleDir"

    # Setup the arguments we need to pass to 'dotnet test'
    $dotnetTestArgs = @(
        "--configuration", $Configuration
        "--no-build"
        "--no-restore"
        '--collect:"XPlat Code Coverage;Format=cobertura"' 
        # '/p:CollectCoverage="{0}"' -f $EnableCoverage
        # "/p:CoverletOutputFormat=cobertura"
        # '/p:ExcludeByFile="{0}"' -f $ExcludeFilesFromCodeCoverage.Replace(",","%2C")
        "--verbosity", $LogLevel
        "--test-adapter-path", "$moduleDir/bin"
        ($DotNetTestFileLoggerProps ? $DotNetTestFileLoggerProps : "/fl")
    )

    # If multiple test loggers have been specified then use that newer config property
    if ($DotNetTestLoggers.Count -gt 0) {
        $DotNetTestLoggers | ForEach-Object {
            $dotnetTestArgs += @("--logger", $_)
        }
    }
    # Otherwise fallback to the original behaviour so we are backwards-compatible
    else {
        $dotnetTestArgs += @("--logger", $DotNetTestLogger)
    }

    if ($AdditionalTestArgs) {
        $dotnetTestArgs += $AdditionalTestArgs
    }

    # Add coverlet.collector configuration options that must be last on the command line
    $dotnetTestArgs += @(
        "--"
        "DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.ExcludeByFile={0}" -f $ExcludeFilesFromCodeCoverage
    )
    
    Write-Build Magenta "CmdLine: dotnet test $SolutionToBuild $dotnetTestArgs"

    try {
        exec { 
            dotnet test $SolutionToBuild @dotnetTestArgs
        }
    }
    finally {
        if ((Test-Path $DotNetTestLogFile) -and $IsAzureDevOps) {
            Write-Host "##vso[artifact.upload artifactname=logs]$((Resolve-Path $DotNetTestLogFile).Path)"
        }

        # Generate test report file
        if (!$SkipTestReport) {
            Write-Host "DEBUG: BEFORE: Show code coverage files:"
            gci -Path $SourcesDir -Filter "*cobertura*.xml" -Recurse | Out-String | Write-Host

            _GenerateTestReport
            _GenerateCodeCoverageMarkdownReport

            Write-Host "DEBUG: AFTER: Show code coverage files:"
            gci -Path $SourcesDir -Filter "*cobertura*.xml" -Recurse | Out-String | Write-Host
            gci -Path $SourcesDir -Filter "*coverage*.md" -Recurse | Out-String | Write-Host
        }
    }
}

# Modified helper to reflect multiple coverage reports (i.e. net8.0 & net481)
function _GenerateTestReport {
    Install-DotNetTool -Name "dotnet-reportgenerator-globaltool" -Version $ReportGeneratorToolVersion

    $coverageOutputFileWildcard = "coverage*cobertura.xml"
    $testReportGlob = "$SourcesDir/**/**/$coverageOutputFileWildcard"
    if (!(Get-ChildItem -Path $SourceDir -Filter $coverageOutputFileWildcard -Recurse)) {
        Write-Warning "No code coverage reports found for the file pattern '$testReportGlob' - skipping test report"
    }
    else {
        exec {
            reportgenerator "-reports:$testReportGlob" `
                            "-targetdir:$CoverageDir" `
                            "-reporttypes:$TestReportTypes"
        }
    }
}

$CodeCoverageLowerThreshold = 60
$CodeCoverageUpperThreshold = 80
function _GenerateCodeCoverageMarkdownReport {
    
    Install-DotNetTool -Name Endjin.CodeCoverageSummary -Global
    $coverageOutputFileWildcard = "coverage*cobertura.xml"
    $coverageOutputFileGlob = "**/$coverageOutputFileWildcard"
    $coverageFiles = Get-ChildItem -Path $SourcesDir -Filter $coverageOutputFileWildcard -Recurse
    if (!$coverageFiles) {
        Write-Warning "No code coverage reports found for the file pattern '$coverageOutputFileWildcard' - skipping code coverage summary"
    }
    else {
        exec {
            endjinccs --files $coverageOutputFileGlob `
                        --badge true `
                        --fail false `
                        --format markdown `
                        --hidebranch false `
                        --hidecomplexity false `
                        --indicators true `
                        --output both `
                        --thresholds ("{0} {1}" -f $CodeCoverageLowerThreshold, $CodeCoverageUpperThreshold)
        }
    }
}
