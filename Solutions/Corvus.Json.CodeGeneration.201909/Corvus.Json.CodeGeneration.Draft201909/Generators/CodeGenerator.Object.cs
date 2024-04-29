//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft201909 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorObject : CodeGeneratorObjectBase {
        
        
        #line 593 "CodeGenerator.Object.tt"

    public bool ShouldGenerate
    {
        get
        {
            return IsImplicitObject || IsNotImplicitType;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.Object.tt"

    // This is only emitted if IsImplicitObject is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Object should not be emitted if IsImplicitObject is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.Object.tt"
            this.Write(@"//------------------------------------------------------------------------------
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

namespace ");
            
            #line default
            #line hidden
            
            #line 27 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "CodeGenerator.Object.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "CodeGenerator.Object.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 30 "CodeGenerator.Object.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Object.tt"
            this.Write(" : IJsonObject<");
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Object.tt"
            this.Write(">\r\n{\r\n    /// <summary>\r\n    /// Initializes a new instance of the <see cref=\"");
            
            #line default
            #line hidden
            
            #line 34 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 34 "CodeGenerator.Object.tt"
            this.Write("\"/> struct.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which" +
                    " to construct the instance.</param>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 37 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 37 "CodeGenerator.Object.tt"
            this.Write("(ImmutableList<JsonObjectProperty> value)\r\n    {\r\n        this.jsonElementBacking" +
                    " = default;\r\n        this.backing = Backing.Object;\r\n");
            
            #line default
            #line hidden
            
            #line 41 "CodeGenerator.Object.tt"
  if(IsImplicitString || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 43 "CodeGenerator.Object.tt"
            this.Write("        this.stringBacking = string.Empty;\r\n");
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Object.tt"
  }
    if (IsImplicitBoolean && !(IsImplicitNumber || IsNotImplicitType))
    { 
            
            #line default
            #line hidden
            
            #line 47 "CodeGenerator.Object.tt"
            this.Write("        this.boolBacking = default;\r\n");
            
            #line default
            #line hidden
            
            #line 48 "CodeGenerator.Object.tt"
  }
    if(IsImplicitNumber || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 51 "CodeGenerator.Object.tt"
            this.Write("        this.numberBacking = default;\r\n");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.Object.tt"
  }
    if(IsImplicitArray || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 55 "CodeGenerator.Object.tt"
            this.Write("        this.arrayBacking = ImmutableList<JsonAny>.Empty;\r\n");
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Object.tt"
  } 
            
            #line default
            #line hidden
            
            #line 57 "CodeGenerator.Object.tt"
            this.Write("        this.objectBacking = value;\r\n    }\r\n\r\n    /// <summary>\r\n    /// Conversi" +
                    "on from JsonObject.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value f" +
                    "rom which to convert.</param>\r\n    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 64 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 64 "CodeGenerator.Object.tt"
            this.Write(@"(JsonObject value)
    {
        if (value.HasDotnetBacking && value.ValueKind == JsonValueKind.Object)
        {
            return new(value.AsPropertyBacking());
        }

        return new(value.AsJsonElement);
    }


    /// <inheritdoc/>
    public ImmutableList<JsonObjectProperty> AsPropertyBacking()
    {
        return this.GetPropertyBacking();
    }

    /// <inheritdoc/>
    public JsonAny this[in JsonPropertyName name]
    {
        get
        {
            if (this.TryGetProperty(name, out JsonAny result))
            {
                return result;
            }

            throw new IndexOutOfRangeException();
        }
    }

    /// <summary>
    /// Creates an instance of the type from the given dictionary of properties.
    /// </summary>
    /// <param name=""source"">The dictionary of properties.</param>
    /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 100 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 100 "CodeGenerator.Object.tt"
            this.Write(@" FromProperties(IDictionary<JsonPropertyName, JsonAny> source)
    {
        return new(source.Select(kvp => new JsonObjectProperty(kvp.Key, kvp.Value)).ToImmutableList());
    }

    /// <summary>
    /// Creates an instance of the type from the given dictionary of properties.
    /// </summary>
    /// <param name=""source"">The dictionary of properties.</param>
    /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 110 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 110 "CodeGenerator.Object.tt"
            this.Write(@" FromProperties(ImmutableList<JsonObjectProperty> source)
    {
        return new(source);
    }

    /// <summary>
    /// Creates an instance of the type from the given dictionary of properties.
    /// </summary>
    /// <param name=""source"">The dictionary of properties.</param>
    /// <returns>An instance of the type initialized from the dictionary of properties.</returns>
    public static ");
            
            #line default
            #line hidden
            
            #line 120 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 120 "CodeGenerator.Object.tt"
            this.Write(" FromProperties(params (JsonPropertyName Name, JsonAny Value)[] source)\r\n    {\r\n " +
                    "       return new(source.Select(s => new JsonObjectProperty(s.Name, s.Value)).To" +
                    "ImmutableList());\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public JsonObjectEnumerat" +
                    "or EnumerateObject()\r\n    {\r\n        if ((this.backing & Backing.JsonElement) !=" +
                    " 0)\r\n        {\r\n            return new(this.jsonElementBacking);\r\n        }\r\n\r\n " +
                    "       if ((this.backing & Backing.Object) != 0)\r\n        {\r\n            return " +
                    "new(this.objectBacking);\r\n        }\r\n\r\n        throw new InvalidOperationExcepti" +
                    "on();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool HasProperties()\r\n    {\r\n " +
                    "       if ((this.backing & Backing.Object) != 0)\r\n        {\r\n            return " +
                    "this.objectBacking.Count > 0;\r\n        }\r\n\r\n        if ((this.backing & Backing." +
                    "JsonElement) != 0)\r\n        {\r\n            using JsonElement.ObjectEnumerator en" +
                    "umerator = this.jsonElementBacking.EnumerateObject();\r\n            return enumer" +
                    "ator.MoveNext();\r\n        }\r\n\r\n        throw new InvalidOperationException();\r\n " +
                    "   }\r\n\r\n    /// <inheritdoc/>\r\n    public bool HasProperty(in JsonPropertyName n" +
                    "ame)\r\n    {\r\n        if ((this.backing & Backing.JsonElement) != 0)\r\n        {\r\n" +
                    "            return name.TryGetProperty(this.jsonElementBacking, out JsonElement " +
                    "_);\r\n        }\r\n\r\n        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n" +
                    "            return this.objectBacking.ContainsKey(name);\r\n        }\r\n\r\n        t" +
                    "hrow new InvalidOperationException();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    publi" +
                    "c bool HasProperty(string name)\r\n    {\r\n        if ((this.backing & Backing.Json" +
                    "Element) != 0)\r\n        {\r\n            return this.jsonElementBacking.TryGetProp" +
                    "erty(name, out _);\r\n        }\r\n\r\n        if ((this.backing & Backing.Object) != " +
                    "0)\r\n        {\r\n            return this.objectBacking.ContainsKey(name);\r\n       " +
                    " }\r\n\r\n        throw new InvalidOperationException();\r\n    }\r\n\r\n    /// <inheritd" +
                    "oc/>\r\n    public bool HasProperty(ReadOnlySpan<char> name)\r\n    {\r\n        if ((" +
                    "this.backing & Backing.JsonElement) != 0)\r\n        {\r\n            return this.js" +
                    "onElementBacking.TryGetProperty(name, out _);\r\n        }\r\n\r\n        if ((this.ba" +
                    "cking & Backing.Object) != 0)\r\n        {\r\n            return this.objectBacking." +
                    "ContainsKey(name);\r\n        }\r\n\r\n        throw new InvalidOperationException();\r" +
                    "\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool HasProperty(ReadOnlySpan<byte> " +
                    "utf8Name)\r\n    {\r\n        if ((this.backing & Backing.JsonElement) != 0)\r\n      " +
                    "  {\r\n            return this.jsonElementBacking.TryGetProperty(utf8Name, out _);" +
                    "\r\n        }\r\n\r\n        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n   " +
                    "         return this.objectBacking.ContainsKey(utf8Name);\r\n        }\r\n\r\n        " +
                    "throw new InvalidOperationException();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    publ" +
                    "ic bool TryGetProperty(in JsonPropertyName name, out JsonAny value)\r\n    {\r\n    " +
                    "    if ((this.backing & Backing.JsonElement) != 0)\r\n        {\r\n            if (n" +
                    "ame.TryGetProperty(this.jsonElementBacking, out JsonElement result))\r\n          " +
                    "  {\r\n                value = new(result);\r\n                return true;\r\n       " +
                    "     }\r\n\r\n            value = default;\r\n            return false;\r\n        }\r\n\r\n" +
                    "        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n            return" +
                    " this.objectBacking.TryGetValue(name, out value);\r\n        }\r\n\r\n        throw ne" +
                    "w InvalidOperationException();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool " +
                    "TryGetProperty(string name, out JsonAny value)\r\n    {\r\n        if ((this.backing" +
                    " & Backing.JsonElement) != 0)\r\n        {\r\n            if (this.jsonElementBackin" +
                    "g.TryGetProperty(name, out JsonElement result))\r\n            {\r\n                " +
                    "value = new(result);\r\n                return true;\r\n            }\r\n\r\n           " +
                    " value = default;\r\n            return false;\r\n        }\r\n\r\n        if ((this.bac" +
                    "king & Backing.Object) != 0)\r\n        {\r\n            return this.objectBacking.T" +
                    "ryGetValue(name, out value);\r\n        }\r\n\r\n        throw new InvalidOperationExc" +
                    "eption();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool TryGetProperty(ReadOn" +
                    "lySpan<char> name, out JsonAny value)\r\n    {\r\n        if ((this.backing & Backin" +
                    "g.JsonElement) != 0)\r\n        {\r\n            if (this.jsonElementBacking.TryGetP" +
                    "roperty(name, out JsonElement result))\r\n            {\r\n                value = n" +
                    "ew(result);\r\n                return true;\r\n            }\r\n\r\n            value = " +
                    "default;\r\n            return false;\r\n        }\r\n\r\n        if ((this.backing & Ba" +
                    "cking.Object) != 0)\r\n        {\r\n            return this.objectBacking.TryGetValu" +
                    "e(name, out value);\r\n        }\r\n\r\n        throw new InvalidOperationException();" +
                    "\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool TryGetProperty(ReadOnlySpan<by" +
                    "te> utf8Name, out JsonAny value)\r\n    {\r\n        if ((this.backing & Backing.Jso" +
                    "nElement) != 0)\r\n        {\r\n            if (this.jsonElementBacking.TryGetProper" +
                    "ty(utf8Name, out JsonElement result))\r\n            {\r\n                value = ne" +
                    "w(result);\r\n                return true;\r\n            }\r\n\r\n            value = d" +
                    "efault;\r\n            return false;\r\n        }\r\n\r\n        if ((this.backing & Bac" +
                    "king.Object) != 0)\r\n        {\r\n            return this.objectBacking.TryGetValue" +
                    "(utf8Name, out value);\r\n        }\r\n\r\n        throw new InvalidOperationException" +
                    "();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool TryGetProperty<TValue>(in J" +
                    "sonPropertyName name, out TValue value)\r\n        where TValue : struct, IJsonVal" +
                    "ue<TValue>\r\n    {\r\n        if ((this.backing & Backing.JsonElement) != 0)\r\n     " +
                    "   {\r\n            if (name.TryGetProperty(this.jsonElementBacking, out JsonEleme" +
                    "nt result))\r\n            {\r\n#if NET8_0_OR_GREATER\r\n                value = TValu" +
                    "e.FromJson(result);\r\n#else\r\n                value = JsonValueNetStandard20Extens" +
                    "ions.FromJsonElement<TValue>(result);\r\n#endif\r\n                return true;\r\n   " +
                    "         }\r\n\r\n            value = default;\r\n            return false;\r\n        }" +
                    "\r\n\r\n        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n            if" +
                    " (this.objectBacking.TryGetValue(name, out JsonAny result))\r\n            {\r\n#if " +
                    "NET8_0_OR_GREATER\r\n                value = TValue.FromAny(result);\r\n#else\r\n     " +
                    "           value = result.As<TValue>();\r\n#endif\r\n                return true;\r\n " +
                    "           }\r\n\r\n            value = default;\r\n            return false;\r\n       " +
                    " }\r\n\r\n        throw new InvalidOperationException();\r\n    }\r\n\r\n    /// <inheritd" +
                    "oc/>\r\n    public bool TryGetProperty<TValue>(string name, out TValue value)\r\n   " +
                    "     where TValue : struct, IJsonValue<TValue>\r\n    {\r\n        if ((this.backing" +
                    " & Backing.JsonElement) != 0)\r\n        {\r\n            if (this.jsonElementBackin" +
                    "g.TryGetProperty(name, out JsonElement result))\r\n            {\r\n#if NET8_0_OR_GR" +
                    "EATER\r\n                value = TValue.FromJson(result);\r\n#else\r\n                " +
                    "value = JsonValueNetStandard20Extensions.FromJsonElement<TValue>(result);\r\n#endi" +
                    "f\r\n                return true;\r\n            }\r\n\r\n            value = default;\r\n" +
                    "            return false;\r\n        }\r\n\r\n        if ((this.backing & Backing.Obje" +
                    "ct) != 0)\r\n        {\r\n            if (this.objectBacking.TryGetValue(name, out J" +
                    "sonAny result))\r\n            {\r\n#if NET8_0_OR_GREATER\r\n                value = T" +
                    "Value.FromAny(result);\r\n#else\r\n                value = result.As<TValue>();\r\n#en" +
                    "dif\r\n                return true;\r\n            }\r\n\r\n            value = default;" +
                    "\r\n            return false;\r\n        }\r\n\r\n        throw new InvalidOperationExce" +
                    "ption();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public bool TryGetProperty<TValue>" +
                    "(ReadOnlySpan<char> name, out TValue value)\r\n        where TValue : struct, IJso" +
                    "nValue<TValue>\r\n    {\r\n        if ((this.backing & Backing.JsonElement) != 0)\r\n " +
                    "       {\r\n            if (this.jsonElementBacking.TryGetProperty(name, out JsonE" +
                    "lement result))\r\n            {\r\n#if NET8_0_OR_GREATER\r\n                value = T" +
                    "Value.FromJson(result);\r\n#else\r\n                value = JsonValueNetStandard20Ex" +
                    "tensions.FromJsonElement<TValue>(result);\r\n#endif\r\n                return true;\r" +
                    "\n            }\r\n\r\n            value = default;\r\n            return false;\r\n     " +
                    "   }\r\n\r\n        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n          " +
                    "  if (this.objectBacking.TryGetValue(name, out JsonAny result))\r\n            {\r\n" +
                    "#if NET8_0_OR_GREATER\r\n                value = TValue.FromAny(result);\r\n#else\r\n " +
                    "               value = result.As<TValue>();\r\n#endif\r\n                return true" +
                    ";\r\n            }\r\n\r\n            value = default;\r\n            return false;\r\n   " +
                    "     }\r\n\r\n        throw new InvalidOperationException();\r\n    }\r\n\r\n    /// <inhe" +
                    "ritdoc/>\r\n    public bool TryGetProperty<TValue>(ReadOnlySpan<byte> utf8Name, ou" +
                    "t TValue value)\r\n        where TValue : struct, IJsonValue<TValue>\r\n    {\r\n     " +
                    "   if ((this.backing & Backing.JsonElement) != 0)\r\n        {\r\n            if (th" +
                    "is.jsonElementBacking.TryGetProperty(utf8Name, out JsonElement result))\r\n       " +
                    "     {\r\n#if NET8_0_OR_GREATER\r\n                value = TValue.FromJson(result);\r" +
                    "\n#else\r\n                value = JsonValueNetStandard20Extensions.FromJsonElement" +
                    "<TValue>(result);\r\n#endif\r\n                return true;\r\n            }\r\n\r\n      " +
                    "      value = default;\r\n            return false;\r\n        }\r\n\r\n        if ((thi" +
                    "s.backing & Backing.Object) != 0)\r\n        {\r\n            if (this.objectBacking" +
                    ".TryGetValue(utf8Name, out JsonAny result))\r\n            {\r\n#if NET8_0_OR_GREATE" +
                    "R\r\n                value = TValue.FromAny(result);\r\n#else\r\n                value" +
                    " = result.As<TValue>();\r\n#endif\r\n                return true;\r\n            }\r\n\r\n" +
                    "            value = default;\r\n            return false;\r\n        }\r\n\r\n        th" +
                    "row new InvalidOperationException();\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public" +
                    " ");
            
            #line default
            #line hidden
            
            #line 471 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 471 "CodeGenerator.Object.tt"
            this.Write(" SetProperty<TValue>(in JsonPropertyName name, TValue value)\r\n        where TValu" +
                    "e : struct, IJsonValue\r\n    {\r\n        return new(this.GetPropertyBackingWith(na" +
                    "me, value.AsAny));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 478 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 478 "CodeGenerator.Object.tt"
            this.Write(" RemoveProperty(in JsonPropertyName name)\r\n    {\r\n        return new(this.GetProp" +
                    "ertyBackingWithout(name));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 484 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 484 "CodeGenerator.Object.tt"
            this.Write(" RemoveProperty(string name)\r\n    {\r\n        return new(this.GetPropertyBackingWi" +
                    "thout(name));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 490 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 490 "CodeGenerator.Object.tt"
            this.Write(" RemoveProperty(ReadOnlySpan<char> name)\r\n    {\r\n        return new(this.GetPrope" +
                    "rtyBackingWithout(name));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 496 "CodeGenerator.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 496 "CodeGenerator.Object.tt"
            this.Write(" RemoveProperty(ReadOnlySpan<byte> utf8Name)\r\n    {\r\n        return new(this.GetP" +
                    "ropertyBackingWithout(utf8Name));\r\n    }\r\n\r\n    /// <summary>\r\n    /// Builds an" +
                    " <see cref=\"ImmutableList{JsonObjectProperty}\"/> from the object.\r\n    /// </sum" +
                    "mary>\r\n    /// <returns>An immutable list of <see cref=\"JsonAny\"/> built from th" +
                    "e array.</returns>\r\n    /// <exception cref=\"InvalidOperationException\">The valu" +
                    "e is not an array.</exception>\r\n    private ImmutableList<JsonObjectProperty> Ge" +
                    "tPropertyBacking()\r\n    {\r\n        if ((this.backing & Backing.Object) != 0)\r\n  " +
                    "      {\r\n            return this.objectBacking;\r\n        }\r\n\r\n        return Pro" +
                    "pertyBackingBuilders.GetPropertyBackingBuilder(this.jsonElementBacking).ToImmuta" +
                    "ble();\r\n    }\r\n\r\n    /// <summary>\r\n    /// Builds an <see cref=\"ImmutableList{J" +
                    "sonObjectProperty}\"/> from the object, without a specific property.\r\n    /// </s" +
                    "ummary>\r\n    /// <returns>An immutable dictionary builder of <see cref=\"JsonProp" +
                    "ertyName\"/> to <see cref=\"JsonAny\"/>, built from the existing object, without th" +
                    "e given property.</returns>\r\n    /// <exception cref=\"InvalidOperationException\"" +
                    ">The value is not an object.</exception>\r\n    private ImmutableList<JsonObjectPr" +
                    "operty> GetPropertyBackingWithout(in JsonPropertyName name)\r\n    {\r\n        if (" +
                    "(this.backing & Backing.Object) != 0)\r\n        {\r\n            return this.object" +
                    "Backing.Remove(name);\r\n        }\r\n\r\n        return PropertyBackingBuilders.GetPr" +
                    "opertyBackingBuilderWithout(this.jsonElementBacking, name).ToImmutable();\r\n    }" +
                    "\r\n\r\n    /// <summary>\r\n    /// Builds an <see cref=\"ImmutableList{JsonObjectProp" +
                    "erty}\"/> from the object, without a specific property.\r\n    /// </summary>\r\n    " +
                    "/// <returns>An immutable dictionary builder of <see cref=\"JsonPropertyName\"/> t" +
                    "o <see cref=\"JsonAny\"/>, built from the existing object, without the given prope" +
                    "rty.</returns>\r\n    /// <exception cref=\"InvalidOperationException\">The value is" +
                    " not an object.</exception>\r\n    private ImmutableList<JsonObjectProperty> GetPr" +
                    "opertyBackingWithout(ReadOnlySpan<char> name)\r\n    {\r\n        if ((this.backing " +
                    "& Backing.Object) != 0)\r\n        {\r\n            return this.objectBacking.Remove" +
                    "(name);\r\n        }\r\n\r\n        return PropertyBackingBuilders.GetPropertyBackingB" +
                    "uilderWithout(this.jsonElementBacking, name).ToImmutable();\r\n    }\r\n\r\n    /// <s" +
                    "ummary>\r\n    /// Builds an <see cref=\"ImmutableList{JsonObjectProperty}\"/> from " +
                    "the object, without a specific property.\r\n    /// </summary>\r\n    /// <returns>A" +
                    "n immutable dictionary builder of <see cref=\"JsonPropertyName\"/> to <see cref=\"J" +
                    "sonAny\"/>, built from the existing object, without the given property.</returns>" +
                    "\r\n    /// <exception cref=\"InvalidOperationException\">The value is not an object" +
                    ".</exception>\r\n    private ImmutableList<JsonObjectProperty> GetPropertyBackingW" +
                    "ithout(ReadOnlySpan<byte> name)\r\n    {\r\n        if ((this.backing & Backing.Obje" +
                    "ct) != 0)\r\n        {\r\n            return this.objectBacking.Remove(name);\r\n     " +
                    "   }\r\n\r\n        return PropertyBackingBuilders.GetPropertyBackingBuilderWithout(" +
                    "this.jsonElementBacking, name).ToImmutable();\r\n    }\r\n\r\n    /// <summary>\r\n    /" +
                    "// Builds an <see cref=\"ImmutableList{JsonObjectProperty}\"/> from the object, wi" +
                    "thout a specific property.\r\n    /// </summary>\r\n    /// <returns>An immutable di" +
                    "ctionary builder of <see cref=\"JsonPropertyName\"/> to <see cref=\"JsonAny\"/>, bui" +
                    "lt from the existing object, without the given property.</returns>\r\n    /// <exc" +
                    "eption cref=\"InvalidOperationException\">The value is not an object.</exception>\r" +
                    "\n    private ImmutableList<JsonObjectProperty> GetPropertyBackingWithout(string " +
                    "name)\r\n    {\r\n        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n    " +
                    "        return this.objectBacking.Remove(name);\r\n        }\r\n\r\n        return Pro" +
                    "pertyBackingBuilders.GetPropertyBackingBuilderWithout(this.jsonElementBacking, n" +
                    "ame).ToImmutable();\r\n    }\r\n\r\n    /// <summary>\r\n    /// Builds an <see cref=\"Im" +
                    "mutableList{JsonObjectProperty}\"/> from the object, without a specific property." +
                    "\r\n    /// </summary>\r\n    /// <returns>An immutable dictionary builder of <see c" +
                    "ref=\"JsonPropertyName\"/> to <see cref=\"JsonAny\"/>, built from the existing objec" +
                    "t, without the given property.</returns>\r\n    /// <exception cref=\"InvalidOperat" +
                    "ionException\">The value is not an object.</exception>\r\n    private ImmutableList" +
                    "<JsonObjectProperty> GetPropertyBackingWith(in JsonPropertyName name, in JsonAny" +
                    " value)\r\n    {\r\n        if ((this.backing & Backing.Object) != 0)\r\n        {\r\n  " +
                    "          return this.objectBacking.SetItem(name, value);\r\n        }\r\n\r\n        " +
                    "ImmutableList<JsonObjectProperty>.Builder result = PropertyBackingBuilders.GetPr" +
                    "opertyBackingBuilderReplacing(this.jsonElementBacking, name, value);\r\n        re" +
                    "turn result.ToImmutable();\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 592 "CodeGenerator.Object.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorObjectBase {
        
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
