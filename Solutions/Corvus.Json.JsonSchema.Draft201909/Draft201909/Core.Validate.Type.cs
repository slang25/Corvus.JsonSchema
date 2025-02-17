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
/// Core vocabulary meta-schema
/// </summary>
public readonly partial struct Core
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

        ValidationContext localResultBoolean = Corvus.Json.Validate.TypeBoolean(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultBoolean.IsValid)
        {
            return validationContext;
        }

        if (localResultBoolean.IsValid)
        {
            isValid = true;
        }

        result = result.MergeResults(isValid, level, localResultObject, localResultBoolean);
        return result;
    }
}