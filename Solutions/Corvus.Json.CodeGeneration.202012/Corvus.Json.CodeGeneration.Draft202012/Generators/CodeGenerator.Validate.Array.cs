//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft202012 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateArray : CodeGeneratorValidateArrayBase {
        
        
        #line 364 "./Templates/CodeGenerator.Validate.Array.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasPrefixItems;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "./Templates/CodeGenerator.Validate.Array.tt"

    // This is only emitted if (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasPrefixItems) is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.Array should not be emitted if (HasItems || HasContains || HasUniqueItems || HasMaxItems || HasMinItems || HasUnevaluatedItems || HasPrefixItems) is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "./Templates/CodeGenerator.Validate.Array.tt"
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
            
            #line 24 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 24 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 26 "./Templates/CodeGenerator.Validate.Array.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 27 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 30 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 30 "./Templates/CodeGenerator.Validate.Array.tt"
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
            
            #line 40 "./Templates/CodeGenerator.Validate.Array.tt"
  if (HasItems || HasContains || HasUniqueItems || HasUnevaluatedItems || HasPrefixItems)
    { 
            
            #line default
            #line hidden
            
            #line 42 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        int arrayLength = 0;\r\n");
            
            #line default
            #line hidden
            
            #line 44 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    else
    { 
            
            #line default
            #line hidden
            
            #line 47 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("        int arrayLength = this.GetArrayLength();\r\n");
            
            #line default
            #line hidden
            
            #line 48 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    if (HasContains)
    { 
            
            #line default
            #line hidden
            
            #line 51 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("        int containsCount = 0;\r\n");
            
            #line default
            #line hidden
            
            #line 52 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    if (HasItems || HasContains || HasUniqueItems || HasUnevaluatedItems || HasPrefixItems)
    { 
            
            #line default
            #line hidden
            
            #line 55 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 56 "./Templates/CodeGenerator.Validate.Array.tt"
  if (!CanEnumerateAsSpecificType)
    { 
            
            #line default
            #line hidden
            
            #line 58 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        using JsonArrayEnumerator arrayEnumerator = this.EnumerateArray();\r\n");
            
            #line default
            #line hidden
            
            #line 60 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    else
    { 
            
            #line default
            #line hidden
            
            #line 63 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        using JsonArrayEnumerator<");
            
            #line default
            #line hidden
            
            #line 64 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( SingleItemsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 64 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("> arrayEnumerator = this.EnumerateArray();\r\n");
            
            #line default
            #line hidden
            
            #line 65 "./Templates/CodeGenerator.Validate.Array.tt"
  } 
            
            #line default
            #line hidden
            
            #line 66 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        while (arrayEnumerator.MoveNext())\r\n        {\r\n            if (level > " +
                    "ValidationLevel.Basic)\r\n            {\r\n                result = result.PushDocum" +
                    "entArrayIndex(arrayLength);\r\n            }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 74 "./Templates/CodeGenerator.Validate.Array.tt"
      if (HasUniqueItems)
        { 
            
            #line default
            #line hidden
            
            #line 76 "./Templates/CodeGenerator.Validate.Array.tt"
  if (!CanEnumerateAsSpecificType)
    { 
            
            #line default
            #line hidden
            
            #line 78 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            using JsonArrayEnumerator innerEnumerator = this.EnumerateArray();\r" +
                    "\n");
            
            #line default
            #line hidden
            
            #line 80 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    else
    { 
            
            #line default
            #line hidden
            
            #line 83 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            using JsonArrayEnumerator<");
            
            #line default
            #line hidden
            
            #line 84 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( SingleItemsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 84 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("> innerEnumerator = this.EnumerateArray();\r\n");
            
            #line default
            #line hidden
            
            #line 85 "./Templates/CodeGenerator.Validate.Array.tt"
  } 
            
            #line default
            #line hidden
            
            #line 86 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@"            int innerIndex = -1;
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
            
            #line 110 "./Templates/CodeGenerator.Validate.Array.tt"
      }
        if (HasContains)
        { 
            
            #line default
            #line hidden
            
            #line 113 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("            ValidationContext containsResult = arrayEnumerator.Current.As<");
            
            #line default
            #line hidden
            
            #line 113 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ContainsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 113 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(">().Validate(result.CreateChildContext(), level);\r\n            if (containsResult" +
                    ".IsValid)\r\n            {\r\n                result = result.WithLocalItemIndex(arr" +
                    "ayLength);\r\n                containsCount++;\r\n");
            
            #line default
            #line hidden
            
            #line 118 "./Templates/CodeGenerator.Validate.Array.tt"
          if (HasMaxContains && !HasUnevaluatedItems)
            { 
            
            #line default
            #line hidden
            
            #line 120 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("                if (level == ValidationLevel.Flag && containsCount > ");
            
            #line default
            #line hidden
            
            #line 120 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(  MaxContains ));
            
            #line default
            #line hidden
            
            #line 120 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n                {\r\n                    return result.WithResult(isValid: false" +
                    ");\r\n                }\r\n");
            
            #line default
            #line hidden
            
            #line 124 "./Templates/CodeGenerator.Validate.Array.tt"
          } 
            
            #line default
            #line hidden
            
            #line 125 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("            }\r\n");
            
            #line default
            #line hidden
            
            #line 126 "./Templates/CodeGenerator.Validate.Array.tt"
      }
        if (HasSingleItemsType && !HasPrefixItems)
        { 
            
            #line default
            #line hidden
            
            #line 129 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@"
            if (level > ValidationLevel.Basic)
            {
                result = result.PushValidationLocationProperty(""items"");
            }

            result = arrayEnumerator.Current.Validate(result, level);
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
            
            #line 147 "./Templates/CodeGenerator.Validate.Array.tt"
      }
        else if (HasPrefixItems)
        {
            int itemsIndex = 0; 
            
            #line default
            #line hidden
            
            #line 151 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            switch (arrayLength)\r\n            {\r\n");
            
            #line default
            #line hidden
            
            #line 154 "./Templates/CodeGenerator.Validate.Array.tt"
          if (HasPrefixItems)
            {
                foreach (var prefixItem in PrefixItems)
                { 
            
            #line default
            #line hidden
            
            #line 158 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("                case ");
            
            #line default
            #line hidden
            
            #line 158 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( itemsIndex ));
            
            #line default
            #line hidden
            
            #line 158 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(":\r\n                    if (level > ValidationLevel.Basic)\r\n                    {\r" +
                    "\n                        result = result.PushValidationLocationProperty(\"prefixI" +
                    "tems\");\r\n                    }\r\n\r\n                    result = arrayEnumerator.C" +
                    "urrent.As<");
            
            #line default
            #line hidden
            
            #line 164 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( prefixItem ));
            
            #line default
            #line hidden
            
            #line 164 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@">().Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PopLocation(); // prefixItems
                    }

                    result = result.WithLocalItemIndex(arrayLength);
                    break;
");
            
            #line default
            #line hidden
            
            #line 177 "./Templates/CodeGenerator.Validate.Array.tt"
                  itemsIndex++;
                }
            }
            
            #line default
            #line hidden
            
            #line 180 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("                default:\r\n");
            
            #line default
            #line hidden
            
            #line 181 "./Templates/CodeGenerator.Validate.Array.tt"
          if (HasSingleItemsType)
            { 
            
            #line default
            #line hidden
            
            #line 183 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@"                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PushValidationLocationProperty(""items"");
                    }

                    result = arrayEnumerator.Current.Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    if (level > ValidationLevel.Basic)
                    {
                        result = result.PopLocation(); // prefixItems
                    }

                    result = result.WithLocalItemIndex(arrayLength);
");
            
            #line default
            #line hidden
            
            #line 200 "./Templates/CodeGenerator.Validate.Array.tt"
          }
            else if (HasUnevaluatedItems)
            { 
            
            #line default
            #line hidden
            
            #line 203 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@"                    if (!result.HasEvaluatedLocalOrAppliedItemIndex(arrayLength))
                    {
                        if (level > ValidationLevel.Basic)
                        {
                            result = result.PushValidationLocationProperty(""unevaluatedItems"");
                        }

                        result = arrayEnumerator.Current.As<");
            
            #line default
            #line hidden
            
            #line 210 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( UnevaluatedItemsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 210 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@">().Validate(result, level);

                        if (level == ValidationLevel.Flag && !result.IsValid)
                        {
                            return result;
                        }

                        if (level > ValidationLevel.Basic)
                        {
                            result = result.PopLocation(); // unevaluatedItems
                        }

                        result = result.WithLocalItemIndex(arrayLength);
                    }
");
            
            #line default
            #line hidden
            
            #line 224 "./Templates/CodeGenerator.Validate.Array.tt"
          } 
            
            #line default
            #line hidden
            
            #line 225 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("                    break;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 227 "./Templates/CodeGenerator.Validate.Array.tt"
      }
        else if (HasUnevaluatedItems)
        { 
            
            #line default
            #line hidden
            
            #line 230 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@"
            if (!result.HasEvaluatedLocalOrAppliedItemIndex(arrayLength))
            {
                if (level > ValidationLevel.Basic)
                {
                    result = result.PushValidationLocationProperty(""unevaluatedItems"");
                }

                result = arrayEnumerator.Current.As<");
            
            #line default
            #line hidden
            
            #line 238 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( UnevaluatedItemsDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 238 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@">().Validate(result, level);

                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // unevaluatedItems
                }

                result = result.WithLocalItemIndex(arrayLength);
            }
");
            
            #line default
            #line hidden
            
            #line 252 "./Templates/CodeGenerator.Validate.Array.tt"
      } 
            
            #line default
            #line hidden
            
            #line 253 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n            if (level > ValidationLevel.Basic)\r\n            {\r\n                " +
                    "result = result.PopLocation(); // array index\r\n            }\r\n\r\n            arra" +
                    "yLength++;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 261 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    if (HasMaxItems)
    { 
            
            #line default
            #line hidden
            
            #line 264 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        if (arrayLength > ");
            
            #line default
            #line hidden
            
            #line 265 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxItems ));
            
            #line default
            #line hidden
            
            #line 265 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.4.1. maxItems - {" +
                    "arrayLength} exceeds maximum number of items ");
            
            #line default
            #line hidden
            
            #line 269 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxItems ));
            
            #line default
            #line hidden
            
            #line 269 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.4.1. maxI" +
                    "tems - item count exceeds maximum number of items ");
            
            #line default
            #line hidden
            
            #line 273 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxItems ));
            
            #line default
            #line hidden
            
            #line 273 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 280 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    if (HasMinItems)
    { 
            
            #line default
            #line hidden
            
            #line 283 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        if (arrayLength < ");
            
            #line default
            #line hidden
            
            #line 284 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinItems ));
            
            #line default
            #line hidden
            
            #line 284 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.4.2. minItems - {" +
                    "arrayLength} is less than the minimum number of items ");
            
            #line default
            #line hidden
            
            #line 288 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinItems ));
            
            #line default
            #line hidden
            
            #line 288 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.4.2. minI" +
                    "tems - item count is less than the minimum number of items ");
            
            #line default
            #line hidden
            
            #line 292 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinItems ));
            
            #line default
            #line hidden
            
            #line 292 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 299 "./Templates/CodeGenerator.Validate.Array.tt"
  }
    if (HasContains)
    {
        if (HasMaxContains)
        { 
            
            #line default
            #line hidden
            
            #line 304 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        if (containsCount > ");
            
            #line default
            #line hidden
            
            #line 305 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MaxContains ));
            
            #line default
            #line hidden
            
            #line 305 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.4.4. maxContains " +
                    "- {containsCount} exceeds maximum number of matching items ");
            
            #line default
            #line hidden
            
            #line 309 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(     MaxContains ));
            
            #line default
            #line hidden
            
            #line 309 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.4.4. maxC" +
                    "ontains - item count exceeds maximum number of matching items ");
            
            #line default
            #line hidden
            
            #line 313 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(     MaxContains ));
            
            #line default
            #line hidden
            
            #line 313 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 320 "./Templates/CodeGenerator.Validate.Array.tt"
      }
        if (HasMinContains)
        { 
            
            #line default
            #line hidden
            
            #line 323 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("\r\n        if (containsCount < ");
            
            #line default
            #line hidden
            
            #line 324 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MinContains ));
            
            #line default
            #line hidden
            
            #line 324 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(")\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false, $\"6.4.5. minContains " +
                    "- {containsCount} is less than minimum number of matching items ");
            
            #line default
            #line hidden
            
            #line 328 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(     MinContains ));
            
            #line default
            #line hidden
            
            #line 328 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n      " +
                    "      {\r\n                result = result.WithResult(isValid: false, \"6.4.5. minC" +
                    "ontains - item count is less than minimum number of matching items ");
            
            #line default
            #line hidden
            
            #line 332 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(     MinContains ));
            
            #line default
            #line hidden
            
            #line 332 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(".\");\r\n            }\r\n            else\r\n            {\r\n                return resu" +
                    "lt.WithResult(isValid: false);\r\n            }\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 339 "./Templates/CodeGenerator.Validate.Array.tt"
      }
        else
        { 
            
            #line default
            #line hidden
            
            #line 342 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write(@"
        if (containsCount == 0)
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
            
            #line 358 "./Templates/CodeGenerator.Validate.Array.tt"
      }
    } 
            
            #line default
            #line hidden
            
            #line 360 "./Templates/CodeGenerator.Validate.Array.tt"
            this.Write("        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 363 "./Templates/CodeGenerator.Validate.Array.tt"
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
