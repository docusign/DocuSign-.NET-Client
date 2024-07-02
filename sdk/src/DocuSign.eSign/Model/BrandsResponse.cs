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
    /// BrandsResponse
    /// </summary>
    [DataContract]
    public partial class BrandsResponse :  IEquatable<BrandsResponse>, IValidatableObject
    {
        public BrandsResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsResponse" /> class.
        /// </summary>
        /// <param name="Brands">The list of brands..</param>
        /// <param name="RecipientBrandIdDefault">The brand seen by envelope recipients when a brand is not explicitly set..</param>
        /// <param name="SenderBrandIdDefault">The brand seen by envelope senders when a brand is not explicitly set..</param>
        public BrandsResponse(List<Brand> Brands = default(List<Brand>), string RecipientBrandIdDefault = default(string), string SenderBrandIdDefault = default(string))
        {
            this.Brands = Brands;
            this.RecipientBrandIdDefault = RecipientBrandIdDefault;
            this.SenderBrandIdDefault = SenderBrandIdDefault;
        }
        
        /// <summary>
        /// The list of brands.
        /// </summary>
        /// <value>The list of brands.</value>
        [DataMember(Name="brands", EmitDefaultValue=false)]
        public List<Brand> Brands { get; set; }
        /// <summary>
        /// The brand seen by envelope recipients when a brand is not explicitly set.
        /// </summary>
        /// <value>The brand seen by envelope recipients when a brand is not explicitly set.</value>
        [DataMember(Name="recipientBrandIdDefault", EmitDefaultValue=false)]
        public string RecipientBrandIdDefault { get; set; }
        /// <summary>
        /// The brand seen by envelope senders when a brand is not explicitly set.
        /// </summary>
        /// <value>The brand seen by envelope senders when a brand is not explicitly set.</value>
        [DataMember(Name="senderBrandIdDefault", EmitDefaultValue=false)]
        public string SenderBrandIdDefault { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandsResponse {\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  RecipientBrandIdDefault: ").Append(RecipientBrandIdDefault).Append("\n");
            sb.Append("  SenderBrandIdDefault: ").Append(SenderBrandIdDefault).Append("\n");
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
            return this.Equals(obj as BrandsResponse);
        }

        /// <summary>
        /// Returns true if BrandsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Brands == other.Brands ||
                    this.Brands != null &&
                    this.Brands.SequenceEqual(other.Brands)
                ) && 
                (
                    this.RecipientBrandIdDefault == other.RecipientBrandIdDefault ||
                    this.RecipientBrandIdDefault != null &&
                    this.RecipientBrandIdDefault.Equals(other.RecipientBrandIdDefault)
                ) && 
                (
                    this.SenderBrandIdDefault == other.SenderBrandIdDefault ||
                    this.SenderBrandIdDefault != null &&
                    this.SenderBrandIdDefault.Equals(other.SenderBrandIdDefault)
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
                if (this.Brands != null)
                    hash = hash * 59 + this.Brands.GetHashCode();
                if (this.RecipientBrandIdDefault != null)
                    hash = hash * 59 + this.RecipientBrandIdDefault.GetHashCode();
                if (this.SenderBrandIdDefault != null)
                    hash = hash * 59 + this.SenderBrandIdDefault.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
