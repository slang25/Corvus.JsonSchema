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
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Benchmarking.Models;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Person
{
    private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        if (valueKind != JsonValueKind.Object)
        {
            return result;
        }

        int propertyCount = 0;
        bool foundName = false;
        foreach (JsonObjectProperty property in this.EnumerateObject())
        {
            if (__TryGetCorvusLocalPropertiesValidator(property, this.HasJsonElementBacking, out ObjectPropertyValidator? propertyValidator))
            {
                result = result.WithLocalProperty(propertyCount);
                var propertyResult = propertyValidator(property, result.CreateChildContext(), level);
                result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if ((this.HasJsonElementBacking && property.NameEquals(NameUtf8JsonPropertyName.Span)) || (!this.HasJsonElementBacking && property.NameEquals(NameJsonPropertyName)))
                {
                    foundName = true;
                }
            }

            propertyCount++;
        }

        if (!foundName)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"name\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        return result;
    }
}