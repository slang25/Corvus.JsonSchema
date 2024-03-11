//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using Corvus.Json;

namespace Corvus.Json.Patch.SpecGenerator;
/// <summary>
/// Generated from JSON Schema.
/// </summary>
public readonly partial struct ScenarioWithResult
{
    /// <summary>
    /// Gets the value as a <see cref = "Corvus.Json.Patch.SpecGenerator.ScenarioCommon"/>.
    /// </summary>
    public Corvus.Json.Patch.SpecGenerator.ScenarioCommon AsScenarioCommon
    {
        get
        {
            return (Corvus.Json.Patch.SpecGenerator.ScenarioCommon)this;
        }
    }

    /// <summary>
    /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.SpecGenerator.ScenarioCommon"/>.
    /// </summary>
    public bool IsScenarioCommon
    {
        get
        {
            return ((Corvus.Json.Patch.SpecGenerator.ScenarioCommon)this).IsValid();
        }
    }

    /// <summary>
    /// Gets the value as a <see cref = "Corvus.Json.Patch.SpecGenerator.ScenarioCommon"/>.
    /// </summary>
    /// <param name = "result">The result of the conversion.</param>
    /// <returns><c>True</c> if the conversion was valid.</returns>
    public bool TryGetAsScenarioCommon(out Corvus.Json.Patch.SpecGenerator.ScenarioCommon result)
    {
        result = (Corvus.Json.Patch.SpecGenerator.ScenarioCommon)this;
        return result.IsValid();
    }

    /// <summary>
    /// Gets the value as a <see cref = "Corvus.Json.Patch.SpecGenerator.NotDisabled"/>.
    /// </summary>
    public Corvus.Json.Patch.SpecGenerator.NotDisabled AsNotDisabled
    {
        get
        {
            return (Corvus.Json.Patch.SpecGenerator.NotDisabled)this;
        }
    }

    /// <summary>
    /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.SpecGenerator.NotDisabled"/>.
    /// </summary>
    public bool IsNotDisabled
    {
        get
        {
            return ((Corvus.Json.Patch.SpecGenerator.NotDisabled)this).IsValid();
        }
    }

    /// <summary>
    /// Gets the value as a <see cref = "Corvus.Json.Patch.SpecGenerator.NotDisabled"/>.
    /// </summary>
    /// <param name = "result">The result of the conversion.</param>
    /// <returns><c>True</c> if the conversion was valid.</returns>
    public bool TryGetAsNotDisabled(out Corvus.Json.Patch.SpecGenerator.NotDisabled result)
    {
        result = (Corvus.Json.Patch.SpecGenerator.NotDisabled)this;
        return result.IsValid();
    }
}