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

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Test operation. Value can be any JSON value.
    /// </para>
    /// </remarks>
    public readonly partial struct Test
    {
        /// <summary>
        /// The well-known property names in the JSON object.
        /// </summary>
        public static class JsonPropertyNames
        {
            /// <summary>
            /// JSON property name for <see cref = "Op"/>.
            /// </summary>
            public static ReadOnlySpan<byte> OpUtf8 => "op"u8;

            /// <summary>
            /// JSON property name for <see cref = "Op"/>.
            /// </summary>
            public const string Op = "op";
            /// <summary>
            /// JSON property name for <see cref = "Path"/>.
            /// </summary>
            public static ReadOnlySpan<byte> PathUtf8 => "path"u8;

            /// <summary>
            /// JSON property name for <see cref = "Path"/>.
            /// </summary>
            public const string Path = "path";
            /// <summary>
            /// JSON property name for <see cref = "Value"/>.
            /// </summary>
            public static ReadOnlySpan<byte> ValueUtf8 => "value"u8;

            /// <summary>
            /// JSON property name for <see cref = "Value"/>.
            /// </summary>
            public const string Value = "value";
        }

        /// <summary>
        /// Gets the <c>op</c> property. If the instance is valid, this property will be not be <c>undefined</c>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.Test.OpEntity Op
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.OpUtf8, out JsonElement result))
                    {
                        return new Corvus.Json.Patch.Model.JsonPatchDocument.Test.OpEntity(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(JsonPropertyNames.Op, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Patch.Model.JsonPatchDocument.Test.OpEntity>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets the <c>path</c> property. If the instance is valid, this property will be not be <c>undefined</c>.
        /// </summary>
        public Corvus.Json.JsonPointer Path
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.PathUtf8, out JsonElement result))
                    {
                        return new Corvus.Json.JsonPointer(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(JsonPropertyNames.Path, out JsonAny result))
                    {
                        return result.As<Corvus.Json.JsonPointer>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets the <c>value</c> property. If the instance is valid, this property will be not be <c>undefined</c>.
        /// </summary>
        public Corvus.Json.JsonAny Value
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.ValueUtf8, out JsonElement result))
                    {
                        return new Corvus.Json.JsonAny(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(JsonPropertyNames.Value, out JsonAny result))
                    {
                        return result.As<Corvus.Json.JsonAny>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Creates an instance of a <see cref = "Test"/>.
        /// </summary>
        public static Test Create(Corvus.Json.JsonPointer path, Corvus.Json.JsonAny value)
        {
            var builder = ImmutableList.CreateBuilder<JsonObjectProperty>();
            builder.Add(JsonPropertyNames.Op, new Corvus.Json.Patch.Model.JsonPatchDocument.Test.OpEntity().AsAny);
            builder.Add(JsonPropertyNames.Path, path.AsAny);
            builder.Add(JsonPropertyNames.Value, value.AsAny);
            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Sets path.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public Test WithPath(in Corvus.Json.JsonPointer value)
        {
            return this.SetProperty(JsonPropertyNames.Path, value);
        }

        /// <summary>
        /// Sets value.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public Test WithValue(in Corvus.Json.JsonAny value)
        {
            return this.SetProperty(JsonPropertyNames.Value, value);
        }

        private static ValidationContext __CorvusValidateValue(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.JsonAny>().Validate(validationContext, level);
        }

        private static ValidationContext __CorvusValidateOp(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Patch.Model.JsonPatchDocument.Test.OpEntity>().Validate(validationContext, level);
        }

        /// <summary>
        /// Tries to get the validator for the given property.
        /// </summary>
        /// <param name = "property">The property for which to get the validator.</param>
        /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
        /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
        /// <returns><c>True</c> if the validator was found.</returns>
        private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
        {
            if (hasJsonElementBacking)
            {
                if (property.NameEquals(JsonPropertyNames.ValueUtf8))
                {
                    propertyValidator = __CorvusValidateValue;
                    return true;
                }
                else if (property.NameEquals(JsonPropertyNames.OpUtf8))
                {
                    propertyValidator = __CorvusValidateOp;
                    return true;
                }
            }
            else
            {
                if (property.NameEquals(JsonPropertyNames.Value))
                {
                    propertyValidator = __CorvusValidateValue;
                    return true;
                }
                else if (property.NameEquals(JsonPropertyNames.Op))
                {
                    propertyValidator = __CorvusValidateOp;
                    return true;
                }
            }

            propertyValidator = null;
            return false;
        }
    }
}