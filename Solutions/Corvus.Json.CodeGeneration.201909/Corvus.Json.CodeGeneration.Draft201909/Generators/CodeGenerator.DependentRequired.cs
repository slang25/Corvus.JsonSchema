//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft201909 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorDependentRequired : CodeGeneratorDependentRequiredBase {
        
        
        #line 87 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasDependentRequired;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"

    // This is only emitted if HasDependentRequired is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.DependentRequired should not be emitted if HasDependentRequired is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
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
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 28 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 28 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 31 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(@"
{
    private static readonly ImmutableList<__CorvusDependency> __CorvusDependentRequired = BuildDependentRequired();

    private static ImmutableList<__CorvusDependency> BuildDependentRequired()
    {
        ImmutableList<__CorvusDependency>.Builder builder =
            ImmutableList.CreateBuilder<__CorvusDependency>();

");
            
            #line default
            #line hidden
            
            #line 43 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
  foreach (var dependentRequired in DependentRequired)
    { 
            
            #line default
            #line hidden
            
            #line 45 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write("        builder.Add(\r\n            new __CorvusDependency(\r\n                new by" +
                    "te[] { ");
            
            #line default
            #line hidden
            
            #line 47 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetEncodedBytes(dependentRequired.Name) ));
            
            #line default
            #line hidden
            
            #line 47 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(" },\r\n                ");
            
            #line default
            #line hidden
            
            #line 48 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(dependentRequired.Name, true) ));
            
            #line default
            #line hidden
            
            #line 48 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(",\r\n                ImmutableArray.Create<ReadOnlyMemory<byte>>(");
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"

        bool isFirst = true;
        foreach (var dependentRequiredValue in dependentRequired.RequiredNames)
        {
            if (!isFirst)
            { 
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(",\r\n");
            
            #line default
            #line hidden
            
            #line 56 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
          }
            else
            {
                isFirst = false;
            } 
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write("                   new byte[] { ");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetEncodedBytes(dependentRequiredValue) ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(" }\r\n");
            
            #line default
            #line hidden
            
            #line 62 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
      } 
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write("),\r\n                ImmutableArray.Create<string>(");
            
            #line default
            #line hidden
            
            #line 64 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"

        isFirst = true;
        foreach (var dependentRequiredValue in dependentRequired.RequiredNames)
        {
            if (!isFirst)
            { 
            
            #line default
            #line hidden
            
            #line 70 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(",\r\n");
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
          }
            else
            {
                isFirst = false;
            } 
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write("                   ");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(dependentRequired.Name, true) ));
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
      } 
            
            #line default
            #line hidden
            
            #line 77 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write(")));\r\n    ");
            
            #line default
            #line hidden
            
            #line 78 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"

    }
    
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
            this.Write("        return builder.ToImmutable();\r\n    }\r\n\r\n    private readonly record struc" +
                    "t __CorvusDependency(ReadOnlyMemory<byte> Utf8Name, string Name, ImmutableArray<" +
                    "ReadOnlyMemory<byte>> Utf8Dependency, ImmutableArray<string> Dependency);\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 86 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.DependentRequired.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorDependentRequiredBase {
        
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
