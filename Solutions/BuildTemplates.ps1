# Runs all the template build commands
$here = Split-Path -Parent $PSCommandPath

if (!(Get-Command "TextTransformCore.exe" -ErrorAction Ignore)) {
    # {VS_INSTALL_PATH}\Common7\IDE\TextTransformCore.exe
    Write-Host -f Red "Please run this script from within a Developer Command Prompt."
    exit 1
}

@(
    "Corvus.Json.CodeGeneration.6\Corvus.Json.CodeGeneration.Draft6"
    "Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Generators"
    "Corvus.Json.CodeGeneration.201909\Corvus.Json.CodeGeneration.Draft201909"
    "Corvus.Json.CodeGeneration.202012\Corvus.Json.CodeGeneration.Draft202012"
    "Corvus.Json.ExtendedTypes\Corvus.Json"
) | Foreach-Object -ThrottleLimit 5 -Parallel {
  Push-Location (Join-Path $using:here $_)
  & ./BuildTemplates.ps1
}

# cd 
# start cmd.exe /C BuildTemplates.cmd
# cd ..\..\
# start pwsh -f BuildTemplates.ps1
# cd ..\..\
# start cmd.exe /C BuildTemplates.cmd
# cd ..\..\
# start cmd.exe /C BuildTemplates.cmd
# cd ..\..\
# start cmd.exe /C BuildTemplates.cmd
# cd ..\..