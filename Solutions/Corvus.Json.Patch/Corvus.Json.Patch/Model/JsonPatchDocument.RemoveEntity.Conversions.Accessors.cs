//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using Corvus.Json;

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Remove operation. Only a path is specified.
    /// </para>
    /// </remarks>
    public readonly partial struct RemoveEntity
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon AsPatchOperationCommon
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon"/>.
        /// </summary>
        public bool IsPatchOperationCommon
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsPatchOperationCommon(out Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon)this;
            return result.IsValid();
        }
    }
}