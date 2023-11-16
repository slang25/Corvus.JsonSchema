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

namespace Corvus.Json.JsonSchema.Draft6;
public readonly partial struct Schema
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct NonNegativeIntegerDefault0
    {
        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeInteger"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NonNegativeIntegerDefault0(Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeInteger value)
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

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeInteger"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static explicit operator Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeInteger(NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return new(value.numberBacking);
            }

            return Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeInteger.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeIntegerDefault0.AllOf1Entity"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NonNegativeIntegerDefault0(Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeIntegerDefault0.AllOf1Entity value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeIntegerDefault0.AllOf1Entity"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static explicit operator Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeIntegerDefault0.AllOf1Entity(NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            return Corvus.Json.JsonSchema.Draft6.Schema.NonNegativeIntegerDefault0.AllOf1Entity.Undefined;
        }
    }
}