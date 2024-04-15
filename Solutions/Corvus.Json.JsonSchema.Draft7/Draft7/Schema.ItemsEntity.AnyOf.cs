//------------------------------------------------------------------------------
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

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Schema
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct ItemsEntity
    {
        /// <summary>
        /// Matches the value against each of the any of values, and returns the result of calling the provided match function for the first match found.
        /// </summary>
        /// <param name = "context">The context to pass to the match function.</param>
        /// <param name = "match0">The function to call if the value matches the <see cref = "Corvus.Json.JsonSchema.Draft7.Schema"/> type.</param>
        /// <param name = "match1">The function to call if the value matches the <see cref = "Corvus.Json.JsonSchema.Draft7.Schema.SchemaArray"/> type.</param>
        /// <param name = "defaultMatch">The fallback match.</param>
        public TOut Match<TIn, TOut>(in TIn context, Matcher<Corvus.Json.JsonSchema.Draft7.Schema, TIn, TOut> match0, Matcher<Corvus.Json.JsonSchema.Draft7.Schema.SchemaArray, TIn, TOut> match1, Matcher<ItemsEntity, TIn, TOut> defaultMatch)
        {
            var anyOf0 = this.As<Corvus.Json.JsonSchema.Draft7.Schema>();
            if (anyOf0.IsValid())
            {
                return match0(anyOf0, context);
            }

            var anyOf1 = this.As<Corvus.Json.JsonSchema.Draft7.Schema.SchemaArray>();
            if (anyOf1.IsValid())
            {
                return match1(anyOf1, context);
            }

            return defaultMatch(this, context);
        }

        /// <summary>
        /// Matches the value against each of the any of values, and returns the result of calling the provided match function for the first match found.
        /// </summary>
        /// <param name = "match0">The function to call if the value matches the <see cref = "Corvus.Json.JsonSchema.Draft7.Schema"/> type.</param>
        /// <param name = "match1">The function to call if the value matches the <see cref = "Corvus.Json.JsonSchema.Draft7.Schema.SchemaArray"/> type.</param>
        /// <param name = "defaultMatch">The fallback match.</param>
        public TOut Match<TOut>(Matcher<Corvus.Json.JsonSchema.Draft7.Schema, TOut> match0, Matcher<Corvus.Json.JsonSchema.Draft7.Schema.SchemaArray, TOut> match1, Matcher<ItemsEntity, TOut> defaultMatch)
        {
            var anyOf0 = this.As<Corvus.Json.JsonSchema.Draft7.Schema>();
            if (anyOf0.IsValid())
            {
                return match0(anyOf0);
            }

            var anyOf1 = this.As<Corvus.Json.JsonSchema.Draft7.Schema.SchemaArray>();
            if (anyOf1.IsValid())
            {
                return match1(anyOf1);
            }

            return defaultMatch(this);
        }
    }
}