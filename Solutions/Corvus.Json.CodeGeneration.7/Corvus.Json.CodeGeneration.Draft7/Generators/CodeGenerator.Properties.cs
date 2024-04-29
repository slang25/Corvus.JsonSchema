//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft7 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorProperties : CodeGeneratorPropertiesBase {
        
        
        #line 224 "CodeGenerator.Properties.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasProperties;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.Properties.tt"

    // This is only emitted if HasProperties is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Properties should not be emitted if HasProperties is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.Properties.tt"
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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Properties.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 30 "CodeGenerator.Properties.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Properties.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Properties.tt"
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// The well-known property names in the JSON object." +
                    "\r\n    /// </summary>\r\n    public static class JsonPropertyNames\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.Properties.tt"
  foreach(var property in Properties)
    { 
            
            #line default
            #line hidden
            
            #line 41 "CodeGenerator.Properties.tt"
            this.Write("        /// <summary>\r\n        /// JSON property name for <see cref=\"");
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Properties.tt"
            this.Write("\"/>.\r\n        /// </summary>\r\n        public static ReadOnlySpan<byte> ");
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Properties.tt"
            this.Write("Utf8 => ");
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(property.JsonPropertyName, true)));
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Properties.tt"
            this.Write("u8;\r\n\r\n        /// <summary>\r\n        /// JSON property name for <see cref=\"");
            
            #line default
            #line hidden
            
            #line 47 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 47 "CodeGenerator.Properties.tt"
            this.Write("\"/>.\r\n        /// </summary>\r\n        public const string ");
            
            #line default
            #line hidden
            
            #line 49 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 49 "CodeGenerator.Properties.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 49 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(property.JsonPropertyName, true)));
            
            #line default
            #line hidden
            
            #line 49 "CodeGenerator.Properties.tt"
            this.Write(";\r\n");
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.Properties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 51 "CodeGenerator.Properties.tt"
            this.Write("    }\r\n");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.Properties.tt"
  foreach(var property in Properties)
    { 
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.Properties.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Gets the ");
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.IsRequired ? "" : "(optional) " ));
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Properties.tt"
            this.Write("<c>");
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(property.JsonPropertyName, false) ));
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Properties.tt"
            this.Write("</c> property.");
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.IsRequired ? " If the instance is valid, this property will be not be <c>undefined</c>." : "" ));
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.Properties.tt"
            this.Write("\r\n    /// </summary>\r\n");
            
            #line default
            #line hidden
            
            #line 58 "CodeGenerator.Properties.tt"
      if (property.HasXmlDocumentationRemarks)
        { 
            
            #line default
            #line hidden
            
            #line 60 "CodeGenerator.Properties.tt"
            this.Write("    /// <remarks>\r\n    ");
            
            #line default
            #line hidden
            
            #line 61 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.XmlDocumentationRemarks ));
            
            #line default
            #line hidden
            
            #line 61 "CodeGenerator.Properties.tt"
            this.Write("/// </remarks>\r\n");
            
            #line default
            #line hidden
            
            #line 62 "CodeGenerator.Properties.tt"
      } 
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Properties.tt"
            this.Write("    public ");
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Properties.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Properties.tt"
            this.Write(@"
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 74 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 74 "CodeGenerator.Properties.tt"
            this.Write("Utf8, out JsonElement result))\r\n                {\r\n                    return new" +
                    "  ");
            
            #line default
            #line hidden
            
            #line 76 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 76 "CodeGenerator.Properties.tt"
            this.Write("(result);\r\n                }\r\n            }\r\n\r\n            if ((this.backing & Ba" +
                    "cking.Object) != 0)\r\n            {\r\n                if(this.objectBacking.TryGet" +
                    "Value(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 82 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 82 "CodeGenerator.Properties.tt"
            this.Write(", out JsonAny result))\r\n                {\r\n                    return result.As<");
            
            #line default
            #line hidden
            
            #line 84 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 84 "CodeGenerator.Properties.tt"
            this.Write(">();\r\n                }\r\n            }\r\n\r\n            return default;\r\n        }\r" +
                    "\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 91 "CodeGenerator.Properties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 92 "CodeGenerator.Properties.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Creates an instance of a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 94 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 94 "CodeGenerator.Properties.tt"
            this.Write("\"/>.\r\n    /// </summary>\r\n    public static ");
            
            #line default
            #line hidden
            
            #line 96 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 96 "CodeGenerator.Properties.tt"
            this.Write(" Create(\r\n");
            
            #line default
            #line hidden
            
            #line 97 "CodeGenerator.Properties.tt"
  bool isFirstCreateParameter = true;
    foreach(var property in RequiredAllOfAndRefProperties)
    {
        if (!IsConst(property.Type))
        {
            if (isFirstCreateParameter)
            {
                isFirstCreateParameter = false;
            }
            else
            {
    
            
            #line default
            #line hidden
            
            #line 109 "CodeGenerator.Properties.tt"
            this.Write(", ");
            
            #line default
            #line hidden
            
            #line 109 "CodeGenerator.Properties.tt"

            }
    
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.Properties.tt"
            this.Write("        ");
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.Properties.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetParameterName ));
            
            #line default
            #line hidden
            
            #line 112 "CodeGenerator.Properties.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 113 "CodeGenerator.Properties.tt"
      }
    }

    foreach(var property in OptionalAllOfAndRefProperties)
    {
        if (isFirstCreateParameter)
        {
            isFirstCreateParameter = false;
        }
        else
        {
    
            
            #line default
            #line hidden
            
            #line 125 "CodeGenerator.Properties.tt"
            this.Write(",");
            
            #line default
            #line hidden
            
            #line 125 "CodeGenerator.Properties.tt"

        }
    
            
            #line default
            #line hidden
            
            #line 128 "CodeGenerator.Properties.tt"
            this.Write("        ");
            
            #line default
            #line hidden
            
            #line 128 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 128 "CodeGenerator.Properties.tt"
            this.Write("? ");
            
            #line default
            #line hidden
            
            #line 128 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetParameterName ));
            
            #line default
            #line hidden
            
            #line 128 "CodeGenerator.Properties.tt"
            this.Write(" = null ");
            
            #line default
            #line hidden
            
            #line 128 "CodeGenerator.Properties.tt"

    }
    
            
            #line default
            #line hidden
            
            #line 131 "CodeGenerator.Properties.tt"
            this.Write(")\r\n    {\r\n        var builder = ImmutableList.CreateBuilder<JsonObjectProperty>()" +
                    ";\r\n");
            
            #line default
            #line hidden
            
            #line 134 "CodeGenerator.Properties.tt"
  foreach(var property in RequiredAllOfAndRefProperties)
    {
        if (IsConst(property.Type))
        { 
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Properties.tt"
            this.Write("        builder.Add(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName));
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Properties.tt"
            this.Write(", new ");
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Properties.tt"
            this.Write("().AsAny);\r\n");
            
            #line default
            #line hidden
            
            #line 139 "CodeGenerator.Properties.tt"
      }
        else
        { 
            
            #line default
            #line hidden
            
            #line 142 "CodeGenerator.Properties.tt"
            this.Write("        builder.Add(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 142 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName));
            
            #line default
            #line hidden
            
            #line 142 "CodeGenerator.Properties.tt"
            this.Write(", ");
            
            #line default
            #line hidden
            
            #line 142 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetParameterName ));
            
            #line default
            #line hidden
            
            #line 142 "CodeGenerator.Properties.tt"
            this.Write(".AsAny);\r\n");
            
            #line default
            #line hidden
            
            #line 143 "CodeGenerator.Properties.tt"
      }
    }

    foreach(var property in OptionalAllOfAndRefProperties)
    { 
            
            #line default
            #line hidden
            
            #line 148 "CodeGenerator.Properties.tt"
            this.Write("\r\n        if (");
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetParameterName ));
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Properties.tt"
            this.Write(" is ");
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Properties.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetParameterName ));
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Properties.tt"
            this.Write("__)\r\n        {\r\n            builder.Add(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 151 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName));
            
            #line default
            #line hidden
            
            #line 151 "CodeGenerator.Properties.tt"
            this.Write(", ");
            
            #line default
            #line hidden
            
            #line 151 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetParameterName ));
            
            #line default
            #line hidden
            
            #line 151 "CodeGenerator.Properties.tt"
            this.Write("__.AsAny);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 153 "CodeGenerator.Properties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 154 "CodeGenerator.Properties.tt"
            this.Write("        return new(builder.ToImmutable());\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 156 "CodeGenerator.Properties.tt"
  foreach(var property in Properties)
    {
        if (IsConst(property.Type))
        {
            continue;
        } 
            
            #line default
            #line hidden
            
            #line 162 "CodeGenerator.Properties.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Sets ");
            
            #line default
            #line hidden
            
            #line 164 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(property.JsonPropertyName, true).Trim('"') ));
            
            #line default
            #line hidden
            
            #line 164 "CodeGenerator.Properties.tt"
            this.Write(".\r\n    /// </summary>\r\n    /// <param name=\"value\">The value to set.</param>\r\n   " +
                    " /// <returns>The entity with the updated property.</returns>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Properties.tt"
            this.Write(" With");
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Properties.tt"
            this.Write("(in ");
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Properties.tt"
            this.Write(" value)\r\n    {\r\n        return this.SetProperty(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 170 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 170 "CodeGenerator.Properties.tt"
            this.Write(", value);\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 172 "CodeGenerator.Properties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 173 "CodeGenerator.Properties.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 174 "CodeGenerator.Properties.tt"
  foreach (var property in LocalProperties)
    { 
            
            #line default
            #line hidden
            
            #line 176 "CodeGenerator.Properties.tt"
            this.Write("\r\n    private static ValidationContext __CorvusValidate");
            
            #line default
            #line hidden
            
            #line 177 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 177 "CodeGenerator.Properties.tt"
            this.Write("(in JsonObjectProperty property, in ValidationContext validationContext, Validati" +
                    "onLevel level)\r\n    {\r\n        return property.ValueAs<");
            
            #line default
            #line hidden
            
            #line 179 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Type.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 179 "CodeGenerator.Properties.tt"
            this.Write(">().Validate(validationContext, level);\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 181 "CodeGenerator.Properties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 182 "CodeGenerator.Properties.tt"
            this.Write(@"
    /// <summary>
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name=""property"">The property for which to get the validator.</param>
    /// <param name=""hasJsonElementBacking""><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name=""propertyValidator"">The validator for the property, if provided by this schema.</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)]out ObjectPropertyValidator? propertyValidator)
    {
        if (hasJsonElementBacking)
        {
");
            
            #line default
            #line hidden
            
            #line 194 "CodeGenerator.Properties.tt"
  bool isFirst = true;
    foreach (var property in LocalProperties)
    { 
            
            #line default
            #line hidden
            
            #line 197 "CodeGenerator.Properties.tt"
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 197 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( isFirst ? string.Empty : "else " ));
            
            #line default
            #line hidden
            
            #line 197 "CodeGenerator.Properties.tt"
            this.Write("if (property.NameEquals(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 197 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 197 "CodeGenerator.Properties.tt"
            this.Write("Utf8))\r\n            {\r\n                propertyValidator = __CorvusValidate");
            
            #line default
            #line hidden
            
            #line 199 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 199 "CodeGenerator.Properties.tt"
            this.Write(";\r\n                return true;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 202 "CodeGenerator.Properties.tt"
      isFirst = false;
    } 
            
            #line default
            #line hidden
            
            #line 204 "CodeGenerator.Properties.tt"
            this.Write("        }\r\n        else\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 207 "CodeGenerator.Properties.tt"
  isFirst = true;
    foreach (var property in LocalProperties)
    { 
            
            #line default
            #line hidden
            
            #line 210 "CodeGenerator.Properties.tt"
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 210 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( isFirst ? string.Empty : "else " ));
            
            #line default
            #line hidden
            
            #line 210 "CodeGenerator.Properties.tt"
            this.Write("if (property.NameEquals(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 210 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 210 "CodeGenerator.Properties.tt"
            this.Write("))\r\n            {\r\n                propertyValidator = __CorvusValidate");
            
            #line default
            #line hidden
            
            #line 212 "CodeGenerator.Properties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 212 "CodeGenerator.Properties.tt"
            this.Write(";\r\n                return true;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 215 "CodeGenerator.Properties.tt"
      isFirst = false;
    } 
            
            #line default
            #line hidden
            
            #line 217 "CodeGenerator.Properties.tt"
            this.Write("        }\r\n\r\n        propertyValidator = null;\r\n        return false;\r\n    }\r\n}\r\n" +
                    "");
            
            #line default
            #line hidden
            
            #line 223 "CodeGenerator.Properties.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorPropertiesBase {
        
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
