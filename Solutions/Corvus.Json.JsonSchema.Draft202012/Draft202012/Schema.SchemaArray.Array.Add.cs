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
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Schema
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct SchemaArray
    {
        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.Add(in JsonAny item1)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.Add(item1);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.Add(params JsonAny[] items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.AddRange(items);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public SchemaArray AddRange<TArray>(in TArray items)
            where TArray : struct, IJsonArray<TArray>
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (JsonAny item in items.EnumerateArray())
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.AddRange<TItem>(IEnumerable<TItem> items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (TItem item in items)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.AddRange(IEnumerable<JsonAny> items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.AddRange(items);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.Insert(int index, in JsonAny item1)
        {
            return new(this.GetImmutableListWith(index, item1));
        }

        /// <inheritdoc/>
        public SchemaArray InsertRange<TArray>(int index, in TArray items)
            where TArray : struct, IJsonArray<TArray>
        {
            return new(this.GetImmutableListWith(index, items.EnumerateArray()));
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.InsertRange<TItem>(int index, IEnumerable<TItem> items)
        {
            return new(this.GetImmutableListWith(index, items.Select(item => item.AsAny)));
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.InsertRange(int index, IEnumerable<JsonAny> items)
        {
            return new(this.GetImmutableListWith(index, items));
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.Replace(in JsonAny oldValue, in JsonAny newValue)
        {
            return new(this.GetImmutableListReplacing(oldValue.AsAny, newValue.AsAny));
        }

        /// <inheritdoc/>
        SchemaArray IJsonArray<SchemaArray>.SetItem(int index, in JsonAny value)
        {
            return new(this.GetImmutableListSetting(index, value.AsAny));
        }

        /// <summary>
        /// Add an item to the array.
        /// </summary>
        /// <param name = "item1">The item to add.</param>
        /// <returns>An instance of the array with the item added.</returns>
        /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
        public SchemaArray Add(in Corvus.Json.JsonSchema.Draft202012.Schema item1)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.Add(item1);
            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Add a set of items to the array.
        /// </summary>
        /// <param name = "items">The items to add.</param>
        /// <returns>An instance of the array with the items added.</returns>
        /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
        public SchemaArray Add(params Corvus.Json.JsonSchema.Draft202012.Schema[] items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (Corvus.Json.JsonSchema.Draft202012.Schema item in items)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Add a set of items to the array.
        /// </summary>
        /// <param name = "items">The items to add.</param>
        /// <returns>An instance of the array with the items added.</returns>
        /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
        public SchemaArray AddRange(IEnumerable<Corvus.Json.JsonSchema.Draft202012.Schema> items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (Corvus.Json.JsonSchema.Draft202012.Schema item in items)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <summary>
        /// Insert an item into the array at the given index.
        /// </summary>
        /// <param name = "index">The index at which to add the item.</param>
        /// <param name = "item1">The item to add.</param>
        /// <returns>An instance of the array with the item added.</returns>
        /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
        public SchemaArray Insert(int index, in Corvus.Json.JsonSchema.Draft202012.Schema item1)
        {
            return new(this.GetImmutableListWith(index, item1));
        }

        /// <summary>
        /// Insert items into the array at the given index.
        /// </summary>
        /// <param name = "index">The index at which to add the items.</param>
        /// <param name = "items">The items to add.</param>
        /// <returns>An instance of the array with the items added.</returns>
        /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
        /// <exception cref = "IndexOutOfRangeException">The index was outside the bounds of the array.</exception>
        public SchemaArray InsertRange(int index, IEnumerable<Corvus.Json.JsonSchema.Draft202012.Schema> items)
        {
            return new(this.GetImmutableListWith(index, items.Select(item => item.AsAny)));
        }

        /// <summary>
        /// Replace the first instance of the given value with the new value, even if the items are identical.
        /// </summary>
        /// <param name = "oldValue">The item to remove.</param>
        /// <param name = "newValue">The item to insert.</param>
        /// <returns>An instance of the array with the item replaced.</returns>
        /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
        public SchemaArray Replace(in Corvus.Json.JsonSchema.Draft202012.Schema oldValue, in Corvus.Json.JsonSchema.Draft202012.Schema newValue)
        {
            return new(this.GetImmutableListReplacing(oldValue.AsAny, newValue.AsAny));
        }

        /// <summary>
        /// Set the item at the given index.
        /// </summary>
        /// <param name = "index">The index at which to set the item.</param>
        /// <param name = "value">The value to set.</param>
        /// <returns>An instance of the array with the item set to the given value.</returns>
        public SchemaArray SetItem(int index, in Corvus.Json.JsonSchema.Draft202012.Schema value)
        {
            return new(this.GetImmutableListSetting(index, value.AsAny));
        }
    }
}