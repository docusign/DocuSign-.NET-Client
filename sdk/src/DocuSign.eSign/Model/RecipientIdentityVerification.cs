/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
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
    /// RecipientIdentityVerification
    /// </summary>
    [DataContract]
    public partial class RecipientIdentityVerification :  IEquatable<RecipientIdentityVerification>, IValidatableObject
    {
        public RecipientIdentityVerification()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientIdentityVerification" /> class.
        /// </summary>
        /// <param name="InputOptions">InputOptions.</param>
        /// <param name="WorkflowId">WorkflowId.</param>
        public RecipientIdentityVerification(List<RecipientIdentityInputOption> InputOptions = default(List<RecipientIdentityInputOption>), string WorkflowId = default(string))
        {
            this.InputOptions = InputOptions;
            this.WorkflowId = WorkflowId;
        }
        
        /// <summary>
        /// Gets or Sets InputOptions
        /// </summary>
        [DataMember(Name="inputOptions", EmitDefaultValue=false)]
        public List<RecipientIdentityInputOption> InputOptions { get; set; }
        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public string WorkflowId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientIdentityVerification {\n");
            sb.Append("  InputOptions: ").Append(InputOptions).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
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
            return this.Equals(obj as RecipientIdentityVerification);
        }

        /// <summary>
        /// Returns true if RecipientIdentityVerification instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientIdentityVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientIdentityVerification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InputOptions == other.InputOptions ||
                    this.InputOptions != null &&
                    this.InputOptions.SequenceEqual(other.InputOptions)
                ) && 
                (
                    this.WorkflowId == other.WorkflowId ||
                    this.WorkflowId != null &&
                    this.WorkflowId.Equals(other.WorkflowId)
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
                if (this.InputOptions != null)
                    hash = hash * 59 + this.InputOptions.GetHashCode();
                if (this.WorkflowId != null)
                    hash = hash * 59 + this.WorkflowId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
