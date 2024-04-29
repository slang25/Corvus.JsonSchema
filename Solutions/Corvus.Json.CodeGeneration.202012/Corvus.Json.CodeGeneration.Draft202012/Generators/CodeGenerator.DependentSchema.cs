//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft202012 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorDependentSchema : CodeGeneratorDependentSchemaBase {
        
        
        #line 118 "CodeGenerator.DependentSchema.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasDependentSchemas;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.DependentSchema.tt"

    // This is only emitted if HasDependentSchemas is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.DependentSchema should not be emitted if HasDependentSchemas is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.DependentSchema.tt"
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
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 29 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 29 "CodeGenerator.DependentSchema.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 31 "CodeGenerator.DependentSchema.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 32 "CodeGenerator.DependentSchema.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "CodeGenerator.DependentSchema.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 35 "CodeGenerator.DependentSchema.tt"
  int dsIndexV = 0;
    foreach( var dependentSchema in DependentSchemas)
    {
        ++dsIndexV; 
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.DependentSchema.tt"
            this.Write("    private static ReadOnlySpan<byte> __DependentSchema");
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.DependentSchema.tt"
            this.Write("Utf8JsonPropertyName => ");
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(dependentSchema.Name, true)));
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.DependentSchema.tt"
            this.Write("u8;\r\n    private const string __DependentSchema");
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.DependentSchema.tt"
            this.Write("JsonPropertyName = ");
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(dependentSchema.Name, true)));
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.DependentSchema.tt"
            this.Write(";\r\n");
            
            #line default
            #line hidden
            
            #line 41 "CodeGenerator.DependentSchema.tt"
  }
    dsIndexV = 0;
    foreach (var dependentSchema in DependentSchemas)
    {
        ++dsIndexV; 
            
            #line default
            #line hidden
            
            #line 46 "CodeGenerator.DependentSchema.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Try to match the instance with the dependent schema " +
                    "for property ");
            
            #line default
            #line hidden
            
            #line 48 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.Name ));
            
            #line default
            #line hidden
            
            #line 48 "CodeGenerator.DependentSchema.tt"
            this.Write(", and get it as a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 48 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 48 "CodeGenerator.DependentSchema.tt"
            this.Write("\" /> if the property is present.\r\n    /// </summary>\r\n    /// <param name=\"result" +
                    "\">The value as a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.DependentSchema.tt"
            this.Write("\" />.</param>.\r\n    /// <returns><c>True</c> if the property was present.</return" +
                    "s>\r\n    public bool TryAsDependentSchemaFor");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.ToPascalCaseWithReservedWords(dependentSchema.Name).ToString() ));
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.DependentSchema.tt"
            this.Write("(out ");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.DependentSchema.tt"
            this.Write(" result)\r\n    {\r\n        if ((this.HasJsonElementBacking && this.HasProperty(__De" +
                    "pendentSchema");
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.DependentSchema.tt"
            this.Write("Utf8JsonPropertyName) || (!this.HasJsonElementBacking && this.HasProperty(__Depen" +
                    "dentSchema");
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.DependentSchema.tt"
            this.Write("JsonPropertyName))))\r\n        {\r\n            result = this.As<");
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 56 "CodeGenerator.DependentSchema.tt"
            this.Write(">();\r\n            return true;\r\n        }\r\n\r\n        result = ");
            
            #line default
            #line hidden
            
            #line 60 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 60 "CodeGenerator.DependentSchema.tt"
            this.Write(".Undefined;\r\n        return false;\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.DependentSchema.tt"
  } 
            
            #line default
            #line hidden
            
            #line 64 "CodeGenerator.DependentSchema.tt"
            this.Write(@"
    /// <summary>
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name=""property"">The property for which to get the validator.</param>
    /// <param name=""hasJsonElementBacking""><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name=""propertyValidator"">The validator for the property, if provided by this schema.</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    public bool __TryGetCorvusDependentSchemaValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)]out PropertyValidator<");
            
            #line default
            #line hidden
            
            #line 72 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 72 "CodeGenerator.DependentSchema.tt"
            this.Write(">? propertyValidator)\r\n    {\r\n        if (hasJsonElementBacking)\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 76 "CodeGenerator.DependentSchema.tt"
  dsIndexV = 0;
    foreach (var dependentSchema in DependentSchemas)
    {
        dsIndexV++; 
            
            #line default
            #line hidden
            
            #line 80 "CodeGenerator.DependentSchema.tt"
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 80 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV == 1 ? string.Empty : "else " ));
            
            #line default
            #line hidden
            
            #line 80 "CodeGenerator.DependentSchema.tt"
            this.Write("if (property.NameEquals(__DependentSchema");
            
            #line default
            #line hidden
            
            #line 80 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 80 "CodeGenerator.DependentSchema.tt"
            this.Write("Utf8JsonPropertyName))\r\n            {\r\n                propertyValidator = __Corv" +
                    "usValidateDependentSchema");
            
            #line default
            #line hidden
            
            #line 82 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 82 "CodeGenerator.DependentSchema.tt"
            this.Write(";\r\n                return true;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 85 "CodeGenerator.DependentSchema.tt"
  } 
            
            #line default
            #line hidden
            
            #line 86 "CodeGenerator.DependentSchema.tt"
            this.Write("        }\r\n        else\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 89 "CodeGenerator.DependentSchema.tt"
  dsIndexV = 0;
    foreach (var dependentSchema in DependentSchemas)
    {
        ++dsIndexV; 
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.DependentSchema.tt"
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV == 1 ? string.Empty : "else " ));
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.DependentSchema.tt"
            this.Write("if (property.NameEquals(__DependentSchema");
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.DependentSchema.tt"
            this.Write("JsonPropertyName))\r\n            {\r\n                propertyValidator = __CorvusVa" +
                    "lidateDependentSchema");
            
            #line default
            #line hidden
            
            #line 95 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 95 "CodeGenerator.DependentSchema.tt"
            this.Write(";\r\n                return true;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 98 "CodeGenerator.DependentSchema.tt"

    } 
            
            #line default
            #line hidden
            
            #line 100 "CodeGenerator.DependentSchema.tt"
            this.Write("        }\r\n\r\n        propertyValidator = null;\r\n        return false;\r\n    }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 106 "CodeGenerator.DependentSchema.tt"
  dsIndexV = 0;
    foreach (var dependentSchema in DependentSchemas)
    {
        dsIndexV++; 
            
            #line default
            #line hidden
            
            #line 110 "CodeGenerator.DependentSchema.tt"
            this.Write("\r\n    private static ValidationContext __CorvusValidateDependentSchema");
            
            #line default
            #line hidden
            
            #line 111 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dsIndexV ));
            
            #line default
            #line hidden
            
            #line 111 "CodeGenerator.DependentSchema.tt"
            this.Write("(in ");
            
            #line default
            #line hidden
            
            #line 111 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 111 "CodeGenerator.DependentSchema.tt"
            this.Write(" that, in ValidationContext validationContext, ValidationLevel level)\r\n    {\r\n   " +
                    "     return that.As<");
            
            #line default
            #line hidden
            
            #line 113 "CodeGenerator.DependentSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( dependentSchema.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 113 "CodeGenerator.DependentSchema.tt"
            this.Write(">().Validate(validationContext, level);\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 115 "CodeGenerator.DependentSchema.tt"
  } 
            
            #line default
            #line hidden
            
            #line 116 "CodeGenerator.DependentSchema.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            
            #line 117 "CodeGenerator.DependentSchema.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorDependentSchemaBase {
        
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
