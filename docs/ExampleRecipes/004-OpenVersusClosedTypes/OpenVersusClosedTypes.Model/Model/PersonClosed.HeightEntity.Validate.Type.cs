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
public readonly partial struct PersonClosed
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct HeightEntity
    {
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;
            ValidationContext localResultNumber = Corvus.Json.Validate.TypeNumber(valueKind, result.CreateChildContext(), level);
            if (level == ValidationLevel.Flag && localResultNumber.IsValid)
            {
                return validationContext;
            }

            if (localResultNumber.IsValid)
            {
                isValid = true;
            }

            result = result.MergeResults(isValid, level, localResultNumber);
            return result;
        }
    }
}