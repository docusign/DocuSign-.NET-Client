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
    /// TemplateDocumentsResult
    /// </summary>
    [DataContract]
    public partial class TemplateDocumentsResult :  IEquatable<TemplateDocumentsResult>, IValidatableObject
    {
        public TemplateDocumentsResult()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDocumentsResult" /> class.
        /// </summary>
        /// <param name="TemplateDocuments">TemplateDocuments.</param>
        /// <param name="TemplateId">The unique identifier of the template. If this is not provided, DocuSign will generate a value. .</param>
        public TemplateDocumentsResult(List<EnvelopeDocument> TemplateDocuments = default(List<EnvelopeDocument>), string TemplateId = default(string))
        {
            this.TemplateDocuments = TemplateDocuments;
            this.TemplateId = TemplateId;
        }
        
        /// <summary>
        /// Gets or Sets TemplateDocuments
        /// </summary>
        [DataMember(Name="templateDocuments", EmitDefaultValue=false)]
        public List<EnvelopeDocument> TemplateDocuments { get; set; }
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value. 
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value. </value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateDocumentsResult {\n");
            sb.Append("  TemplateDocuments: ").Append(TemplateDocuments).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(obj as TemplateDocumentsResult);
        }

        /// <summary>
        /// Returns true if TemplateDocumentsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateDocumentsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateDocumentsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TemplateDocuments == other.TemplateDocuments ||
                    this.TemplateDocuments != null &&
                    this.TemplateDocuments.SequenceEqual(other.TemplateDocuments)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
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
                if (this.TemplateDocuments != null)
                    hash = hash * 59 + this.TemplateDocuments.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
