//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.10
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft6 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorEnum : CodeGeneratorEnumBase {
        
        
        #line 124 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasEnum;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"

    // This is only emitted if HasEnum is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Enum should not be emitted if IsEnum is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
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
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Permitted values.\r\n    /// </summary>\r\n    public" +
                    " static class EnumValues\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
  int enumItemIndex = 0;
    foreach (var enumValue in EnumValues)
    {
        if (enumValue.IsString)
        { 
            
            #line default
            #line hidden
            
            #line 45 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// ");
            
            #line default
            #line hidden
            
            #line 46 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.AsPropertyName ));
            
            #line default
            #line hidden
            
            #line 46 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".\r\n        /// </summary>\r\n        /// <remarks>\r\n        /// {Description}.\r\n   " +
                    "     /// </remarks>\r\n        public static readonly ");
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.AsPropertyName ));
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(");
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.SerializedValue ));
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 52 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
        else if (enumValue.IsBoolean)
        { 
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// [{Title} || Item ");
            
            #line default
            #line hidden
            
            #line 56 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex));
            
            #line default
            #line hidden
            
            #line 56 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("] (with predictable naming).\r\n        /// </summary>\r\n        /// <remarks>\r\n    " +
                    "    /// {Description}.\r\n        /// </remarks>\r\n        public static readonly ");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" Item");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.SerializedValue ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 62 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
        else if (enumValue.IsNumber)
        { 
            
            #line default
            #line hidden
            
            #line 65 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// [{Title} || Item ");
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("] (with predictable naming).\r\n        /// </summary>\r\n        /// <remarks>\r\n    " +
                    "    /// {Description}.\r\n        /// </remarks>\r\n        public static readonly ");
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" Item");
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(");
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.SerializedValue ));
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
        else if (enumValue.IsObject)
        { 
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// [{Title} || Item ");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex));
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("] (with predictable naming).\r\n        /// </summary>\r\n        /// <remarks>\r\n    " +
                    "    /// {Description}.\r\n        /// </remarks>\r\n        public static readonly ");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" Item");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex));
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.SerializedValue ));
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
        else if (enumValue.IsArray)
        { 
            
            #line default
            #line hidden
            
            #line 85 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// [{Title} || Item ");
            
            #line default
            #line hidden
            
            #line 86 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 86 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("] (with predictable naming).\r\n        /// </summary>\r\n        /// <remarks>\r\n    " +
                    "    /// {Description}.\r\n        /// </remarks>\r\n        public static readonly ");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" Item");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.SerializedValue ));
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
        else if (enumValue.IsNull)
        { 
            
            #line default
            #line hidden
            
            #line 95 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// [{Title} || Item ");
            
            #line default
            #line hidden
            
            #line 96 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 96 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("] (with predictable naming).\r\n        /// </summary>\r\n        /// <remarks>\r\n    " +
                    "    /// {Description}.\r\n        /// </remarks>\r\n        public static readonly ");
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" Item");
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex));
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(\"null\");\r\n");
            
            #line default
            #line hidden
            
            #line 102 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
        ++enumItemIndex;
    }

    enumItemIndex = 0;
    foreach (var enumValue in EnumValues)
    {
        if (enumValue.IsString)
        { 
            
            #line default
            #line hidden
            
            #line 111 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("        /// <summary>\r\n        /// [{Title} || Item ");
            
            #line default
            #line hidden
            
            #line 112 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 112 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("] (with predictable naming).\r\n        /// </summary>\r\n        /// <remarks>\r\n    " +
                    "    /// {Description}.\r\n        /// </remarks>\r\n        internal static readonly" +
                    " ");
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" Item");
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumItemIndex ));
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(".Parse(");
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( enumValue.SerializedValue ));
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 118 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
      }
            enumItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 121 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
            this.Write("    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 123 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Enum.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorEnumBase {
        
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
