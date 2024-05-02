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
    
    
    public partial class CodeGeneratorValidateObject : CodeGeneratorValidateObjectBase {
        
        
        #line 319 "CodeGenerator.Validate.Object.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties|| HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)) || !AllowsAdditionalProperties);
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.Validate.Object.tt"

    // This is only emitted if HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties|| HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)) || !AllowsAdditionalProperties) is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.Object should not be emitted if HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties|| HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)) || !AllowsAdditionalProperties) is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.Validate.Object.tt"
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
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Validate.Object.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 30 "CodeGenerator.Validate.Object.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Validate.Object.tt"
            this.Write(@"
{
    private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;

        if (valueKind != JsonValueKind.Object)
        {
            return result;
        }
");
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Validate.Object.tt"
  if (HasMaxProperties || HasMinProperties || HasLocalProperties || HasRequired || HasDependentSchemas || HasPatternProperties || HasAdditionalProperties || HasUnevaluatedProperties)
    { 
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n        int propertyCount = 0;\r\n");
            
            #line default
            #line hidden
            
            #line 46 "CodeGenerator.Validate.Object.tt"
  }
    if (HasRequired)
    {
        foreach(var property in RequiredProperties)
        { 
            
            #line default
            #line hidden
            
            #line 51 "CodeGenerator.Validate.Object.tt"
            this.Write("        bool found");
            
            #line default
            #line hidden
            
            #line 51 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 51 "CodeGenerator.Validate.Object.tt"
            this.Write(" = false;\r\n");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.Validate.Object.tt"
      }
    } 
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 55 "CodeGenerator.Validate.Object.tt"
  if (HasDependentRequired)
    { 
            
            #line default
            #line hidden
            
            #line 57 "CodeGenerator.Validate.Object.tt"
            this.Write(@"        foreach(var dependentRequired in __CorvusDependentRequired)
        {
            if (this.HasJsonElementBacking)
            {
                if (this.HasProperty(dependentRequired.Utf8Name.Span))
                {
                    foreach (ReadOnlyMemory<byte> dependency in dependentRequired.Utf8Dependency)
                    {
                        ReadOnlySpan<byte> dSpan = dependency.Span;
                        if (!this.HasProperty(dSpan)");
            
            #line default
            #line hidden
            
            #line 66 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasDefaults ? " && !this.HasDefault(dSpan))" : ")" ));
            
            #line default
            #line hidden
            
            #line 66 "CodeGenerator.Validate.Object.tt"
            this.Write(@"
                        {
                            if (level >= ValidationLevel.Detailed)
                            {
#if NET8_0_OR_GREATER
                                result = result.WithResult(isValid: false, $""6.5.4. dependentRequired - dependent property \""{Encoding.UTF8.GetString(dSpan)}\"" not found."");
#else
                                result = result.WithResult(isValid: false, $""6.5.4. dependentRequired - dependent property \""{Encoding.UTF8.GetString(dSpan.ToArray())}\"" not found."");
#endif
                            }
                            else if (level >= ValidationLevel.Basic)
                            {
                                result = result.WithResult(isValid: false, ""6.5.4. dependentRequired - dependent property not found."");
                            }
                            else
                            {
                                return result.WithResult(isValid: false);
                            }
                        }
                    }
                }
            }
            else
            {
                if (this.HasProperty(dependentRequired.Name))
                {
                    foreach (string dependency in dependentRequired.Dependency)
                    {
                        if (!this.HasProperty(dependency)");
            
            #line default
            #line hidden
            
            #line 94 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasDefaults ? " && !this.HasDefault(dependency))" : ")" ));
            
            #line default
            #line hidden
            
            #line 94 "CodeGenerator.Validate.Object.tt"
            this.Write(@"
                        {
                            if (level >= ValidationLevel.Detailed)
                            {
                                result = result.WithResult(isValid: false, $""6.5.4. dependentRequired - dependent property \""{dependency}\"" not found."");
                            }
                            else if (level >= ValidationLevel.Basic)
                            {
                                result = result.WithResult(isValid: false, ""6.5.4. dependentRequired - dependent property not found."");
                            }
                            else
                            {
                                return result.WithResult(isValid: false);
                            }
                        }
                    }
                }
            }
        }
");
            
            #line default
            #line hidden
            
            #line 113 "CodeGenerator.Validate.Object.tt"
  } 
            
            #line default
            #line hidden
            
            #line 114 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n        foreach (JsonObjectProperty property in this.EnumerateObject())\r\n      " +
                    "  {\r\n");
            
            #line default
            #line hidden
            
            #line 117 "CodeGenerator.Validate.Object.tt"
  if (HasLocalProperties || HasRequired)
    { 
            
            #line default
            #line hidden
            
            #line 119 "CodeGenerator.Validate.Object.tt"
            this.Write(@"
            if (__TryGetCorvusLocalPropertiesValidator(property, this.HasJsonElementBacking, out ObjectPropertyValidator? propertyValidator))
            {
                result = result.WithLocalProperty(propertyCount);

                if (level > ValidationLevel.Basic)
                {
                    result = result.PushDocumentProperty(""properties"", property.Name.GetString());
                }

                var propertyResult = propertyValidator(property, result.CreateChildContext(), level);
                result = result.MergeResults(propertyResult.IsValid, level, propertyResult);

                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // property name
                }

                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }
");
            
            #line default
            #line hidden
            
            #line 141 "CodeGenerator.Validate.Object.tt"
      if (HasRequired)
        { 
            
            #line default
            #line hidden
            
            #line 143 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 144 "CodeGenerator.Validate.Object.tt"
          int requiredIndex = 0 ;
            foreach (var property in RequiredProperties)
            { 
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write("                ");
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( requiredIndex != 0 ? "else " : "" ));
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write("if ((this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write("Utf8)) || (!this.HasJsonElementBacking && property.NameEquals(JsonPropertyNames.");
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.Object.tt"
            this.Write(")))\r\n                {\r\n                    found");
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Validate.Object.tt"
            this.Write(" = true;\r\n                }\r\n");
            
            #line default
            #line hidden
            
            #line 151 "CodeGenerator.Validate.Object.tt"
          requiredIndex++;
            }
        } 
            
            #line default
            #line hidden
            
            #line 154 "CodeGenerator.Validate.Object.tt"
            this.Write("            }\r\n");
            
            #line default
            #line hidden
            
            #line 155 "CodeGenerator.Validate.Object.tt"
  }
    if (HasDependentSchemas)
    { 
            
            #line default
            #line hidden
            
            #line 158 "CodeGenerator.Validate.Object.tt"
            this.Write("            if (__TryGetCorvusDependentSchemaValidator(property, this.HasJsonElem" +
                    "entBacking, out PropertyValidator<");
            
            #line default
            #line hidden
            
            #line 158 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 158 "CodeGenerator.Validate.Object.tt"
            this.Write(@">? dependentSchemaValidator))
            {                
                var dependentSchemaResult = dependentSchemaValidator(this, result.CreateChildContext(), level);
                if (level == ValidationLevel.Flag && !dependentSchemaResult.IsValid)
                {
                    return result.WithResult(isValid: false);
                }

                result = result.MergeChildContext(dependentSchemaResult, true);
            }
");
            
            #line default
            #line hidden
            
            #line 168 "CodeGenerator.Validate.Object.tt"
  }
    if (HasPropertyNames || HasPatternProperties)
    { 
            
            #line default
            #line hidden
            
            #line 171 "CodeGenerator.Validate.Object.tt"
            this.Write("            string propertyName = property.Name.GetString();\r\n");
            
            #line default
            #line hidden
            
            #line 172 "CodeGenerator.Validate.Object.tt"
      if (HasPropertyNames)
        { 
            
            #line default
            #line hidden
            
            #line 174 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n            result = new ");
            
            #line default
            #line hidden
            
            #line 175 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PropertyNamesDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 175 "CodeGenerator.Validate.Object.tt"
            this.Write("(propertyName).Validate(result, level);\r\n            if (level == ValidationLevel" +
                    ".Flag && !result.IsValid)\r\n            {\r\n                return result;\r\n      " +
                    "      }\r\n");
            
            #line default
            #line hidden
            
            #line 180 "CodeGenerator.Validate.Object.tt"
      }
        if (HasPatternProperties)
        { 
            
            #line default
            #line hidden
            
            #line 183 "CodeGenerator.Validate.Object.tt"
            this.Write(@"
            foreach (System.Collections.Generic.KeyValuePair<Regex, PatternPropertyValidator> patternProperty in __CorvusPatternProperties)
            {
                if (patternProperty.Key.IsMatch(propertyName))
                {
                    result = result.WithLocalProperty(propertyCount);
                    result = patternProperty.Value(property, result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }
                }
            }
");
            
            #line default
            #line hidden
            
            #line 196 "CodeGenerator.Validate.Object.tt"
      }
    }
    if (AllowsAdditionalProperties && HasAdditionalProperties)
    { 
            
            #line default
            #line hidden
            
            #line 200 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n            if (!result.HasEvaluatedLocalProperty(propertyCount))\r\n            " +
                    "{\r\n                result = property.ValueAs<");
            
            #line default
            #line hidden
            
            #line 203 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( AdditionalPropertiesDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 203 "CodeGenerator.Validate.Object.tt"
            this.Write(@">().Validate(result, level);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }
                result = result.WithLocalProperty(propertyCount);
            }
");
            
            #line default
            #line hidden
            
            #line 210 "CodeGenerator.Validate.Object.tt"
  }
    if (AllowsAdditionalProperties && HasUnevaluatedProperties)
    { 
            
            #line default
            #line hidden
            
            #line 213 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n            if (!result.HasEvaluatedLocalOrAppliedProperty(propertyCount))\r\n   " +
                    "         {\r\n\r\n                result = property.ValueAs<");
            
            #line default
            #line hidden
            
            #line 217 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( UnevaluatedPropertiesDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 217 "CodeGenerator.Validate.Object.tt"
            this.Write(@">().Validate(result, level);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                result = result.WithLocalProperty(propertyCount);
            }
");
            
            #line default
            #line hidden
            
            #line 225 "CodeGenerator.Validate.Object.tt"
  }
    if (!AllowsAdditionalProperties)
    { 
            
            #line default
            #line hidden
            
            #line 228 "CodeGenerator.Validate.Object.tt"
            this.Write(@"
            if (!result.HasEvaluatedLocalProperty(propertyCount))
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $""9.3.2.3. additionalProperties - additional property \""{property.Name}\"" is not permitted."");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, ""9.3.2.3. additionalProperties - additional properties are not permitted."");
                }
                else
                {
                    return result.WithResult(isValid: false);
                }
            }
");
            
            #line default
            #line hidden
            
            #line 244 "CodeGenerator.Validate.Object.tt"
  }
    if (HasMaxProperties || HasMinProperties || HasLocalProperties || HasRequired || HasDependentSchemas || HasPatternProperties || HasAdditionalProperties || HasUnevaluatedProperties)
    { 
            
            #line default
            #line hidden
            
            #line 247 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n            propertyCount++;\r\n");
            
            #line default
            #line hidden
            
            #line 249 "CodeGenerator.Validate.Object.tt"
  } 
            
            #line default
            #line hidden
            
            #line 250 "CodeGenerator.Validate.Object.tt"
            this.Write("        }\r\n");
            
            #line default
            #line hidden
            
            #line 251 "CodeGenerator.Validate.Object.tt"
  if (HasRequired)
    {
        foreach (var property in RequiredProperties)
        {
            if (!property.HasDefaultValue)
            { 
            
            #line default
            #line hidden
            
            #line 257 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n        if (!found");
            
            #line default
            #line hidden
            
            #line 258 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.DotnetPropertyName ));
            
            #line default
            #line hidden
            
            #line 258 "CodeGenerator.Validate.Object.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.5.3. required - r" +
                    "equired property \\\"");
            
            #line default
            #line hidden
            
            #line 262 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(property.JsonPropertyName, true).Trim('"') ));
            
            #line default
            #line hidden
            
            #line 262 "CodeGenerator.Validate.Object.tt"
            this.Write(@"\"" not present."");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, ""6.5.3. required - required property not present."");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }
");
            
            #line default
            #line hidden
            
            #line 273 "CodeGenerator.Validate.Object.tt"
          }
        }
    }
    if (HasMaxProperties)
    { 
            
            #line default
            #line hidden
            
            #line 278 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n        if (propertyCount > ");
            
            #line default
            #line hidden
            
            #line 279 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxProperties ));
            
            #line default
            #line hidden
            
            #line 279 "CodeGenerator.Validate.Object.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.5.1. maxPropertie" +
                    "s - property count of {propertyCount} is greater than ");
            
            #line default
            #line hidden
            
            #line 283 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxProperties ));
            
            #line default
            #line hidden
            
            #line 283 "CodeGenerator.Validate.Object.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.5.1. maxP" +
                    "roperties - property count greater than ");
            
            #line default
            #line hidden
            
            #line 287 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxProperties ));
            
            #line default
            #line hidden
            
            #line 287 "CodeGenerator.Validate.Object.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 294 "CodeGenerator.Validate.Object.tt"
  }
    if (HasMinProperties)
    { 
            
            #line default
            #line hidden
            
            #line 297 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n        if (propertyCount < ");
            
            #line default
            #line hidden
            
            #line 298 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinProperties ));
            
            #line default
            #line hidden
            
            #line 298 "CodeGenerator.Validate.Object.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.5.2. minPropertie" +
                    "s - property count of {propertyCount} is lezs than ");
            
            #line default
            #line hidden
            
            #line 302 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinProperties ));
            
            #line default
            #line hidden
            
            #line 302 "CodeGenerator.Validate.Object.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.5.2. minP" +
                    "roperties - property count less than ");
            
            #line default
            #line hidden
            
            #line 306 "CodeGenerator.Validate.Object.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinProperties ));
            
            #line default
            #line hidden
            
            #line 306 "CodeGenerator.Validate.Object.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 313 "CodeGenerator.Validate.Object.tt"
  } 
            
            #line default
            #line hidden
            
            #line 314 "CodeGenerator.Validate.Object.tt"
            this.Write("\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 318 "CodeGenerator.Validate.Object.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateObjectBase {
        
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
