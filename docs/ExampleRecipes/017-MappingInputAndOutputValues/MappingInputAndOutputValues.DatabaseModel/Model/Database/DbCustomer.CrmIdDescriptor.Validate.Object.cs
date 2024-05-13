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

namespace JsonSchemaSample.DatabaseApi;
public readonly partial struct DbCustomer
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct CrmIdDescriptor
    {
        private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

            int propertyCount = 0;
            bool foundId = false;
            bool foundSource = false;
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

                    if ((this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.IdUtf8)) || (!this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.Id)))
                    {
                        foundId = true;
                    }
                    else if ((this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.SourceUtf8)) || (!this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.Source)))
                    {
                        foundSource = true;
                    }
                }

                propertyCount++;
            }

            if (!foundId)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.5.3. required - required property \"id\" not present.");
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

            if (!foundSource)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.5.3. required - required property \"source\" not present.");
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