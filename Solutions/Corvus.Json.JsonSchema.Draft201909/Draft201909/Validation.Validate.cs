//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Text.Json;
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft201909;
/// <summary>
/// Validation vocabulary meta-schema
/// </summary>
public readonly partial struct Validation
{
    /// <inheritdoc/>
    public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
    {
        ValidationContext result = validationContext;
        if (level > ValidationLevel.Flag)
        {
            result = result.UsingResults();
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.UsingStack();
            result = result.PushSchemaLocation("https://json-schema.org/draft/2019-09/meta/validation");
        }

        JsonValueKind valueKind = this.ValueKind;
        result = this.ValidateType(valueKind, result, level);
        if (level == ValidationLevel.Flag && !result.IsValid)
        {
            return result;
        }

        result = this.ValidateObject(valueKind, result, level);
        if (level == ValidationLevel.Flag && !result.IsValid)
        {
            return result;
        }

        if (level != ValidationLevel.Flag)
        {
            result = result.PopLocation();
        }

        return result;
    }
}