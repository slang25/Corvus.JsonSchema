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

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Schema
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct DependenciesEntity
    {
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;
            ValidationContext localResultObject = Corvus.Json.Validate.TypeObject(valueKind, result.CreateChildContext(), level);
            if (level == ValidationLevel.Flag && localResultObject.IsValid)
            {
                return validationContext;
            }

            if (localResultObject.IsValid)
            {
                isValid = true;
            }

            result = result.MergeResults(isValid, level, localResultObject);
            return result;
        }
    }
}