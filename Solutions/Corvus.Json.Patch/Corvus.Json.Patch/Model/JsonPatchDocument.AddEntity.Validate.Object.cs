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

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Add operation. Value can be any JSON value.
    /// </para>
    /// </remarks>
    public readonly partial struct AddEntity
    {
        private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

            int propertyCount = 0;
            bool foundOp = false;
            bool foundValue = false;
            foreach (JsonObjectProperty property in this.EnumerateObject())
            {
                if (__TryGetCorvusLocalPropertiesValidator(property, this.HasJsonElementBacking, out ObjectPropertyValidator? propertyValidator))
                {
                    result = result.WithLocalProperty(propertyCount);
                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PushDocumentProperty("properties", property.Name.GetString());
                    }

                    var propertyResult = propertyValidator(property, result.CreateChildContext(), level);
                    result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PopLocation(); // property name
                    }

                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    if ((this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.OpUtf8)) || (!this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.Op)))
                    {
                        foundOp = true;
                    }
                    else if ((this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.ValueUtf8)) || (!this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.Value)))
                    {
                        foundValue = true;
                    }
                }

                propertyCount++;
            }

            if (!foundOp)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.5.3. required - required property \"op\" not present.");
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

            if (!foundValue)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.5.3. required - required property \"value\" not present.");
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
}