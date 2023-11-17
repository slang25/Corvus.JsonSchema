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

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Schema
{
    public readonly partial struct DependenciesEntity
    {
        /// <summary>
        /// A type generated from a JsonSchema specification.
        /// </summary>
        public readonly partial struct AdditionalPropertiesEntity
        {
            /// <summary>
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Schema"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Schema(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.Schema.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Schema"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Schema value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Core"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Core(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.Core.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Core"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Core value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Applicator"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Applicator(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.Applicator.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Applicator"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Applicator value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Unevaluated"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Unevaluated(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.Unevaluated.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Unevaluated"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Unevaluated value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Validation(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.Validation.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Validation value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.MetaData"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.MetaData(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.MetaData.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.MetaData"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.MetaData value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.FormatAnnotation"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.FormatAnnotation(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.FormatAnnotation.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.FormatAnnotation"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.FormatAnnotation value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Content"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Content(AdditionalPropertiesEntity value)
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

                return Corvus.Json.JsonSchema.Draft202012.Content.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Content"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Content value)
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
            /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.StringArray"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static explicit operator Corvus.Json.JsonSchema.Draft202012.Validation.StringArray(AdditionalPropertiesEntity value)
            {
                if ((value.backing & Backing.JsonElement) != 0)
                {
                    return new(value.AsJsonElement);
                }

                if ((value.backing & Backing.Array) != 0)
                {
                    return new(value.arrayBacking);
                }

                return Corvus.Json.JsonSchema.Draft202012.Validation.StringArray.Undefined;
            }

            /// <summary>
            /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.StringArray"/>.
            /// </summary>
            /// <param name = "value">The value from which to convert.</param>
            public static implicit operator AdditionalPropertiesEntity(Corvus.Json.JsonSchema.Draft202012.Validation.StringArray value)
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