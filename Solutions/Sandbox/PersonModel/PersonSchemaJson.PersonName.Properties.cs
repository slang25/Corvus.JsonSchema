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

namespace Corvus.Json.Benchmarking.Models;
public readonly partial struct PersonSchemaJson
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PersonName
    {
        /// <summary>
        /// JSON property name for <see cref = "FamilyName"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> FamilyNameUtf8JsonPropertyName = new byte[]{102, 97, 109, 105, 108, 121, 78, 97, 109, 101};
        /// <summary>
        /// JSON property name for <see cref = "FamilyName"/>.
        /// </summary>
        public const string FamilyNameJsonPropertyName = "familyName";
        /// <summary>
        /// JSON property name for <see cref = "GivenName"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> GivenNameUtf8JsonPropertyName = new byte[]{103, 105, 118, 101, 110, 78, 97, 109, 101};
        /// <summary>
        /// JSON property name for <see cref = "GivenName"/>.
        /// </summary>
        public const string GivenNameJsonPropertyName = "givenName";
        /// <summary>
        /// JSON property name for <see cref = "OtherNames"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> OtherNamesUtf8JsonPropertyName = new byte[]{111, 116, 104, 101, 114, 78, 97, 109, 101, 115};
        /// <summary>
        /// JSON property name for <see cref = "OtherNames"/>.
        /// </summary>
        public const string OtherNamesJsonPropertyName = "otherNames";
        /// <summary>
        /// Gets FamilyName.
        /// </summary>
        public Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement FamilyName
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(FamilyNameUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(FamilyNameJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets GivenName.
        /// </summary>
        public Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement GivenName
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(GivenNameUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(GivenNameJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets OtherNames.
        /// </summary>
        public Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames OtherNames
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(OtherNamesUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(OtherNamesJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Tries to get the validator for the given property.
        /// </summary>
        /// <param name = "property">The property for which to get the validator.</param>
        /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
        /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
        /// <returns><c>True</c> if the validator was found.</returns>
        public bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
        {
            if (hasJsonElementBacking)
            {
                if (property.NameEquals(FamilyNameUtf8JsonPropertyName.Span))
                {
                    propertyValidator = __CorvusValidateFamilyName;
                    return true;
                }
                else if (property.NameEquals(GivenNameUtf8JsonPropertyName.Span))
                {
                    propertyValidator = __CorvusValidateGivenName;
                    return true;
                }
                else if (property.NameEquals(OtherNamesUtf8JsonPropertyName.Span))
                {
                    propertyValidator = __CorvusValidateOtherNames;
                    return true;
                }
            }
            else
            {
                if (property.NameEquals(FamilyNameJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateFamilyName;
                    return true;
                }
                else if (property.NameEquals(GivenNameJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateGivenName;
                    return true;
                }
                else if (property.NameEquals(OtherNamesJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateOtherNames;
                    return true;
                }
            }

            propertyValidator = null;
            return false;
        }

        /// <summary>
        /// Creates an instance of a <see cref = "PersonName"/>.
        /// </summary>
        public static PersonName Create(Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement familyName, Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement? givenName = null, Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames? otherNames = null)
        {
            var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
            builder.Add(FamilyNameJsonPropertyName, familyName.AsAny);
            if (givenName is Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement givenName__)
            {
                builder.Add(GivenNameJsonPropertyName, givenName__.AsAny);
            }

            if (otherNames is Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames otherNames__)
            {
                builder.Add(OtherNamesJsonPropertyName, otherNames__.AsAny);
            }

            return builder.ToImmutable();
        }

        /// <summary>
        /// Sets familyName.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public PersonName WithFamilyName(in Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement value)
        {
            return this.SetProperty(FamilyNameJsonPropertyName, value);
        }

        /// <summary>
        /// Sets givenName.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public PersonName WithGivenName(in Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement value)
        {
            return this.SetProperty(GivenNameJsonPropertyName, value);
        }

        /// <summary>
        /// Sets otherNames.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public PersonName WithOtherNames(in Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames value)
        {
            return this.SetProperty(OtherNamesJsonPropertyName, value);
        }

        private static ValidationContext __CorvusValidateFamilyName(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement>().Validate(validationContext, level);
        }

        private static ValidationContext __CorvusValidateGivenName(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Benchmarking.Models.PersonSchemaJson.PersonNameElement>().Validate(validationContext, level);
        }

        private static ValidationContext __CorvusValidateOtherNames(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Benchmarking.Models.PersonSchemaJson.OtherNames>().Validate(validationContext, level);
        }
    }
}