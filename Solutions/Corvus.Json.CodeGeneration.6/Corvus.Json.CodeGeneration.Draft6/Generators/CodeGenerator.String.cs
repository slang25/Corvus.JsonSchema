//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft6 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorString : CodeGeneratorStringBase {
        
        
        #line 439 "CodeGenerator.String.tt"

    public bool ShouldGenerate
    {
        get
        {
            return IsImplicitString || IsNotImplicitType;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.String.tt"

    // This is only emitted if IsImplicitString is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.String should not be emitted if IsImplicitString is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.String.tt"
            this.Write(@"//------------------------------------------------------------------------------
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

namespace ");
            
            #line default
            #line hidden
            
            #line 29 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 29 "CodeGenerator.String.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.String.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.String.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "CodeGenerator.String.tt"
            this.Write(" : IJsonString<");
            
            #line default
            #line hidden
            
            #line 33 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "CodeGenerator.String.tt"
            this.Write(">\r\n{\r\n    /// <summary>\r\n    /// Initializes a new instance of the <see cref=\"");
            
            #line default
            #line hidden
            
            #line 36 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 36 "CodeGenerator.String.tt"
            this.Write("\"/> struct.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which" +
                    " to construct the instance.</param>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.String.tt"
            this.Write("(string value)\r\n    {\r\n        this.jsonElementBacking = default;\r\n        this.b" +
                    "acking = Backing.String;\r\n\r\n        this.stringBacking = value;\r\n");
            
            #line default
            #line hidden
            
            #line 45 "CodeGenerator.String.tt"
  if (IsImplicitBoolean && !(IsImplicitNumber || IsNotImplicitType))
    { 
            
            #line default
            #line hidden
            
            #line 47 "CodeGenerator.String.tt"
            this.Write("        this.boolBacking = default;\r\n");
            
            #line default
            #line hidden
            
            #line 48 "CodeGenerator.String.tt"
  }
    if(IsImplicitNumber || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 51 "CodeGenerator.String.tt"
            this.Write("        this.numberBacking = default;\r\n");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.String.tt"
  }
    if(IsImplicitArray || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 55 "CodeGenerator.String.tt"
            this.Write("        this.arrayBacking = ImmutableList<JsonAny>.Empty;\r\n");
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.String.tt"
  }
    if(IsImplicitObject || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 59 "CodeGenerator.String.tt"
            this.Write("        this.objectBacking = ImmutableList<JsonObjectProperty>.Empty;\r\n");
            
            #line default
            #line hidden
            
            #line 60 "CodeGenerator.String.tt"
  } 
            
            #line default
            #line hidden
            
            #line 61 "CodeGenerator.String.tt"
            this.Write("    }\r\n\r\n    /// <summary>\r\n    /// Conversion from string.\r\n    /// </summary>\r\n" +
                    "    /// <param name=\"value\">The value from which to convert.</param>\r\n    public" +
                    " static implicit operator ");
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.String.tt"
            this.Write("(string value)\r\n    {\r\n        return new(value);\r\n    }\r\n\r\n    /// <summary>\r\n  " +
                    "  /// Conversion from JsonString.\r\n    /// </summary>\r\n    /// <param name=\"valu" +
                    "e\">The value from which to convert.</param>\r\n    public static implicit operator" +
                    " ");
            
            #line default
            #line hidden
            
            #line 76 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 76 "CodeGenerator.String.tt"
            this.Write(@"(JsonString value)
    {
        if (value.HasDotnetBacking && value.ValueKind == JsonValueKind.String)
        {
            return new((string)value);
        }

        return new(value.AsJsonElement);
    }

    /// <summary>
    /// Conversion to string.
    /// </summary>
    /// <param name=""value"">The value from which to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a string.</exception>
    public static explicit operator string(");
            
            #line default
            #line hidden
            
            #line 91 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 91 "CodeGenerator.String.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            if (value.jsonElementBacking.GetString() is string result)
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
    /// Concatenate two JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 120 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 120 "CodeGenerator.String.tt"
            this.Write(@" Concatenate<T1, T2>(Span<byte> buffer, in T1 firstValue, in T2 secondValue)
        where T1 : struct, IJsonValue<T1>
        where T2 : struct, IJsonValue<T2>
    {
        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, firstValue, secondValue);
        return ParseValue(buffer[..written]);
    }

    /// <summary>
    /// Concatenate three JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 129 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 129 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <typeparam name=""T3"">The type of the third value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <param name=""thirdValue"">The third value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 139 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 139 "CodeGenerator.String.tt"
            this.Write(@" Concatenate<T1, T2, T3>(Span<byte> buffer, in T1 firstValue, in T2 secondValue, in T3 thirdValue)
        where T1 : struct, IJsonValue<T1>
        where T2 : struct, IJsonValue<T2>
        where T3 : struct, IJsonValue<T3>
    {
        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, firstValue, secondValue, thirdValue);
        return ParseValue(buffer[..written]);
    }

    /// <summary>
    /// Concatenate four JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <typeparam name=""T3"">The type of the third value.</typeparam>
    /// <typeparam name=""T4"">The type of the fourth value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <param name=""thirdValue"">The third value.</param>
    /// <param name=""fourthValue"">The fourth value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 161 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 161 "CodeGenerator.String.tt"
            this.Write(@" Concatenate<T1, T2, T3, T4>(Span<byte> buffer, in T1 firstValue, in T2 secondValue, in T3 thirdValue, in T4 fourthValue)
        where T1 : struct, IJsonValue<T1>
        where T2 : struct, IJsonValue<T2>
        where T3 : struct, IJsonValue<T3>
        where T4 : struct, IJsonValue<T4>
    {
        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, firstValue, secondValue, thirdValue, fourthValue);
        return ParseValue(buffer[..written]);
    }

    /// <summary>
    /// Concatenate five JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 172 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 172 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <typeparam name=""T3"">The type of the third value.</typeparam>
    /// <typeparam name=""T4"">The type of the fourth value.</typeparam>
    /// <typeparam name=""T5"">The type of the fifth value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <param name=""thirdValue"">The third value.</param>
    /// <param name=""fourthValue"">The fourth value.</param>
    /// <param name=""fifthValue"">The fifth value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 186 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 186 "CodeGenerator.String.tt"
            this.Write(@" Concatenate<T1, T2, T3, T4, T5>(Span<byte> buffer, in T1 firstValue, in T2 secondValue, in T3 thirdValue, in T4 fourthValue, in T5 fifthValue)
        where T1 : struct, IJsonValue<T1>
        where T2 : struct, IJsonValue<T2>
        where T3 : struct, IJsonValue<T3>
        where T4 : struct, IJsonValue<T4>
        where T5 : struct, IJsonValue<T5>
    {
        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, firstValue, secondValue, thirdValue, fourthValue, fifthValue);
        return ParseValue(buffer[..written]);
    }

    /// <summary>
    /// Concatenate six JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 198 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 198 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <typeparam name=""T3"">The type of the third value.</typeparam>
    /// <typeparam name=""T4"">The type of the fourth value.</typeparam>
    /// <typeparam name=""T5"">The type of the fifth value.</typeparam>
    /// <typeparam name=""T6"">The type of the sixth value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <param name=""thirdValue"">The third value.</param>
    /// <param name=""fourthValue"">The fourth value.</param>
    /// <param name=""fifthValue"">The fifth value.</param>
    /// <param name=""sixthValue"">The sixth value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 214 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 214 "CodeGenerator.String.tt"
            this.Write(@" Concatenate<T1, T2, T3, T4, T5, T6>(Span<byte> buffer, in T1 firstValue, in T2 secondValue, in T3 thirdValue, in T4 fourthValue, in T5 fifthValue, in T6 sixthValue)
        where T1 : struct, IJsonValue<T1>
        where T2 : struct, IJsonValue<T2>
        where T3 : struct, IJsonValue<T3>
        where T4 : struct, IJsonValue<T4>
        where T5 : struct, IJsonValue<T5>
        where T6 : struct, IJsonValue<T6>
    {
        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, firstValue, secondValue, thirdValue, fourthValue, fifthValue, sixthValue);
        return ParseValue(buffer[..written]);
    }

    /// <summary>
    /// Concatenate seven JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 227 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 227 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <typeparam name=""T3"">The type of the third value.</typeparam>
    /// <typeparam name=""T4"">The type of the fourth value.</typeparam>
    /// <typeparam name=""T5"">The type of the fifth value.</typeparam>
    /// <typeparam name=""T6"">The type of the sixth value.</typeparam>
    /// <typeparam name=""T7"">The type of the seventh value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <param name=""thirdValue"">The third value.</param>
    /// <param name=""fourthValue"">The fourth value.</param>
    /// <param name=""fifthValue"">The fifth value.</param>
    /// <param name=""sixthValue"">The sixth value.</param>
    /// <param name=""seventhValue"">The seventh value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 245 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 245 "CodeGenerator.String.tt"
            this.Write(@" Concatenate<T1, T2, T3, T4, T5, T6, T7>(Span<byte> buffer, in T1 firstValue, in T2 secondValue, in T3 thirdValue, in T4 fourthValue, in T5 fifthValue, in T6 sixthValue, in T7 seventhValue)
        where T1 : struct, IJsonValue<T1>
        where T2 : struct, IJsonValue<T2>
        where T3 : struct, IJsonValue<T3>
        where T4 : struct, IJsonValue<T4>
        where T5 : struct, IJsonValue<T5>
        where T6 : struct, IJsonValue<T6>
        where T7 : struct, IJsonValue<T7>
    {
        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, firstValue, secondValue, thirdValue, fourthValue, fifthValue, sixthValue, seventhValue);
        return ParseValue(buffer[..written]);
    }

    /// <summary>
    /// Concatenate eight JSON values, producing an instance of the string type ");
            
            #line default
            #line hidden
            
            #line 259 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 259 "CodeGenerator.String.tt"
            this.Write(@".
    /// </summary>
    /// <typeparam name=""T1"">The type of the first value.</typeparam>
    /// <typeparam name=""T2"">The type of the second value.</typeparam>
    /// <typeparam name=""T3"">The type of the third value.</typeparam>
    /// <typeparam name=""T4"">The type of the fourth value.</typeparam>
    /// <typeparam name=""T5"">The type of the fifth value.</typeparam>
    /// <typeparam name=""T6"">The type of the sixth value.</typeparam>
    /// <typeparam name=""T7"">The type of the seventh value.</typeparam>
    /// <typeparam name=""T8"">The type of the eighth value.</typeparam>
    /// <param name=""buffer"">The buffer into which to concatenate the values.</param>
    /// <param name=""firstValue"">The first value.</param>
    /// <param name=""secondValue"">The second value.</param>
    /// <param name=""thirdValue"">The third value.</param>
    /// <param name=""fourthValue"">The fourth value.</param>
    /// <param name=""fifthValue"">The fifth value.</param>
    /// <param name=""sixthValue"">The sixth value.</param>
    /// <param name=""seventhValue"">The seventh value.</param>
    /// <param name=""eighthValue"">The eighth value.</param>
    /// <returns>An instance of this string type.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 279 "CodeGenerator.String.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 279 "CodeGenerator.String.tt"
            this.Write(" Concatenate<T1, T2, T3, T4, T5, T6, T7, T8>(Span<byte> buffer, in T1 firstValue," +
                    " in T2 secondValue, in T3 thirdValue, in T4 fourthValue, in T5 fifthValue, in T6" +
                    " sixthValue, in T7 seventhValue, in T8 eighthValue)\r\n        where T1 : struct, " +
                    "IJsonValue<T1>\r\n        where T2 : struct, IJsonValue<T2>\r\n        where T3 : st" +
                    "ruct, IJsonValue<T3>\r\n        where T4 : struct, IJsonValue<T4>\r\n        where T" +
                    "5 : struct, IJsonValue<T5>\r\n        where T6 : struct, IJsonValue<T6>\r\n        w" +
                    "here T7 : struct, IJsonValue<T7>\r\n        where T8 : struct, IJsonValue<T8>\r\n   " +
                    " {\r\n        int written = LowAllocJsonUtils.ConcatenateAsUtf8JsonString(buffer, " +
                    "firstValue, secondValue, thirdValue, fourthValue, fifthValue, sixthValue, sevent" +
                    "hValue, eighthValue);\r\n        return ParseValue(buffer[..written]);\r\n    }\r\n\r\n " +
                    "   /// <inheritdoc/>\r\n    public bool TryGetString([NotNullWhen(true)] out strin" +
                    "g? value)\r\n    {\r\n        if ((this.backing & Backing.String) != 0)\r\n        {\r\n" +
                    "            value = this.stringBacking;\r\n            return true;\r\n        }\r\n\r\n" +
                    "        if ((this.backing & Backing.JsonElement) != 0 && this.jsonElementBacking" +
                    ".ValueKind == JsonValueKind.String)\r\n        {\r\n            value = this.jsonEle" +
                    "mentBacking.GetString();\r\n            return value is not null;\r\n        }\r\n\r\n  " +
                    "      value = null;\r\n        return false;\r\n    }\r\n\r\n    /// <summary>\r\n    /// " +
                    "Gets the string value.\r\n    /// </summary>\r\n    /// <returns><c>The string if th" +
                    "is value represents a string</c>, otherwise <c>null</c>.</returns>\r\n    public s" +
                    "tring? GetString()\r\n    {\r\n        if (this.TryGetString(out string? value))\r\n  " +
                    "      {\r\n            return value;\r\n        }\r\n\r\n        return null;\r\n    }\r\n\r\n" +
                    "    /// <summary>\r\n    /// Compare to a sequence of characters.\r\n    /// </summa" +
                    "ry>\r\n    /// <param name=\"utf8Bytes\">The UTF8-encoded character sequence to comp" +
                    "are.</param>\r\n    /// <returns><c>True</c> if teh sequences match.</returns>\r\n  " +
                    "  public bool EqualsUtf8Bytes(ReadOnlySpan<byte> utf8Bytes)\r\n    {\r\n        if (" +
                    "(this.backing & Backing.JsonElement) != 0)\r\n        {\r\n            if (this.json" +
                    "ElementBacking.ValueKind == JsonValueKind.String)\r\n            {\r\n              " +
                    "  return this.jsonElementBacking.ValueEquals(utf8Bytes);\r\n            }\r\n       " +
                    " }\r\n\r\n        if ((this.backing & Backing.String) != 0)\r\n        {\r\n            " +
                    "int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Bytes.Length);\r\n#if NET8_0_" +
                    "OR_GREATER\r\n            char[]? pooledChars = null;\r\n\r\n            Span<char> ch" +
                    "ars = maxCharCount <= JsonValueHelpers.MaxStackAlloc  ?\r\n                stackal" +
                    "loc char[maxCharCount] :\r\n                (pooledChars = ArrayPool<char>.Shared." +
                    "Rent(maxCharCount));\r\n\r\n            try\r\n            {\r\n                int writ" +
                    "ten = Encoding.UTF8.GetChars(utf8Bytes, chars);\r\n                return chars[.." +
                    "written].SequenceEqual(this.stringBacking);\r\n            }\r\n            finally\r" +
                    "\n            {\r\n                if (pooledChars is char[] pc)\r\n                {" +
                    "\r\n                    ArrayPool<char>.Shared.Return(pc);\r\n                }\r\n   " +
                    "         }\r\n#else\r\n            char[] chars = ArrayPool<char>.Shared.Rent(maxCha" +
                    "rCount);\r\n            byte[] bytes = ArrayPool<byte>.Shared.Rent(utf8Bytes.Lengt" +
                    "h);\r\n            utf8Bytes.CopyTo(bytes);\r\n\r\n            try\r\n            {\r\n   " +
                    "             int written = Encoding.UTF8.GetChars(bytes, 0, bytes.Length, chars," +
                    " 0);\r\n                return chars.SequenceEqual(this.stringBacking);\r\n         " +
                    "   }\r\n            finally\r\n            {\r\n                ArrayPool<char>.Shared" +
                    ".Return(chars);\r\n                ArrayPool<byte>.Shared.Return(bytes);\r\n        " +
                    "    }\r\n#endif\r\n        }\r\n\r\n        return false;\r\n    }\r\n\r\n    /// <summary>\r\n " +
                    "   /// Compare to a sequence of characters.\r\n    /// </summary>\r\n    /// <param " +
                    "name=\"chars\">The character sequence to compare.</param>\r\n    /// <returns><c>Tru" +
                    "e</c> if teh sequences match.</returns>\r\n    public bool EqualsString(string cha" +
                    "rs)\r\n    {\r\n        if ((this.backing & Backing.JsonElement) != 0)\r\n        {\r\n " +
                    "           if (this.jsonElementBacking.ValueKind == JsonValueKind.String)\r\n     " +
                    "       {\r\n                return this.jsonElementBacking.ValueEquals(chars);\r\n  " +
                    "          }\r\n\r\n            return false;\r\n        }\r\n\r\n        if ((this.backing" +
                    " & Backing.String) != 0)\r\n        {\r\n            return chars.Equals(this.string" +
                    "Backing, StringComparison.Ordinal);\r\n        }\r\n\r\n        return false;\r\n    }\r\n" +
                    "\r\n    /// <summary>\r\n    /// Compare to a sequence of characters.\r\n    /// </sum" +
                    "mary>\r\n    /// <param name=\"chars\">The character sequence to compare.</param>\r\n " +
                    "   /// <returns><c>True</c> if teh sequences match.</returns>\r\n    public bool E" +
                    "qualsString(ReadOnlySpan<char> chars)\r\n    {\r\n        if ((this.backing & Backin" +
                    "g.JsonElement) != 0)\r\n        {\r\n            if (this.jsonElementBacking.ValueKi" +
                    "nd == JsonValueKind.String)\r\n            {\r\n                return this.jsonElem" +
                    "entBacking.ValueEquals(chars);\r\n            }\r\n\r\n            return false;\r\n    " +
                    "    }\r\n\r\n        if ((this.backing & Backing.String) != 0)\r\n        {\r\n#if NET8_" +
                    "0_OR_GREATER\r\n            return chars.SequenceEqual(this.stringBacking);\r\n#else" +
                    "\r\n            return chars.SequenceEqual(this.stringBacking.AsSpan());\r\n#endif\r\n" +
                    "        }\r\n\r\n        return false;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 438 "CodeGenerator.String.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorStringBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
