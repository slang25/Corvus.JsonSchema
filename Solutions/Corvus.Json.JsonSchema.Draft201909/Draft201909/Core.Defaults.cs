//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft201909;
/// <summary>
/// Core vocabulary meta-schema
/// </summary>
public readonly partial struct Core
{
    private static readonly ImmutableList<JsonObjectProperty> __CorvusDefaults = BuildDefaults();
    /// <inheritdoc/>
    public bool TryGetDefault(in JsonPropertyName name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(name, out value);
    }

    /// <inheritdoc/>
    public bool TryGetDefault(string name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(name, out value);
    }

    /// <inheritdoc/>
    public bool TryGetDefault(ReadOnlySpan<char> name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(name, out value);
    }

    /// <inheritdoc/>
    public bool TryGetDefault(ReadOnlySpan<byte> utf8Name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(utf8Name, out value);
    }

    /// <inheritdoc/>
    public bool HasDefault(in JsonPropertyName name)
    {
        return __CorvusDefaults.TryGetValue(name, out _);
    }

    /// <inheritdoc/>
    public bool HasDefault(string name)
    {
        return __CorvusDefaults.TryGetValue(name, out _);
    }

    /// <inheritdoc/>
    public bool HasDefault(ReadOnlySpan<char> name)
    {
        return __CorvusDefaults.TryGetValue(name, out _);
    }

    /// <inheritdoc/>
    public bool HasDefault(ReadOnlySpan<byte> utf8Name)
    {
        return __CorvusDefaults.TryGetValue(utf8Name, out _);
    }

    private static ImmutableList<JsonObjectProperty> BuildDefaults()
    {
        ImmutableList<JsonObjectProperty>.Builder builder = ImmutableList.CreateBuilder<JsonObjectProperty>();
        builder.Add(JsonPropertyNames.Defs, Corvus.Json.JsonSchema.Draft201909.Core.DefsEntity.DefaultInstance);
        builder.Add(JsonPropertyNames.RecursiveAnchor, Corvus.Json.JsonSchema.Draft201909.Core.RecursiveAnchorEntity.DefaultInstance);
        return builder.ToImmutable();
    }
}