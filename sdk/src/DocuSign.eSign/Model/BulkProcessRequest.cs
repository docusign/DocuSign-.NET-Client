/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// BulkProcessRequest
    /// </summary>
    [DataContract]
    public partial class BulkProcessRequest :  IEquatable<BulkProcessRequest>, IValidatableObject
    {
        public BulkProcessRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkProcessRequest" /> class.
        /// </summary>
        /// <param name="BatchName">BatchName.</param>
        /// <param name="EnvelopeOrTemplateId">EnvelopeOrTemplateId.</param>
        public BulkProcessRequest(string BatchName = default(string), string EnvelopeOrTemplateId = default(string))
        {
            this.BatchName = BatchName;
            this.EnvelopeOrTemplateId = EnvelopeOrTemplateId;
        }
        
        /// <summary>
        /// Gets or Sets BatchName
        /// </summary>
        [DataMember(Name="batchName", EmitDefaultValue=false)]
        public string BatchName { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeOrTemplateId
        /// </summary>
        [DataMember(Name="envelopeOrTemplateId", EmitDefaultValue=false)]
        public string EnvelopeOrTemplateId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkProcessRequest {\n");
            sb.Append("  BatchName: ").Append(BatchName).Append("\n");
            sb.Append("  EnvelopeOrTemplateId: ").Append(EnvelopeOrTemplateId).Append("\n");
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
            return this.Equals(obj as BulkProcessRequest);
        }

        /// <summary>
        /// Returns true if BulkProcessRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkProcessRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkProcessRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BatchName == other.BatchName ||
                    this.BatchName != null &&
                    this.BatchName.Equals(other.BatchName)
                ) && 
                (
                    this.EnvelopeOrTemplateId == other.EnvelopeOrTemplateId ||
                    this.EnvelopeOrTemplateId != null &&
                    this.EnvelopeOrTemplateId.Equals(other.EnvelopeOrTemplateId)
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
                if (this.BatchName != null)
                    hash = hash * 59 + this.BatchName.GetHashCode();
                if (this.EnvelopeOrTemplateId != null)
                    hash = hash * 59 + this.EnvelopeOrTemplateId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
