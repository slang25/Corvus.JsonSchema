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
    /// Remove operation. Only a path is specified.
    /// </para>
    /// </remarks>
    public readonly partial struct RemoveEntity : IJsonObject<RemoveEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "RemoveEntity"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public RemoveEntity(ImmutableList<JsonObjectProperty> value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Object;
            this.objectBacking = value;
        }

        /// <summary>
        /// Conversion from JsonObject.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator RemoveEntity(JsonObject value)
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
        public JsonAny this[in JsonPropertyName name]
        {
            get
            {
                if (this.TryGetProperty(name, out JsonAny result))
                {
                    return result;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Creates an instance of the type from the given dictionary of properties.
        /// </summary>
        /// <param name = "source">The dictionary of properties.</param>
        /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
        public static RemoveEntity FromProperties(IDictionary<JsonPropertyName, JsonAny> source)
        {
            return new(source.Select(kvp => new JsonObjectProperty(kvp.Key, kvp.Value)).ToImmutableList());
        }

        /// <summary>
        /// Creates an instance of the type from the given dictionary of properties.
        /// </summary>
        /// <param name = "source">The dictionary of properties.</param>
        /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
        public static RemoveEntity FromProperties(ImmutableList<JsonObjectProperty> source)
        {
            return new(source);
        }

        /// <summary>
        /// Creates an instance of the type from the given dictionary of properties.
        /// </summary>
        /// <param name = "source">The dictionary of properties.</param>
        /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
        public static RemoveEntity FromProperties(params (JsonPropertyName Name, JsonAny Value)[] source)
        {
            return new(source.Select(s => new JsonObjectProperty(s.Name, s.Value)).ToImmutableList());
        }

        /// <inheritdoc/>
        public JsonObjectEnumerator EnumerateObject()
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
        public bool TryGetProperty(in JsonPropertyName name, out JsonAny value)
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
        public bool TryGetProperty(string name, out JsonAny value)
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
        public bool TryGetProperty(ReadOnlySpan<char> name, out JsonAny value)
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
        public bool TryGetProperty(ReadOnlySpan<byte> utf8Name, out JsonAny value)
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
        public bool TryGetProperty<TValue>(in JsonPropertyName name, out TValue value)
            where TValue : struct, IJsonValue<TValue>
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (name.TryGetProperty(this.jsonElementBacking, out JsonElement result))
                {
                    value = TValue.FromJson(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
                    value = TValue.FromAny(result);
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool TryGetProperty<TValue>(string name, out TValue value)
            where TValue : struct, IJsonValue<TValue>
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
                    value = TValue.FromJson(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
                    value = TValue.FromAny(result);
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool TryGetProperty<TValue>(ReadOnlySpan<char> name, out TValue value)
            where TValue : struct, IJsonValue<TValue>
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(name, out JsonElement result))
                {
                    value = TValue.FromJson(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(name, out JsonAny result))
                {
                    value = TValue.FromAny(result);
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public bool TryGetProperty<TValue>(ReadOnlySpan<byte> utf8Name, out TValue value)
            where TValue : struct, IJsonValue<TValue>
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.TryGetProperty(utf8Name, out JsonElement result))
                {
                    value = TValue.FromJson(result);
                    return true;
                }

                value = default;
                return false;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(utf8Name, out JsonAny result))
                {
                    value = TValue.FromAny(result);
                    return true;
                }

                value = default;
                return false;
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public RemoveEntity SetProperty<TValue>(in JsonPropertyName name, TValue value)
            where TValue : struct, IJsonValue
        {
            return new(this.GetPropertyBackingWith(name, value.AsAny));
        }

        /// <inheritdoc/>
        public RemoveEntity RemoveProperty(in JsonPropertyName name)
        {
            return new(this.GetPropertyBackingWithout(name));
        }

        /// <inheritdoc/>
        public RemoveEntity RemoveProperty(string name)
        {
            return new(this.GetPropertyBackingWithout(name));
        }

        /// <inheritdoc/>
        public RemoveEntity RemoveProperty(ReadOnlySpan<char> name)
        {
            return new(this.GetPropertyBackingWithout(name));
        }

        /// <inheritdoc/>
        public RemoveEntity RemoveProperty(ReadOnlySpan<byte> utf8Name)
        {
            return new(this.GetPropertyBackingWithout(utf8Name));
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