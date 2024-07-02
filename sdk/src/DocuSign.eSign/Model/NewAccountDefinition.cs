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
    /// NewAccountDefinition
    /// </summary>
    [DataContract]
    public partial class NewAccountDefinition :  IEquatable<NewAccountDefinition>, IValidatableObject
    {
        public NewAccountDefinition()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccountDefinition" /> class.
        /// </summary>
        /// <param name="AccountName">The account name for the new account..</param>
        /// <param name="AccountSettings">The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden..</param>
        /// <param name="AddressInformation">A complex type that contains the following information for the new account: &#x60;Street1&#x60;, &#x60;Street2&#x60;, &#x60;City&#x60;, &#x60;State&#x60;, &#x60;Zip&#x60;, &#x60;Phone&#x60;, and &#x60;Fax&#x60;..</param>
        /// <param name="CreditCardInformation">A complex type that has information about the credit card used to pay for this account..</param>
        /// <param name="DirectDebitProcessorInformation">Information about the bank that processes direct debits for the payment plan..</param>
        /// <param name="DistributorCode">The code that identifies the billing plan groups and plans for the new account..</param>
        /// <param name="DistributorPassword">The password for the distributorCode..</param>
        /// <param name="EnablePreAuth">EnablePreAuth.</param>
        /// <param name="EnvelopePartitionId">EnvelopePartitionId.</param>
        /// <param name="InitialUser">A complex type with the initial user information for the new account. Note that some user information is set internally based on the plan and cannot be overridden..</param>
        /// <param name="PaymentMethod">PaymentMethod.</param>
        /// <param name="PaymentProcessor">PaymentProcessor.</param>
        /// <param name="PaymentProcessorInformation">Information about the entity that processes payments for the billing plan..</param>
        /// <param name="PlanInformation">An object used to identify the features and attributes of the account being created..</param>
        /// <param name="ProcessPayment">ProcessPayment.</param>
        /// <param name="ReferralInformation">A complex type that contains properties for entering referral and discount information..</param>
        /// <param name="SocialAccountInformation">Contains properties that map a DocuSign user to a social account (Facebook, Yahoo, etc.).</param>
        /// <param name="TaxExemptId">TaxExemptId.</param>
        public NewAccountDefinition(string AccountName = default(string), AccountSettingsInformation AccountSettings = default(AccountSettingsInformation), AccountAddress AddressInformation = default(AccountAddress), CreditCardInformation CreditCardInformation = default(CreditCardInformation), DirectDebitProcessorInformation DirectDebitProcessorInformation = default(DirectDebitProcessorInformation), string DistributorCode = default(string), string DistributorPassword = default(string), string EnablePreAuth = default(string), string EnvelopePartitionId = default(string), UserInformation InitialUser = default(UserInformation), string PaymentMethod = default(string), string PaymentProcessor = default(string), PaymentProcessorInformation PaymentProcessorInformation = default(PaymentProcessorInformation), PlanInformation PlanInformation = default(PlanInformation), string ProcessPayment = default(string), ReferralInformation ReferralInformation = default(ReferralInformation), SocialAccountInformation SocialAccountInformation = default(SocialAccountInformation), string TaxExemptId = default(string))
        {
            this.AccountName = AccountName;
            this.AccountSettings = AccountSettings;
            this.AddressInformation = AddressInformation;
            this.CreditCardInformation = CreditCardInformation;
            this.DirectDebitProcessorInformation = DirectDebitProcessorInformation;
            this.DistributorCode = DistributorCode;
            this.DistributorPassword = DistributorPassword;
            this.EnablePreAuth = EnablePreAuth;
            this.EnvelopePartitionId = EnvelopePartitionId;
            this.InitialUser = InitialUser;
            this.PaymentMethod = PaymentMethod;
            this.PaymentProcessor = PaymentProcessor;
            this.PaymentProcessorInformation = PaymentProcessorInformation;
            this.PlanInformation = PlanInformation;
            this.ProcessPayment = ProcessPayment;
            this.ReferralInformation = ReferralInformation;
            this.SocialAccountInformation = SocialAccountInformation;
            this.TaxExemptId = TaxExemptId;
        }
        
        /// <summary>
        /// The account name for the new account.
        /// </summary>
        /// <value>The account name for the new account.</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.
        /// </summary>
        /// <value>The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.</value>
        [DataMember(Name="accountSettings", EmitDefaultValue=false)]
        public AccountSettingsInformation AccountSettings { get; set; }
        /// <summary>
        /// A complex type that contains the following information for the new account: &#x60;Street1&#x60;, &#x60;Street2&#x60;, &#x60;City&#x60;, &#x60;State&#x60;, &#x60;Zip&#x60;, &#x60;Phone&#x60;, and &#x60;Fax&#x60;.
        /// </summary>
        /// <value>A complex type that contains the following information for the new account: &#x60;Street1&#x60;, &#x60;Street2&#x60;, &#x60;City&#x60;, &#x60;State&#x60;, &#x60;Zip&#x60;, &#x60;Phone&#x60;, and &#x60;Fax&#x60;.</value>
        [DataMember(Name="addressInformation", EmitDefaultValue=false)]
        public AccountAddress AddressInformation { get; set; }
        /// <summary>
        /// A complex type that has information about the credit card used to pay for this account.
        /// </summary>
        /// <value>A complex type that has information about the credit card used to pay for this account.</value>
        [DataMember(Name="creditCardInformation", EmitDefaultValue=false)]
        public CreditCardInformation CreditCardInformation { get; set; }
        /// <summary>
        /// Information about the bank that processes direct debits for the payment plan.
        /// </summary>
        /// <value>Information about the bank that processes direct debits for the payment plan.</value>
        [DataMember(Name="directDebitProcessorInformation", EmitDefaultValue=false)]
        public DirectDebitProcessorInformation DirectDebitProcessorInformation { get; set; }
        /// <summary>
        /// The code that identifies the billing plan groups and plans for the new account.
        /// </summary>
        /// <value>The code that identifies the billing plan groups and plans for the new account.</value>
        [DataMember(Name="distributorCode", EmitDefaultValue=false)]
        public string DistributorCode { get; set; }
        /// <summary>
        /// The password for the distributorCode.
        /// </summary>
        /// <value>The password for the distributorCode.</value>
        [DataMember(Name="distributorPassword", EmitDefaultValue=false)]
        public string DistributorPassword { get; set; }
        /// <summary>
        /// Gets or Sets EnablePreAuth
        /// </summary>
        [DataMember(Name="enablePreAuth", EmitDefaultValue=false)]
        public string EnablePreAuth { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopePartitionId
        /// </summary>
        [DataMember(Name="envelopePartitionId", EmitDefaultValue=false)]
        public string EnvelopePartitionId { get; set; }
        /// <summary>
        /// A complex type with the initial user information for the new account. Note that some user information is set internally based on the plan and cannot be overridden.
        /// </summary>
        /// <value>A complex type with the initial user information for the new account. Note that some user information is set internally based on the plan and cannot be overridden.</value>
        [DataMember(Name="initialUser", EmitDefaultValue=false)]
        public UserInformation InitialUser { get; set; }
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Gets or Sets PaymentProcessor
        /// </summary>
        [DataMember(Name="paymentProcessor", EmitDefaultValue=false)]
        public string PaymentProcessor { get; set; }
        /// <summary>
        /// Information about the entity that processes payments for the billing plan.
        /// </summary>
        /// <value>Information about the entity that processes payments for the billing plan.</value>
        [DataMember(Name="paymentProcessorInformation", EmitDefaultValue=false)]
        public PaymentProcessorInformation PaymentProcessorInformation { get; set; }
        /// <summary>
        /// An object used to identify the features and attributes of the account being created.
        /// </summary>
        /// <value>An object used to identify the features and attributes of the account being created.</value>
        [DataMember(Name="planInformation", EmitDefaultValue=false)]
        public PlanInformation PlanInformation { get; set; }
        /// <summary>
        /// Gets or Sets ProcessPayment
        /// </summary>
        [DataMember(Name="processPayment", EmitDefaultValue=false)]
        public string ProcessPayment { get; set; }
        /// <summary>
        /// A complex type that contains properties for entering referral and discount information.
        /// </summary>
        /// <value>A complex type that contains properties for entering referral and discount information.</value>
        [DataMember(Name="referralInformation", EmitDefaultValue=false)]
        public ReferralInformation ReferralInformation { get; set; }
        /// <summary>
        /// Contains properties that map a DocuSign user to a social account (Facebook, Yahoo, etc.)
        /// </summary>
        /// <value>Contains properties that map a DocuSign user to a social account (Facebook, Yahoo, etc.)</value>
        [DataMember(Name="socialAccountInformation", EmitDefaultValue=false)]
        public SocialAccountInformation SocialAccountInformation { get; set; }
        /// <summary>
        /// Gets or Sets TaxExemptId
        /// </summary>
        [DataMember(Name="taxExemptId", EmitDefaultValue=false)]
        public string TaxExemptId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAccountDefinition {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountSettings: ").Append(AccountSettings).Append("\n");
            sb.Append("  AddressInformation: ").Append(AddressInformation).Append("\n");
            sb.Append("  CreditCardInformation: ").Append(CreditCardInformation).Append("\n");
            sb.Append("  DirectDebitProcessorInformation: ").Append(DirectDebitProcessorInformation).Append("\n");
            sb.Append("  DistributorCode: ").Append(DistributorCode).Append("\n");
            sb.Append("  DistributorPassword: ").Append(DistributorPassword).Append("\n");
            sb.Append("  EnablePreAuth: ").Append(EnablePreAuth).Append("\n");
            sb.Append("  EnvelopePartitionId: ").Append(EnvelopePartitionId).Append("\n");
            sb.Append("  InitialUser: ").Append(InitialUser).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentProcessor: ").Append(PaymentProcessor).Append("\n");
            sb.Append("  PaymentProcessorInformation: ").Append(PaymentProcessorInformation).Append("\n");
            sb.Append("  PlanInformation: ").Append(PlanInformation).Append("\n");
            sb.Append("  ProcessPayment: ").Append(ProcessPayment).Append("\n");
            sb.Append("  ReferralInformation: ").Append(ReferralInformation).Append("\n");
            sb.Append("  SocialAccountInformation: ").Append(SocialAccountInformation).Append("\n");
            sb.Append("  TaxExemptId: ").Append(TaxExemptId).Append("\n");
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
            return this.Equals(obj as NewAccountDefinition);
        }

        /// <summary>
        /// Returns true if NewAccountDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of NewAccountDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAccountDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.AccountSettings == other.AccountSettings ||
                    this.AccountSettings != null &&
                    this.AccountSettings.Equals(other.AccountSettings)
                ) && 
                (
                    this.AddressInformation == other.AddressInformation ||
                    this.AddressInformation != null &&
                    this.AddressInformation.Equals(other.AddressInformation)
                ) && 
                (
                    this.CreditCardInformation == other.CreditCardInformation ||
                    this.CreditCardInformation != null &&
                    this.CreditCardInformation.Equals(other.CreditCardInformation)
                ) && 
                (
                    this.DirectDebitProcessorInformation == other.DirectDebitProcessorInformation ||
                    this.DirectDebitProcessorInformation != null &&
                    this.DirectDebitProcessorInformation.Equals(other.DirectDebitProcessorInformation)
                ) && 
                (
                    this.DistributorCode == other.DistributorCode ||
                    this.DistributorCode != null &&
                    this.DistributorCode.Equals(other.DistributorCode)
                ) && 
                (
                    this.DistributorPassword == other.DistributorPassword ||
                    this.DistributorPassword != null &&
                    this.DistributorPassword.Equals(other.DistributorPassword)
                ) && 
                (
                    this.EnablePreAuth == other.EnablePreAuth ||
                    this.EnablePreAuth != null &&
                    this.EnablePreAuth.Equals(other.EnablePreAuth)
                ) && 
                (
                    this.EnvelopePartitionId == other.EnvelopePartitionId ||
                    this.EnvelopePartitionId != null &&
                    this.EnvelopePartitionId.Equals(other.EnvelopePartitionId)
                ) && 
                (
                    this.InitialUser == other.InitialUser ||
                    this.InitialUser != null &&
                    this.InitialUser.Equals(other.InitialUser)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.PaymentProcessor == other.PaymentProcessor ||
                    this.PaymentProcessor != null &&
                    this.PaymentProcessor.Equals(other.PaymentProcessor)
                ) && 
                (
                    this.PaymentProcessorInformation == other.PaymentProcessorInformation ||
                    this.PaymentProcessorInformation != null &&
                    this.PaymentProcessorInformation.Equals(other.PaymentProcessorInformation)
                ) && 
                (
                    this.PlanInformation == other.PlanInformation ||
                    this.PlanInformation != null &&
                    this.PlanInformation.Equals(other.PlanInformation)
                ) && 
                (
                    this.ProcessPayment == other.ProcessPayment ||
                    this.ProcessPayment != null &&
                    this.ProcessPayment.Equals(other.ProcessPayment)
                ) && 
                (
                    this.ReferralInformation == other.ReferralInformation ||
                    this.ReferralInformation != null &&
                    this.ReferralInformation.Equals(other.ReferralInformation)
                ) && 
                (
                    this.SocialAccountInformation == other.SocialAccountInformation ||
                    this.SocialAccountInformation != null &&
                    this.SocialAccountInformation.Equals(other.SocialAccountInformation)
                ) && 
                (
                    this.TaxExemptId == other.TaxExemptId ||
                    this.TaxExemptId != null &&
                    this.TaxExemptId.Equals(other.TaxExemptId)
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
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.AccountSettings != null)
                    hash = hash * 59 + this.AccountSettings.GetHashCode();
                if (this.AddressInformation != null)
                    hash = hash * 59 + this.AddressInformation.GetHashCode();
                if (this.CreditCardInformation != null)
                    hash = hash * 59 + this.CreditCardInformation.GetHashCode();
                if (this.DirectDebitProcessorInformation != null)
                    hash = hash * 59 + this.DirectDebitProcessorInformation.GetHashCode();
                if (this.DistributorCode != null)
                    hash = hash * 59 + this.DistributorCode.GetHashCode();
                if (this.DistributorPassword != null)
                    hash = hash * 59 + this.DistributorPassword.GetHashCode();
                if (this.EnablePreAuth != null)
                    hash = hash * 59 + this.EnablePreAuth.GetHashCode();
                if (this.EnvelopePartitionId != null)
                    hash = hash * 59 + this.EnvelopePartitionId.GetHashCode();
                if (this.InitialUser != null)
                    hash = hash * 59 + this.InitialUser.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentProcessor != null)
                    hash = hash * 59 + this.PaymentProcessor.GetHashCode();
                if (this.PaymentProcessorInformation != null)
                    hash = hash * 59 + this.PaymentProcessorInformation.GetHashCode();
                if (this.PlanInformation != null)
                    hash = hash * 59 + this.PlanInformation.GetHashCode();
                if (this.ProcessPayment != null)
                    hash = hash * 59 + this.ProcessPayment.GetHashCode();
                if (this.ReferralInformation != null)
                    hash = hash * 59 + this.ReferralInformation.GetHashCode();
                if (this.SocialAccountInformation != null)
                    hash = hash * 59 + this.SocialAccountInformation.GetHashCode();
                if (this.TaxExemptId != null)
                    hash = hash * 59 + this.TaxExemptId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
