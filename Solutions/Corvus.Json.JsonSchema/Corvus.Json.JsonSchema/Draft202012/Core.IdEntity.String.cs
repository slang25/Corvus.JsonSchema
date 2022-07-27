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
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Core
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct IdEntity : IJsonString<IdEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "IdEntity"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public IdEntity(string value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.String;
            this.stringBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "IdEntity"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public IdEntity(in ReadOnlySpan<char> value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.String;
            this.stringBacking = value.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "IdEntity"/> struct.
        /// </summary>
        /// <param name = "utf8Value">The value from which to construct the instance.</param>
        public IdEntity(in ReadOnlySpan<byte> utf8Value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.String;
            this.stringBacking = Encoding.UTF8.GetString(utf8Value);
        }

        /// <summary>
        /// Conversion from JsonString.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator JsonString(IdEntity value)
        {
            return value.AsString;
        }

        /// <summary>
        /// Conversion to JsonString.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator IdEntity(JsonString value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return new((string)value);
        }

        /// <summary>
        /// Conversion from string.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator IdEntity(string value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to string.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a string.</exception>
        public static implicit operator string (IdEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                if (value.jsonElementBacking.GetString()is string result)
                {
                    return result;
                }

                throw new InvalidOperationException();
            }

            if ((value.backing & Backing.String) != 0)
            {
                return value.stringBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from string.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator IdEntity(ReadOnlySpan<char> value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to string.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a string.</exception>
        public static implicit operator ReadOnlySpan<char>(IdEntity value)
        {
            return ((string)value).AsSpan();
        }

        /// <summary>
        /// Conversion from string.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator IdEntity(ReadOnlySpan<byte> value)
        {
            return new(value);
        }

        /// <inheritdoc/>
        public bool TryGetString([NotNullWhen(true)] out string? value)
        {
            if ((this.backing & Backing.String) != 0)
            {
                value = this.stringBacking;
                return true;
            }

            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.String)
            {
                value = this.jsonElementBacking.GetString();
                return value is not null;
            }

            value = null;
            return false;
        }

        /// <inheritdoc/>
        public ReadOnlySpan<char> AsSpan()
        {
            if ((this.backing & Backing.String) != 0)
            {
                return this.stringBacking.AsSpan();
            }

            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.String)
            {
                return this.jsonElementBacking.GetString().AsSpan();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Gets the string value.
        /// </summary>
        /// <returns><c>The string if this value represents a string</c>, otherwise <c>null</c>.</returns>
        public string? AsOptionalString()
        {
            if (this.TryGetString(out string? value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Compare to a sequence of characters.
        /// </summary>
        /// <param name = "utf8Bytes">The UTF8-encoded character sequence to compare.</param>
        /// <returns><c>True</c> if teh sequences match.</returns>
        public bool EqualsUtf8Bytes(ReadOnlySpan<byte> utf8Bytes)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind == JsonValueKind.String)
                {
                    return this.jsonElementBacking.ValueEquals(utf8Bytes);
                }
            }

            if ((this.backing & Backing.String) != 0)
            {
                int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Bytes.Length);
                char[]? pooledChars = null;
                Span<char> chars = maxCharCount <= JsonValueHelpers.MaxStackAlloc ? stackalloc char[maxCharCount] : (pooledChars = ArrayPool<char>.Shared.Rent(maxCharCount));
                try
                {
                    int written = Encoding.UTF8.GetChars(utf8Bytes, chars);
                    return chars[..written].SequenceEqual(this.stringBacking);
                }
                finally
                {
                    if (pooledChars is not null)
                    {
                        ArrayPool<char>.Shared.Return(pooledChars);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Compare to a sequence of characters.
        /// </summary>
        /// <param name = "chars">The character sequence to compare.</param>
        /// <returns><c>True</c> if teh sequences match.</returns>
        public bool EqualsString(string chars)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind == JsonValueKind.String)
                {
                    return this.jsonElementBacking.ValueEquals(chars);
                }

                return false;
            }

            if ((this.backing & Backing.String) != 0)
            {
                return chars.Equals(this.stringBacking, StringComparison.Ordinal);
            }

            return false;
        }

        /// <summary>
        /// Compare to a sequence of characters.
        /// </summary>
        /// <param name = "chars">The character sequence to compare.</param>
        /// <returns><c>True</c> if teh sequences match.</returns>
        public bool EqualsString(ReadOnlySpan<char> chars)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind == JsonValueKind.String)
                {
                    return this.jsonElementBacking.ValueEquals(chars);
                }

                return false;
            }

            if ((this.backing & Backing.String) != 0)
            {
                return chars.SequenceEqual(this.stringBacking);
            }

            return false;
        }
    }
}