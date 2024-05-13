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

namespace JsonSchemaSample.Api;
public readonly partial struct Matrix2d
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct Row
    {
        private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Array)
            {
                return result;
            }

            int arrayLength = 0;
            using JsonArrayEnumerator<Corvus.Json.JsonDouble> arrayEnumerator = this.EnumerateArray();
            while (arrayEnumerator.MoveNext())
            {
                if (level > ValidationLevel.Basic)
                {
                    result = result.PushDocumentArrayIndex(arrayLength);
                }

                if (level > ValidationLevel.Basic)
                {
                    result = result.PushValidationLocationProperty("items");
                }

                result = arrayEnumerator.Current.Validate(result, level);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // items
                }

                result = result.WithLocalItemIndex(arrayLength);
                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // array index
                }

                arrayLength++;
            }

            if (arrayLength > 2)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.4.1. maxItems - {arrayLength} exceeds maximum number of items 2.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "6.4.1. maxItems - item count exceeds maximum number of items 2.");
                }
                else
                {
                    return result.WithResult(isValid: false);
                }
            }

            if (arrayLength < 2)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.4.2. minItems - {arrayLength} is less than the minimum number of items 2.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "6.4.2. minItems - item count is less than the minimum number of items 2.");
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