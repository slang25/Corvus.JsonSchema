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

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Schema
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct DependenciesEntity
    {
        private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

            int propertyCount = 0;
            foreach (JsonObjectProperty property in this.EnumerateObject())
            {
                if (!result.HasEvaluatedLocalProperty(propertyCount))
                {
                    result = property.ValueAs<Corvus.Json.JsonSchema.Draft7.Schema.DependenciesEntity.AdditionalPropertiesEntity>().Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    result = result.WithLocalProperty(propertyCount);
                }

                propertyCount++;
            }

            return result;
        }
    }
}