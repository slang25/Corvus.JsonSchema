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
public readonly partial struct PersonSchemaJson
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct OtherNames
    {
        private ValidationContext ValidateOneOf(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            int oneOfCount = 0;
            ValidationContext oneOfResult0 = this.As<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult0.IsValid)
            {
                result = result.MergeChildContext(oneOfResult0, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult0);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult0);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult0);
                }
            }

            ValidationContext oneOfResult1 = this.As<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElementArray>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult1.IsValid)
            {
                result = result.MergeChildContext(oneOfResult1, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult1);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult1);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult1);
                }
            }

            if (oneOfCount == 1)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: true, "Validation 10.2.1.3. onef - validated against the oneOf schema.");
                }
            }
            else if (oneOfCount == 0)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - failed to validate against any of the oneOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - failed to validate against any of the oneOf schema.");
                }
                else
                {
                    result = result.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - validated against more than one of the oneOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - failed to validate against more than one of the oneOf schema.");
                }
                else
                {
                    result = result.WithResult(isValid: false);
                }
            }

            return result;
        }
    }
}