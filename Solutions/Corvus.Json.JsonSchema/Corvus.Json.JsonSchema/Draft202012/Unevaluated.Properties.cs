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
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Unevaluated
{
    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedItems"/>.
    /// </summary>
    public static ReadOnlySpan<byte> UnevaluatedItemsUtf8JsonPropertyName => "unevaluatedItems"u8;

    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedItems"/>.
    /// </summary>
    public const string UnevaluatedItemsJsonPropertyName = "unevaluatedItems";
    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedProperties"/>.
    /// </summary>
    public static ReadOnlySpan<byte> UnevaluatedPropertiesUtf8JsonPropertyName => "unevaluatedProperties"u8;

    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedProperties"/>.
    /// </summary>
    public const string UnevaluatedPropertiesJsonPropertyName = "unevaluatedProperties";
    /// <summary>
    /// Gets UnevaluatedItems.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema UnevaluatedItems
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(UnevaluatedItemsUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(UnevaluatedItemsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets UnevaluatedProperties.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema UnevaluatedProperties
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(UnevaluatedPropertiesUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(UnevaluatedPropertiesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Unevaluated"/>.
    /// </summary>
    public static Unevaluated Create(Corvus.Json.JsonSchema.Draft202012.Schema? unevaluatedItems = null, Corvus.Json.JsonSchema.Draft202012.Schema? unevaluatedProperties = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (unevaluatedItems is Corvus.Json.JsonSchema.Draft202012.Schema unevaluatedItems__)
        {
            builder.Add(UnevaluatedItemsJsonPropertyName, unevaluatedItems__.AsAny);
        }

        if (unevaluatedProperties is Corvus.Json.JsonSchema.Draft202012.Schema unevaluatedProperties__)
        {
            builder.Add(UnevaluatedPropertiesJsonPropertyName, unevaluatedProperties__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets unevaluatedItems.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Unevaluated WithUnevaluatedItems(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(UnevaluatedItemsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets unevaluatedProperties.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Unevaluated WithUnevaluatedProperties(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(UnevaluatedPropertiesJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateUnevaluatedItems(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.Schema>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateUnevaluatedProperties(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.Schema>().Validate(validationContext, level);
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
            if (property.NameEquals(UnevaluatedItemsUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateUnevaluatedItems;
                return true;
            }
            else if (property.NameEquals(UnevaluatedPropertiesUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateUnevaluatedProperties;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(UnevaluatedItemsJsonPropertyName))
            {
                propertyValidator = __CorvusValidateUnevaluatedItems;
                return true;
            }
            else if (property.NameEquals(UnevaluatedPropertiesJsonPropertyName))
            {
                propertyValidator = __CorvusValidateUnevaluatedProperties;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}