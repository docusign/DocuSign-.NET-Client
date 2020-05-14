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
    /// Allows the sender to pre-specify the signature name, signature initials and signature font used in the signature stamp for the recipient.  Used only with recipient types In Person Signers and Signers.
    /// </summary>
    [DataContract]
    public partial class RecipientSignatureInformation :  IEquatable<RecipientSignatureInformation>, IValidatableObject
    {
        public RecipientSignatureInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientSignatureInformation" /> class.
        /// </summary>
        /// <param name="FontStyle">FontStyle.</param>
        /// <param name="SignatureInitials">SignatureInitials.</param>
        /// <param name="SignatureName">Specifies the user signature name..</param>
        public RecipientSignatureInformation(string FontStyle = default(string), string SignatureInitials = default(string), string SignatureName = default(string))
        {
            this.FontStyle = FontStyle;
            this.SignatureInitials = SignatureInitials;
            this.SignatureName = SignatureName;
        }
        
        /// <summary>
        /// Gets or Sets FontStyle
        /// </summary>
        [DataMember(Name="fontStyle", EmitDefaultValue=false)]
        public string FontStyle { get; set; }
        /// <summary>
        /// Gets or Sets SignatureInitials
        /// </summary>
        [DataMember(Name="signatureInitials", EmitDefaultValue=false)]
        public string SignatureInitials { get; set; }
        /// <summary>
        /// Specifies the user signature name.
        /// </summary>
        /// <value>Specifies the user signature name.</value>
        [DataMember(Name="signatureName", EmitDefaultValue=false)]
        public string SignatureName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSignatureInformation {\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            sb.Append("  SignatureInitials: ").Append(SignatureInitials).Append("\n");
            sb.Append("  SignatureName: ").Append(SignatureName).Append("\n");
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
            return this.Equals(obj as RecipientSignatureInformation);
        }

        /// <summary>
        /// Returns true if RecipientSignatureInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSignatureInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSignatureInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FontStyle == other.FontStyle ||
                    this.FontStyle != null &&
                    this.FontStyle.Equals(other.FontStyle)
                ) && 
                (
                    this.SignatureInitials == other.SignatureInitials ||
                    this.SignatureInitials != null &&
                    this.SignatureInitials.Equals(other.SignatureInitials)
                ) && 
                (
                    this.SignatureName == other.SignatureName ||
                    this.SignatureName != null &&
                    this.SignatureName.Equals(other.SignatureName)
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
                if (this.FontStyle != null)
                    hash = hash * 59 + this.FontStyle.GetHashCode();
                if (this.SignatureInitials != null)
                    hash = hash * 59 + this.SignatureInitials.GetHashCode();
                if (this.SignatureName != null)
                    hash = hash * 59 + this.SignatureName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
