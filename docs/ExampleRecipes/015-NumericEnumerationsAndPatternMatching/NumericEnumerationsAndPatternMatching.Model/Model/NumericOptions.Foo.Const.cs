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
    /// The foo item.
    /// </summary>
    public readonly partial struct Foo
    {
        private static readonly Foo __CorvusConstValue = Foo.ParseValue("1"u8);
        /// <summary>
        /// Initializes a new instance of the <see cref = "Foo"/> struct.
        /// </summary>
        public Foo()
        {
            this.jsonElementBacking = __CorvusConstValue.jsonElementBacking;
            this.numberBacking = __CorvusConstValue.numberBacking;
            this.backing = __CorvusConstValue.backing;
        }

        /// <summary>
        /// Gets the constant value for this instance
        /// </summary>
        public static Foo ConstInstance => __CorvusConstValue;
    }
}