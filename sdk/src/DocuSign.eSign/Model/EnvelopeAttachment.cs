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
    /// EnvelopeAttachment
    /// </summary>
    [DataContract]
    public partial class EnvelopeAttachment :  IEquatable<EnvelopeAttachment>, IValidatableObject
    {
        public EnvelopeAttachment()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeAttachment" /> class.
        /// </summary>
        /// <param name="AccessControl">AccessControl.</param>
        /// <param name="AttachmentId">AttachmentId.</param>
        /// <param name="AttachmentType">AttachmentType.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Label">Label.</param>
        /// <param name="Name">Name.</param>
        public EnvelopeAttachment(string AccessControl = default(string), string AttachmentId = default(string), string AttachmentType = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string Label = default(string), string Name = default(string))
        {
            this.AccessControl = AccessControl;
            this.AttachmentId = AttachmentId;
            this.AttachmentType = AttachmentType;
            this.ErrorDetails = ErrorDetails;
            this.Label = Label;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets AccessControl
        /// </summary>
        [DataMember(Name="accessControl", EmitDefaultValue=false)]
        public string AccessControl { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentType
        /// </summary>
        [DataMember(Name="attachmentType", EmitDefaultValue=false)]
        public string AttachmentType { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeAttachment {\n");
            sb.Append("  AccessControl: ").Append(AccessControl).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as EnvelopeAttachment);
        }

        /// <summary>
        /// Returns true if EnvelopeAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeAttachment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessControl == other.AccessControl ||
                    this.AccessControl != null &&
                    this.AccessControl.Equals(other.AccessControl)
                ) && 
                (
                    this.AttachmentId == other.AttachmentId ||
                    this.AttachmentId != null &&
                    this.AttachmentId.Equals(other.AttachmentId)
                ) && 
                (
                    this.AttachmentType == other.AttachmentType ||
                    this.AttachmentType != null &&
                    this.AttachmentType.Equals(other.AttachmentType)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.AccessControl != null)
                    hash = hash * 59 + this.AccessControl.GetHashCode();
                if (this.AttachmentId != null)
                    hash = hash * 59 + this.AttachmentId.GetHashCode();
                if (this.AttachmentType != null)
                    hash = hash * 59 + this.AttachmentType.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
