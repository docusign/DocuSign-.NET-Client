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
    /// This object provides details about a feature set, or add-on product that is associated with an account. It is reserved for DocuSign internal use only.
    /// </summary>
    [DataContract]
    public partial class FeatureSet :  IEquatable<FeatureSet>, IValidatableObject
    {
        public FeatureSet()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureSet" /> class.
        /// </summary>
        /// <param name="CurrencyFeatureSetPrices">A complex type that contains alternate currency values that are configured for this plan feature set..</param>
        /// <param name="EnvelopeFee">EnvelopeFee.</param>
        /// <param name="FeatureSetId">A unique ID for the feature set..</param>
        /// <param name="FixedFee">FixedFee.</param>
        /// <param name="Is21CFRPart11">When set to **true**, indicates that this module is enabled on the account..</param>
        /// <param name="IsActive">IsActive.</param>
        /// <param name="IsEnabled">Specifies whether the feature set is actively enabled as part of the plan..</param>
        /// <param name="Name">Name.</param>
        /// <param name="SeatFee">An incremental seat cost for seat-based plans. Only valid when isEnabled for the feature set is set to true..</param>
        public FeatureSet(List<CurrencyFeatureSetPrice> CurrencyFeatureSetPrices = default(List<CurrencyFeatureSetPrice>), string EnvelopeFee = default(string), string FeatureSetId = default(string), string FixedFee = default(string), string Is21CFRPart11 = default(string), string IsActive = default(string), string IsEnabled = default(string), string Name = default(string), string SeatFee = default(string))
        {
            this.CurrencyFeatureSetPrices = CurrencyFeatureSetPrices;
            this.EnvelopeFee = EnvelopeFee;
            this.FeatureSetId = FeatureSetId;
            this.FixedFee = FixedFee;
            this.Is21CFRPart11 = Is21CFRPart11;
            this.IsActive = IsActive;
            this.IsEnabled = IsEnabled;
            this.Name = Name;
            this.SeatFee = SeatFee;
        }
        
        /// <summary>
        /// A complex type that contains alternate currency values that are configured for this plan feature set.
        /// </summary>
        /// <value>A complex type that contains alternate currency values that are configured for this plan feature set.</value>
        [DataMember(Name="currencyFeatureSetPrices", EmitDefaultValue=false)]
        public List<CurrencyFeatureSetPrice> CurrencyFeatureSetPrices { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeFee
        /// </summary>
        [DataMember(Name="envelopeFee", EmitDefaultValue=false)]
        public string EnvelopeFee { get; set; }
        /// <summary>
        /// A unique ID for the feature set.
        /// </summary>
        /// <value>A unique ID for the feature set.</value>
        [DataMember(Name="featureSetId", EmitDefaultValue=false)]
        public string FeatureSetId { get; set; }
        /// <summary>
        /// Gets or Sets FixedFee
        /// </summary>
        [DataMember(Name="fixedFee", EmitDefaultValue=false)]
        public string FixedFee { get; set; }
        /// <summary>
        /// When set to **true**, indicates that this module is enabled on the account.
        /// </summary>
        /// <value>When set to **true**, indicates that this module is enabled on the account.</value>
        [DataMember(Name="is21CFRPart11", EmitDefaultValue=false)]
        public string Is21CFRPart11 { get; set; }
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public string IsActive { get; set; }
        /// <summary>
        /// Specifies whether the feature set is actively enabled as part of the plan.
        /// </summary>
        /// <value>Specifies whether the feature set is actively enabled as part of the plan.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public string IsEnabled { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// An incremental seat cost for seat-based plans. Only valid when isEnabled for the feature set is set to true.
        /// </summary>
        /// <value>An incremental seat cost for seat-based plans. Only valid when isEnabled for the feature set is set to true.</value>
        [DataMember(Name="seatFee", EmitDefaultValue=false)]
        public string SeatFee { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureSet {\n");
            sb.Append("  CurrencyFeatureSetPrices: ").Append(CurrencyFeatureSetPrices).Append("\n");
            sb.Append("  EnvelopeFee: ").Append(EnvelopeFee).Append("\n");
            sb.Append("  FeatureSetId: ").Append(FeatureSetId).Append("\n");
            sb.Append("  FixedFee: ").Append(FixedFee).Append("\n");
            sb.Append("  Is21CFRPart11: ").Append(Is21CFRPart11).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SeatFee: ").Append(SeatFee).Append("\n");
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
            return this.Equals(obj as FeatureSet);
        }

        /// <summary>
        /// Returns true if FeatureSet instances are equal
        /// </summary>
        /// <param name="other">Instance of FeatureSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrencyFeatureSetPrices == other.CurrencyFeatureSetPrices ||
                    this.CurrencyFeatureSetPrices != null &&
                    this.CurrencyFeatureSetPrices.SequenceEqual(other.CurrencyFeatureSetPrices)
                ) && 
                (
                    this.EnvelopeFee == other.EnvelopeFee ||
                    this.EnvelopeFee != null &&
                    this.EnvelopeFee.Equals(other.EnvelopeFee)
                ) && 
                (
                    this.FeatureSetId == other.FeatureSetId ||
                    this.FeatureSetId != null &&
                    this.FeatureSetId.Equals(other.FeatureSetId)
                ) && 
                (
                    this.FixedFee == other.FixedFee ||
                    this.FixedFee != null &&
                    this.FixedFee.Equals(other.FixedFee)
                ) && 
                (
                    this.Is21CFRPart11 == other.Is21CFRPart11 ||
                    this.Is21CFRPart11 != null &&
                    this.Is21CFRPart11.Equals(other.Is21CFRPart11)
                ) && 
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) && 
                (
                    this.IsEnabled == other.IsEnabled ||
                    this.IsEnabled != null &&
                    this.IsEnabled.Equals(other.IsEnabled)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SeatFee == other.SeatFee ||
                    this.SeatFee != null &&
                    this.SeatFee.Equals(other.SeatFee)
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
                if (this.CurrencyFeatureSetPrices != null)
                    hash = hash * 59 + this.CurrencyFeatureSetPrices.GetHashCode();
                if (this.EnvelopeFee != null)
                    hash = hash * 59 + this.EnvelopeFee.GetHashCode();
                if (this.FeatureSetId != null)
                    hash = hash * 59 + this.FeatureSetId.GetHashCode();
                if (this.FixedFee != null)
                    hash = hash * 59 + this.FixedFee.GetHashCode();
                if (this.Is21CFRPart11 != null)
                    hash = hash * 59 + this.Is21CFRPart11.GetHashCode();
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                if (this.IsEnabled != null)
                    hash = hash * 59 + this.IsEnabled.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SeatFee != null)
                    hash = hash * 59 + this.SeatFee.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
