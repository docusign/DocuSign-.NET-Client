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
    /// BillingPrice
    /// </summary>
    [DataContract]
    public partial class BillingPrice :  IEquatable<BillingPrice>, IValidatableObject
    {
        public BillingPrice()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPrice" /> class.
        /// </summary>
        /// <param name="BeginQuantity">Reserved: TBD.</param>
        /// <param name="EndQuantity">EndQuantity.</param>
        /// <param name="UnitPrice">Reserved: TBD.</param>
        public BillingPrice(string BeginQuantity = default(string), string EndQuantity = default(string), string UnitPrice = default(string))
        {
            this.BeginQuantity = BeginQuantity;
            this.EndQuantity = EndQuantity;
            this.UnitPrice = UnitPrice;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="beginQuantity", EmitDefaultValue=false)]
        public string BeginQuantity { get; set; }
        /// <summary>
        /// Gets or Sets EndQuantity
        /// </summary>
        [DataMember(Name="endQuantity", EmitDefaultValue=false)]
        public string EndQuantity { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public string UnitPrice { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPrice {\n");
            sb.Append("  BeginQuantity: ").Append(BeginQuantity).Append("\n");
            sb.Append("  EndQuantity: ").Append(EndQuantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return this.Equals(obj as BillingPrice);
        }

        /// <summary>
        /// Returns true if BillingPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPrice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BeginQuantity == other.BeginQuantity ||
                    this.BeginQuantity != null &&
                    this.BeginQuantity.Equals(other.BeginQuantity)
                ) && 
                (
                    this.EndQuantity == other.EndQuantity ||
                    this.EndQuantity != null &&
                    this.EndQuantity.Equals(other.EndQuantity)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
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
                if (this.BeginQuantity != null)
                    hash = hash * 59 + this.BeginQuantity.GetHashCode();
                if (this.EndQuantity != null)
                    hash = hash * 59 + this.EndQuantity.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
