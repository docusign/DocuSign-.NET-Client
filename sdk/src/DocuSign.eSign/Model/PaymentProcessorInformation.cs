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
    /// PaymentProcessorInformation
    /// </summary>
    [DataContract]
    public partial class PaymentProcessorInformation :  IEquatable<PaymentProcessorInformation>, IValidatableObject
    {
        public PaymentProcessorInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProcessorInformation" /> class.
        /// </summary>
        /// <param name="Address">Address.</param>
        /// <param name="BillingAgreementId">BillingAgreementId.</param>
        /// <param name="Email">Email.</param>
        public PaymentProcessorInformation(AddressInformation Address = default(AddressInformation), string BillingAgreementId = default(string), string Email = default(string))
        {
            this.Address = Address;
            this.BillingAgreementId = BillingAgreementId;
            this.Email = Email;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressInformation Address { get; set; }
        /// <summary>
        /// Gets or Sets BillingAgreementId
        /// </summary>
        [DataMember(Name="billingAgreementId", EmitDefaultValue=false)]
        public string BillingAgreementId { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProcessorInformation {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BillingAgreementId: ").Append(BillingAgreementId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as PaymentProcessorInformation);
        }

        /// <summary>
        /// Returns true if PaymentProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.BillingAgreementId == other.BillingAgreementId ||
                    this.BillingAgreementId != null &&
                    this.BillingAgreementId.Equals(other.BillingAgreementId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.BillingAgreementId != null)
                    hash = hash * 59 + this.BillingAgreementId.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
