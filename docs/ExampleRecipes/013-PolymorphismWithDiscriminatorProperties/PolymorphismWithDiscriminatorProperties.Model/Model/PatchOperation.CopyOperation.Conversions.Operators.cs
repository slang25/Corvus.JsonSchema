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
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace JsonSchemaSample.Api;
public readonly partial struct PatchOperation
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Copy operation. "from" is a JSON Pointer.
    /// </para>
    /// </remarks>
    public readonly partial struct CopyOperation
    {
        /// <summary>
        /// Conversion to <see cref = "JsonSchemaSample.Api.PatchOperation.PatchOperationCommon"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator JsonSchemaSample.Api.PatchOperation.PatchOperationCommon(CopyOperation value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            return JsonSchemaSample.Api.PatchOperation.PatchOperationCommon.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "JsonSchemaSample.Api.PatchOperation.PatchOperationCommon"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static explicit operator CopyOperation(JsonSchemaSample.Api.PatchOperation.PatchOperationCommon value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new(value.AsPropertyBacking()),
                _ => Undefined
            };
        }
    }
}