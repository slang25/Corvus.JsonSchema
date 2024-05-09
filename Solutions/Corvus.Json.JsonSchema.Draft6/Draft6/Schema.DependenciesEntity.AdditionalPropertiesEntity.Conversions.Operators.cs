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
    public readonly partial struct DependenciesEntity
    {
        /// <summary>
        /// Generated from JSON Schema.
        /// </summary>
        public readonly partial struct AdditionalPropertiesEntity
        {
            /// <summary>
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft6.Schema"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft6.Schema(AdditionalPropertiesEntity value)
            {
                if ((value.backing & Backing.JsonElement) != 0)
                {
                    return new(value.AsJsonElement);
                }

                if ((value.backing & Backing.Object) != 0)
                {
                    return new(value.objectBacking);
                }

                if ((value.backing & Backing.Bool) != 0)
                {
                    return new(value.boolBacking);
                }

                return Corvus.Json.JsonSchema.Draft6.Schema.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft6.Schema"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft6.Schema value)
            {
                if (value.HasJsonElementBacking)
                {
                    return new(value.AsJsonElement);
                }

                return value.ValueKind switch
                {
                    JsonValueKind.Object => new(value.AsPropertyBacking()),
                    JsonValueKind.True => new(true),
                    JsonValueKind.False => new(false),
                    _ => Undefined
                };
            }

            /// <summary>
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft6.Schema.StringArray"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft6.Schema.StringArray(AdditionalPropertiesEntity value)
            {
                if ((value.backing & Backing.JsonElement) != 0)
                {
                    return new(value.AsJsonElement);
                }

                if ((value.backing & Backing.Array) != 0)
                {
                    return new(value.arrayBacking);
                }

                return Corvus.Json.JsonSchema.Draft6.Schema.StringArray.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft6.Schema.StringArray"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft6.Schema.StringArray value)
            {
                if (value.HasJsonElementBacking)
                {
                    return new(value.AsJsonElement);
                }

                return value.ValueKind switch
                {
                    JsonValueKind.Array => new(value.AsImmutableList()),
                    _ => Undefined
                };
            }
        }
    }
}