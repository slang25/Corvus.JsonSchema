//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Runtime.CompilerServices;
using Corvus.Json;

namespace Corvus.Json.Benchmarking.Models;
/// <summary>
/// A component of a person's name.
/// </summary>
/// <remarks>
/// <para>
/// This is an array of strings, each of which is a component of a person's name.
/// </para>
/// </remarks>
public readonly partial struct PersonNameElementArray
{
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    PersonNameElementArray IJsonArray<PersonNameElementArray>.Remove(in JsonAny item1)
    {
        return new(this.GetImmutableListWithout(item1));
    }

    /// <summary>
    /// Remove the specified item from the array.
    /// </summary>
    /// <param name = "item">The item to remove.</param>
    /// <returns>An instance of the array with the item removed.</returns>
    /// <exception cref = "InvalidOperationException">The value was not an array.</exception>
    public PersonNameElementArray Remove(in Corvus.Json.Benchmarking.Models.PersonNameElement item)
    {
        return new(this.GetImmutableListWithout(item.AsAny));
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public PersonNameElementArray RemoveAt(int index)
    {
        return new(this.GetImmutableListWithoutRange(index, 1));
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public PersonNameElementArray RemoveRange(int index, int count)
    {
        return new(this.GetImmutableListWithoutRange(index, count));
    }
}