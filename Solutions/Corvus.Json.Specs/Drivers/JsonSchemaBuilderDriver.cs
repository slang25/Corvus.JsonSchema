﻿// <copyright file="JsonSchemaBuilderDriver.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.CodeGeneration;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyModel;

namespace Drivers;

/// <summary>
/// Shared implementation for the drivers.
/// </summary>
public class JsonSchemaBuilderDriver : IDisposable
{
    private const string GlobalUsingStatements = @"
// <auto-generated/>

global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;";

    private readonly IConfiguration configuration;
    private readonly IJsonSchemaBuilder builder;
    private readonly string settingsKey;
    private readonly FileSystemDocumentResolver documentResolver = new();
#if NET8_0_OR_GREATER
    private TestAssemblyLoadContext? assemblyLoadContext = new();
#endif

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSchemaBuilderDriver"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <param name="builder">The <see cref="IJsonSchemaBuilder"/> instance to drive.</param>
    /// <param name="settingsKey">The settings key for the driver.</param>
    public JsonSchemaBuilderDriver(IConfiguration configuration, IJsonSchemaBuilder builder, string settingsKey)
    {
        this.configuration = configuration;
        this.builder = builder;
        this.settingsKey = settingsKey;
    }

    public void Dispose()
    {
        this.documentResolver.Dispose();

#if NET8_0_OR_GREATER
        ////if (this.assemblyLoadContext is not null)
        ////{
        ////    this.assemblyLoadContext.Unload();
        ////    this.assemblyLoadContext = null;
        ////    GC.Collect();
        ////    GC.WaitForPendingFinalizers();
        ////    GC.SuppressFinalize(this);
        ////}
#endif
    }

    /// <summary>
    /// Get the <see cref="JsonElement"/> at the given reference location.
    /// </summary>
    /// <param name="filename">The name of the file containing the element.</param>
    /// <param name="referenceFragment">The local reference to the element in the file.</param>
    /// <returns>The element, found in the specified document.</returns>
    public Task<JsonElement?> GetElementFromLocalFile(string filename, string referenceFragment)
    {
        string baseDirectory = this.configuration[$"{this.settingsKey}:testBaseDirectory"]!;
        string path = Path.Combine(baseDirectory, filename);
        return this.documentResolver.TryResolve(new JsonReference(path, referenceFragment));
    }

    /// <summary>
    /// Generate the schema for the given type.
    /// </summary>
    /// <param name="schema">The schema.</param>
    /// <param name="virtualFileName">The virtual file name for the schema.</param>
    /// <param name="featureName">The unique name of the feature.</param>
    /// <param name="scenarioName">The unique name of the scenario.</param>
    /// <returns>A <see cref="Task{Type}"/> which, when complete, returns the <see cref="Type"/> generated for the schema.</returns>
    public async Task<Type> GenerateTypeFor(string schema, string virtualFileName, string featureName, string scenarioName)
    {
        string baseDirectory = this.configuration[$"{this.settingsKey}:testBaseDirectory"]!;
        string path = Path.Combine(baseDirectory, virtualFileName);

        if (SchemaReferenceNormalization.TryNormalizeSchemaReference(path, out string? result))
        {
            path = result;
        }

        this.builder.AddDocument(path, JsonDocument.Parse(schema));

        (string rootType, ImmutableDictionary<JsonReference, TypeAndCode> generatedTypes) = await this.builder.BuildTypesFor(new JsonReference(path), $"{featureName}Feature.{scenarioName}", rebase: true).ConfigureAwait(false);
#if NET8_0_OR_GREATER
        return CompileGeneratedType(this.assemblyLoadContext!, rootType, generatedTypes);
#else
        return CompileGeneratedType(rootType, generatedTypes);
#endif
    }

    /// <summary>
    /// Generates a type for the given root Schema element.
    /// </summary>
    /// <param name="writeBenchmarks">If <c>true</c>, write benchmark files.</param>
    /// <param name="index">The index of the scenario example.</param>
    /// <param name="filename">The filename containing the Schema.</param>
    /// <param name="schemaPath">The path to the Schema in the file.</param>
    /// <param name="dataPath">The path to the data in the file.</param>
    /// <param name="featureName">The feature name for the type.</param>
    /// <param name="scenarioName">The scenario name for the type.</param>
    /// <param name="valid">Whether the scenario is expected to be valid.</param>
    /// <returns>The fully qualified type name of the entity we have generated.</returns>
#pragma warning disable RCS1163 // Unused parameter.
    public async Task<Type> GenerateTypeFor(bool writeBenchmarks, int index, string filename, string schemaPath, string dataPath, string featureName, string scenarioName, bool valid)
#pragma warning restore RCS1163 // Unused parameter.
    {
        string baseDirectory = this.configuration[$"{this.settingsKey}:testBaseDirectory"]!;
        string path = Path.Combine(baseDirectory, filename) + schemaPath;

        (string rootType, ImmutableDictionary<JsonReference, TypeAndCode> generatedTypes) = await this.builder.BuildTypesFor(new JsonReference(path), $"{featureName}Feature.{scenarioName}", rebase: true).ConfigureAwait(false);

#if NET8_0_OR_GREATER
        return CompileGeneratedType(this.assemblyLoadContext!, rootType, generatedTypes);
#else
        return CompileGeneratedType(rootType, generatedTypes);
#endif
    }

    /// <summary>
    /// Create an instance of the given <see cref="IJsonValue"/> type from
    /// the json data provided.
    /// </summary>
    /// <param name="type">The type (which must be a <see cref="IJsonValue"/> and have a constructor with a single <see cref="JsonElement"/> parameter.</param>
    /// <param name="data">The JSON data from which to initialize the value.</param>
    /// <returns>An instance of a <see cref="IJsonValue"/> initialized from the data.</returns>
    public IJsonValue CreateInstance(Type type, JsonElement data)
    {
        ConstructorInfo? constructor =
            type
                .GetConstructors()
                .SingleOrDefault(c => c.GetParameters().Length == 1 && c.GetParameters()[0].ParameterType.Name.StartsWith("JsonElement"))
            ?? throw new InvalidOperationException($"Unable to find the public JsonElement constructor on type '{type.FullName}'");

        return (IJsonValue)constructor.Invoke([data]);
    }

    /// <summary>
    /// Create an instance of the given <see cref="IJsonValue"/> type from
    /// the json data provided.
    /// </summary>
    /// <param name="type">The type (which must be a <see cref="IJsonValue"/> and have a constructor with a single <see cref="JsonElement"/> parameter.</param>
    /// <param name="data">The JSON data from which to initialize the value.</param>
    /// <returns>An instance of a <see cref="IJsonValue"/> initialized from the data.</returns>
    public IJsonValue CreateInstance(Type type, string data)
    {
        using var document = JsonDocument.Parse(data);
        return this.CreateInstance(type, document.RootElement.Clone());
    }

#if NET8_0_OR_GREATER
    private static Type CompileGeneratedType(AssemblyLoadContext assemblyLoadContext, string rootType, ImmutableDictionary<JsonReference, TypeAndCode> generatedTypes)
    {
        bool isCorvusType = rootType.StartsWith("Corvus.");

        (IEnumerable<MetadataReference> references, IEnumerable<string?> defines) = BuildMetadataReferencesAndDefines();

        IEnumerable<SyntaxTree> syntaxTrees = ParseSyntaxTrees(generatedTypes, defines);

        // We are happy with the defaults (debug etc.)
        var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
        var compilation = CSharpCompilation.Create($"Driver.GeneratedTypes_{Guid.NewGuid()}", syntaxTrees, references, options);
        using MemoryStream outputStream = new();
        EmitResult result = compilation.Emit(outputStream);

        if (!result.Success)
        {
            throw new Exception("Unable to compile generated code\r\n" + BuildCompilationErrors(result));
        }

        outputStream.Flush();
        outputStream.Position = 0;

        Assembly generatedAssembly = assemblyLoadContext.LoadFromStream(outputStream);

        if (isCorvusType)
        {
            return AssemblyLoadContext.Default.Assemblies.Single(a => a.GetName().Name == "Corvus.Json.ExtendedTypes").ExportedTypes.Single(t => t.FullName == rootType);
        }

        return generatedAssembly.ExportedTypes.Single(t => t.FullName == rootType);
    }
#else
    private static Type CompileGeneratedType(string rootType, ImmutableDictionary<JsonReference, TypeAndCode> generatedTypes)
    {
        bool isCorvusType = rootType.StartsWith("Corvus.");

        (IEnumerable<MetadataReference> references, IEnumerable<string?> defines) = BuildMetadataReferencesAndDefines();

        IEnumerable<SyntaxTree> syntaxTrees = ParseSyntaxTrees(generatedTypes, defines);

        // We are happy with the defaults (debug etc.)
        var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
        var compilation = CSharpCompilation.Create($"Driver.GeneratedTypes_{Guid.NewGuid()}", syntaxTrees, references, options);
        using MemoryStream outputStream = new();
        EmitResult result = compilation.Emit(outputStream);

        if (!result.Success)
        {
            throw new Exception("Unable to compile generated code\r\n" + BuildCompilationErrors(result));
        }

        outputStream.Flush();
        outputStream.Position = 0;

        var generatedAssembly = Assembly.Load(outputStream.ToArray());

        if (isCorvusType)
        {
            return typeof(JsonAny).Assembly.ExportedTypes.Single(t => t.FullName == rootType);
        }

        return generatedAssembly.ExportedTypes.Single(t => t.FullName == rootType);
    }
#endif

    private static string BuildCompilationErrors(EmitResult result)
    {
        var builder = new StringBuilder();
        foreach (Diagnostic diagnostic in result.Diagnostics)
        {
            builder.AppendLine(diagnostic.ToString());
        }

        return builder.ToString();
    }

    private static (IEnumerable<MetadataReference> MetadataReferences, IEnumerable<string?> Defines) BuildMetadataReferencesAndDefines()
    {
        DependencyContext? ctx = DependencyContext.Default ?? DependencyContext.Load(Assembly.GetExecutingAssembly());
        if (ctx is null)
        {
            throw new InvalidOperationException("Unable to find compilation context.");
        }

        return (from l in ctx.CompileLibraries
               from r in l.ResolveReferencePaths()
               select MetadataReference.CreateFromFile(r),
               ctx.CompilationOptions.Defines.AsEnumerable());
    }

    private static IEnumerable<SyntaxTree> ParseSyntaxTrees(ImmutableDictionary<JsonReference, TypeAndCode> generatedTypes, IEnumerable<string?> defines)
    {
        CSharpParseOptions parseOptions = CSharpParseOptions.Default
            .WithLanguageVersion(LanguageVersion.Preview)
            .WithPreprocessorSymbols(defines.Where(s => s is not null).Cast<string>());
        yield return CSharpSyntaxTree.ParseText(GlobalUsingStatements, options: parseOptions, path: "GlobalUsingStatements.cs");

        foreach (KeyValuePair<JsonReference, TypeAndCode> type in generatedTypes)
        {
            foreach (CodeAndFilename codeAndFilename in type.Value.Code)
            {
                yield return CSharpSyntaxTree.ParseText(codeAndFilename.Code, options: parseOptions, path: codeAndFilename.Filename);
            }
        }
    }

#if NET8_0_OR_GREATER
    private class TestAssemblyLoadContext : AssemblyLoadContext
    {
        public TestAssemblyLoadContext()
            : base($"TestAssemblyLoadContext_{Guid.NewGuid():N}", isCollectible: true)
        {
        }
    }
#endif
}