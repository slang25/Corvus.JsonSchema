//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using Corvus.Json;

namespace Corvus.Json.Benchmarking.Models;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct PersonSchemaJson
{
    private ValidationContext ValidateRef(in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        ValidationContext refResult = this.As<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonArray>().Validate(validationContext.CreateChildContext(), level);
        if (!refResult.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = validationContext.MergeResults(false, level, refResult);
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = validationContext.MergeResults(false, level, refResult);
            }
            else
            {
                result = validationContext.WithResult(isValid: false);
            }
        }
        else
        {
            if (level >= ValidationLevel.Basic)
            {
                result = result.MergeResults(result.IsValid, level, refResult);
            }

            result = result.MergeChildContext(refResult, false);
        }

        return result;
    }
}