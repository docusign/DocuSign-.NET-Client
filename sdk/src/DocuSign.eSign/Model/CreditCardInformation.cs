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
    /// CreditCardInformation
    /// </summary>
    [DataContract]
    public partial class CreditCardInformation :  IEquatable<CreditCardInformation>, IValidatableObject
    {
        public CreditCardInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardInformation" /> class.
        /// </summary>
        /// <param name="Address">Address.</param>
        /// <param name="CardNumber">The number on the credit card..</param>
        /// <param name="CardType">The credit card type. Valid values are: visa, mastercard, or amex..</param>
        /// <param name="CvNumber">CvNumber.</param>
        /// <param name="ExpirationMonth">The month that the credit card expires (1-12)..</param>
        /// <param name="ExpirationYear">The year 4 digit year in which the credit card expires..</param>
        /// <param name="NameOnCard">The exact name printed on the credit card..</param>
        public CreditCardInformation(AddressInformation Address = default(AddressInformation), string CardNumber = default(string), string CardType = default(string), string CvNumber = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string), string NameOnCard = default(string))
        {
            this.Address = Address;
            this.CardNumber = CardNumber;
            this.CardType = CardType;
            this.CvNumber = CvNumber;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.NameOnCard = NameOnCard;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressInformation Address { get; set; }
        /// <summary>
        /// The number on the credit card.
        /// </summary>
        /// <value>The number on the credit card.</value>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }
        /// <summary>
        /// The credit card type. Valid values are: visa, mastercard, or amex.
        /// </summary>
        /// <value>The credit card type. Valid values are: visa, mastercard, or amex.</value>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public string CardType { get; set; }
        /// <summary>
        /// Gets or Sets CvNumber
        /// </summary>
        [DataMember(Name="cvNumber", EmitDefaultValue=false)]
        public string CvNumber { get; set; }
        /// <summary>
        /// The month that the credit card expires (1-12).
        /// </summary>
        /// <value>The month that the credit card expires (1-12).</value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }
        /// <summary>
        /// The year 4 digit year in which the credit card expires.
        /// </summary>
        /// <value>The year 4 digit year in which the credit card expires.</value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }
        /// <summary>
        /// The exact name printed on the credit card.
        /// </summary>
        /// <value>The exact name printed on the credit card.</value>
        [DataMember(Name="nameOnCard", EmitDefaultValue=false)]
        public string NameOnCard { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardInformation {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  CvNumber: ").Append(CvNumber).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  NameOnCard: ").Append(NameOnCard).Append("\n");
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
            return this.Equals(obj as CreditCardInformation);
        }

        /// <summary>
        /// Returns true if CreditCardInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCardInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardInformation other)
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
                    this.CardNumber == other.CardNumber ||
                    this.CardNumber != null &&
                    this.CardNumber.Equals(other.CardNumber)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
                ) && 
                (
                    this.CvNumber == other.CvNumber ||
                    this.CvNumber != null &&
                    this.CvNumber.Equals(other.CvNumber)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.NameOnCard == other.NameOnCard ||
                    this.NameOnCard != null &&
                    this.NameOnCard.Equals(other.NameOnCard)
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
                if (this.CardNumber != null)
                    hash = hash * 59 + this.CardNumber.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                if (this.CvNumber != null)
                    hash = hash * 59 + this.CvNumber.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.NameOnCard != null)
                    hash = hash * 59 + this.NameOnCard.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
