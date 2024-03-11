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

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct MinContainsEntity
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger"/>.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger AsNonNegativeInteger
        {
            get
            {
                return (Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger"/>.
        /// </summary>
        public bool IsNonNegativeInteger
        {
            get
            {
                return ((Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsNonNegativeInteger(out Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger result)
        {
            result = (Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeInteger)this;
            return result.IsValid();
        }
    }
}