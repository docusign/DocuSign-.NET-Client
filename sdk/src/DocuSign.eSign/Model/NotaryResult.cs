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
    /// Describes a single notary jurisdiction.
    /// </summary>
    [DataContract]
    public partial class NotaryResult :  IEquatable<NotaryResult>, IValidatableObject
    {
        public NotaryResult()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotaryResult" /> class.
        /// </summary>
        /// <param name="Jurisdictions">Jurisdictions.</param>
        /// <param name="Notary">Notary.</param>
        public NotaryResult(List<Jurisdiction> Jurisdictions = default(List<Jurisdiction>), Notary Notary = default(Notary))
        {
            this.Jurisdictions = Jurisdictions;
            this.Notary = Notary;
        }
        
        /// <summary>
        /// Gets or Sets Jurisdictions
        /// </summary>
        [DataMember(Name="jurisdictions", EmitDefaultValue=false)]
        public List<Jurisdiction> Jurisdictions { get; set; }
        /// <summary>
        /// Gets or Sets Notary
        /// </summary>
        [DataMember(Name="notary", EmitDefaultValue=false)]
        public Notary Notary { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotaryResult {\n");
            sb.Append("  Jurisdictions: ").Append(Jurisdictions).Append("\n");
            sb.Append("  Notary: ").Append(Notary).Append("\n");
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
            return this.Equals(obj as NotaryResult);
        }

        /// <summary>
        /// Returns true if NotaryResult instances are equal
        /// </summary>
        /// <param name="other">Instance of NotaryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotaryResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Jurisdictions == other.Jurisdictions ||
                    this.Jurisdictions != null &&
                    this.Jurisdictions.SequenceEqual(other.Jurisdictions)
                ) && 
                (
                    this.Notary == other.Notary ||
                    this.Notary != null &&
                    this.Notary.Equals(other.Notary)
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
                if (this.Jurisdictions != null)
                    hash = hash * 59 + this.Jurisdictions.GetHashCode();
                if (this.Notary != null)
                    hash = hash * 59 + this.Notary.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
