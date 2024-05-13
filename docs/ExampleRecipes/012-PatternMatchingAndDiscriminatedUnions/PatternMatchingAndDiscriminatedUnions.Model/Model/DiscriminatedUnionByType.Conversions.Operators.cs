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

namespace JsonSchemaSample.Api;
/// <summary>
/// Generated from JSON Schema.
/// </summary>
public readonly partial struct DiscriminatedUnionByType
{
    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.JsonString"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static explicit operator Corvus.Json.JsonString(DiscriminatedUnionByType value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.String) != 0)
        {
            return new(value.stringBacking);
        }

        return Corvus.Json.JsonString.Undefined;
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.JsonInt32"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static explicit operator Corvus.Json.JsonInt32(DiscriminatedUnionByType value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Number) != 0)
        {
            return new(value.numberBacking);
        }

        return Corvus.Json.JsonInt32.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.JsonInt32"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator DiscriminatedUnionByType(Corvus.Json.JsonInt32 value)
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
    /// Conversion to <see cref = "JsonSchemaSample.Api.PersonOpen"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static explicit operator JsonSchemaSample.Api.PersonOpen(DiscriminatedUnionByType value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return JsonSchemaSample.Api.PersonOpen.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "JsonSchemaSample.Api.PersonOpen"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator DiscriminatedUnionByType(JsonSchemaSample.Api.PersonOpen value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new(value.AsPropertyBacking()),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "JsonSchemaSample.Api.DiscriminatedUnionByType.People"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static explicit operator JsonSchemaSample.Api.DiscriminatedUnionByType.People(DiscriminatedUnionByType value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Array) != 0)
        {
            return new(value.arrayBacking);
        }

        return JsonSchemaSample.Api.DiscriminatedUnionByType.People.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "JsonSchemaSample.Api.DiscriminatedUnionByType.People"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator DiscriminatedUnionByType(JsonSchemaSample.Api.DiscriminatedUnionByType.People value)
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