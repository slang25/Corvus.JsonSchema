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

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Schema
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct SimpleTypes
    {
        /// <summary>
        /// Permitted values.
        /// </summary>
        public static class EnumValues
        {
            /// <summary>
            /// Array.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes Array = SimpleTypes.Parse("\"array\"");
            /// <summary>
            /// Gets the Array as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> ArrayUtf8 => "array"u8;

            /// <summary>
            /// Boolean.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes Boolean = SimpleTypes.Parse("\"boolean\"");
            /// <summary>
            /// Gets the Boolean as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> BooleanUtf8 => "boolean"u8;

            /// <summary>
            /// Integer.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes Integer = SimpleTypes.Parse("\"integer\"");
            /// <summary>
            /// Gets the Integer as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> IntegerUtf8 => "integer"u8;

            /// <summary>
            /// Null.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes Null = SimpleTypes.Parse("\"null\"");
            /// <summary>
            /// Gets the Null as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> NullUtf8 => "null"u8;

            /// <summary>
            /// Number.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes Number = SimpleTypes.Parse("\"number\"");
            /// <summary>
            /// Gets the Number as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> NumberUtf8 => "number"u8;

            /// <summary>
            /// Object.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes Object = SimpleTypes.Parse("\"object\"");
            /// <summary>
            /// Gets the Object as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> ObjectUtf8 => "object"u8;

            /// <summary>
            /// String.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly SimpleTypes String = SimpleTypes.Parse("\"string\"");
            /// <summary>
            /// Gets the String as a raw UTF8 string.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static ReadOnlySpan<byte> StringUtf8 => "string"u8;

            /// <summary>
            /// [{Title} || Item 0] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item0 = SimpleTypes.Parse("\"array\"");
            /// <summary>
            /// [{Title} || Item 1] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item1 = SimpleTypes.Parse("\"boolean\"");
            /// <summary>
            /// [{Title} || Item 2] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item2 = SimpleTypes.Parse("\"integer\"");
            /// <summary>
            /// [{Title} || Item 3] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item3 = SimpleTypes.Parse("\"null\"");
            /// <summary>
            /// [{Title} || Item 4] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item4 = SimpleTypes.Parse("\"number\"");
            /// <summary>
            /// [{Title} || Item 5] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item5 = SimpleTypes.Parse("\"object\"");
            /// <summary>
            /// [{Title} || Item 6] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly SimpleTypes Item6 = SimpleTypes.Parse("\"string\"");
        }
    }
}