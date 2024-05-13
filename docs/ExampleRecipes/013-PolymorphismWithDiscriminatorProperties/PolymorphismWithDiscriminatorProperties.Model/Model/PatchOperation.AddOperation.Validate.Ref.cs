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

namespace JsonSchemaSample.Api;
public readonly partial struct PatchOperation
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Add operation. Value can be any JSON value.
    /// </para>
    /// </remarks>
    public readonly partial struct AddOperation
    {
        private ValidationContext ValidateRef(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (level > ValidationLevel.Basic)
            {
                result = result.PushValidationLocationProperty("$ref");
            }

            ValidationContext refResult = this.As<JsonSchemaSample.Api.PatchOperation.PatchOperationCommon>().Validate(validationContext.CreateChildContext(), level);
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

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation();
            }

            return result;
        }
    }
}