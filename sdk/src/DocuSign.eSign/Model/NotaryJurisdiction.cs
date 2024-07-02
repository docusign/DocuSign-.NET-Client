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
    /// A notary jurisdiction.
    /// </summary>
    [DataContract]
    public partial class NotaryJurisdiction :  IEquatable<NotaryJurisdiction>, IValidatableObject
    {
        public NotaryJurisdiction()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotaryJurisdiction" /> class.
        /// </summary>
        /// <param name="CommissionExpiration">CommissionExpiration.</param>
        /// <param name="CommissionId">CommissionId.</param>
        /// <param name="County">County.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Jurisdiction">Description of the jurisdiction for this notary. This is a read-only property..</param>
        /// <param name="RegisteredName">RegisteredName.</param>
        /// <param name="SealType">SealType.</param>
        public NotaryJurisdiction(string CommissionExpiration = default(string), string CommissionId = default(string), string County = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), Jurisdiction Jurisdiction = default(Jurisdiction), string RegisteredName = default(string), string SealType = default(string))
        {
            this.CommissionExpiration = CommissionExpiration;
            this.CommissionId = CommissionId;
            this.County = County;
            this.ErrorDetails = ErrorDetails;
            this.Jurisdiction = Jurisdiction;
            this.RegisteredName = RegisteredName;
            this.SealType = SealType;
        }
        
        /// <summary>
        /// Gets or Sets CommissionExpiration
        /// </summary>
        [DataMember(Name="commissionExpiration", EmitDefaultValue=false)]
        public string CommissionExpiration { get; set; }
        /// <summary>
        /// Gets or Sets CommissionId
        /// </summary>
        [DataMember(Name="commissionId", EmitDefaultValue=false)]
        public string CommissionId { get; set; }
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Description of the jurisdiction for this notary. This is a read-only property.
        /// </summary>
        /// <value>Description of the jurisdiction for this notary. This is a read-only property.</value>
        [DataMember(Name="jurisdiction", EmitDefaultValue=false)]
        public Jurisdiction Jurisdiction { get; set; }
        /// <summary>
        /// Gets or Sets RegisteredName
        /// </summary>
        [DataMember(Name="registeredName", EmitDefaultValue=false)]
        public string RegisteredName { get; set; }
        /// <summary>
        /// Gets or Sets SealType
        /// </summary>
        [DataMember(Name="sealType", EmitDefaultValue=false)]
        public string SealType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotaryJurisdiction {\n");
            sb.Append("  CommissionExpiration: ").Append(CommissionExpiration).Append("\n");
            sb.Append("  CommissionId: ").Append(CommissionId).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  RegisteredName: ").Append(RegisteredName).Append("\n");
            sb.Append("  SealType: ").Append(SealType).Append("\n");
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
            return this.Equals(obj as NotaryJurisdiction);
        }

        /// <summary>
        /// Returns true if NotaryJurisdiction instances are equal
        /// </summary>
        /// <param name="other">Instance of NotaryJurisdiction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotaryJurisdiction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommissionExpiration == other.CommissionExpiration ||
                    this.CommissionExpiration != null &&
                    this.CommissionExpiration.Equals(other.CommissionExpiration)
                ) && 
                (
                    this.CommissionId == other.CommissionId ||
                    this.CommissionId != null &&
                    this.CommissionId.Equals(other.CommissionId)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Jurisdiction == other.Jurisdiction ||
                    this.Jurisdiction != null &&
                    this.Jurisdiction.Equals(other.Jurisdiction)
                ) && 
                (
                    this.RegisteredName == other.RegisteredName ||
                    this.RegisteredName != null &&
                    this.RegisteredName.Equals(other.RegisteredName)
                ) && 
                (
                    this.SealType == other.SealType ||
                    this.SealType != null &&
                    this.SealType.Equals(other.SealType)
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
                if (this.CommissionExpiration != null)
                    hash = hash * 59 + this.CommissionExpiration.GetHashCode();
                if (this.CommissionId != null)
                    hash = hash * 59 + this.CommissionId.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Jurisdiction != null)
                    hash = hash * 59 + this.Jurisdiction.GetHashCode();
                if (this.RegisteredName != null)
                    hash = hash * 59 + this.RegisteredName.GetHashCode();
                if (this.SealType != null)
                    hash = hash * 59 + this.SealType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
