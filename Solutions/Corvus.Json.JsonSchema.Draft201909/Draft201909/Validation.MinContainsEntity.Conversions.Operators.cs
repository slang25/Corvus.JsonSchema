//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Validation
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct MinContainsEntity
    {
        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Validation.NonNegativeInteger"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static explicit operator Corvus.Json.JsonSchema.Draft201909.Validation.NonNegativeInteger(MinContainsEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return new(value.numberBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Validation.NonNegativeInteger.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Validation.NonNegativeInteger"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator MinContainsEntity(Corvus.Json.JsonSchema.Draft201909.Validation.NonNegativeInteger value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Number => new(value.AsBinaryJsonNumber),
                _ => Undefined
            };
        }
    }
}