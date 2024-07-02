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
    /// This object contains details about a payment gateway account.
    /// </summary>
    [DataContract]
    public partial class PaymentGatewayAccount :  IEquatable<PaymentGatewayAccount>, IValidatableObject
    {
        public PaymentGatewayAccount()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentGatewayAccount" /> class.
        /// </summary>
        /// <param name="AllowCustomMetadata">AllowCustomMetadata.</param>
        /// <param name="Config">This property contains metadata about the payment gateway account&#39;s configuration such as the API key, &#x60;userId&#x60;, and &#x60;merchantId&#x60; details..</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="IsEnabled">IsEnabled.</param>
        /// <param name="IsLegacy">IsLegacy.</param>
        /// <param name="LastModified">LastModified.</param>
        /// <param name="PaymentGateway">PaymentGateway.</param>
        /// <param name="PaymentGatewayAccountId">PaymentGatewayAccountId.</param>
        /// <param name="PaymentGatewayDisplayName">PaymentGatewayDisplayName.</param>
        /// <param name="PayPalLegacySettings">Reserved for DocuSign..</param>
        /// <param name="SupportedCurrencies">SupportedCurrencies.</param>
        /// <param name="SupportedPaymentMethods">SupportedPaymentMethods.</param>
        /// <param name="SupportedPaymentMethodsWithOptions">SupportedPaymentMethodsWithOptions.</param>
        /// <param name="ZeroDecimalCurrencies">ZeroDecimalCurrencies.</param>
        public PaymentGatewayAccount(bool? AllowCustomMetadata = default(bool?), PaymentGatewayAccountSetting Config = default(PaymentGatewayAccountSetting), string DisplayName = default(string), string IsEnabled = default(string), string IsLegacy = default(string), string LastModified = default(string), string PaymentGateway = default(string), string PaymentGatewayAccountId = default(string), string PaymentGatewayDisplayName = default(string), PayPalLegacySettings PayPalLegacySettings = default(PayPalLegacySettings), List<string> SupportedCurrencies = default(List<string>), List<string> SupportedPaymentMethods = default(List<string>), List<PaymentMethodWithOptions> SupportedPaymentMethodsWithOptions = default(List<PaymentMethodWithOptions>), List<string> ZeroDecimalCurrencies = default(List<string>))
        {
            this.AllowCustomMetadata = AllowCustomMetadata;
            this.Config = Config;
            this.DisplayName = DisplayName;
            this.IsEnabled = IsEnabled;
            this.IsLegacy = IsLegacy;
            this.LastModified = LastModified;
            this.PaymentGateway = PaymentGateway;
            this.PaymentGatewayAccountId = PaymentGatewayAccountId;
            this.PaymentGatewayDisplayName = PaymentGatewayDisplayName;
            this.PayPalLegacySettings = PayPalLegacySettings;
            this.SupportedCurrencies = SupportedCurrencies;
            this.SupportedPaymentMethods = SupportedPaymentMethods;
            this.SupportedPaymentMethodsWithOptions = SupportedPaymentMethodsWithOptions;
            this.ZeroDecimalCurrencies = ZeroDecimalCurrencies;
        }
        
        /// <summary>
        /// Gets or Sets AllowCustomMetadata
        /// </summary>
        [DataMember(Name="allowCustomMetadata", EmitDefaultValue=false)]
        public bool? AllowCustomMetadata { get; set; }
        /// <summary>
        /// This property contains metadata about the payment gateway account&#39;s configuration such as the API key, &#x60;userId&#x60;, and &#x60;merchantId&#x60; details.
        /// </summary>
        /// <value>This property contains metadata about the payment gateway account&#39;s configuration such as the API key, &#x60;userId&#x60;, and &#x60;merchantId&#x60; details.</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public PaymentGatewayAccountSetting Config { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public string IsEnabled { get; set; }
        /// <summary>
        /// Gets or Sets IsLegacy
        /// </summary>
        [DataMember(Name="isLegacy", EmitDefaultValue=false)]
        public string IsLegacy { get; set; }
        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
        /// <summary>
        /// Gets or Sets PaymentGateway
        /// </summary>
        [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
        public string PaymentGateway { get; set; }
        /// <summary>
        /// Gets or Sets PaymentGatewayAccountId
        /// </summary>
        [DataMember(Name="paymentGatewayAccountId", EmitDefaultValue=false)]
        public string PaymentGatewayAccountId { get; set; }
        /// <summary>
        /// Gets or Sets PaymentGatewayDisplayName
        /// </summary>
        [DataMember(Name="paymentGatewayDisplayName", EmitDefaultValue=false)]
        public string PaymentGatewayDisplayName { get; set; }
        /// <summary>
        /// Reserved for DocuSign.
        /// </summary>
        /// <value>Reserved for DocuSign.</value>
        [DataMember(Name="payPalLegacySettings", EmitDefaultValue=false)]
        public PayPalLegacySettings PayPalLegacySettings { get; set; }
        /// <summary>
        /// Gets or Sets SupportedCurrencies
        /// </summary>
        [DataMember(Name="supportedCurrencies", EmitDefaultValue=false)]
        public List<string> SupportedCurrencies { get; set; }
        /// <summary>
        /// Gets or Sets SupportedPaymentMethods
        /// </summary>
        [DataMember(Name="supportedPaymentMethods", EmitDefaultValue=false)]
        public List<string> SupportedPaymentMethods { get; set; }
        /// <summary>
        /// Gets or Sets SupportedPaymentMethodsWithOptions
        /// </summary>
        [DataMember(Name="supportedPaymentMethodsWithOptions", EmitDefaultValue=false)]
        public List<PaymentMethodWithOptions> SupportedPaymentMethodsWithOptions { get; set; }
        /// <summary>
        /// Gets or Sets ZeroDecimalCurrencies
        /// </summary>
        [DataMember(Name="zeroDecimalCurrencies", EmitDefaultValue=false)]
        public List<string> ZeroDecimalCurrencies { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentGatewayAccount {\n");
            sb.Append("  AllowCustomMetadata: ").Append(AllowCustomMetadata).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsLegacy: ").Append(IsLegacy).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  PaymentGatewayAccountId: ").Append(PaymentGatewayAccountId).Append("\n");
            sb.Append("  PaymentGatewayDisplayName: ").Append(PaymentGatewayDisplayName).Append("\n");
            sb.Append("  PayPalLegacySettings: ").Append(PayPalLegacySettings).Append("\n");
            sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
            sb.Append("  SupportedPaymentMethods: ").Append(SupportedPaymentMethods).Append("\n");
            sb.Append("  SupportedPaymentMethodsWithOptions: ").Append(SupportedPaymentMethodsWithOptions).Append("\n");
            sb.Append("  ZeroDecimalCurrencies: ").Append(ZeroDecimalCurrencies).Append("\n");
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
            return this.Equals(obj as PaymentGatewayAccount);
        }

        /// <summary>
        /// Returns true if PaymentGatewayAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentGatewayAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentGatewayAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowCustomMetadata == other.AllowCustomMetadata ||
                    this.AllowCustomMetadata != null &&
                    this.AllowCustomMetadata.Equals(other.AllowCustomMetadata)
                ) && 
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.IsEnabled == other.IsEnabled ||
                    this.IsEnabled != null &&
                    this.IsEnabled.Equals(other.IsEnabled)
                ) && 
                (
                    this.IsLegacy == other.IsLegacy ||
                    this.IsLegacy != null &&
                    this.IsLegacy.Equals(other.IsLegacy)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.PaymentGateway == other.PaymentGateway ||
                    this.PaymentGateway != null &&
                    this.PaymentGateway.Equals(other.PaymentGateway)
                ) && 
                (
                    this.PaymentGatewayAccountId == other.PaymentGatewayAccountId ||
                    this.PaymentGatewayAccountId != null &&
                    this.PaymentGatewayAccountId.Equals(other.PaymentGatewayAccountId)
                ) && 
                (
                    this.PaymentGatewayDisplayName == other.PaymentGatewayDisplayName ||
                    this.PaymentGatewayDisplayName != null &&
                    this.PaymentGatewayDisplayName.Equals(other.PaymentGatewayDisplayName)
                ) && 
                (
                    this.PayPalLegacySettings == other.PayPalLegacySettings ||
                    this.PayPalLegacySettings != null &&
                    this.PayPalLegacySettings.Equals(other.PayPalLegacySettings)
                ) && 
                (
                    this.SupportedCurrencies == other.SupportedCurrencies ||
                    this.SupportedCurrencies != null &&
                    this.SupportedCurrencies.SequenceEqual(other.SupportedCurrencies)
                ) && 
                (
                    this.SupportedPaymentMethods == other.SupportedPaymentMethods ||
                    this.SupportedPaymentMethods != null &&
                    this.SupportedPaymentMethods.SequenceEqual(other.SupportedPaymentMethods)
                ) && 
                (
                    this.SupportedPaymentMethodsWithOptions == other.SupportedPaymentMethodsWithOptions ||
                    this.SupportedPaymentMethodsWithOptions != null &&
                    this.SupportedPaymentMethodsWithOptions.SequenceEqual(other.SupportedPaymentMethodsWithOptions)
                ) && 
                (
                    this.ZeroDecimalCurrencies == other.ZeroDecimalCurrencies ||
                    this.ZeroDecimalCurrencies != null &&
                    this.ZeroDecimalCurrencies.SequenceEqual(other.ZeroDecimalCurrencies)
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
                if (this.AllowCustomMetadata != null)
                    hash = hash * 59 + this.AllowCustomMetadata.GetHashCode();
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.IsEnabled != null)
                    hash = hash * 59 + this.IsEnabled.GetHashCode();
                if (this.IsLegacy != null)
                    hash = hash * 59 + this.IsLegacy.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.PaymentGateway != null)
                    hash = hash * 59 + this.PaymentGateway.GetHashCode();
                if (this.PaymentGatewayAccountId != null)
                    hash = hash * 59 + this.PaymentGatewayAccountId.GetHashCode();
                if (this.PaymentGatewayDisplayName != null)
                    hash = hash * 59 + this.PaymentGatewayDisplayName.GetHashCode();
                if (this.PayPalLegacySettings != null)
                    hash = hash * 59 + this.PayPalLegacySettings.GetHashCode();
                if (this.SupportedCurrencies != null)
                    hash = hash * 59 + this.SupportedCurrencies.GetHashCode();
                if (this.SupportedPaymentMethods != null)
                    hash = hash * 59 + this.SupportedPaymentMethods.GetHashCode();
                if (this.SupportedPaymentMethodsWithOptions != null)
                    hash = hash * 59 + this.SupportedPaymentMethodsWithOptions.GetHashCode();
                if (this.ZeroDecimalCurrencies != null)
                    hash = hash * 59 + this.ZeroDecimalCurrencies.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
