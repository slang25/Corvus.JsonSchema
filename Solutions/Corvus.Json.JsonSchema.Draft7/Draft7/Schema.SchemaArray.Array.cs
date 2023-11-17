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
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Schema
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct SchemaArray : IJsonArray<SchemaArray>
    {
        /// <summary>
        /// Gets an empty array.
        /// </summary>
        public static readonly SchemaArray EmptyArray = From(ImmutableList<JsonAny>.Empty);
        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public SchemaArray(ImmutableList<JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Array;
            this.arrayBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public SchemaArray(IEnumerable<JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Array;
            this.arrayBacking = value.ToImmutableList();
        }

        /// <inheritdoc/>
        public JsonAny this[int index]
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new JsonAny(this.jsonElementBacking[index]);
                }

                if ((this.backing & Backing.Array) != 0)
                {
                    try
                    {
                        return this.arrayBacking[index];
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        throw new IndexOutOfRangeException(ex.Message, ex);
                    }
                }

                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Conversion from immutable list.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator ImmutableList<JsonAny>(SchemaArray value)
        {
            return value.GetImmutableList();
        }

        /// <summary>s
        /// Conversion to immutable list.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator SchemaArray(ImmutableList<JsonAny> value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion from JsonArray.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator SchemaArray(JsonArray value)
        {
            if (value.HasDotnetBacking && value.ValueKind == JsonValueKind.Array)
            {
                return new(value.AsImmutableList());
            }

            return new(value.AsJsonElement);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "items">The list of items from which to construct the array.</param>
        /// <returns>An instance of the array constructed from the list.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SchemaArray From(ImmutableList<JsonAny> items)
        {
            return new(items);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value1">The first value from which to construct the instance.</param>
        /// <returns>A SchemaArray instantiated from the given items.</returns>
        public static SchemaArray FromItems(in Corvus.Json.JsonSchema.Draft7.Schema value1)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            builder.Add(value1.AsAny);
            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value1">The first value from which to construct the instance.</param>
        /// <param name = "value2">The second value from which to construct the instance.</param>
        /// <returns>A SchemaArray instantiated from the given items.</returns>
        public static SchemaArray FromItems(in Corvus.Json.JsonSchema.Draft7.Schema value1, in Corvus.Json.JsonSchema.Draft7.Schema value2)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            builder.Add(value1.AsAny);
            builder.Add(value2.AsAny);
            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value1">The first value from which to construct the instance.</param>
        /// <param name = "value2">The second value from which to construct the instance.</param>
        /// <param name = "value3">The thirdvalue from which to construct the instance.</param>
        /// <returns>A SchemaArray instantiated from the given items.</returns>
        public static SchemaArray FromItems(in Corvus.Json.JsonSchema.Draft7.Schema value1, in Corvus.Json.JsonSchema.Draft7.Schema value2, in Corvus.Json.JsonSchema.Draft7.Schema value3)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            builder.Add(value1.AsAny);
            builder.Add(value2.AsAny);
            builder.Add(value3.AsAny);
            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        /// <returns>A JsonAny instantiated from the given items.</returns>
        public static SchemaArray FromItems(params Corvus.Json.JsonSchema.Draft7.Schema[] value)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            foreach (Corvus.Json.JsonSchema.Draft7.Schema item in value)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SchemaArray"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        /// <returns>A JsonAny instantiated from the given items.</returns>
        public static SchemaArray FromRange(IEnumerable<Corvus.Json.JsonSchema.Draft7.Schema> value)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            foreach (Corvus.Json.JsonSchema.Draft7.Schema item in value)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <typeparam name = "T">The type of the <paramref name = "items"/> from which to create the array.</typeparam>
        /// <param name = "items">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        /// <remarks>
        /// This will serialize the items to create the underlying JsonArray. Note the
        /// other overloads which avoid this serialization step.
        /// </remarks>
        public static SchemaArray From<T>(IEnumerable<T> items)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            foreach (T item in items)
            {
                var abw = new ArrayBufferWriter<byte>();
                using var writer = new Utf8JsonWriter(abw);
                JsonSerializer.Serialize(writer, item);
                writer.Flush();
                builder.Add(JsonAny.Parse(abw.WrittenMemory));
            }

            return new SchemaArray(builder.ToImmutable());
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name = "items">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        /// <remarks>
        /// This will serialize the items to create the underlying JsonArray. Note the
        /// other overloads which avoid this serialization step.
        /// </remarks>
        public static SchemaArray FromRange(IEnumerable<JsonAny> items)
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            foreach (JsonAny item in items)
            {
                builder.Add(item);
            }

            return new SchemaArray(builder.ToImmutable());
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name = "items">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        /// <remarks>
        /// This will serialize the items to create the underlying JsonArray. Note the
        /// other overloads which avoid this serialization step.
        /// </remarks>
        public static SchemaArray FromRange<T>(IEnumerable<T> items)
            where T : struct, IJsonValue<T>
        {
            ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
            foreach (T item in items)
            {
                builder.Add(item.AsAny);
            }

            return new SchemaArray(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public ImmutableList<JsonAny> AsImmutableList()
        {
            return this.GetImmutableList();
        }

        /// <inheritdoc/>
        public ImmutableList<JsonAny>.Builder AsImmutableListBuilder()
        {
            return this.GetImmutableListBuilder();
        }

        /// <inheritdoc/>
        public int GetArrayLength()
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return this.jsonElementBacking.GetArrayLength();
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return this.arrayBacking.Count;
            }

            return 0;
        }

        /// <inheritdoc/>
        public JsonArrayEnumerator<Corvus.Json.JsonSchema.Draft7.Schema> EnumerateArray()
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new JsonArrayEnumerator<Corvus.Json.JsonSchema.Draft7.Schema>(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return new JsonArrayEnumerator<Corvus.Json.JsonSchema.Draft7.Schema>(this.arrayBacking);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        JsonArrayEnumerator IJsonArray<SchemaArray>.EnumerateArray()
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new JsonArrayEnumerator(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return new JsonArrayEnumerator(this.arrayBacking);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        JsonArrayEnumerator<TItem> IJsonArray<SchemaArray>.EnumerateArray<TItem>()
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new JsonArrayEnumerator<TItem>(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return new JsonArrayEnumerator<TItem>(this.arrayBacking);
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array.
        /// </summary>
        /// <returns>An immutable list of <see cref = "JsonAny"/> built from the array.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        private ImmutableList<JsonAny> GetImmutableList()
        {
            if ((this.backing & Backing.Array) != 0)
            {
                return this.arrayBacking;
            }

            return this.GetImmutableListBuilder().ToImmutable();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}.Builder"/> from the array.
        /// </summary>
        /// <returns>An immutable list builder of <see cref = "JsonAny"/>, built from the existing array.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        private ImmutableList<JsonAny>.Builder GetImmutableListBuilder()
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                ImmutableList<JsonAny>.Builder builder = ImmutableList.CreateBuilder<JsonAny>();
                foreach (JsonElement item in this.jsonElementBacking.EnumerateArray())
                {
                    builder.Add(new(item));
                }

                return builder;
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return this.arrayBacking.ToBuilder();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array, replacing the item at the specified index with the given item.
        /// </summary>
        /// <param name = "index">The index at which to add the element.</param>
        /// <param name = "value">The value to add.</param>
        /// <returns>An immutable list containing the contents of the list, with the specified item at the index.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        /// <exception cref = "IndexOutOfRangeException">Thrown if the range is beyond the bounds of the array.</exception>
        private ImmutableList<JsonAny> GetImmutableListSetting(int index, in JsonAny value)
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return JsonValueHelpers.GetImmutableListFromJsonElementSetting(this.jsonElementBacking, index, value);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                try
                {
                    return this.arrayBacking.SetItem(index, value);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(ex.Message, ex);
                }
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array, removing the first item that equals the given value, and replacing it with the specified item.
        /// </summary>
        /// <param name = "oldItem">The item to remove.</param>
        /// <param name = "newItem">The item to insert.</param>
        /// <returns>An immutable list containing the contents of the list, without the first instance that matches the old item, replacing it with the new item.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        private ImmutableList<JsonAny> GetImmutableListReplacing(in JsonAny oldItem, in JsonAny newItem)
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return JsonValueHelpers.GetImmutableListFromJsonElementReplacing(this.jsonElementBacking, oldItem, newItem);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return this.arrayBacking.Replace(oldItem, newItem);
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array, removing the first item that equals the given value.
        /// </summary>
        /// <param name = "item">The item to remove.</param>
        /// <returns>An immutable list containing the contents of the list, without the first instance that matches the given item.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        private ImmutableList<JsonAny> GetImmutableListWithout(in JsonAny item)
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return JsonValueHelpers.GetImmutableListFromJsonElementWithout(this.jsonElementBacking, item);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return this.arrayBacking.Remove(item);
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array, removing the given range.
        /// </summary>
        /// <param name = "index">The start index of the range to remove.</param>
        /// <param name = "count">The length of the range to remove.</param>
        /// <returns>An immutable list containing the contents of the list, without the given range of items.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        /// <exception cref = "IndexOutOfRangeException">Thrown if the range is beyond the bounds of the array.</exception>
        private ImmutableList<JsonAny> GetImmutableListWithoutRange(int index, int count)
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return JsonValueHelpers.GetImmutableListFromJsonElementWithoutRange(this.jsonElementBacking, index, count);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                try
                {
                    return this.arrayBacking.RemoveRange(index, count);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(ex.Message, ex);
                }
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array, adding the given item.
        /// </summary>
        /// <param name = "index">The index at which to add the element.</param>
        /// <param name = "value">The value to add.</param>
        /// <returns>An immutable list containing the contents of the list, without the array.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        /// <exception cref = "IndexOutOfRangeException">Thrown if the range is beyond the bounds of the array.</exception>
        private ImmutableList<JsonAny> GetImmutableListWith(int index, in JsonAny value)
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return JsonValueHelpers.GetImmutableListFromJsonElementWith(this.jsonElementBacking, index, value);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                try
                {
                    return this.arrayBacking.Insert(index, value);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(ex.Message, ex);
                }
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Builds an <see cref = "ImmutableList{JsonAny}"/> from the array, adding the given item.
        /// </summary>
        /// <param name = "index">The index at which to add the element.</param>
        /// <param name = "values">The values to add.</param>
        /// <returns>An immutable list containing the contents of the list, without the array.</returns>
        /// <exception cref = "InvalidOperationException">The value is not an array.</exception>
        /// <exception cref = "IndexOutOfRangeException">Thrown if the range is beyond the bounds of the array.</exception>
        private ImmutableList<JsonAny> GetImmutableListWith<TEnumerable>(int index, TEnumerable values)
            where TEnumerable : IEnumerable<JsonAny>
        {
            if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return JsonValueHelpers.GetImmutableListFromJsonElementWith(this.jsonElementBacking, index, values);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                try
                {
                    return this.arrayBacking.InsertRange(index, values);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(ex.Message, ex);
                }
            }

            throw new InvalidOperationException();
        }
    }
}