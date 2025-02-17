//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Schema
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct DependenciesEntity : IJsonObject<DependenciesEntity>, IReadOnlyDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "DependenciesEntity"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public DependenciesEntity(ImmutableList<JsonObjectProperty> value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Object;
            this.objectBacking = value;
        }

        /// <summary>
        /// Conversion from JsonObject.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator DependenciesEntity(JsonObject value)
        {
            if (value.HasDotnetBacking && value.ValueKind == JsonValueKind.Object)
            {
                return new(value.AsPropertyBacking());
            }

            return new(value.AsJsonElement);
        }

        /// <inheritdoc/>
        public ImmutableList<JsonObjectProperty> AsPropertyBacking()
        {
            return this.GetPropertyBacking();
        }

        /// <inheritdoc/>
        JsonAny IJsonObject<DependenciesEntity>.this[in JsonPropertyName name]
        {
            get
            {
                if (this.TryGetProperty(name, out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity result))
                {
                    return result.AsAny;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Get the property with the given name.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity this[in JsonPropertyName name]
        {
            get
            {
                if (this.TryGetProperty(name, out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity result))
                {
                    return result;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <inheritdoc/>
        Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity IReadOnlyDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>.this[JsonPropertyName key] => this[key];
        /// <inheritdoc/>
        IEnumerable<JsonPropertyName> IReadOnlyDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>.Keys
        {
            get
            {
                foreach (var property in this.EnumerateObject())
                {
                    yield return property.Name;
                }
            }
        }

        /// <inheritdoc/>
        IEnumerable<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity> IReadOnlyDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>.Values
        {
            get
            {
                foreach (var property in this.EnumerateObject())
                {
                    yield return property.Value;
                }
            }
        }

        /// <inheritdoc/>
        int IReadOnlyCollection<KeyValuePair<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>>.Count
        {
            get
            {
                if (this.HasJsonElementBacking)
                {
                    int count = 0;
                    foreach (var _ in this.jsonElementBacking.EnumerateObject())
                    {
                        count++;
                    }

                    return count;
                }

                if (this.HasDotnetBacking)
                {
                    return this.objectBacking.Count;
                }

                throw new InvalidOperationException();
            }
        }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Creates an instance of the type from the given dictionary of properties.
    /// </summary>
    /// <param name="source">The dictionary of properties.</param>
    /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
    static DependenciesEntity IJsonObject<DependenciesEntity>.FromProperties(IDictionary<JsonPropertyName, JsonAny> source)
    {
        return new(source.Select(kvp => new JsonObjectProperty(kvp.Key, kvp.Value)).ToImmutableList());
    }
#endif
        /// <summary>
        /// Creates an instance of the type from the given dictionary of properties.
        /// </summary>
        /// <param name = "source">The dictionary of properties.</param>
        /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
        public static DependenciesEntity FromProperties(ImmutableList<JsonObjectProperty> source)
        {
            return new(source);
        }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Creates an instance of the type from the given dictionary of properties.
    /// </summary>
    /// <param name="source">The dictionary of properties.</param>
    /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
    static DependenciesEntity IJsonObject<DependenciesEntity>.FromProperties(params (JsonPropertyName Name, JsonAny Value)[] source)
    {
        return new(source.Select(s => new JsonObjectProperty(s.Name, s.Value)).ToImmutableList());
    }
#endif
        /// <summary>
        /// Creates an instance of the type from the given dictionary of properties.
        /// </summary>
        /// <param name = "source">The dictionary of properties.</param>
        /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
        public static DependenciesEntity FromProperties(IDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity> source)
        {
            return new(source.Select(kvp => new JsonObjectProperty(kvp.Key, kvp.Value)).ToImmutableList());
        }

        /// <summary>
        /// Creates an instance of the type from the given dictionary of properties.
        /// </summary>
        /// <param name = "source">The dictionary of properties.</param>
        /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
        public static DependenciesEntity FromProperties(params (JsonPropertyName Name, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity Value)[] source)
        {
            return new(source.Select(s => new JsonObjectProperty(s.Name, s.Value.AsAny)).ToImmutableList());
        }

        /// <inheritdoc/>
        JsonObjectEnumerator IJsonObject<DependenciesEntity>.EnumerateObject()
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return new(this.objectBacking);
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Enumerate the object.
        /// </summary>
        /// <returns>An enumerator for the object.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        public JsonObjectEnumerator<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity> EnumerateObject()
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return new(this.objectBacking);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool HasProperties()
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.Count > 0;
            }

            if ((this.backing & Backing.JsonElement) != 0)
            {
                using JsonElement.ObjectEnumerator enumerator = this.jsonElementBacking.EnumerateObject();
                return enumerator.MoveNext();
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool HasProperty(in JsonPropertyName name)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return name.TryGetProperty(this.jsonElementBacking, out JsonElement _);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.ContainsKey(name);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool HasProperty(string name)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return this.jsonElementBacking.TryGetProperty(name, out _);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.ContainsKey(name);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<char> name)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return this.jsonElementBacking.TryGetProperty(name, out _);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.ContainsKey(name);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<byte> utf8Name)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return this.jsonElementBacking.TryGetProperty(utf8Name, out _);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.ContainsKey(utf8Name);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty(in JsonPropertyName name, out JsonAny value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (name.TryGetProperty(this.jsonElementBacking, out JsonElement result))
                {
                    value = new(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.TryGetValue(name, out value);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty(string name, out JsonAny value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
                    value = new(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.TryGetValue(name, out value);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty(ReadOnlySpan<char> name, out JsonAny value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
                    value = new(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.TryGetValue(name, out value);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty(ReadOnlySpan<byte> utf8Name, out JsonAny value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(utf8Name, out JsonElement result))
                {
                    value = new(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.TryGetValue(utf8Name, out value);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty<TValue>(in JsonPropertyName name, out TValue value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (name.TryGetProperty(this.jsonElementBacking, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<TValue>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromAny(result);
#else
                    value = result.As<TValue>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty<TValue>(string name, out TValue value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<TValue>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromAny(result);
#else
                    value = result.As<TValue>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty<TValue>(ReadOnlySpan<char> name, out TValue value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<TValue>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromAny(result);
#else
                    value = result.As<TValue>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        bool IJsonObject<DependenciesEntity>.TryGetProperty<TValue>(ReadOnlySpan<byte> utf8Name, out TValue value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(utf8Name, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<TValue>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(utf8Name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = TValue.FromAny(result);
#else
                    value = result.As<TValue>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        DependenciesEntity IJsonObject<DependenciesEntity>.SetProperty<TValue>(in JsonPropertyName name, TValue value)
        {
            return new(this.GetPropertyBackingWith(name, value.AsAny));
        }

        /// <summary>
        /// Get a property.
        /// </summary>
        /// <param name = "name">The name of the property.</param>
        /// <param name = "value">The value of the property.</param>
        /// <returns><c>True</c> if the property was present.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        public bool TryGetProperty(in JsonPropertyName name, out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (name.TryGetProperty(this.jsonElementBacking, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromAny(result);
#else
                    value = result.As<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Get a property.
        /// </summary>
        /// <param name = "name">The name of the property.</param>
        /// <param name = "value">The value of the property.</param>
        /// <returns><c>True</c> if the property was present.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        public bool TryGetProperty(string name, out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromAny(result);
#else
                    value = result.As<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Get a property.
        /// </summary>
        /// <param name = "name">The name of the property.</param>
        /// <param name = "value">The value of the property.</param>
        /// <returns><c>True</c> if the property was present.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        public bool TryGetProperty(ReadOnlySpan<char> name, out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromAny(result);
#else
                    value = result.As<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Get a property.
        /// </summary>
        /// <param name = "utf8Name">The name of the property as a UTF8 string.</param>
        /// <param name = "value">The value of the property.</param>
        /// <returns><c>True</c> if the property was present.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        public bool TryGetProperty(ReadOnlySpan<byte> utf8Name, out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity value)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(utf8Name, out JsonElement result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromJson(result);
#else
                    value = JsonValueNetStandard20Extensions.FromJsonElement<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>(result);
#endif
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(utf8Name, out JsonAny result))
                {
#if NET8_0_OR_GREATER
                value = Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity.FromAny(result);
#else
                    value = result.As<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>();
#endif
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Sets the given property value.
        /// </summary>
        /// <param name = "name">The name of the property.</param>
        /// <param name = "value">The value of the property.</param>
        /// <returns>The instance with the property set.</returns>
        public DependenciesEntity SetProperty(in JsonPropertyName name, in Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity value)
        {
            return new(this.GetPropertyBackingWith(name, value.AsAny));
        }

        /// <inheritdoc/>
        public DependenciesEntity RemoveProperty(in JsonPropertyName name)
        {
            return new(this.GetPropertyBackingWithout(name));
        }

        /// <inheritdoc/>
        public DependenciesEntity RemoveProperty(string name)
        {
            return new(this.GetPropertyBackingWithout(name));
        }

        /// <inheritdoc/>
        public DependenciesEntity RemoveProperty(ReadOnlySpan<char> name)
        {
            return new(this.GetPropertyBackingWithout(name));
        }

        /// <inheritdoc/>
        public DependenciesEntity RemoveProperty(ReadOnlySpan<byte> utf8Name)
        {
            return new(this.GetPropertyBackingWithout(utf8Name));
        }

        /// <inheritdoc/>
        bool IReadOnlyDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>.ContainsKey(JsonPropertyName key)
        {
            return this.HasProperty(key);
        }

        /// <inheritdoc/>
        bool IReadOnlyDictionary<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>.TryGetValue(JsonPropertyName key, [MaybeNullWhen(false)] out Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity value)
        {
            return this.TryGetProperty(key, out value);
        }

        /// <inheritdoc/>
        IEnumerator<KeyValuePair<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>> IEnumerable<KeyValuePair<JsonPropertyName, Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>>.GetEnumerator()
        {
            if (this.HasJsonElementBacking)
            {
                return new ReadOnlyDictionaryJsonObjectEnumerator<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>(this.jsonElementBacking);
            }

            if (this.HasDotnetBacking)
            {
                return new ReadOnlyDictionaryJsonObjectEnumerator<Corvus.Json.JsonSchema.Draft202012.Schema.DependenciesEntity.AdditionalPropertiesEntity>(this.objectBacking);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.EnumerateObject();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonObjectProperty}"/> from the object.
        /// </summary>
        /// <returns>An immutable list of <see cref = "JsonAny"/> built from the array.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        private ImmutableList<JsonObjectProperty> GetPropertyBacking()
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking;
            }

            return PropertyBackingBuilders.GetPropertyBackingBuilder(this.jsonElementBacking).ToImmutable();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonObjectProperty}"/> from the object, without a specific property.
        /// </summary>
        /// <returns>An immutable dictionary builder of <see cref = "JsonPropertyName"/> to <see cref = "JsonAny"/>, built from the existing object, without the given property.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        private ImmutableList<JsonObjectProperty> GetPropertyBackingWithout(in JsonPropertyName name)
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.Remove(name);
            }

            return PropertyBackingBuilders.GetPropertyBackingBuilderWithout(this.jsonElementBacking, name).ToImmutable();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonObjectProperty}"/> from the object, without a specific property.
        /// </summary>
        /// <returns>An immutable dictionary builder of <see cref = "JsonPropertyName"/> to <see cref = "JsonAny"/>, built from the existing object, without the given property.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        private ImmutableList<JsonObjectProperty> GetPropertyBackingWithout(ReadOnlySpan<char> name)
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.Remove(name);
            }

            return PropertyBackingBuilders.GetPropertyBackingBuilderWithout(this.jsonElementBacking, name).ToImmutable();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonObjectProperty}"/> from the object, without a specific property.
        /// </summary>
        /// <returns>An immutable dictionary builder of <see cref = "JsonPropertyName"/> to <see cref = "JsonAny"/>, built from the existing object, without the given property.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        private ImmutableList<JsonObjectProperty> GetPropertyBackingWithout(ReadOnlySpan<byte> name)
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.Remove(name);
            }

            return PropertyBackingBuilders.GetPropertyBackingBuilderWithout(this.jsonElementBacking, name).ToImmutable();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonObjectProperty}"/> from the object, without a specific property.
        /// </summary>
        /// <returns>An immutable dictionary builder of <see cref = "JsonPropertyName"/> to <see cref = "JsonAny"/>, built from the existing object, without the given property.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        private ImmutableList<JsonObjectProperty> GetPropertyBackingWithout(string name)
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.Remove(name);
            }

            return PropertyBackingBuilders.GetPropertyBackingBuilderWithout(this.jsonElementBacking, name).ToImmutable();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonObjectProperty}"/> from the object, without a specific property.
        /// </summary>
        /// <returns>An immutable dictionary builder of <see cref = "JsonPropertyName"/> to <see cref = "JsonAny"/>, built from the existing object, without the given property.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an object.</exception>
        private ImmutableList<JsonObjectProperty> GetPropertyBackingWith(in JsonPropertyName name, in JsonAny value)
        {
            if ((this.backing & Backing.Object) != 0)
            {
                return this.objectBacking.SetItem(name, value);
            }

            ImmutableList<JsonObjectProperty>.Builder result = PropertyBackingBuilders.GetPropertyBackingBuilderReplacing(this.jsonElementBacking, name, value);
            return result.ToImmutable();
        }
    }
}