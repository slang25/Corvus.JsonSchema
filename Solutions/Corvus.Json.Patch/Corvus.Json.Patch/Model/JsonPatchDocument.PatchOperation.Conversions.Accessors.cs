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
    /// A single JSON Patch operation
    /// </para>
    /// </remarks>
    public readonly partial struct PatchOperation
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity AsAddEntity
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity"/>.
        /// </summary>
        public bool IsAddEntity
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsAddEntity(out Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity AsRemoveEntity
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity"/>.
        /// </summary>
        public bool IsRemoveEntity
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsRemoveEntity(out Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity AsReplaceEntity
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity"/>.
        /// </summary>
        public bool IsReplaceEntity
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsReplaceEntity(out Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Move"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.Move AsMove
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.Move)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Move"/>.
        /// </summary>
        public bool IsMove
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.Move)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Move"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsMove(out Corvus.Json.Patch.Model.JsonPatchDocument.Move result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.Move)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Copy"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.Copy AsCopy
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.Copy)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Copy"/>.
        /// </summary>
        public bool IsCopy
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.Copy)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Copy"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsCopy(out Corvus.Json.Patch.Model.JsonPatchDocument.Copy result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.Copy)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Test"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.Test AsTest
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.Test)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Test"/>.
        /// </summary>
        public bool IsTest
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.Test)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.Test"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsTest(out Corvus.Json.Patch.Model.JsonPatchDocument.Test result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.Test)this;
            return result.IsValid();
        }
    }
}