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

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// Meta-data vocabulary meta-schema
/// </summary>
public readonly partial struct MetaData
{
    /// <summary>
    /// The well-known property names in the JSON object.
    /// </summary>
    public static class JsonPropertyNames
    {
        /// <summary>
        /// JSON property name for <see cref = "Default"/>.
        /// </summary>
        public static ReadOnlySpan<byte> DefaultUtf8 => "default"u8;

        /// <summary>
        /// JSON property name for <see cref = "Default"/>.
        /// </summary>
        public const string Default = "default";
        /// <summary>
        /// JSON property name for <see cref = "Deprecated"/>.
        /// </summary>
        public static ReadOnlySpan<byte> DeprecatedUtf8 => "deprecated"u8;

        /// <summary>
        /// JSON property name for <see cref = "Deprecated"/>.
        /// </summary>
        public const string Deprecated = "deprecated";
        /// <summary>
        /// JSON property name for <see cref = "Description"/>.
        /// </summary>
        public static ReadOnlySpan<byte> DescriptionUtf8 => "description"u8;

        /// <summary>
        /// JSON property name for <see cref = "Description"/>.
        /// </summary>
        public const string Description = "description";
        /// <summary>
        /// JSON property name for <see cref = "Examples"/>.
        /// </summary>
        public static ReadOnlySpan<byte> ExamplesUtf8 => "examples"u8;

        /// <summary>
        /// JSON property name for <see cref = "Examples"/>.
        /// </summary>
        public const string Examples = "examples";
        /// <summary>
        /// JSON property name for <see cref = "ReadOnly"/>.
        /// </summary>
        public static ReadOnlySpan<byte> ReadOnlyUtf8 => "readOnly"u8;

        /// <summary>
        /// JSON property name for <see cref = "ReadOnly"/>.
        /// </summary>
        public const string ReadOnly = "readOnly";
        /// <summary>
        /// JSON property name for <see cref = "Title"/>.
        /// </summary>
        public static ReadOnlySpan<byte> TitleUtf8 => "title"u8;

        /// <summary>
        /// JSON property name for <see cref = "Title"/>.
        /// </summary>
        public const string Title = "title";
        /// <summary>
        /// JSON property name for <see cref = "WriteOnly"/>.
        /// </summary>
        public static ReadOnlySpan<byte> WriteOnlyUtf8 => "writeOnly"u8;

        /// <summary>
        /// JSON property name for <see cref = "WriteOnly"/>.
        /// </summary>
        public const string WriteOnly = "writeOnly";
    }

    /// <summary>
    /// Gets the (optional) <c>default</c> property.
    /// </summary>
    public Corvus.Json.JsonAny Default
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.DefaultUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonAny(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.Default, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonAny>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the (optional) <c>deprecated</c> property.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity Deprecated
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.DeprecatedUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.Deprecated, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the (optional) <c>description</c> property.
    /// </summary>
    public Corvus.Json.JsonString Description
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.DescriptionUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.Description, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the (optional) <c>examples</c> property.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray Examples
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.ExamplesUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.Examples, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the (optional) <c>readOnly</c> property.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity ReadOnly
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.ReadOnlyUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.ReadOnly, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the (optional) <c>title</c> property.
    /// </summary>
    public Corvus.Json.JsonString Title
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.TitleUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.Title, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the (optional) <c>writeOnly</c> property.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity WriteOnly
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.WriteOnlyUtf8, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(JsonPropertyNames.WriteOnly, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "MetaData"/>.
    /// </summary>
    public static MetaData Create(Corvus.Json.JsonAny? @default = null, Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity? deprecated = null, Corvus.Json.JsonString? description = null, Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray? examples = null, Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity? readOnly = null, Corvus.Json.JsonString? title = null, Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity? writeOnly = null)
    {
        var builder = ImmutableList.CreateBuilder<JsonObjectProperty>();
        if (@default is Corvus.Json.JsonAny @default__)
        {
            builder.Add(JsonPropertyNames.Default, @default__.AsAny);
        }

        if (deprecated is Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity deprecated__)
        {
            builder.Add(JsonPropertyNames.Deprecated, deprecated__.AsAny);
        }

        if (description is Corvus.Json.JsonString description__)
        {
            builder.Add(JsonPropertyNames.Description, description__.AsAny);
        }

        if (examples is Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray examples__)
        {
            builder.Add(JsonPropertyNames.Examples, examples__.AsAny);
        }

        if (readOnly is Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity readOnly__)
        {
            builder.Add(JsonPropertyNames.ReadOnly, readOnly__.AsAny);
        }

        if (title is Corvus.Json.JsonString title__)
        {
            builder.Add(JsonPropertyNames.Title, title__.AsAny);
        }

        if (writeOnly is Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity writeOnly__)
        {
            builder.Add(JsonPropertyNames.WriteOnly, writeOnly__.AsAny);
        }

        return new(builder.ToImmutable());
    }

    /// <summary>
    /// Sets default.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithDefault(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(JsonPropertyNames.Default, value);
    }

    /// <summary>
    /// Sets deprecated.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithDeprecated(in Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity value)
    {
        return this.SetProperty(JsonPropertyNames.Deprecated, value);
    }

    /// <summary>
    /// Sets description.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithDescription(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(JsonPropertyNames.Description, value);
    }

    /// <summary>
    /// Sets examples.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithExamples(in Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray value)
    {
        return this.SetProperty(JsonPropertyNames.Examples, value);
    }

    /// <summary>
    /// Sets readOnly.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithReadOnly(in Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity value)
    {
        return this.SetProperty(JsonPropertyNames.ReadOnly, value);
    }

    /// <summary>
    /// Sets title.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithTitle(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(JsonPropertyNames.Title, value);
    }

    /// <summary>
    /// Sets writeOnly.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithWriteOnly(in Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity value)
    {
        return this.SetProperty(JsonPropertyNames.WriteOnly, value);
    }

    private static ValidationContext __CorvusValidateTitle(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDescription(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDefault(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonAny>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDeprecated(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateReadOnly(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateWriteOnly(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateExamples(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray>().Validate(validationContext, level);
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
            if (property.NameEquals(JsonPropertyNames.TitleUtf8))
            {
                propertyValidator = __CorvusValidateTitle;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.DescriptionUtf8))
            {
                propertyValidator = __CorvusValidateDescription;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.DefaultUtf8))
            {
                propertyValidator = __CorvusValidateDefault;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.DeprecatedUtf8))
            {
                propertyValidator = __CorvusValidateDeprecated;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.ReadOnlyUtf8))
            {
                propertyValidator = __CorvusValidateReadOnly;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.WriteOnlyUtf8))
            {
                propertyValidator = __CorvusValidateWriteOnly;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.ExamplesUtf8))
            {
                propertyValidator = __CorvusValidateExamples;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(JsonPropertyNames.Title))
            {
                propertyValidator = __CorvusValidateTitle;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.Description))
            {
                propertyValidator = __CorvusValidateDescription;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.Default))
            {
                propertyValidator = __CorvusValidateDefault;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.Deprecated))
            {
                propertyValidator = __CorvusValidateDeprecated;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.ReadOnly))
            {
                propertyValidator = __CorvusValidateReadOnly;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.WriteOnly))
            {
                propertyValidator = __CorvusValidateWriteOnly;
                return true;
            }
            else if (property.NameEquals(JsonPropertyNames.Examples))
            {
                propertyValidator = __CorvusValidateExamples;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}