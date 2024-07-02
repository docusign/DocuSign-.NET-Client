/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// This response object is returned after you upload a chunked upload.
    /// </summary>
    [DataContract]
    public partial class ChunkedUploadResponse :  IEquatable<ChunkedUploadResponse>, IValidatableObject
    {
        public ChunkedUploadResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedUploadResponse" /> class.
        /// </summary>
        /// <param name="Checksum">Checksum.</param>
        /// <param name="ChunkedUploadId">ChunkedUploadId.</param>
        /// <param name="ChunkedUploadParts">ChunkedUploadParts.</param>
        /// <param name="ChunkedUploadUri">ChunkedUploadUri.</param>
        /// <param name="Committed">Committed.</param>
        /// <param name="ExpirationDateTime">ExpirationDateTime.</param>
        /// <param name="MaxChunkedUploadParts">MaxChunkedUploadParts.</param>
        /// <param name="MaxTotalSize">MaxTotalSize.</param>
        /// <param name="TotalSize">TotalSize.</param>
        public ChunkedUploadResponse(string Checksum = default(string), string ChunkedUploadId = default(string), List<ChunkedUploadPart> ChunkedUploadParts = default(List<ChunkedUploadPart>), string ChunkedUploadUri = default(string), string Committed = default(string), string ExpirationDateTime = default(string), string MaxChunkedUploadParts = default(string), string MaxTotalSize = default(string), string TotalSize = default(string))
        {
            this.Checksum = Checksum;
            this.ChunkedUploadId = ChunkedUploadId;
            this.ChunkedUploadParts = ChunkedUploadParts;
            this.ChunkedUploadUri = ChunkedUploadUri;
            this.Committed = Committed;
            this.ExpirationDateTime = ExpirationDateTime;
            this.MaxChunkedUploadParts = MaxChunkedUploadParts;
            this.MaxTotalSize = MaxTotalSize;
            this.TotalSize = TotalSize;
        }
        
        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }
        /// <summary>
        /// Gets or Sets ChunkedUploadId
        /// </summary>
        [DataMember(Name="chunkedUploadId", EmitDefaultValue=false)]
        public string ChunkedUploadId { get; set; }
        /// <summary>
        /// Gets or Sets ChunkedUploadParts
        /// </summary>
        [DataMember(Name="chunkedUploadParts", EmitDefaultValue=false)]
        public List<ChunkedUploadPart> ChunkedUploadParts { get; set; }
        /// <summary>
        /// Gets or Sets ChunkedUploadUri
        /// </summary>
        [DataMember(Name="chunkedUploadUri", EmitDefaultValue=false)]
        public string ChunkedUploadUri { get; set; }
        /// <summary>
        /// Gets or Sets Committed
        /// </summary>
        [DataMember(Name="committed", EmitDefaultValue=false)]
        public string Committed { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationDateTime
        /// </summary>
        [DataMember(Name="expirationDateTime", EmitDefaultValue=false)]
        public string ExpirationDateTime { get; set; }
        /// <summary>
        /// Gets or Sets MaxChunkedUploadParts
        /// </summary>
        [DataMember(Name="maxChunkedUploadParts", EmitDefaultValue=false)]
        public string MaxChunkedUploadParts { get; set; }
        /// <summary>
        /// Gets or Sets MaxTotalSize
        /// </summary>
        [DataMember(Name="maxTotalSize", EmitDefaultValue=false)]
        public string MaxTotalSize { get; set; }
        /// <summary>
        /// Gets or Sets TotalSize
        /// </summary>
        [DataMember(Name="totalSize", EmitDefaultValue=false)]
        public string TotalSize { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChunkedUploadResponse {\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  ChunkedUploadId: ").Append(ChunkedUploadId).Append("\n");
            sb.Append("  ChunkedUploadParts: ").Append(ChunkedUploadParts).Append("\n");
            sb.Append("  ChunkedUploadUri: ").Append(ChunkedUploadUri).Append("\n");
            sb.Append("  Committed: ").Append(Committed).Append("\n");
            sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
            sb.Append("  MaxChunkedUploadParts: ").Append(MaxChunkedUploadParts).Append("\n");
            sb.Append("  MaxTotalSize: ").Append(MaxTotalSize).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ChunkedUploadResponse);
        }

        /// <summary>
        /// Returns true if ChunkedUploadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChunkedUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChunkedUploadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Checksum == other.Checksum ||
                    this.Checksum != null &&
                    this.Checksum.Equals(other.Checksum)
                ) && 
                (
                    this.ChunkedUploadId == other.ChunkedUploadId ||
                    this.ChunkedUploadId != null &&
                    this.ChunkedUploadId.Equals(other.ChunkedUploadId)
                ) && 
                (
                    this.ChunkedUploadParts == other.ChunkedUploadParts ||
                    this.ChunkedUploadParts != null &&
                    this.ChunkedUploadParts.SequenceEqual(other.ChunkedUploadParts)
                ) && 
                (
                    this.ChunkedUploadUri == other.ChunkedUploadUri ||
                    this.ChunkedUploadUri != null &&
                    this.ChunkedUploadUri.Equals(other.ChunkedUploadUri)
                ) && 
                (
                    this.Committed == other.Committed ||
                    this.Committed != null &&
                    this.Committed.Equals(other.Committed)
                ) && 
                (
                    this.ExpirationDateTime == other.ExpirationDateTime ||
                    this.ExpirationDateTime != null &&
                    this.ExpirationDateTime.Equals(other.ExpirationDateTime)
                ) && 
                (
                    this.MaxChunkedUploadParts == other.MaxChunkedUploadParts ||
                    this.MaxChunkedUploadParts != null &&
                    this.MaxChunkedUploadParts.Equals(other.MaxChunkedUploadParts)
                ) && 
                (
                    this.MaxTotalSize == other.MaxTotalSize ||
                    this.MaxTotalSize != null &&
                    this.MaxTotalSize.Equals(other.MaxTotalSize)
                ) && 
                (
                    this.TotalSize == other.TotalSize ||
                    this.TotalSize != null &&
                    this.TotalSize.Equals(other.TotalSize)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Checksum != null)
                    hash = hash * 59 + this.Checksum.GetHashCode();
                if (this.ChunkedUploadId != null)
                    hash = hash * 59 + this.ChunkedUploadId.GetHashCode();
                if (this.ChunkedUploadParts != null)
                    hash = hash * 59 + this.ChunkedUploadParts.GetHashCode();
                if (this.ChunkedUploadUri != null)
                    hash = hash * 59 + this.ChunkedUploadUri.GetHashCode();
                if (this.Committed != null)
                    hash = hash * 59 + this.Committed.GetHashCode();
                if (this.ExpirationDateTime != null)
                    hash = hash * 59 + this.ExpirationDateTime.GetHashCode();
                if (this.MaxChunkedUploadParts != null)
                    hash = hash * 59 + this.MaxChunkedUploadParts.GetHashCode();
                if (this.MaxTotalSize != null)
                    hash = hash * 59 + this.MaxTotalSize.GetHashCode();
                if (this.TotalSize != null)
                    hash = hash * 59 + this.TotalSize.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
