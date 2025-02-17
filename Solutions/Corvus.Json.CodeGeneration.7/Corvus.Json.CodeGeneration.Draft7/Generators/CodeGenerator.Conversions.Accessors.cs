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
    
    
    public partial class CodeGeneratorConversionsAccessors : CodeGeneratorConversionsAccessorsBase {
        
        
        #line 75 "CodeGenerator.Conversions.Accessors.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasConversions;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.Conversions.Accessors.tt"

    // This is only emitted if HasDirectConversions is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Conversions.Accessors should not be emitted if HasDirectConversions is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 23 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 23 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 25 "CodeGenerator.Conversions.Accessors.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 26 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 26 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 27 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 27 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 29 "CodeGenerator.Conversions.Accessors.tt"
  // Accessors are only provided
    foreach (Conversion conversion in DirectConversions)
    {
        if (conversion.DotnetTypeName == BuiltInTypes.AnyTypeDeclaration.Type)
        {
            continue;
        } 
            
            #line default
            #line hidden
            
            #line 36 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 37 "CodeGenerator.Conversions.Accessors.tt"
      if (!conversion.IsBuiltInType)
        { 
            
            #line default
            #line hidden
            
            #line 39 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("    /// <summary>\r\n    /// Gets the value as a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(" As");
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\r\n    {\r\n        get\r\n        {\r\n            return (");
            
            #line default
            #line hidden
            
            #line 46 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 46 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(")this;\r\n        }\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 49 "CodeGenerator.Conversions.Accessors.tt"
      } 
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Gets a value indicating whether this is a valid <see" +
                    " cref=\"");
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 52 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    public bool Is");
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 54 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\r\n    {\r\n        get\r\n        {\r\n            return ((");
            
            #line default
            #line hidden
            
            #line 58 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 58 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(")this).IsValid();\r\n        }\r\n    }\r\n\r\n    /// <summary>\r\n    /// Gets the value " +
                    "as a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 63 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    /// <param name=\"result\">The result of the convers" +
                    "ion.</param>\r\n    /// <returns><c>True</c> if the conversion was valid.</returns" +
                    ">\r\n    public bool TryGetAs");
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("(out ");
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 67 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(" result)\r\n    {\r\n        result = (");
            
            #line default
            #line hidden
            
            #line 69 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 69 "CodeGenerator.Conversions.Accessors.tt"
            this.Write(")this;\r\n        return result.IsValid();\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 72 "CodeGenerator.Conversions.Accessors.tt"
  }  
            
            #line default
            #line hidden
            
            #line 73 "CodeGenerator.Conversions.Accessors.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            
            #line 74 "CodeGenerator.Conversions.Accessors.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorConversionsAccessorsBase {
        
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
