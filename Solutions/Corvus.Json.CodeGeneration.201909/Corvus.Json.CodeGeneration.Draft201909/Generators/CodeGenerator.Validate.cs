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
    
    
    public partial class CodeGeneratorValidate : CodeGeneratorValidateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.Validate.tt"
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
            
            #line 18 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 18 "CodeGenerator.Validate.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 20 "CodeGenerator.Validate.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 21 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 21 "CodeGenerator.Validate.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 22 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 22 "CodeGenerator.Validate.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 24 "CodeGenerator.Validate.tt"
  if (HasMultipleOf)
    { 
            
            #line default
            #line hidden
            
            #line 26 "CodeGenerator.Validate.tt"
            this.Write("    private static readonly BinaryJsonNumber __Corvus_MultipleOf = new(");
            
            #line default
            #line hidden
            
            #line 26 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MultipleOf ));
            
            #line default
            #line hidden
            
            #line 26 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Validate.tt"
  }

    if (HasMaximum)
    {
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Validate.tt"
            this.Write("    private static readonly BinaryJsonNumber __Corvus_Maximum = new(");
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Maximum ));
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 34 "CodeGenerator.Validate.tt"
  }

    if (HasMinimum)
    {
            
            #line default
            #line hidden
            
            #line 38 "CodeGenerator.Validate.tt"
            this.Write("    private static readonly BinaryJsonNumber __Corvus_Minimum = new(");
            
            #line default
            #line hidden
            
            #line 38 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Minimum ));
            
            #line default
            #line hidden
            
            #line 38 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.Validate.tt"
  }

    if (HasExclusiveMaximum)
    { 
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Validate.tt"
            this.Write("    private static readonly BinaryJsonNumber __Corvus_ExclusiveMaximum = new(");
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ExclusiveMaximum ));
            
            #line default
            #line hidden
            
            #line 44 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 46 "CodeGenerator.Validate.tt"
  }

    if (HasExclusiveMinimum)
    { 
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.Validate.tt"
            this.Write("    private static readonly BinaryJsonNumber __Corvus_ExclusiveMinimum = new(");
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ExclusiveMinimum ));
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.Validate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 53 "CodeGenerator.Validate.tt"
            this.Write(@"    /// <inheritdoc/>
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
            
            #line 65 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.RelativeSchemaLocation ));
            
            #line default
            #line hidden
            
            #line 65 "CodeGenerator.Validate.tt"
            this.Write("\");\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.Validate.tt"
  if (HasAdditionalProperties || HasUnevaluatedProperties)
    { 
            
            #line default
            #line hidden
            
            #line 69 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = result.UsingEvaluatedProperties();\r\n");
            
            #line default
            #line hidden
            
            #line 71 "CodeGenerator.Validate.tt"
  }
    if (HasAdditionalItems || HasUnevaluatedItems)
    { 
            
            #line default
            #line hidden
            
            #line 74 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = result.UsingEvaluatedItems();\r\n");
            
            #line default
            #line hidden
            
            #line 76 "CodeGenerator.Validate.tt"
  }
    if (HasRef)
    { 
            
            #line default
            #line hidden
            
            #line 79 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateRef(result, level);\r\n        if (level == Validat" +
                    "ionLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n      " +
                    "  }\r\n");
            
            #line default
            #line hidden
            
            #line 85 "CodeGenerator.Validate.tt"
  }
    if ((HasExplicitType || HasFormat || HasMediaTypeOrEncoding) || (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasAdditionalItems) || (HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties || HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)))))
    { 
            
            #line default
            #line hidden
            
            #line 88 "CodeGenerator.Validate.tt"
            this.Write("\r\n        JsonValueKind valueKind = this.ValueKind;\r\n");
            
            #line default
            #line hidden
            
            #line 90 "CodeGenerator.Validate.tt"
  }
    if (HasExplicitType || HasFormat || HasMediaTypeOrEncoding)
    {
        if (HasExplicitType)
        { 
            
            #line default
            #line hidden
            
            #line 95 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateType(valueKind, result, level);\r\n        if (leve" +
                    "l == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return res" +
                    "ult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 101 "CodeGenerator.Validate.tt"
      }
        if (HasFormat)
        { 
            
            #line default
            #line hidden
            
            #line 104 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateFormat(valueKind, result, level);\r\n        if (le" +
                    "vel == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return r" +
                    "esult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 110 "CodeGenerator.Validate.tt"
      }
        if (HasMediaTypeOrEncoding)
        { 
            
            #line default
            #line hidden
            
            #line 113 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateMediaTypeAndEncoding(valueKind, result, level);\r\n" +
                    "        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n      " +
                    "      return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 119 "CodeGenerator.Validate.tt"
      }
    }
    if (HasConst)
    { 
            
            #line default
            #line hidden
            
            #line 123 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = Corvus.Json.Validate.ValidateConst(this, result, level, __Corv" +
                    "usConstValue);\r\n        if (level == ValidationLevel.Flag && !result.IsValid)\r\n " +
                    "       {\r\n            return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 129 "CodeGenerator.Validate.tt"
  }
    if (HasEnum)
    { 
            
            #line default
            #line hidden
            
            #line 132 "CodeGenerator.Validate.tt"
            this.Write("        result = Corvus.Json.Validate.ValidateEnum(\r\n            this,\r\n         " +
                    "   result,\r\n            level");
            
            #line default
            #line hidden
            
            #line 135 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( EnumValues.Length > 0 ? "," : ");" ));
            
            #line default
            #line hidden
            
            #line 135 "CodeGenerator.Validate.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 136 "CodeGenerator.Validate.tt"
      for(int enumIndex = 0; enumIndex < EnumValues.Length; ++enumIndex)
        { 
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Validate.tt"
            this.Write("            EnumValues.Item");
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumIndex ));
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumIndex < (EnumValues.Length - 1) ? "," : ");" ));
            
            #line default
            #line hidden
            
            #line 138 "CodeGenerator.Validate.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 139 "CodeGenerator.Validate.tt"
      } 
            
            #line default
            #line hidden
            
            #line 140 "CodeGenerator.Validate.tt"
            this.Write("        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n       " +
                    "     return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 144 "CodeGenerator.Validate.tt"
  }
    if (HasMultipleOf || HasMaximum || HasExclusiveMaximum|| HasMinimum || HasExclusiveMinimum)
    { 
            
            #line default
            #line hidden
            
            #line 147 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = Corvus.Json.Validate.ValidateNumber(\r\n            this,\r\n     " +
                    "       result,\r\n            level,\r\n            ");
            
            #line default
            #line hidden
            
            #line 152 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMultipleOf ? "__Corvus_MultipleOf" : "BinaryJsonNumber.None" ));
            
            #line default
            #line hidden
            
            #line 152 "CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 153 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMaximum ? "__Corvus_Maximum" : "BinaryJsonNumber.None" ));
            
            #line default
            #line hidden
            
            #line 153 "CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 154 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasExclusiveMaximum ? "__Corvus_ExclusiveMaximum" : "BinaryJsonNumber.None" ));
            
            #line default
            #line hidden
            
            #line 154 "CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 155 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMinimum ? "__Corvus_Minimum" : "BinaryJsonNumber.None" ));
            
            #line default
            #line hidden
            
            #line 155 "CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 156 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasExclusiveMinimum ? "__Corvus_ExclusiveMinimum" : "BinaryJsonNumber.None" ));
            
            #line default
            #line hidden
            
            #line 156 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n " +
                    "           return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 162 "CodeGenerator.Validate.tt"
  }
    if (HasMaxLength || HasMinLength || HasPattern)
    { 
            
            #line default
            #line hidden
            
            #line 165 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = Corvus.Json.Validate.ValidateString(\r\n            this,\r\n     " +
                    "       result,\r\n            level,\r\n            ");
            
            #line default
            #line hidden
            
            #line 170 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMaxLength ? MaxLength : "null" ));
            
            #line default
            #line hidden
            
            #line 170 "CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 171 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasMinLength ? MinLength : "null" ));
            
            #line default
            #line hidden
            
            #line 171 "CodeGenerator.Validate.tt"
            this.Write(",\r\n            ");
            
            #line default
            #line hidden
            
            #line 172 "CodeGenerator.Validate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasPattern ? "__CorvusPatternExpression" : "null" ));
            
            #line default
            #line hidden
            
            #line 172 "CodeGenerator.Validate.tt"
            this.Write(");\r\n\r\n        if (level == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n " +
                    "           return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 178 "CodeGenerator.Validate.tt"
  }
    if (HasIfThenElse)
    { 
            
            #line default
            #line hidden
            
            #line 181 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateIfThenElse(result, level);\r\n        if (level == " +
                    "ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r" +
                    "\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 187 "CodeGenerator.Validate.tt"
  }
    if (HasNot)
    { 
            
            #line default
            #line hidden
            
            #line 190 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateNot(result, level);\r\n        if (level == Validat" +
                    "ionLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n      " +
                    "  }\r\n");
            
            #line default
            #line hidden
            
            #line 196 "CodeGenerator.Validate.tt"
  }
    if (HasAllOf)
    { 
            
            #line default
            #line hidden
            
            #line 199 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateAllOf(result, level);\r\n        if (level == Valid" +
                    "ationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n    " +
                    "    }\r\n");
            
            #line default
            #line hidden
            
            #line 205 "CodeGenerator.Validate.tt"
  }
    if (HasAnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 208 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateAnyOf(result, level);\r\n        if (level == Valid" +
                    "ationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n    " +
                    "    }\r\n");
            
            #line default
            #line hidden
            
            #line 214 "CodeGenerator.Validate.tt"
  }
    if (HasOneOf)
    { 
            
            #line default
            #line hidden
            
            #line 217 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateOneOf(result, level);\r\n        if (level == Valid" +
                    "ationLevel.Flag && !result.IsValid)\r\n        {\r\n            return result;\r\n    " +
                    "    }\r\n");
            
            #line default
            #line hidden
            
            #line 223 "CodeGenerator.Validate.tt"
  }
    if (HasDependentRequired || HasLocalProperties || HasRequired || HasMaxProperties || HasMinProperties || HasDependentSchemas || HasPropertyNames || HasPatternProperties || ((AllowsAdditionalProperties && (HasAdditionalProperties || HasUnevaluatedProperties)) || !AllowsAdditionalProperties))
    { 
            
            #line default
            #line hidden
            
            #line 226 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateObject(valueKind, result, level);\r\n        if (le" +
                    "vel == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return r" +
                    "esult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 232 "CodeGenerator.Validate.tt"
  }
    if (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasAdditionalItems)
    { 
            
            #line default
            #line hidden
            
            #line 235 "CodeGenerator.Validate.tt"
            this.Write("\r\n        result = this.ValidateArray(valueKind, result, level);\r\n        if (lev" +
                    "el == ValidationLevel.Flag && !result.IsValid)\r\n        {\r\n            return re" +
                    "sult;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 241 "CodeGenerator.Validate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 242 "CodeGenerator.Validate.tt"
            this.Write("        if (level != ValidationLevel.Flag)\r\n        {\r\n            result = resul" +
                    "t.PopLocation();\r\n        }\r\n\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 250 "CodeGenerator.Validate.tt"
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
