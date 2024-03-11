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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Applicator
{
    public readonly partial struct PatternPropertiesEntity
    {
        /// <summary>
        /// Generated from JSON Schema.
        /// </summary>
        public readonly partial struct PropertyNamesEntity : IJsonBoolean<PropertyNamesEntity>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref = "PropertyNamesEntity"/> struct.
            /// </summary>
            /// <param name = "value">The value from which to construct the instance.</param>
            public PropertyNamesEntity(bool value)
            {
                this.jsonElementBacking = default;
                this.backing = Backing.Bool;
                this.numberBacking = new(value);
                this.stringBacking = string.Empty;
                this.arrayBacking = ImmutableList<JsonAny>.Empty;
                this.objectBacking = ImmutableList<JsonObjectProperty>.Empty;
            }

            /// <summary>
            /// Conversion from JsonBoolean.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator PropertyNamesEntity(JsonBoolean value)
            {
                if (value.HasDotnetBacking && (value.ValueKind == JsonValueKind.True || value.ValueKind == JsonValueKind.False))
                {
                    return new((bool)value);
                }

                return new(value.AsJsonElement);
            }

            /// <summary>
            /// Conversion from bool.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator PropertyNamesEntity(bool value)
            {
                return new(value);
            }

            /// <summary>
            /// Conversion to bool.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            /// <exception cref = "InvalidOperationException">The value was not a string.</exception>
            public static explicit operator bool (PropertyNamesEntity value)
            {
                return value.GetBoolean() ?? throw new InvalidOperationException();
            }

            /// <summary>
            /// Try to retrieve the value as a boolean.
            /// </summary>
            /// <param name = "result"><see langword="true"/> if the value was true, otherwise <see langword="false"/>.</param>
            /// <returns><see langword="true"/> if the value was representable as a boolean, otherwise <see langword="false"/>.</returns>
            public bool TryGetBoolean([NotNullWhen(true)] out bool result)
            {
                switch (this.ValueKind)
                {
                    case JsonValueKind.True:
                        result = true;
                        return true;
                    case JsonValueKind.False:
                        result = false;
                        return true;
                    default:
                        result = default;
                        return false;
                }
            }

            /// <summary>
            /// Get the value as a boolean.
            /// </summary>
            /// <returns>The value of the boolean, or <see langword="null"/> if the value was not representable as a boolean.</returns>
            public bool? GetBoolean()
            {
                if (this.TryGetBoolean(out bool result))
                {
                    return result;
                }

                return null;
            }
        }
    }
}