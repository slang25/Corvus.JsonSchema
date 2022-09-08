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

namespace Corvus.Json.Benchmarking.Models;
public readonly partial struct PersonSchemaJson
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct OtherNames
    {
        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }

            result = this.ValidateOneOf(result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

            return result;
        }
    }
}