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

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct NonNegativeInteger
    {
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;
            ValidationContext localResultInteger = Corvus.Json.Validate.TypeInteger(this, result.CreateChildContext(), level);
            if (level == ValidationLevel.Flag && localResultInteger.IsValid)
            {
                return validationContext;
            }

            if (localResultInteger.IsValid)
            {
                isValid = true;
            }

            result = result.MergeResults(isValid, level, localResultInteger);
            return result;
        }
    }
}