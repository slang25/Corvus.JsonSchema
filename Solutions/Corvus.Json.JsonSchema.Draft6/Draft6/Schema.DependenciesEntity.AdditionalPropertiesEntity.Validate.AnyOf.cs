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

namespace Corvus.Json.JsonSchema.Draft6;
public readonly partial struct Schema
{
    public readonly partial struct DependenciesEntity
    {
        /// <summary>
        /// Generated from JSON Schema.
        /// </summary>
        public readonly partial struct AdditionalPropertiesEntity
        {
            private ValidationContext ValidateAnyOf(in ValidationContext validationContext, ValidationLevel level)
            {
                ValidationContext result = validationContext;
                if (level > ValidationLevel.Basic)
                {
                    result = result.PushValidationLocationProperty("anyOf");
                }

                ValidationContext childContextBase = result;
                bool foundValid = false;
                ValidationContext childContext0 = childContextBase;
                if (level > ValidationLevel.Basic)
                {
                    childContext0 = childContext0.PushValidationLocationArrayIndex(0);
                }

                ValidationContext anyOfResult0 = this.As<Corvus.Json.JsonSchema.Draft6.Schema>().Validate(childContext0.CreateChildContext(), level);
                if (anyOfResult0.IsValid)
                {
                    result = result.MergeChildContext(anyOfResult0, level >= ValidationLevel.Verbose);
                    foundValid = true;
                }
                else
                {
                    if (level >= ValidationLevel.Verbose)
                    {
                        result = result.MergeResults(result.IsValid, level, anyOfResult0);
                    }
                }

                ValidationContext childContext1 = childContextBase;
                if (level > ValidationLevel.Basic)
                {
                    childContext1 = childContext1.PushValidationLocationArrayIndex(1);
                }

                ValidationContext anyOfResult1 = this.As<Corvus.Json.JsonSchema.Draft6.Schema.StringArray>().Validate(childContext1.CreateChildContext(), level);
                if (anyOfResult1.IsValid)
                {
                    result = result.MergeChildContext(anyOfResult1, level >= ValidationLevel.Verbose);
                    foundValid = true;
                }
                else
                {
                    if (level >= ValidationLevel.Verbose)
                    {
                        result = result.MergeResults(result.IsValid, level, anyOfResult1);
                    }
                }

                if (foundValid)
                {
                    if (level >= ValidationLevel.Detailed)
                    {
                        result = result.WithResult(isValid: true, "Validation 10.2.1.2. anyOf - validated against the anyOf schema.");
                    }
                }
                else
                {
                    if (level >= ValidationLevel.Detailed)
                    {
                        result = result.WithResult(isValid: false, "Validation 10.2.1.2. anyOf - failed to validate against the anyOf schema.");
                    }
                    else if (level >= ValidationLevel.Basic)
                    {
                        result = result.WithResult(isValid: false, "Validation 10.2.1.2. anyOf - failed to validate against the anyOf schema.");
                    }
                    else
                    {
                        result = result.WithResult(isValid: false);
                    }
                }

                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // anyOf
                }

                return result;
            }
        }
    }
}