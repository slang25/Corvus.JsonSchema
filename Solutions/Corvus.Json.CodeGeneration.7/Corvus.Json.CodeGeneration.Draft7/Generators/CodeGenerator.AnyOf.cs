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
    
    
    public partial class CodeGeneratorAnyOf : CodeGeneratorAnyOfBase {
        
        
        #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasAnyOf;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"

    // This is only emitted if HasAnyOf is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.AnyOf should not be emitted if HasAnyOf is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
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
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 31 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 31 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(@"
{
    /// <summary>
    /// Matches the value against each of the any of values, and returns the result of calling the provided match function for the first match found.
    /// </summary>
    /// <param name=""context"">The context to pass to the match function.</param>
");
            
            #line default
            #line hidden
            
            #line 37 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
  int anyOfItemIndex = 0;
    foreach (var anyOf in AnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("    /// <param name=\"match");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("\">The function to call if the value matches the <see cref=\"");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOf ));
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("\"/> type.</param>\r\n");
            
            #line default
            #line hidden
            
            #line 41 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
      anyOfItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 43 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("    /// <param name=\"defaultMatch\">The fallback match.</param>\r\n    public TOut M" +
                    "atch<TIn, TOut>(\r\n        in TIn context");
            
            #line default
            #line hidden
            
            #line 45 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
  anyOfItemIndex = 0;
    foreach (var anyOf in AnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 48 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(",\r\n\r\n        Matcher<");
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOf ));
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(", TIn, TOut> match");
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
      anyOfItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 52 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(",\r\n        Matcher<");
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(", TIn, TOut> defaultMatch)\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
  anyOfItemIndex = 0;
    foreach (var anyOf in AnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("        var anyOf");
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(" = this.As<");
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOf ));
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(">();\r\n        if (anyOf");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(".IsValid())\r\n        {\r\n            return match");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("(anyOf");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(", context);\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 64 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
      anyOfItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("        return defaultMatch(this, context);\r\n    }\r\n\r\n    /// <summary>\r\n    /// " +
                    "Matches the value against each of the any of values, and returns the result of c" +
                    "alling the provided match function for the first match found.\r\n    /// </summary" +
                    ">\r\n");
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
  anyOfItemIndex = 0;
    foreach (var anyOf in AnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("    /// <param name=\"match");
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("\">The function to call if the value matches the <see cref=\"");
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOf ));
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("\"/> type.</param>\r\n");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
      anyOfItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 78 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("    /// <param name=\"defaultMatch\">The fallback match.</param>\r\n    public TOut M" +
                    "atch<TOut>(");
            
            #line default
            #line hidden
            
            #line 79 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
  anyOfItemIndex = 0;
    foreach (var anyOf in AnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("        Matcher<");
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOf ));
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(", TOut> match");
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(",");
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
      anyOfItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 84 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("        Matcher<");
            
            #line default
            #line hidden
            
            #line 84 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 84 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(", TOut> defaultMatch)\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 86 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
  anyOfItemIndex = 0;
    foreach (var anyOf in AnyOf)
    { 
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("        var anyOf");
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(" = this.As<");
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOf ));
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(">();\r\n        if (anyOf");
            
            #line default
            #line hidden
            
            #line 90 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 90 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(".IsValid())\r\n        {\r\n            return match");
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("(anyOf");
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( anyOfItemIndex ));
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write(");\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 95 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
      anyOfItemIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 97 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
            this.Write("        return defaultMatch(this);\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 100 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.AnyOf.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorAnyOfBase {
        
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
