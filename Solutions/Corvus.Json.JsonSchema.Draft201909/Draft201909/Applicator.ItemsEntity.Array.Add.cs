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

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Applicator
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct ItemsEntity
    {
        /// <inheritdoc/>
        public ItemsEntity Add(in JsonAny item1)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.Add(item1);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public ItemsEntity Add(params JsonAny[] items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.AddRange(items);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public ItemsEntity AddRange<TArray>(in TArray items)
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
        public ItemsEntity AddRange<TItem>(IEnumerable<TItem> items)
            where TItem : struct, IJsonValue<TItem>
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (TItem item in items)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public ItemsEntity AddRange(IEnumerable<JsonAny> items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.AddRange(items);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public ItemsEntity Insert(int index, in JsonAny item1)
        {
            return new(this.GetImmutableListWith(index, item1));
        }

        /// <inheritdoc/>
        public ItemsEntity InsertRange<TArray>(int index, in TArray items)
            where TArray : struct, IJsonArray<TArray>
        {
            return new(this.GetImmutableListWith(index, items.EnumerateArray()));
        }

        /// <inheritdoc/>
        public ItemsEntity InsertRange<TItem>(int index, IEnumerable<TItem> items)
            where TItem : struct, IJsonValue<TItem>
        {
            return new(this.GetImmutableListWith(index, items.Select(item => item.AsAny)));
        }

        /// <inheritdoc/>
        public ItemsEntity InsertRange(int index, IEnumerable<JsonAny> items)
        {
            return new(this.GetImmutableListWith(index, items));
        }

        /// <inheritdoc/>
        public ItemsEntity Replace(in JsonAny oldValue, in JsonAny newValue)
        {
            return new(this.GetImmutableListReplacing(oldValue.AsAny, newValue.AsAny));
        }

        /// <inheritdoc/>
        public ItemsEntity SetItem(int index, in JsonAny value)
        {
            return new(this.GetImmutableListSetting(index, value.AsAny));
        }
    }
}