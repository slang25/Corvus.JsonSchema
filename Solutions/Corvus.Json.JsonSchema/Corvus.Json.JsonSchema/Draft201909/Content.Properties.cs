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
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Content
{
    /// <summary>
    /// JSON property name for <see cref = "ContentMediaType"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ContentMediaTypeUtf8JsonPropertyName => "contentMediaType"u8;

    /// <summary>
    /// JSON property name for <see cref = "ContentMediaType"/>.
    /// </summary>
    public const string ContentMediaTypeJsonPropertyName = "contentMediaType";
    /// <summary>
    /// JSON property name for <see cref = "ContentEncoding"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ContentEncodingUtf8JsonPropertyName => "contentEncoding"u8;

    /// <summary>
    /// JSON property name for <see cref = "ContentEncoding"/>.
    /// </summary>
    public const string ContentEncodingJsonPropertyName = "contentEncoding";
    /// <summary>
    /// JSON property name for <see cref = "ContentSchema"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ContentSchemaUtf8JsonPropertyName => "contentSchema"u8;

    /// <summary>
    /// JSON property name for <see cref = "ContentSchema"/>.
    /// </summary>
    public const string ContentSchemaJsonPropertyName = "contentSchema";
    /// <summary>
    /// Gets ContentMediaType.
    /// </summary>
    public Corvus.Json.JsonString ContentMediaType
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ContentMediaTypeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ContentMediaTypeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ContentEncoding.
    /// </summary>
    public Corvus.Json.JsonString ContentEncoding
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ContentEncodingUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ContentEncodingJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ContentSchema.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft201909.Schema ContentSchema
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ContentSchemaUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft201909.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ContentSchemaJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft201909.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Content"/>.
    /// </summary>
    public static Content Create(Corvus.Json.JsonString? contentMediaType = null, Corvus.Json.JsonString? contentEncoding = null, Corvus.Json.JsonSchema.Draft201909.Schema? contentSchema = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (contentMediaType is Corvus.Json.JsonString contentMediaType__)
        {
            builder.Add(ContentMediaTypeJsonPropertyName, contentMediaType__.AsAny);
        }

        if (contentEncoding is Corvus.Json.JsonString contentEncoding__)
        {
            builder.Add(ContentEncodingJsonPropertyName, contentEncoding__.AsAny);
        }

        if (contentSchema is Corvus.Json.JsonSchema.Draft201909.Schema contentSchema__)
        {
            builder.Add(ContentSchemaJsonPropertyName, contentSchema__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets contentMediaType.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Content WithContentMediaType(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(ContentMediaTypeJsonPropertyName, value);
    }

    /// <summary>
    /// Sets contentEncoding.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Content WithContentEncoding(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(ContentEncodingJsonPropertyName, value);
    }

    /// <summary>
    /// Sets contentSchema.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Content WithContentSchema(in Corvus.Json.JsonSchema.Draft201909.Schema value)
    {
        return this.SetProperty(ContentSchemaJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateContentMediaType(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateContentEncoding(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateContentSchema(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft201909.Schema>().Validate(validationContext, level);
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
            if (property.NameEquals(ContentMediaTypeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateContentMediaType;
                return true;
            }
            else if (property.NameEquals(ContentEncodingUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateContentEncoding;
                return true;
            }
            else if (property.NameEquals(ContentSchemaUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateContentSchema;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(ContentMediaTypeJsonPropertyName))
            {
                propertyValidator = __CorvusValidateContentMediaType;
                return true;
            }
            else if (property.NameEquals(ContentEncodingJsonPropertyName))
            {
                propertyValidator = __CorvusValidateContentEncoding;
                return true;
            }
            else if (property.NameEquals(ContentSchemaJsonPropertyName))
            {
                propertyValidator = __CorvusValidateContentSchema;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}