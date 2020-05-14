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
    /// CurrencyPlanPrice
    /// </summary>
    [DataContract]
    public partial class CurrencyPlanPrice :  IEquatable<CurrencyPlanPrice>, IValidatableObject
    {
        public CurrencyPlanPrice()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyPlanPrice" /> class.
        /// </summary>
        /// <param name="CurrencyCode">Specifies the ISO currency code for the account..</param>
        /// <param name="CurrencySymbol">Specifies the currency symbol for the account..</param>
        /// <param name="PerSeatPrice">PerSeatPrice.</param>
        /// <param name="SupportedCardTypes">SupportedCardTypes.</param>
        /// <param name="SupportIncidentFee">The support incident fee charged for each support incident..</param>
        /// <param name="SupportPlanFee">The support plan fee charged for this plan..</param>
        public CurrencyPlanPrice(string CurrencyCode = default(string), string CurrencySymbol = default(string), string PerSeatPrice = default(string), CreditCardTypes SupportedCardTypes = default(CreditCardTypes), string SupportIncidentFee = default(string), string SupportPlanFee = default(string))
        {
            this.CurrencyCode = CurrencyCode;
            this.CurrencySymbol = CurrencySymbol;
            this.PerSeatPrice = PerSeatPrice;
            this.SupportedCardTypes = SupportedCardTypes;
            this.SupportIncidentFee = SupportIncidentFee;
            this.SupportPlanFee = SupportPlanFee;
        }
        
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Specifies the currency symbol for the account.
        /// </summary>
        /// <value>Specifies the currency symbol for the account.</value>
        [DataMember(Name="currencySymbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// Gets or Sets PerSeatPrice
        /// </summary>
        [DataMember(Name="perSeatPrice", EmitDefaultValue=false)]
        public string PerSeatPrice { get; set; }
        /// <summary>
        /// Gets or Sets SupportedCardTypes
        /// </summary>
        [DataMember(Name="supportedCardTypes", EmitDefaultValue=false)]
        public CreditCardTypes SupportedCardTypes { get; set; }
        /// <summary>
        /// The support incident fee charged for each support incident.
        /// </summary>
        /// <value>The support incident fee charged for each support incident.</value>
        [DataMember(Name="supportIncidentFee", EmitDefaultValue=false)]
        public string SupportIncidentFee { get; set; }
        /// <summary>
        /// The support plan fee charged for this plan.
        /// </summary>
        /// <value>The support plan fee charged for this plan.</value>
        [DataMember(Name="supportPlanFee", EmitDefaultValue=false)]
        public string SupportPlanFee { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyPlanPrice {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  PerSeatPrice: ").Append(PerSeatPrice).Append("\n");
            sb.Append("  SupportedCardTypes: ").Append(SupportedCardTypes).Append("\n");
            sb.Append("  SupportIncidentFee: ").Append(SupportIncidentFee).Append("\n");
            sb.Append("  SupportPlanFee: ").Append(SupportPlanFee).Append("\n");
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
            return this.Equals(obj as CurrencyPlanPrice);
        }

        /// <summary>
        /// Returns true if CurrencyPlanPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrencyPlanPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyPlanPrice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.CurrencySymbol == other.CurrencySymbol ||
                    this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(other.CurrencySymbol)
                ) && 
                (
                    this.PerSeatPrice == other.PerSeatPrice ||
                    this.PerSeatPrice != null &&
                    this.PerSeatPrice.Equals(other.PerSeatPrice)
                ) && 
                (
                    this.SupportedCardTypes == other.SupportedCardTypes ||
                    this.SupportedCardTypes != null &&
                    this.SupportedCardTypes.Equals(other.SupportedCardTypes)
                ) && 
                (
                    this.SupportIncidentFee == other.SupportIncidentFee ||
                    this.SupportIncidentFee != null &&
                    this.SupportIncidentFee.Equals(other.SupportIncidentFee)
                ) && 
                (
                    this.SupportPlanFee == other.SupportPlanFee ||
                    this.SupportPlanFee != null &&
                    this.SupportPlanFee.Equals(other.SupportPlanFee)
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
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hash = hash * 59 + this.CurrencySymbol.GetHashCode();
                if (this.PerSeatPrice != null)
                    hash = hash * 59 + this.PerSeatPrice.GetHashCode();
                if (this.SupportedCardTypes != null)
                    hash = hash * 59 + this.SupportedCardTypes.GetHashCode();
                if (this.SupportIncidentFee != null)
                    hash = hash * 59 + this.SupportIncidentFee.GetHashCode();
                if (this.SupportPlanFee != null)
                    hash = hash * 59 + this.SupportPlanFee.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
