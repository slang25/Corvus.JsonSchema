//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft6 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateArray : CodeGeneratorValidateArrayBase {
        
        
        #line 267 "CodeGenerator.Validate.Array.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasAdditionalItems;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "CodeGenerator.Validate.Array.tt"

    // This is only emitted if (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasAditionalItems) is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.Array should not be emitted if (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasAdditionalItems) is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "CodeGenerator.Validate.Array.tt"
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
            
            #line 24 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 24 "CodeGenerator.Validate.Array.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 26 "CodeGenerator.Validate.Array.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 27 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 27 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 28 "CodeGenerator.Validate.Array.tt"
            this.Write(@"
{
    private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;

        if (valueKind != JsonValueKind.Array)
        {
            return result;
        }
");
            
            #line default
            #line hidden
            
            #line 38 "CodeGenerator.Validate.Array.tt"
  if (HasItems || HasContains || HasUniqueItems || HasAdditionalItems)
    { 
            
            #line default
            #line hidden
            
            #line 40 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        int arrayLength = 0;\r\n");
            
            #line default
            #line hidden
            
            #line 42 "CodeGenerator.Validate.Array.tt"
  }
    else
    { 
            
            #line default
            #line hidden
            
            #line 45 "CodeGenerator.Validate.Array.tt"
            this.Write("        int arrayLength = this.GetArrayLength();\r\n");
            
            #line default
            #line hidden
            
            #line 46 "CodeGenerator.Validate.Array.tt"
  }
    if (HasContains)
    { 
            
            #line default
            #line hidden
            
            #line 49 "CodeGenerator.Validate.Array.tt"
            this.Write("        int containsCount = 0;\r\n");
            
            #line default
            #line hidden
            
            #line 50 "CodeGenerator.Validate.Array.tt"
  }
    if (HasItems || HasContains || HasUniqueItems || HasAdditionalItems)
    { 
            
            #line default
            #line hidden
            
            #line 53 "CodeGenerator.Validate.Array.tt"
            this.Write(@"        using var arrayEnumerator = this.EnumerateArray();

        while (arrayEnumerator.MoveNext())
        {
            if (level > ValidationLevel.Basic)
            {
                result = result.PushDocumentArrayIndex(arrayLength);
            }

");
            
            #line default
            #line hidden
            
            #line 62 "CodeGenerator.Validate.Array.tt"
      if (HasUniqueItems)
        { 
            
            #line default
            #line hidden
            
            #line 64 "CodeGenerator.Validate.Array.tt"
            this.Write(@"            using var innerEnumerator = this.EnumerateArray();
            int innerIndex = -1;
            while (innerIndex < arrayLength && innerEnumerator.MoveNext())
            {
                innerIndex++;
            }

            while (innerEnumerator.MoveNext())
            {
                if (innerEnumerator.Current.Equals(arrayEnumerator.Current))
                {
                    if (level >= ValidationLevel.Detailed)
                    {
                        result = result.WithResult(isValid: false, $""6.4.3. uniqueItems - duplicate items were found at indices {arrayLength} and {innerIndex}."");
                    }
                    else if (level >= ValidationLevel.Basic)
                    {
                        result = result.WithResult(isValid: false, ""6.4.3. uniqueItems - duplicate items were found."");
                    }
                    else
                    {
                        return result.WithResult(isValid: false);
                    }
                }
            }
");
            
            #line default
            #line hidden
            
            #line 89 "CodeGenerator.Validate.Array.tt"
      }
        if (HasContains)
        { 
            
            #line default
            #line hidden
            
            #line 92 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            ValidationContext containsResult = arrayEnumerator.Current.As<");
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ContainsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 93 "CodeGenerator.Validate.Array.tt"
            this.Write(">().Validate(result.CreateChildContext(), level);\r\n\r\n            if (containsResu" +
                    "lt.IsValid)\r\n            {\r\n                result = result.WithLocalItemIndex(a" +
                    "rrayLength);\r\n                containsCount++;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 100 "CodeGenerator.Validate.Array.tt"
      }
        if (HasSingleItemsType)
        { 
            
            #line default
            #line hidden
            
            #line 103 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            if (level > ValidationLevel.Basic)\r\n            {\r\n                " +
                    "result = result.PushValidationLocationProperty(\"items\");\r\n            }\r\n\r\n     " +
                    "       result = arrayEnumerator.Current.As<");
            
            #line default
            #line hidden
            
            #line 109 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( SingleItemsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 109 "CodeGenerator.Validate.Array.tt"
            this.Write(@">().Validate(result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // items
            }

            result = result.WithLocalItemIndex(arrayLength);
");
            
            #line default
            #line hidden
            
            #line 121 "CodeGenerator.Validate.Array.tt"
      }
        else if (HasMultipleItemsType)
        { 
            
            #line default
            #line hidden
            
            #line 124 "CodeGenerator.Validate.Array.tt"
            this.Write("            switch (arrayLength)\r\n            {\r\n");
            
            #line default
            #line hidden
            
            #line 126 "CodeGenerator.Validate.Array.tt"
          int itemsIndex = 0;
            foreach (var item in Items)
            { 
            
            #line default
            #line hidden
            
            #line 129 "CodeGenerator.Validate.Array.tt"
            this.Write("                case ");
            
            #line default
            #line hidden
            
            #line 129 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( itemsIndex ));
            
            #line default
            #line hidden
            
            #line 129 "CodeGenerator.Validate.Array.tt"
            this.Write(":\r\n                    if (level > ValidationLevel.Basic)\r\n                    {\r" +
                    "\n                        result = result.PushValidationLocationProperty(\"items\")" +
                    ";\r\n                    }\r\n\r\n                    result = arrayEnumerator.Current" +
                    ".As<");
            
            #line default
            #line hidden
            
            #line 135 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( item ));
            
            #line default
            #line hidden
            
            #line 135 "CodeGenerator.Validate.Array.tt"
            this.Write(@">().Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    result = result.WithLocalItemIndex(arrayLength);

                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PopLocation(); // items
                    }

                    break;
");
            
            #line default
            #line hidden
            
            #line 149 "CodeGenerator.Validate.Array.tt"
              itemsIndex++;
            } 
            
            #line default
            #line hidden
            
            #line 151 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n                default:\r\n");
            
            #line default
            #line hidden
            
            #line 153 "CodeGenerator.Validate.Array.tt"
          if (!AllowsAdditionalItems)
            { 
            
            #line default
            #line hidden
            
            #line 155 "CodeGenerator.Validate.Array.tt"
            this.Write(@"                    if (level >= ValidationLevel.Detailed)
                    {
                        result = result.WithResult(isValid: false, $""9.3.1.2. additionalItems - Additional items are not permitted at index {arrayLength}."");
                    }
                    else if (level >= ValidationLevel.Basic)
                    {
                        result = result.WithResult(isValid: false, ""9.3.1.2. additionalItems - Additional items are not permitted."");
                    }
                    else if (level == ValidationLevel.Flag)
                    {
                        return result.WithResult(isValid: false);
                    }
");
            
            #line default
            #line hidden
            
            #line 167 "CodeGenerator.Validate.Array.tt"
          }
            if (AllowsAdditionalItems)
            {
                if (HasAdditionalItems)
                {
                    if (HasAdditionalItemsSchema)
                    { 
            
            #line default
            #line hidden
            
            #line 174 "CodeGenerator.Validate.Array.tt"
            this.Write("                    if (level > ValidationLevel.Basic)\r\n                    {\r\n  " +
                    "                      result = result.PushValidationLocationProperty(\"additional" +
                    "Items\");\r\n                    }\r\n\r\n                    result = arrayEnumerator." +
                    "Current.As<");
            
            #line default
            #line hidden
            
            #line 179 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( AdditionalItemsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 179 "CodeGenerator.Validate.Array.tt"
            this.Write(@">().Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PopLocation(); // additionalItems
                    }
");
            
            #line default
            #line hidden
            
            #line 189 "CodeGenerator.Validate.Array.tt"
                  } 
            
            #line default
            #line hidden
            
            #line 190 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n                    result = result.WithLocalItemIndex(arrayLength);\r\n");
            
            #line default
            #line hidden
            
            #line 192 "CodeGenerator.Validate.Array.tt"
              }
            } 
            
            #line default
            #line hidden
            
            #line 194 "CodeGenerator.Validate.Array.tt"
            this.Write("                    break;\r\n                }\r\n");
            
            #line default
            #line hidden
            
            #line 196 "CodeGenerator.Validate.Array.tt"
      } 
            
            #line default
            #line hidden
            
            #line 197 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            if (level > ValidationLevel.Basic)\r\n            {\r\n                " +
                    "result = result.PopLocation(); // array index\r\n            }\r\n\r\n            arra" +
                    "yLength++;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 205 "CodeGenerator.Validate.Array.tt"
  }
    if (HasMaxItems)
    { 
            
            #line default
            #line hidden
            
            #line 208 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        if (arrayLength > ");
            
            #line default
            #line hidden
            
            #line 209 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxItems ));
            
            #line default
            #line hidden
            
            #line 209 "CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.4.1. maxItems - {" +
                    "arrayLength} exceeds maximum number of items ");
            
            #line default
            #line hidden
            
            #line 213 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxItems ));
            
            #line default
            #line hidden
            
            #line 213 "CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.4.1. maxI" +
                    "tems - item count exceeds maximum number of items ");
            
            #line default
            #line hidden
            
            #line 217 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxItems ));
            
            #line default
            #line hidden
            
            #line 217 "CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 224 "CodeGenerator.Validate.Array.tt"
  }
    if (HasMinItems)
    { 
            
            #line default
            #line hidden
            
            #line 227 "CodeGenerator.Validate.Array.tt"
            this.Write("        if (arrayLength < ");
            
            #line default
            #line hidden
            
            #line 227 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinItems ));
            
            #line default
            #line hidden
            
            #line 227 "CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.4.2. minItems - {" +
                    "arrayLength} is less than the minimum number of items ");
            
            #line default
            #line hidden
            
            #line 231 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinItems ));
            
            #line default
            #line hidden
            
            #line 231 "CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.4.2. minI" +
                    "tems - item count is less than the minimum number of items ");
            
            #line default
            #line hidden
            
            #line 235 "CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinItems ));
            
            #line default
            #line hidden
            
            #line 235 "CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 243 "CodeGenerator.Validate.Array.tt"
  }
    if (HasContains)
    { 
            
            #line default
            #line hidden
            
            #line 246 "CodeGenerator.Validate.Array.tt"
            this.Write(@"        if (containsCount == 0)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $""10.3.1.3. contains - no items found matching the required schema."");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, ""10.3.1.3. contains - no items found matching the required schema."");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }
");
            
            #line default
            #line hidden
            
            #line 261 "CodeGenerator.Validate.Array.tt"
  } 
            
            #line default
            #line hidden
            
            #line 262 "CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 266 "CodeGenerator.Validate.Array.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateArrayBase {
        
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
