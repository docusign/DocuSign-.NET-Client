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
    /// Contains information about an item on a billing invoice.
    /// </summary>
    [DataContract]
    public partial class BillingInvoiceItem :  IEquatable<BillingInvoiceItem>, IValidatableObject
    {
        public BillingInvoiceItem()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoiceItem" /> class.
        /// </summary>
        /// <param name="ChargeAmount">Reserved: TBD.</param>
        /// <param name="ChargeName">Reserved: TBD.</param>
        /// <param name="InvoiceItemId">Reserved: TBD.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="UnitPrice">Reserved: TBD.</param>
        public BillingInvoiceItem(string ChargeAmount = default(string), string ChargeName = default(string), string InvoiceItemId = default(string), string Quantity = default(string), string UnitPrice = default(string))
        {
            this.ChargeAmount = ChargeAmount;
            this.ChargeName = ChargeName;
            this.InvoiceItemId = InvoiceItemId;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="chargeAmount", EmitDefaultValue=false)]
        public string ChargeAmount { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="chargeName", EmitDefaultValue=false)]
        public string ChargeName { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="invoiceItemId", EmitDefaultValue=false)]
        public string InvoiceItemId { get; set; }
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }
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
            sb.Append("class BillingInvoiceItem {\n");
            sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
            sb.Append("  ChargeName: ").Append(ChargeName).Append("\n");
            sb.Append("  InvoiceItemId: ").Append(InvoiceItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(obj as BillingInvoiceItem);
        }

        /// <summary>
        /// Returns true if BillingInvoiceItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingInvoiceItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInvoiceItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChargeAmount == other.ChargeAmount ||
                    this.ChargeAmount != null &&
                    this.ChargeAmount.Equals(other.ChargeAmount)
                ) && 
                (
                    this.ChargeName == other.ChargeName ||
                    this.ChargeName != null &&
                    this.ChargeName.Equals(other.ChargeName)
                ) && 
                (
                    this.InvoiceItemId == other.InvoiceItemId ||
                    this.InvoiceItemId != null &&
                    this.InvoiceItemId.Equals(other.InvoiceItemId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                if (this.ChargeAmount != null)
                    hash = hash * 59 + this.ChargeAmount.GetHashCode();
                if (this.ChargeName != null)
                    hash = hash * 59 + this.ChargeName.GetHashCode();
                if (this.InvoiceItemId != null)
                    hash = hash * 59 + this.InvoiceItemId.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
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
