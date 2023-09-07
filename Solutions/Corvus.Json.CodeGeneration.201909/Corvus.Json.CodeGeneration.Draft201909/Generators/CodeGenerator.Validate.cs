//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.10
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft201909 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidate : CodeGeneratorValidateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "./Templates/CodeGenerator.Validate.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using System.Text.Json;
using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 18 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 18 "./Templates/CodeGenerator.Validate.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 20 "./Templates/CodeGenerator.Validate.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 21 "./Templates/CodeGenerator.Validate.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 24 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 24 "./Templates/CodeGenerator.Validate.tt"
            this.Write(@"
{
    /// <inheritdoc/>
    public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
    {
        ValidationContext result = validationContext;
        if (level > ValidationLevel.Flag)
        {
            result = result.UsingResults();
        }
        
        if (level > ValidationLevel.Basic)
        {
            result = result.UsingStack();
            result = result.PushSchemaLocation(""");
            
            #line default
            #line hidden
            
            #line 38 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.LocatedSchema.Location ));
            
            #line default
            #line hidden
            
            #line 38 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\");\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 40 "./Templates/CodeGenerator.Validate.tt"
  if (HasAdditionalProperties || HasUnevaluatedProperties)
    { 
            
            #line default
            #line hidden
            
            #line 42 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = result.UsingEvaluatedProperties();\r\n");
            
            #line default
            #line hidden
            
            #line 44 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasAdditionalItems || HasUnevaluatedItems)
    { 
            
            #line default
            #line hidden
            
            #line 47 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = result.UsingEvaluatedItems();\r\n");
            
            #line default
            #line hidden
            
            #line 49 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasRef)
    { 
            
            #line default
            #line hidden
            
            #line 52 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateRef(result, level);\r\n        if (level == Validat" +
                    "ionLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n      " +
                    "  }\r\n");
            
            #line default
            #line hidden
            
            #line 58 "./Templates/CodeGenerator.Validate.tt"
  }
    if ((HasExplicitType || HasFormat || HasMediaTypeOrEncoding) || (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasAdditionalItems) || (HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties || HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)))))
    { 
            
            #line default
            #line hidden
            
            #line 61 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        JsonValueKind valueKind = this.ValueKind;\r\n");
            
            #line default
            #line hidden
            
            #line 63 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasExplicitType || HasFormat || HasMediaTypeOrEncoding)
    {
        if (HasExplicitType)
        { 
            
            #line default
            #line hidden
            
            #line 68 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateType(valueKind, result, level);\r\n        if (leve" +
                    "l == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return res" +
                    "ult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 74 "./Templates/CodeGenerator.Validate.tt"
      }
        if (HasFormat)
        { 
            
            #line default
            #line hidden
            
            #line 77 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateFormat(valueKind, result, level);\r\n        if (le" +
                    "vel == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return r" +
                    "esult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 83 "./Templates/CodeGenerator.Validate.tt"
      }
        if (HasMediaTypeOrEncoding)
        { 
            
            #line default
            #line hidden
            
            #line 86 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateMediaTypeAndEncoding(valueKind, result, level);\r\n" +
                    "        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n      " +
                    "      return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 92 "./Templates/CodeGenerator.Validate.tt"
      }
    }
    if (HasConst)
    { 
            
            #line default
            #line hidden
            
            #line 96 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = Corvus.Json.Validate.ValidateConst(this, result, level, __Corv" +
                    "usConstValue);\r\n        if (level == ValidationLevel.Flag && !result.IsValid)\r\n " +
                    "       {\r\n            return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 102 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasEnum)
    { 
            
            #line default
            #line hidden
            
            #line 105 "./Templates/CodeGenerator.Validate.tt"
            this.Write("        result = Corvus.Json.Validate.ValidateEnum(\r\n            this,\r\n         " +
                    "   result,\r\n            level");
            
            #line default
            #line hidden
            
            #line 108 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( EnumValues.Length > 0 ? "," : ");" ));
            
            #line default
            #line hidden
            
            #line 108 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 109 "./Templates/CodeGenerator.Validate.tt"
      for(int enumIndex = 0; enumIndex < EnumValues.Length; ++enumIndex)
        { 
            
            #line default
            #line hidden
            
            #line 111 "./Templates/CodeGenerator.Validate.tt"
            this.Write("            EnumValues.Item");
            
            #line default
            #line hidden
            
            #line 111 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumIndex ));
            
            #line default
            #line hidden
            
            #line 111 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumIndex < (EnumValues.Length - 1) ? "," : ");" ));
            
            #line default
            #line hidden
            
            #line 111 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 112 "./Templates/CodeGenerator.Validate.tt"
      } 
            
            #line default
            #line hidden
            
            #line 113 "./Templates/CodeGenerator.Validate.tt"
            this.Write("        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n       " +
                    "     return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 117 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasMultipleOf || HasMaximum || HasExclusiveMaximum|| HasMinimum || HasExclusiveMinimum)
    { 
            
            #line default
            #line hidden
            
            #line 120 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = Corvus.Json.Validate.ValidateNumber(\r\n            this,\r\n     " +
                    "       result,\r\n            level,\r\n            ");
            
            #line default
            #line hidden
            
            #line 125 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMultipleOf ? MultipleOf : "null" ));
            
            #line default
            #line hidden
            
            #line 125 "./Templates/CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 126 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMaximum ? Maximum : "null" ));
            
            #line default
            #line hidden
            
            #line 126 "./Templates/CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 127 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasExclusiveMaximum ? ExclusiveMaximum : "null" ));
            
            #line default
            #line hidden
            
            #line 127 "./Templates/CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 128 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMinimum ? Minimum : "null" ));
            
            #line default
            #line hidden
            
            #line 128 "./Templates/CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 129 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasExclusiveMinimum ? ExclusiveMinimum : "null" ));
            
            #line default
            #line hidden
            
            #line 129 "./Templates/CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n " +
                    "           return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 135 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasMaxLength || HasMinLength || HasPattern)
    { 
            
            #line default
            #line hidden
            
            #line 138 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = Corvus.Json.Validate.ValidateString(\r\n            this,\r\n     " +
                    "       result,\r\n            level,\r\n            ");
            
            #line default
            #line hidden
            
            #line 143 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMaxLength ? MaxLength : "null" ));
            
            #line default
            #line hidden
            
            #line 143 "./Templates/CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 144 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMinLength ? MinLength : "null" ));
            
            #line default
            #line hidden
            
            #line 144 "./Templates/CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 145 "./Templates/CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasPattern ? "__CorvusPatternExpression" : "null" ));
            
            #line default
            #line hidden
            
            #line 145 "./Templates/CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n " +
                    "           return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 151 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasIfThenElse)
    { 
            
            #line default
            #line hidden
            
            #line 154 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateIfThenElse(result, level);\r\n        if (level == " +
                    "ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r" +
                    "\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 160 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasNot)
    { 
            
            #line default
            #line hidden
            
            #line 163 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateNot(result, level);\r\n        if (level == Validat" +
                    "ionLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n      " +
                    "  }\r\n");
            
            #line default
            #line hidden
            
            #line 169 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasAllOf)
    { 
            
            #line default
            #line hidden
            
            #line 172 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateAllOf(result, level);\r\n        if (level == Valid" +
                    "ationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n    " +
                    "    }\r\n");
            
            #line default
            #line hidden
            
            #line 178 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasAnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 181 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateAnyOf(result, level);\r\n        if (level == Valid" +
                    "ationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n    " +
                    "    }\r\n");
            
            #line default
            #line hidden
            
            #line 187 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasOneOf)
    { 
            
            #line default
            #line hidden
            
            #line 190 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateOneOf(result, level);\r\n        if (level == Valid" +
                    "ationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n    " +
                    "    }\r\n");
            
            #line default
            #line hidden
            
            #line 196 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties || HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)) || !AllowsAdditionalProperties))
    { 
            
            #line default
            #line hidden
            
            #line 199 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateObject(valueKind, result, level);\r\n        if (le" +
                    "vel == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return r" +
                    "esult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 205 "./Templates/CodeGenerator.Validate.tt"
  }
    if (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasAdditionalItems)
    { 
            
            #line default
            #line hidden
            
            #line 208 "./Templates/CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateArray(valueKind, result, level);\r\n        if (lev" +
                    "el == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return re" +
                    "sult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 214 "./Templates/CodeGenerator.Validate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 215 "./Templates/CodeGenerator.Validate.tt"
            this.Write("        if (level != ValidationLevel.Flag)\r\n        {\r\n            result = resul" +
                    "t.PopLocation();\r\n        }\r\n\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 223 "./Templates/CodeGenerator.Validate.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateBase {
        
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
