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

namespace JsonSchemaSample.Api;
public readonly partial struct NumericOptions
{
    /// <summary>
    /// The baz item.
    /// </summary>
    public readonly partial struct Baz
    {
        private static readonly Baz __CorvusConstValue = Baz.ParseValue("8"u8);
        /// <summary>
        /// Initializes a new instance of the <see cref = "Baz"/> struct.
        /// </summary>
        public Baz()
        {
            this.jsonElementBacking = __CorvusConstValue.jsonElementBacking;
            this.numberBacking = __CorvusConstValue.numberBacking;
            this.backing = __CorvusConstValue.backing;
        }

        /// <summary>
        /// Gets the constant value for this instance
        /// </summary>
        public static Baz ConstInstance => __CorvusConstValue;
    }
}