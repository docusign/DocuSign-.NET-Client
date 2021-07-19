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
    /// Contains information about an account billing plan.
    /// </summary>
    [DataContract]
    public partial class AccountBillingPlan :  IEquatable<AccountBillingPlan>, IValidatableObject
    {
        public AccountBillingPlan()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBillingPlan" /> class.
        /// </summary>
        /// <param name="AddOns">Reserved:.</param>
        /// <param name="AppStoreReceiptExpirationDate">AppStoreReceiptExpirationDate.</param>
        /// <param name="AppStoreReceiptPurchaseDate">AppStoreReceiptPurchaseDate.</param>
        /// <param name="CanCancelRenewal">Reserved: TBD.</param>
        /// <param name="CanUpgrade">When set to **true**, specifies that you can upgrade the account through the API..</param>
        /// <param name="CurrencyCode">Specifies the ISO currency code for the account..</param>
        /// <param name="DowngradePlanInformation">DowngradePlanInformation.</param>
        /// <param name="EnableSupport">When set to **true**, then customer support is provided as part of the account plan..</param>
        /// <param name="IncludedSeats">The number of seats (users) included..</param>
        /// <param name="IncrementalSeats">Reserved: TBD.</param>
        /// <param name="IsDowngrade">IsDowngrade.</param>
        /// <param name="NotificationType">NotificationType.</param>
        /// <param name="OtherDiscountPercent"> Any other percentage discount for the plan. .</param>
        /// <param name="PaymentCycle">PaymentCycle.</param>
        /// <param name="PaymentMethod"> The payment method used with the plan. The possible values are: CreditCard, PurchaseOrder, Premium, or Freemium. .</param>
        /// <param name="PerSeatPrice">PerSeatPrice.</param>
        /// <param name="PlanClassification">Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free..</param>
        /// <param name="PlanFeatureSets">A complex type that sets the feature sets for the account. It contains the following information (all string content):  * currencyFeatureSetPrices - Contains the currencyCode and currencySymbol for the alternate currency values for envelopeFee, fixedFee, seatFee that are configured for this plan feature set. * envelopeFee - An incremental envelope cost for plans with envelope overages (when isEnabled&#x3D;true). * featureSetId - A unique ID for the feature set. * fixedFee - A one-time fee associated with the plan (when isEnabled&#x3D;true). * isActive - Specifies whether the feature set is actively set as part of the plan. * isEnabled - Specifies whether the feature set is actively enabled as part of the plan. * name - The name of the feature set. * seatFee - An incremental seat cost for seat-based plans (when isEnabled&#x3D;true). .</param>
        /// <param name="PlanId">PlanId.</param>
        /// <param name="PlanName">The name of the Billing Plan..</param>
        /// <param name="PlanStartDate">PlanStartDate.</param>
        /// <param name="RenewalDate">RenewalDate.</param>
        /// <param name="RenewalStatus">The renewal status for the account. The acceptable values are:  * auto: The account automatically renews. * queued_for_close: Account will be closed at the billingPeriodEndDate. * queued_for_downgrade: Account will be downgraded at the billingPeriodEndDate..</param>
        /// <param name="SeatDiscounts"> A complex type that contains any seat discount information.  Values are: BeginSeatCount, EndSeatCount, and SeatDiscountPercent.  .</param>
        /// <param name="SupportIncidentFee">The support incident fee charged for each support incident..</param>
        /// <param name="SupportPlanFee">The support plan fee charged for this plan..</param>
        public AccountBillingPlan(List<AddOn> AddOns = default(List<AddOn>), string AppStoreReceiptExpirationDate = default(string), string AppStoreReceiptPurchaseDate = default(string), string CanCancelRenewal = default(string), string CanUpgrade = default(string), string CurrencyCode = default(string), DowngradePlanUpdateResponse DowngradePlanInformation = default(DowngradePlanUpdateResponse), string EnableSupport = default(string), string IncludedSeats = default(string), string IncrementalSeats = default(string), string IsDowngrade = default(string), string NotificationType = default(string), string OtherDiscountPercent = default(string), string PaymentCycle = default(string), string PaymentMethod = default(string), string PerSeatPrice = default(string), string PlanClassification = default(string), List<FeatureSet> PlanFeatureSets = default(List<FeatureSet>), string PlanId = default(string), string PlanName = default(string), string PlanStartDate = default(string), string RenewalDate = default(string), string RenewalStatus = default(string), List<SeatDiscount> SeatDiscounts = default(List<SeatDiscount>), string SupportIncidentFee = default(string), string SupportPlanFee = default(string))
        {
            this.AddOns = AddOns;
            this.AppStoreReceiptExpirationDate = AppStoreReceiptExpirationDate;
            this.AppStoreReceiptPurchaseDate = AppStoreReceiptPurchaseDate;
            this.CanCancelRenewal = CanCancelRenewal;
            this.CanUpgrade = CanUpgrade;
            this.CurrencyCode = CurrencyCode;
            this.DowngradePlanInformation = DowngradePlanInformation;
            this.EnableSupport = EnableSupport;
            this.IncludedSeats = IncludedSeats;
            this.IncrementalSeats = IncrementalSeats;
            this.IsDowngrade = IsDowngrade;
            this.NotificationType = NotificationType;
            this.OtherDiscountPercent = OtherDiscountPercent;
            this.PaymentCycle = PaymentCycle;
            this.PaymentMethod = PaymentMethod;
            this.PerSeatPrice = PerSeatPrice;
            this.PlanClassification = PlanClassification;
            this.PlanFeatureSets = PlanFeatureSets;
            this.PlanId = PlanId;
            this.PlanName = PlanName;
            this.PlanStartDate = PlanStartDate;
            this.RenewalDate = RenewalDate;
            this.RenewalStatus = RenewalStatus;
            this.SeatDiscounts = SeatDiscounts;
            this.SupportIncidentFee = SupportIncidentFee;
            this.SupportPlanFee = SupportPlanFee;
        }
        
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="addOns", EmitDefaultValue=false)]
        public List<AddOn> AddOns { get; set; }
        /// <summary>
        /// Gets or Sets AppStoreReceiptExpirationDate
        /// </summary>
        [DataMember(Name="appStoreReceiptExpirationDate", EmitDefaultValue=false)]
        public string AppStoreReceiptExpirationDate { get; set; }
        /// <summary>
        /// Gets or Sets AppStoreReceiptPurchaseDate
        /// </summary>
        [DataMember(Name="appStoreReceiptPurchaseDate", EmitDefaultValue=false)]
        public string AppStoreReceiptPurchaseDate { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="canCancelRenewal", EmitDefaultValue=false)]
        public string CanCancelRenewal { get; set; }
        /// <summary>
        /// When set to **true**, specifies that you can upgrade the account through the API.
        /// </summary>
        /// <value>When set to **true**, specifies that you can upgrade the account through the API.</value>
        [DataMember(Name="canUpgrade", EmitDefaultValue=false)]
        public string CanUpgrade { get; set; }
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets DowngradePlanInformation
        /// </summary>
        [DataMember(Name="downgradePlanInformation", EmitDefaultValue=false)]
        public DowngradePlanUpdateResponse DowngradePlanInformation { get; set; }
        /// <summary>
        /// When set to **true**, then customer support is provided as part of the account plan.
        /// </summary>
        /// <value>When set to **true**, then customer support is provided as part of the account plan.</value>
        [DataMember(Name="enableSupport", EmitDefaultValue=false)]
        public string EnableSupport { get; set; }
        /// <summary>
        /// The number of seats (users) included.
        /// </summary>
        /// <value>The number of seats (users) included.</value>
        [DataMember(Name="includedSeats", EmitDefaultValue=false)]
        public string IncludedSeats { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="incrementalSeats", EmitDefaultValue=false)]
        public string IncrementalSeats { get; set; }
        /// <summary>
        /// Gets or Sets IsDowngrade
        /// </summary>
        [DataMember(Name="isDowngrade", EmitDefaultValue=false)]
        public string IsDowngrade { get; set; }
        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [DataMember(Name="notificationType", EmitDefaultValue=false)]
        public string NotificationType { get; set; }
        /// <summary>
        ///  Any other percentage discount for the plan. 
        /// </summary>
        /// <value> Any other percentage discount for the plan. </value>
        [DataMember(Name="otherDiscountPercent", EmitDefaultValue=false)]
        public string OtherDiscountPercent { get; set; }
        /// <summary>
        /// Gets or Sets PaymentCycle
        /// </summary>
        [DataMember(Name="paymentCycle", EmitDefaultValue=false)]
        public string PaymentCycle { get; set; }
        /// <summary>
        ///  The payment method used with the plan. The possible values are: CreditCard, PurchaseOrder, Premium, or Freemium. 
        /// </summary>
        /// <value> The payment method used with the plan. The possible values are: CreditCard, PurchaseOrder, Premium, or Freemium. </value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Gets or Sets PerSeatPrice
        /// </summary>
        [DataMember(Name="perSeatPrice", EmitDefaultValue=false)]
        public string PerSeatPrice { get; set; }
        /// <summary>
        /// Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free.
        /// </summary>
        /// <value>Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free.</value>
        [DataMember(Name="planClassification", EmitDefaultValue=false)]
        public string PlanClassification { get; set; }
        /// <summary>
        /// A complex type that sets the feature sets for the account. It contains the following information (all string content):  * currencyFeatureSetPrices - Contains the currencyCode and currencySymbol for the alternate currency values for envelopeFee, fixedFee, seatFee that are configured for this plan feature set. * envelopeFee - An incremental envelope cost for plans with envelope overages (when isEnabled&#x3D;true). * featureSetId - A unique ID for the feature set. * fixedFee - A one-time fee associated with the plan (when isEnabled&#x3D;true). * isActive - Specifies whether the feature set is actively set as part of the plan. * isEnabled - Specifies whether the feature set is actively enabled as part of the plan. * name - The name of the feature set. * seatFee - An incremental seat cost for seat-based plans (when isEnabled&#x3D;true). 
        /// </summary>
        /// <value>A complex type that sets the feature sets for the account. It contains the following information (all string content):  * currencyFeatureSetPrices - Contains the currencyCode and currencySymbol for the alternate currency values for envelopeFee, fixedFee, seatFee that are configured for this plan feature set. * envelopeFee - An incremental envelope cost for plans with envelope overages (when isEnabled&#x3D;true). * featureSetId - A unique ID for the feature set. * fixedFee - A one-time fee associated with the plan (when isEnabled&#x3D;true). * isActive - Specifies whether the feature set is actively set as part of the plan. * isEnabled - Specifies whether the feature set is actively enabled as part of the plan. * name - The name of the feature set. * seatFee - An incremental seat cost for seat-based plans (when isEnabled&#x3D;true). </value>
        [DataMember(Name="planFeatureSets", EmitDefaultValue=false)]
        public List<FeatureSet> PlanFeatureSets { get; set; }
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="planId", EmitDefaultValue=false)]
        public string PlanId { get; set; }
        /// <summary>
        /// The name of the Billing Plan.
        /// </summary>
        /// <value>The name of the Billing Plan.</value>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }
        /// <summary>
        /// Gets or Sets PlanStartDate
        /// </summary>
        [DataMember(Name="planStartDate", EmitDefaultValue=false)]
        public string PlanStartDate { get; set; }
        /// <summary>
        /// Gets or Sets RenewalDate
        /// </summary>
        [DataMember(Name="renewalDate", EmitDefaultValue=false)]
        public string RenewalDate { get; set; }
        /// <summary>
        /// The renewal status for the account. The acceptable values are:  * auto: The account automatically renews. * queued_for_close: Account will be closed at the billingPeriodEndDate. * queued_for_downgrade: Account will be downgraded at the billingPeriodEndDate.
        /// </summary>
        /// <value>The renewal status for the account. The acceptable values are:  * auto: The account automatically renews. * queued_for_close: Account will be closed at the billingPeriodEndDate. * queued_for_downgrade: Account will be downgraded at the billingPeriodEndDate.</value>
        [DataMember(Name="renewalStatus", EmitDefaultValue=false)]
        public string RenewalStatus { get; set; }
        /// <summary>
        ///  A complex type that contains any seat discount information.  Values are: BeginSeatCount, EndSeatCount, and SeatDiscountPercent.  
        /// </summary>
        /// <value> A complex type that contains any seat discount information.  Values are: BeginSeatCount, EndSeatCount, and SeatDiscountPercent.  </value>
        [DataMember(Name="seatDiscounts", EmitDefaultValue=false)]
        public List<SeatDiscount> SeatDiscounts { get; set; }
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
            sb.Append("class AccountBillingPlan {\n");
            sb.Append("  AddOns: ").Append(AddOns).Append("\n");
            sb.Append("  AppStoreReceiptExpirationDate: ").Append(AppStoreReceiptExpirationDate).Append("\n");
            sb.Append("  AppStoreReceiptPurchaseDate: ").Append(AppStoreReceiptPurchaseDate).Append("\n");
            sb.Append("  CanCancelRenewal: ").Append(CanCancelRenewal).Append("\n");
            sb.Append("  CanUpgrade: ").Append(CanUpgrade).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DowngradePlanInformation: ").Append(DowngradePlanInformation).Append("\n");
            sb.Append("  EnableSupport: ").Append(EnableSupport).Append("\n");
            sb.Append("  IncludedSeats: ").Append(IncludedSeats).Append("\n");
            sb.Append("  IncrementalSeats: ").Append(IncrementalSeats).Append("\n");
            sb.Append("  IsDowngrade: ").Append(IsDowngrade).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  OtherDiscountPercent: ").Append(OtherDiscountPercent).Append("\n");
            sb.Append("  PaymentCycle: ").Append(PaymentCycle).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PerSeatPrice: ").Append(PerSeatPrice).Append("\n");
            sb.Append("  PlanClassification: ").Append(PlanClassification).Append("\n");
            sb.Append("  PlanFeatureSets: ").Append(PlanFeatureSets).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  PlanStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  RenewalDate: ").Append(RenewalDate).Append("\n");
            sb.Append("  RenewalStatus: ").Append(RenewalStatus).Append("\n");
            sb.Append("  SeatDiscounts: ").Append(SeatDiscounts).Append("\n");
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
            return this.Equals(obj as AccountBillingPlan);
        }

        /// <summary>
        /// Returns true if AccountBillingPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountBillingPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountBillingPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddOns == other.AddOns ||
                    this.AddOns != null &&
                    this.AddOns.SequenceEqual(other.AddOns)
                ) && 
                (
                    this.AppStoreReceiptExpirationDate == other.AppStoreReceiptExpirationDate ||
                    this.AppStoreReceiptExpirationDate != null &&
                    this.AppStoreReceiptExpirationDate.Equals(other.AppStoreReceiptExpirationDate)
                ) && 
                (
                    this.AppStoreReceiptPurchaseDate == other.AppStoreReceiptPurchaseDate ||
                    this.AppStoreReceiptPurchaseDate != null &&
                    this.AppStoreReceiptPurchaseDate.Equals(other.AppStoreReceiptPurchaseDate)
                ) && 
                (
                    this.CanCancelRenewal == other.CanCancelRenewal ||
                    this.CanCancelRenewal != null &&
                    this.CanCancelRenewal.Equals(other.CanCancelRenewal)
                ) && 
                (
                    this.CanUpgrade == other.CanUpgrade ||
                    this.CanUpgrade != null &&
                    this.CanUpgrade.Equals(other.CanUpgrade)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.DowngradePlanInformation == other.DowngradePlanInformation ||
                    this.DowngradePlanInformation != null &&
                    this.DowngradePlanInformation.Equals(other.DowngradePlanInformation)
                ) && 
                (
                    this.EnableSupport == other.EnableSupport ||
                    this.EnableSupport != null &&
                    this.EnableSupport.Equals(other.EnableSupport)
                ) && 
                (
                    this.IncludedSeats == other.IncludedSeats ||
                    this.IncludedSeats != null &&
                    this.IncludedSeats.Equals(other.IncludedSeats)
                ) && 
                (
                    this.IncrementalSeats == other.IncrementalSeats ||
                    this.IncrementalSeats != null &&
                    this.IncrementalSeats.Equals(other.IncrementalSeats)
                ) && 
                (
                    this.IsDowngrade == other.IsDowngrade ||
                    this.IsDowngrade != null &&
                    this.IsDowngrade.Equals(other.IsDowngrade)
                ) && 
                (
                    this.NotificationType == other.NotificationType ||
                    this.NotificationType != null &&
                    this.NotificationType.Equals(other.NotificationType)
                ) && 
                (
                    this.OtherDiscountPercent == other.OtherDiscountPercent ||
                    this.OtherDiscountPercent != null &&
                    this.OtherDiscountPercent.Equals(other.OtherDiscountPercent)
                ) && 
                (
                    this.PaymentCycle == other.PaymentCycle ||
                    this.PaymentCycle != null &&
                    this.PaymentCycle.Equals(other.PaymentCycle)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.PerSeatPrice == other.PerSeatPrice ||
                    this.PerSeatPrice != null &&
                    this.PerSeatPrice.Equals(other.PerSeatPrice)
                ) && 
                (
                    this.PlanClassification == other.PlanClassification ||
                    this.PlanClassification != null &&
                    this.PlanClassification.Equals(other.PlanClassification)
                ) && 
                (
                    this.PlanFeatureSets == other.PlanFeatureSets ||
                    this.PlanFeatureSets != null &&
                    this.PlanFeatureSets.SequenceEqual(other.PlanFeatureSets)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.PlanName == other.PlanName ||
                    this.PlanName != null &&
                    this.PlanName.Equals(other.PlanName)
                ) && 
                (
                    this.PlanStartDate == other.PlanStartDate ||
                    this.PlanStartDate != null &&
                    this.PlanStartDate.Equals(other.PlanStartDate)
                ) && 
                (
                    this.RenewalDate == other.RenewalDate ||
                    this.RenewalDate != null &&
                    this.RenewalDate.Equals(other.RenewalDate)
                ) && 
                (
                    this.RenewalStatus == other.RenewalStatus ||
                    this.RenewalStatus != null &&
                    this.RenewalStatus.Equals(other.RenewalStatus)
                ) && 
                (
                    this.SeatDiscounts == other.SeatDiscounts ||
                    this.SeatDiscounts != null &&
                    this.SeatDiscounts.SequenceEqual(other.SeatDiscounts)
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
                if (this.AddOns != null)
                    hash = hash * 59 + this.AddOns.GetHashCode();
                if (this.AppStoreReceiptExpirationDate != null)
                    hash = hash * 59 + this.AppStoreReceiptExpirationDate.GetHashCode();
                if (this.AppStoreReceiptPurchaseDate != null)
                    hash = hash * 59 + this.AppStoreReceiptPurchaseDate.GetHashCode();
                if (this.CanCancelRenewal != null)
                    hash = hash * 59 + this.CanCancelRenewal.GetHashCode();
                if (this.CanUpgrade != null)
                    hash = hash * 59 + this.CanUpgrade.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.DowngradePlanInformation != null)
                    hash = hash * 59 + this.DowngradePlanInformation.GetHashCode();
                if (this.EnableSupport != null)
                    hash = hash * 59 + this.EnableSupport.GetHashCode();
                if (this.IncludedSeats != null)
                    hash = hash * 59 + this.IncludedSeats.GetHashCode();
                if (this.IncrementalSeats != null)
                    hash = hash * 59 + this.IncrementalSeats.GetHashCode();
                if (this.IsDowngrade != null)
                    hash = hash * 59 + this.IsDowngrade.GetHashCode();
                if (this.NotificationType != null)
                    hash = hash * 59 + this.NotificationType.GetHashCode();
                if (this.OtherDiscountPercent != null)
                    hash = hash * 59 + this.OtherDiscountPercent.GetHashCode();
                if (this.PaymentCycle != null)
                    hash = hash * 59 + this.PaymentCycle.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.PerSeatPrice != null)
                    hash = hash * 59 + this.PerSeatPrice.GetHashCode();
                if (this.PlanClassification != null)
                    hash = hash * 59 + this.PlanClassification.GetHashCode();
                if (this.PlanFeatureSets != null)
                    hash = hash * 59 + this.PlanFeatureSets.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.PlanName != null)
                    hash = hash * 59 + this.PlanName.GetHashCode();
                if (this.PlanStartDate != null)
                    hash = hash * 59 + this.PlanStartDate.GetHashCode();
                if (this.RenewalDate != null)
                    hash = hash * 59 + this.RenewalDate.GetHashCode();
                if (this.RenewalStatus != null)
                    hash = hash * 59 + this.RenewalStatus.GetHashCode();
                if (this.SeatDiscounts != null)
                    hash = hash * 59 + this.SeatDiscounts.GetHashCode();
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
