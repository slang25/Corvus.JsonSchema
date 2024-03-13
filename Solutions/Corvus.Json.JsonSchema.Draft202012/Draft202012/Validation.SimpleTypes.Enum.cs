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

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
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
            /// Gets "array" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes Array = SimpleTypes.Parse("\"array\"");
            /// <summary>
            /// Gets "array" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> ArrayUtf8 => "array"u8;

            /// <summary>
            /// Gets "boolean" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes Boolean = SimpleTypes.Parse("\"boolean\"");
            /// <summary>
            /// Gets "boolean" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> BooleanUtf8 => "boolean"u8;

            /// <summary>
            /// Gets "integer" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes Integer = SimpleTypes.Parse("\"integer\"");
            /// <summary>
            /// Gets "integer" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> IntegerUtf8 => "integer"u8;

            /// <summary>
            /// Gets "null" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes Null = SimpleTypes.Parse("\"null\"");
            /// <summary>
            /// Gets "null" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> NullUtf8 => "null"u8;

            /// <summary>
            /// Gets "number" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes Number = SimpleTypes.Parse("\"number\"");
            /// <summary>
            /// Gets "number" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> NumberUtf8 => "number"u8;

            /// <summary>
            /// Gets "object" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes Object = SimpleTypes.Parse("\"object\"");
            /// <summary>
            /// Gets "object" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> ObjectUtf8 => "object"u8;

            /// <summary>
            /// Gets "string" as a JSON value.
            /// </summary>
            public static readonly SimpleTypes String = SimpleTypes.Parse("\"string\"");
            /// <summary>
            /// Gets "string" as a UTF8 string.
            /// </summary>
            public static ReadOnlySpan<byte> StringUtf8 => "string"u8;

            /// <summary>
            /// Gets "array" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item0 = SimpleTypes.Parse("\"array\"");
            /// <summary>
            /// Gets "boolean" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item1 = SimpleTypes.Parse("\"boolean\"");
            /// <summary>
            /// Gets "integer" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item2 = SimpleTypes.Parse("\"integer\"");
            /// <summary>
            /// Gets "null" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item3 = SimpleTypes.Parse("\"null\"");
            /// <summary>
            /// Gets "number" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item4 = SimpleTypes.Parse("\"number\"");
            /// <summary>
            /// Gets "object" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item5 = SimpleTypes.Parse("\"object\"");
            /// <summary>
            /// Gets "string" as a JSON value.
            /// </summary>
            internal static readonly SimpleTypes Item6 = SimpleTypes.Parse("\"string\"");
        }
    }
}