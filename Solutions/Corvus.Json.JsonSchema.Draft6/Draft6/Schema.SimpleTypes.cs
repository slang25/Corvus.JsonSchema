//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Buffers;
using System.ComponentModel;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft6;
public readonly partial struct Schema
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    [System.Text.Json.Serialization.JsonConverter(typeof(Corvus.Json.Internal.JsonValueConverter<SimpleTypes>))]
    public readonly partial struct SimpleTypes
    {
        private readonly Backing backing;
        private readonly JsonElement jsonElementBacking;
        private readonly string stringBacking;
        /// <summary>
        /// Initializes a new instance of the <see cref = "SimpleTypes"/> struct.
        /// </summary>
        public SimpleTypes()
        {
            this.jsonElementBacking = default;
            this.backing = Backing.JsonElement;
            this.stringBacking = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SimpleTypes"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public SimpleTypes(in JsonElement value)
        {
            this.jsonElementBacking = value;
            this.backing = Backing.JsonElement;
            this.stringBacking = string.Empty;
        }

        /// <summary>
        /// Gets a Null instance.
        /// </summary>
        public static SimpleTypes Null { get; } = new(JsonValueHelpers.NullElement);
        /// <summary>
        /// Gets an Undefined instance.
        /// </summary>
        public static SimpleTypes Undefined { get; }
        /// <summary>
        /// Gets the default instance of the type.
        /// </summary>
        public static SimpleTypes DefaultInstance { get; }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                if ((this.backing & Backing.String) != 0)
                {
                    return new(this.stringBacking);
                }

                if ((this.backing & Backing.Null) != 0)
                {
                    return JsonAny.Null;
                }

                return JsonAny.Undefined;
            }
        }

        /// <inheritdoc/>
        public JsonElement AsJsonElement
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return this.jsonElementBacking;
                }

                if ((this.backing & Backing.String) != 0)
                {
                    return JsonValueHelpers.StringToJsonElement(this.stringBacking);
                }

                if ((this.backing & Backing.Null) != 0)
                {
                    return JsonValueHelpers.NullElement;
                }

                return default;
            }
        }

        /// <inheritdoc/>
        public JsonString AsString
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                if ((this.backing & Backing.String) != 0)
                {
                    return new(this.stringBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        JsonBoolean IJsonValue.AsBoolean
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        JsonNumber IJsonValue.AsNumber
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        JsonObject IJsonValue.AsObject
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        JsonArray IJsonValue.AsArray
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        public bool HasJsonElementBacking
        {
            get
            {
                return (this.backing & Backing.JsonElement) != 0;
            }
        }

        /// <inheritdoc/>
        public bool HasDotnetBacking
        {
            get
            {
                return (this.backing & Backing.Dotnet) != 0;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return this.jsonElementBacking.ValueKind;
                }

                if ((this.backing & Backing.String) != 0)
                {
                    return JsonValueKind.String;
                }

                if ((this.backing & Backing.Null) != 0)
                {
                    return JsonValueKind.Null;
                }

                return JsonValueKind.Undefined;
            }
        }

        /// <summary>
        /// Conversion from JsonAny.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not compatible with this type.</exception>
        public static implicit operator SimpleTypes(in JsonAny value)
        {
            return value.As<SimpleTypes>();
        }

        /// <summary>
        /// Conversion to JsonAny.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not compatible with this type.</exception>
        public static implicit operator JsonAny(in SimpleTypes value)
        {
            return value.AsAny;
        }

        /// <summary>
        /// Equality operator.
        /// </summary>
        /// <param name = "left">The lhs.</param>
        /// <param name = "right">The rhs.</param>
        /// <returns><c>True</c> if the values are equal.</returns>
        public static bool operator ==(in SimpleTypes left, in SimpleTypes right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Inequality operator.
        /// </summary>
        /// <param name = "left">The lhs.</param>
        /// <param name = "right">The rhs.</param>
        /// <returns><c>True</c> if the values are equal.</returns>
        public static bool operator !=(in SimpleTypes left, in SimpleTypes right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Gets an instance of the JSON value from a JsonAny value.
        /// </summary>
        /// <param name = "value">The <see cref = "JsonAny"/> value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the <see cref = "JsonAny"/>.</returns>
        /// <remarks>The returned value will have a <see cref = "IJsonValue.ValueKind"/> of <see cref = "JsonValueKind.Undefined"/> if the
        /// value cannot be constructed from the given instance (e.g. because they have an incompatible dotnet backing type.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTypes FromAny(in JsonAny value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            JsonValueKind valueKind = value.ValueKind;
            return valueKind switch
            {
                JsonValueKind.String => new((string)value.AsString),
                JsonValueKind.Null => Null,
                _ => Undefined,
            };
        }

        /// <summary>
        /// Gets an instance of the JSON value from a <see cref = "JsonElement"/> value.
        /// </summary>
        /// <param name = "value">The <see cref = "JsonElement"/> value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the <see cref = "JsonElement"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTypes FromJson(in JsonElement value)
        {
            return new(value);
        }

        /// <summary>
        /// Gets an instance of the JSON value from a boolean value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be SimpleTypes.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static SimpleTypes IJsonValue<SimpleTypes>.FromBoolean<TValue>(in TValue value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from a string value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be SimpleTypes.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTypes FromString<TValue>(in TValue value)
            where TValue : struct, IJsonString<TValue>
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            if (value.ValueKind == JsonValueKind.String)
            {
                return new((string)value);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from a number value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be SimpleTypes.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static SimpleTypes IJsonValue<SimpleTypes>.FromNumber<TValue>(in TValue value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from an array value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be SimpleTypes.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static SimpleTypes IJsonValue<SimpleTypes>.FromArray<TValue>(in TValue value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from an object value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be SimpleTypes.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static SimpleTypes IJsonValue<SimpleTypes>.FromObject<TValue>(in TValue value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Parses a JSON string into a SimpleTypes.
        /// </summary>
        /// <param name = "json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "SimpleTypes"/> instance built from the JSON string.</returns>
        public static SimpleTypes Parse(string json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(json, options);
            return new SimpleTypes(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a SimpleTypes.
        /// </summary>
        /// <param name = "utf8Json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "SimpleTypes"/> instance built from the JSON string.</returns>
        public static SimpleTypes Parse(Stream utf8Json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(utf8Json, options);
            return new SimpleTypes(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a SimpleTypes.
        /// </summary>
        /// <param name = "utf8Json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "SimpleTypes"/> instance built from the JSON string.</returns>
        public static SimpleTypes Parse(ReadOnlyMemory<byte> utf8Json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(utf8Json, options);
            return new SimpleTypes(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a SimpleTypes.
        /// </summary>
        /// <param name = "json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "SimpleTypes"/> instance built from the JSON string.</returns>
        public static SimpleTypes Parse(ReadOnlyMemory<char> json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(json, options);
            return new SimpleTypes(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a SimpleTypes.
        /// </summary>
        /// <param name = "utf8Json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "SimpleTypes"/> instance built from the JSON string.</returns>
        public static SimpleTypes Parse(ReadOnlySequence<byte> utf8Json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(utf8Json, options);
            return new SimpleTypes(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON value from a buffer.
        /// </summary>
        /// <param name = "buffer">The buffer from which to parse the value.</param>
        /// <returns>The parsed value.</returns>
        static SimpleTypes ParseValue(ReadOnlySpan<char> buffer)
        {
            return IJsonValue<SimpleTypes>.ParseValue(buffer);
        }

        /// <summary>
        /// Parses a JSON value from a buffer.
        /// </summary>
        /// <param name = "buffer">The buffer from which to parse the value.</param>
        /// <returns>The parsed value.</returns>
        static SimpleTypes ParseValue(ReadOnlySpan<byte> buffer)
        {
            return IJsonValue<SimpleTypes>.ParseValue(buffer);
        }

        /// <summary>
        /// Parses a JSON value from a buffer.
        /// </summary>
        /// <param name = "reader">The reader from which to parse the value.</param>
        /// <returns>The parsed value.</returns>
        static SimpleTypes ParseValue(ref Utf8JsonReader reader)
        {
            return IJsonValue<SimpleTypes>.ParseValue(ref reader);
        }

        /// <summary>
        /// Gets the value as an instance of the target value.
        /// </summary>
        /// <typeparam name = "TTarget">The type of the target.</typeparam>
        /// <returns>An instance of the target type.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TTarget As<TTarget>()
            where TTarget : struct, IJsonValue<TTarget>
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return TTarget.FromJson(this.jsonElementBacking);
            }

            if ((this.backing & Backing.String) != 0)
            {
                return TTarget.FromString(this);
            }

            if ((this.backing & Backing.Null) != 0)
            {
                return TTarget.Null;
            }

            return TTarget.Undefined;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return (obj is IJsonValue jv && this.Equals(jv.AsAny)) || (obj is null && this.IsNull());
        }

        /// <inheritdoc/>
        public bool Equals<T>(in T other)
            where T : struct, IJsonValue<T>
        {
            return JsonValueHelpers.CompareValues(this, other);
        }

        /// <summary>
        /// Equality comparison.
        /// </summary>
        /// <param name = "other">The other item with which to compare.</param>
        /// <returns><see langword="true"/> if the values were equal.</returns>
        public bool Equals(in SimpleTypes other)
        {
            return JsonValueHelpers.CompareValues(this, other);
        }

        /// <inheritdoc/>
        public void WriteTo(Utf8JsonWriter writer)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Undefined)
                {
                    this.jsonElementBacking.WriteTo(writer);
                }

                return;
            }

            if ((this.backing & Backing.String) != 0)
            {
                writer.WriteStringValue(this.stringBacking);
                return;
            }

            if ((this.backing & Backing.Null) != 0)
            {
                writer.WriteNullValue();
                return;
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return JsonValueHelpers.GetHashCode(this);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Serialize();
        }
    }
}