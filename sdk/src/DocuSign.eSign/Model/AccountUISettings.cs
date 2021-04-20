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
    /// AccountUISettings
    /// </summary>
    [DataContract]
    public partial class AccountUISettings :  IEquatable<AccountUISettings>, IValidatableObject
    {
        public AccountUISettings()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUISettings" /> class.
        /// </summary>
        /// <param name="AdminMessage">AdminMessage.</param>
        /// <param name="AskAnAdmin">AskAnAdmin.</param>
        /// <param name="EnableAdminMessage">EnableAdminMessage.</param>
        /// <param name="EnableAdminMessageMetadata">EnableAdminMessageMetadata.</param>
        /// <param name="EnableAdvancedPaymentsReactEdit">EnableAdvancedPaymentsReactEdit.</param>
        /// <param name="EnableEasySignCanUseMultiTemplateApply">EnableEasySignCanUseMultiTemplateApply.</param>
        /// <param name="EnableEasySignCanUseMultiTemplateApplyMetadata">EnableEasySignCanUseMultiTemplateApplyMetadata.</param>
        /// <param name="EnableEasySignTemplateUpload">EnableEasySignTemplateUpload.</param>
        /// <param name="EnableEasySignTemplateUploadMetadata">EnableEasySignTemplateUploadMetadata.</param>
        /// <param name="EnableEnvelopeCopyWithData">EnableEnvelopeCopyWithData.</param>
        /// <param name="EnableEnvelopeCopyWithDataMetadata">EnableEnvelopeCopyWithDataMetadata.</param>
        /// <param name="EnableLegacyHomepageLink">EnableLegacyHomepageLink.</param>
        /// <param name="EnableLegacyHomepageLinkMetadata">EnableLegacyHomepageLinkMetadata.</param>
        /// <param name="HasExternalLinkedAccounts">HasExternalLinkedAccounts.</param>
        /// <param name="HasExternalLinkedAccountsMetadata">HasExternalLinkedAccountsMetadata.</param>
        /// <param name="HideSendAnEnvelope">HideSendAnEnvelope.</param>
        /// <param name="HideSendAnEnvelopeMetadata">HideSendAnEnvelopeMetadata.</param>
        /// <param name="HideUseATemplate">HideUseATemplate.</param>
        /// <param name="HideUseATemplateInPrepare">HideUseATemplateInPrepare.</param>
        /// <param name="HideUseATemplateInPrepareMetadata">HideUseATemplateInPrepareMetadata.</param>
        /// <param name="HideUseATemplateMetadata">HideUseATemplateMetadata.</param>
        /// <param name="OrderBasedRecipientIdGeneration">OrderBasedRecipientIdGeneration.</param>
        /// <param name="OrderBasedRecipientIdGenerationMetadata">OrderBasedRecipientIdGenerationMetadata.</param>
        /// <param name="RemoveEnvelopeForwarding">RemoveEnvelopeForwarding.</param>
        /// <param name="RemoveEnvelopeForwardingMetadata">RemoveEnvelopeForwardingMetadata.</param>
        /// <param name="ShouldRedactAccessCode">ShouldRedactAccessCode.</param>
        /// <param name="ShouldRedactAccessCodeMetadata">ShouldRedactAccessCodeMetadata.</param>
        /// <param name="UploadNewImageToSignOrInitial">UploadNewImageToSignOrInitial.</param>
        /// <param name="UploadNewImageToSignOrInitialMetadata">UploadNewImageToSignOrInitialMetadata.</param>
        public AccountUISettings(AdminMessage AdminMessage = default(AdminMessage), AskAnAdmin AskAnAdmin = default(AskAnAdmin), string EnableAdminMessage = default(string), SettingsMetadata EnableAdminMessageMetadata = default(SettingsMetadata), string EnableAdvancedPaymentsReactEdit = default(string), string EnableEasySignCanUseMultiTemplateApply = default(string), SettingsMetadata EnableEasySignCanUseMultiTemplateApplyMetadata = default(SettingsMetadata), string EnableEasySignTemplateUpload = default(string), SettingsMetadata EnableEasySignTemplateUploadMetadata = default(SettingsMetadata), string EnableEnvelopeCopyWithData = default(string), SettingsMetadata EnableEnvelopeCopyWithDataMetadata = default(SettingsMetadata), string EnableLegacyHomepageLink = default(string), SettingsMetadata EnableLegacyHomepageLinkMetadata = default(SettingsMetadata), string HasExternalLinkedAccounts = default(string), SettingsMetadata HasExternalLinkedAccountsMetadata = default(SettingsMetadata), string HideSendAnEnvelope = default(string), SettingsMetadata HideSendAnEnvelopeMetadata = default(SettingsMetadata), string HideUseATemplate = default(string), string HideUseATemplateInPrepare = default(string), SettingsMetadata HideUseATemplateInPrepareMetadata = default(SettingsMetadata), SettingsMetadata HideUseATemplateMetadata = default(SettingsMetadata), string OrderBasedRecipientIdGeneration = default(string), SettingsMetadata OrderBasedRecipientIdGenerationMetadata = default(SettingsMetadata), string RemoveEnvelopeForwarding = default(string), SettingsMetadata RemoveEnvelopeForwardingMetadata = default(SettingsMetadata), string ShouldRedactAccessCode = default(string), SettingsMetadata ShouldRedactAccessCodeMetadata = default(SettingsMetadata), string UploadNewImageToSignOrInitial = default(string), SettingsMetadata UploadNewImageToSignOrInitialMetadata = default(SettingsMetadata))
        {
            this.AdminMessage = AdminMessage;
            this.AskAnAdmin = AskAnAdmin;
            this.EnableAdminMessage = EnableAdminMessage;
            this.EnableAdminMessageMetadata = EnableAdminMessageMetadata;
            this.EnableAdvancedPaymentsReactEdit = EnableAdvancedPaymentsReactEdit;
            this.EnableEasySignCanUseMultiTemplateApply = EnableEasySignCanUseMultiTemplateApply;
            this.EnableEasySignCanUseMultiTemplateApplyMetadata = EnableEasySignCanUseMultiTemplateApplyMetadata;
            this.EnableEasySignTemplateUpload = EnableEasySignTemplateUpload;
            this.EnableEasySignTemplateUploadMetadata = EnableEasySignTemplateUploadMetadata;
            this.EnableEnvelopeCopyWithData = EnableEnvelopeCopyWithData;
            this.EnableEnvelopeCopyWithDataMetadata = EnableEnvelopeCopyWithDataMetadata;
            this.EnableLegacyHomepageLink = EnableLegacyHomepageLink;
            this.EnableLegacyHomepageLinkMetadata = EnableLegacyHomepageLinkMetadata;
            this.HasExternalLinkedAccounts = HasExternalLinkedAccounts;
            this.HasExternalLinkedAccountsMetadata = HasExternalLinkedAccountsMetadata;
            this.HideSendAnEnvelope = HideSendAnEnvelope;
            this.HideSendAnEnvelopeMetadata = HideSendAnEnvelopeMetadata;
            this.HideUseATemplate = HideUseATemplate;
            this.HideUseATemplateInPrepare = HideUseATemplateInPrepare;
            this.HideUseATemplateInPrepareMetadata = HideUseATemplateInPrepareMetadata;
            this.HideUseATemplateMetadata = HideUseATemplateMetadata;
            this.OrderBasedRecipientIdGeneration = OrderBasedRecipientIdGeneration;
            this.OrderBasedRecipientIdGenerationMetadata = OrderBasedRecipientIdGenerationMetadata;
            this.RemoveEnvelopeForwarding = RemoveEnvelopeForwarding;
            this.RemoveEnvelopeForwardingMetadata = RemoveEnvelopeForwardingMetadata;
            this.ShouldRedactAccessCode = ShouldRedactAccessCode;
            this.ShouldRedactAccessCodeMetadata = ShouldRedactAccessCodeMetadata;
            this.UploadNewImageToSignOrInitial = UploadNewImageToSignOrInitial;
            this.UploadNewImageToSignOrInitialMetadata = UploadNewImageToSignOrInitialMetadata;
        }
        
        /// <summary>
        /// Gets or Sets AdminMessage
        /// </summary>
        [DataMember(Name="adminMessage", EmitDefaultValue=false)]
        public AdminMessage AdminMessage { get; set; }
        /// <summary>
        /// Gets or Sets AskAnAdmin
        /// </summary>
        [DataMember(Name="askAnAdmin", EmitDefaultValue=false)]
        public AskAnAdmin AskAnAdmin { get; set; }
        /// <summary>
        /// Gets or Sets EnableAdminMessage
        /// </summary>
        [DataMember(Name="enableAdminMessage", EmitDefaultValue=false)]
        public string EnableAdminMessage { get; set; }
        /// <summary>
        /// Gets or Sets EnableAdminMessageMetadata
        /// </summary>
        [DataMember(Name="enableAdminMessageMetadata", EmitDefaultValue=false)]
        public SettingsMetadata EnableAdminMessageMetadata { get; set; }
        /// <summary>
        /// Gets or Sets EnableAdvancedPaymentsReactEdit
        /// </summary>
        [DataMember(Name="enableAdvancedPaymentsReactEdit", EmitDefaultValue=false)]
        public string EnableAdvancedPaymentsReactEdit { get; set; }
        /// <summary>
        /// Gets or Sets EnableEasySignCanUseMultiTemplateApply
        /// </summary>
        [DataMember(Name="enableEasySignCanUseMultiTemplateApply", EmitDefaultValue=false)]
        public string EnableEasySignCanUseMultiTemplateApply { get; set; }
        /// <summary>
        /// Gets or Sets EnableEasySignCanUseMultiTemplateApplyMetadata
        /// </summary>
        [DataMember(Name="enableEasySignCanUseMultiTemplateApplyMetadata", EmitDefaultValue=false)]
        public SettingsMetadata EnableEasySignCanUseMultiTemplateApplyMetadata { get; set; }
        /// <summary>
        /// Gets or Sets EnableEasySignTemplateUpload
        /// </summary>
        [DataMember(Name="enableEasySignTemplateUpload", EmitDefaultValue=false)]
        public string EnableEasySignTemplateUpload { get; set; }
        /// <summary>
        /// Gets or Sets EnableEasySignTemplateUploadMetadata
        /// </summary>
        [DataMember(Name="enableEasySignTemplateUploadMetadata", EmitDefaultValue=false)]
        public SettingsMetadata EnableEasySignTemplateUploadMetadata { get; set; }
        /// <summary>
        /// Gets or Sets EnableEnvelopeCopyWithData
        /// </summary>
        [DataMember(Name="enableEnvelopeCopyWithData", EmitDefaultValue=false)]
        public string EnableEnvelopeCopyWithData { get; set; }
        /// <summary>
        /// Gets or Sets EnableEnvelopeCopyWithDataMetadata
        /// </summary>
        [DataMember(Name="enableEnvelopeCopyWithDataMetadata", EmitDefaultValue=false)]
        public SettingsMetadata EnableEnvelopeCopyWithDataMetadata { get; set; }
        /// <summary>
        /// Gets or Sets EnableLegacyHomepageLink
        /// </summary>
        [DataMember(Name="enableLegacyHomepageLink", EmitDefaultValue=false)]
        public string EnableLegacyHomepageLink { get; set; }
        /// <summary>
        /// Gets or Sets EnableLegacyHomepageLinkMetadata
        /// </summary>
        [DataMember(Name="enableLegacyHomepageLinkMetadata", EmitDefaultValue=false)]
        public SettingsMetadata EnableLegacyHomepageLinkMetadata { get; set; }
        /// <summary>
        /// Gets or Sets HasExternalLinkedAccounts
        /// </summary>
        [DataMember(Name="hasExternalLinkedAccounts", EmitDefaultValue=false)]
        public string HasExternalLinkedAccounts { get; set; }
        /// <summary>
        /// Gets or Sets HasExternalLinkedAccountsMetadata
        /// </summary>
        [DataMember(Name="hasExternalLinkedAccountsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata HasExternalLinkedAccountsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets HideSendAnEnvelope
        /// </summary>
        [DataMember(Name="hideSendAnEnvelope", EmitDefaultValue=false)]
        public string HideSendAnEnvelope { get; set; }
        /// <summary>
        /// Gets or Sets HideSendAnEnvelopeMetadata
        /// </summary>
        [DataMember(Name="hideSendAnEnvelopeMetadata", EmitDefaultValue=false)]
        public SettingsMetadata HideSendAnEnvelopeMetadata { get; set; }
        /// <summary>
        /// Gets or Sets HideUseATemplate
        /// </summary>
        [DataMember(Name="hideUseATemplate", EmitDefaultValue=false)]
        public string HideUseATemplate { get; set; }
        /// <summary>
        /// Gets or Sets HideUseATemplateInPrepare
        /// </summary>
        [DataMember(Name="hideUseATemplateInPrepare", EmitDefaultValue=false)]
        public string HideUseATemplateInPrepare { get; set; }
        /// <summary>
        /// Gets or Sets HideUseATemplateInPrepareMetadata
        /// </summary>
        [DataMember(Name="hideUseATemplateInPrepareMetadata", EmitDefaultValue=false)]
        public SettingsMetadata HideUseATemplateInPrepareMetadata { get; set; }
        /// <summary>
        /// Gets or Sets HideUseATemplateMetadata
        /// </summary>
        [DataMember(Name="hideUseATemplateMetadata", EmitDefaultValue=false)]
        public SettingsMetadata HideUseATemplateMetadata { get; set; }
        /// <summary>
        /// Gets or Sets OrderBasedRecipientIdGeneration
        /// </summary>
        [DataMember(Name="orderBasedRecipientIdGeneration", EmitDefaultValue=false)]
        public string OrderBasedRecipientIdGeneration { get; set; }
        /// <summary>
        /// Gets or Sets OrderBasedRecipientIdGenerationMetadata
        /// </summary>
        [DataMember(Name="orderBasedRecipientIdGenerationMetadata", EmitDefaultValue=false)]
        public SettingsMetadata OrderBasedRecipientIdGenerationMetadata { get; set; }
        /// <summary>
        /// Gets or Sets RemoveEnvelopeForwarding
        /// </summary>
        [DataMember(Name="removeEnvelopeForwarding", EmitDefaultValue=false)]
        public string RemoveEnvelopeForwarding { get; set; }
        /// <summary>
        /// Gets or Sets RemoveEnvelopeForwardingMetadata
        /// </summary>
        [DataMember(Name="removeEnvelopeForwardingMetadata", EmitDefaultValue=false)]
        public SettingsMetadata RemoveEnvelopeForwardingMetadata { get; set; }
        /// <summary>
        /// Gets or Sets ShouldRedactAccessCode
        /// </summary>
        [DataMember(Name="shouldRedactAccessCode", EmitDefaultValue=false)]
        public string ShouldRedactAccessCode { get; set; }
        /// <summary>
        /// Gets or Sets ShouldRedactAccessCodeMetadata
        /// </summary>
        [DataMember(Name="shouldRedactAccessCodeMetadata", EmitDefaultValue=false)]
        public SettingsMetadata ShouldRedactAccessCodeMetadata { get; set; }
        /// <summary>
        /// Gets or Sets UploadNewImageToSignOrInitial
        /// </summary>
        [DataMember(Name="uploadNewImageToSignOrInitial", EmitDefaultValue=false)]
        public string UploadNewImageToSignOrInitial { get; set; }
        /// <summary>
        /// Gets or Sets UploadNewImageToSignOrInitialMetadata
        /// </summary>
        [DataMember(Name="uploadNewImageToSignOrInitialMetadata", EmitDefaultValue=false)]
        public SettingsMetadata UploadNewImageToSignOrInitialMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountUISettings {\n");
            sb.Append("  AdminMessage: ").Append(AdminMessage).Append("\n");
            sb.Append("  AskAnAdmin: ").Append(AskAnAdmin).Append("\n");
            sb.Append("  EnableAdminMessage: ").Append(EnableAdminMessage).Append("\n");
            sb.Append("  EnableAdminMessageMetadata: ").Append(EnableAdminMessageMetadata).Append("\n");
            sb.Append("  EnableAdvancedPaymentsReactEdit: ").Append(EnableAdvancedPaymentsReactEdit).Append("\n");
            sb.Append("  EnableEasySignCanUseMultiTemplateApply: ").Append(EnableEasySignCanUseMultiTemplateApply).Append("\n");
            sb.Append("  EnableEasySignCanUseMultiTemplateApplyMetadata: ").Append(EnableEasySignCanUseMultiTemplateApplyMetadata).Append("\n");
            sb.Append("  EnableEasySignTemplateUpload: ").Append(EnableEasySignTemplateUpload).Append("\n");
            sb.Append("  EnableEasySignTemplateUploadMetadata: ").Append(EnableEasySignTemplateUploadMetadata).Append("\n");
            sb.Append("  EnableEnvelopeCopyWithData: ").Append(EnableEnvelopeCopyWithData).Append("\n");
            sb.Append("  EnableEnvelopeCopyWithDataMetadata: ").Append(EnableEnvelopeCopyWithDataMetadata).Append("\n");
            sb.Append("  EnableLegacyHomepageLink: ").Append(EnableLegacyHomepageLink).Append("\n");
            sb.Append("  EnableLegacyHomepageLinkMetadata: ").Append(EnableLegacyHomepageLinkMetadata).Append("\n");
            sb.Append("  HasExternalLinkedAccounts: ").Append(HasExternalLinkedAccounts).Append("\n");
            sb.Append("  HasExternalLinkedAccountsMetadata: ").Append(HasExternalLinkedAccountsMetadata).Append("\n");
            sb.Append("  HideSendAnEnvelope: ").Append(HideSendAnEnvelope).Append("\n");
            sb.Append("  HideSendAnEnvelopeMetadata: ").Append(HideSendAnEnvelopeMetadata).Append("\n");
            sb.Append("  HideUseATemplate: ").Append(HideUseATemplate).Append("\n");
            sb.Append("  HideUseATemplateInPrepare: ").Append(HideUseATemplateInPrepare).Append("\n");
            sb.Append("  HideUseATemplateInPrepareMetadata: ").Append(HideUseATemplateInPrepareMetadata).Append("\n");
            sb.Append("  HideUseATemplateMetadata: ").Append(HideUseATemplateMetadata).Append("\n");
            sb.Append("  OrderBasedRecipientIdGeneration: ").Append(OrderBasedRecipientIdGeneration).Append("\n");
            sb.Append("  OrderBasedRecipientIdGenerationMetadata: ").Append(OrderBasedRecipientIdGenerationMetadata).Append("\n");
            sb.Append("  RemoveEnvelopeForwarding: ").Append(RemoveEnvelopeForwarding).Append("\n");
            sb.Append("  RemoveEnvelopeForwardingMetadata: ").Append(RemoveEnvelopeForwardingMetadata).Append("\n");
            sb.Append("  ShouldRedactAccessCode: ").Append(ShouldRedactAccessCode).Append("\n");
            sb.Append("  ShouldRedactAccessCodeMetadata: ").Append(ShouldRedactAccessCodeMetadata).Append("\n");
            sb.Append("  UploadNewImageToSignOrInitial: ").Append(UploadNewImageToSignOrInitial).Append("\n");
            sb.Append("  UploadNewImageToSignOrInitialMetadata: ").Append(UploadNewImageToSignOrInitialMetadata).Append("\n");
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
            return this.Equals(obj as AccountUISettings);
        }

        /// <summary>
        /// Returns true if AccountUISettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountUISettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUISettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdminMessage == other.AdminMessage ||
                    this.AdminMessage != null &&
                    this.AdminMessage.Equals(other.AdminMessage)
                ) && 
                (
                    this.AskAnAdmin == other.AskAnAdmin ||
                    this.AskAnAdmin != null &&
                    this.AskAnAdmin.Equals(other.AskAnAdmin)
                ) && 
                (
                    this.EnableAdminMessage == other.EnableAdminMessage ||
                    this.EnableAdminMessage != null &&
                    this.EnableAdminMessage.Equals(other.EnableAdminMessage)
                ) && 
                (
                    this.EnableAdminMessageMetadata == other.EnableAdminMessageMetadata ||
                    this.EnableAdminMessageMetadata != null &&
                    this.EnableAdminMessageMetadata.Equals(other.EnableAdminMessageMetadata)
                ) && 
                (
                    this.EnableAdvancedPaymentsReactEdit == other.EnableAdvancedPaymentsReactEdit ||
                    this.EnableAdvancedPaymentsReactEdit != null &&
                    this.EnableAdvancedPaymentsReactEdit.Equals(other.EnableAdvancedPaymentsReactEdit)
                ) && 
                (
                    this.EnableEasySignCanUseMultiTemplateApply == other.EnableEasySignCanUseMultiTemplateApply ||
                    this.EnableEasySignCanUseMultiTemplateApply != null &&
                    this.EnableEasySignCanUseMultiTemplateApply.Equals(other.EnableEasySignCanUseMultiTemplateApply)
                ) && 
                (
                    this.EnableEasySignCanUseMultiTemplateApplyMetadata == other.EnableEasySignCanUseMultiTemplateApplyMetadata ||
                    this.EnableEasySignCanUseMultiTemplateApplyMetadata != null &&
                    this.EnableEasySignCanUseMultiTemplateApplyMetadata.Equals(other.EnableEasySignCanUseMultiTemplateApplyMetadata)
                ) && 
                (
                    this.EnableEasySignTemplateUpload == other.EnableEasySignTemplateUpload ||
                    this.EnableEasySignTemplateUpload != null &&
                    this.EnableEasySignTemplateUpload.Equals(other.EnableEasySignTemplateUpload)
                ) && 
                (
                    this.EnableEasySignTemplateUploadMetadata == other.EnableEasySignTemplateUploadMetadata ||
                    this.EnableEasySignTemplateUploadMetadata != null &&
                    this.EnableEasySignTemplateUploadMetadata.Equals(other.EnableEasySignTemplateUploadMetadata)
                ) && 
                (
                    this.EnableEnvelopeCopyWithData == other.EnableEnvelopeCopyWithData ||
                    this.EnableEnvelopeCopyWithData != null &&
                    this.EnableEnvelopeCopyWithData.Equals(other.EnableEnvelopeCopyWithData)
                ) && 
                (
                    this.EnableEnvelopeCopyWithDataMetadata == other.EnableEnvelopeCopyWithDataMetadata ||
                    this.EnableEnvelopeCopyWithDataMetadata != null &&
                    this.EnableEnvelopeCopyWithDataMetadata.Equals(other.EnableEnvelopeCopyWithDataMetadata)
                ) && 
                (
                    this.EnableLegacyHomepageLink == other.EnableLegacyHomepageLink ||
                    this.EnableLegacyHomepageLink != null &&
                    this.EnableLegacyHomepageLink.Equals(other.EnableLegacyHomepageLink)
                ) && 
                (
                    this.EnableLegacyHomepageLinkMetadata == other.EnableLegacyHomepageLinkMetadata ||
                    this.EnableLegacyHomepageLinkMetadata != null &&
                    this.EnableLegacyHomepageLinkMetadata.Equals(other.EnableLegacyHomepageLinkMetadata)
                ) && 
                (
                    this.HasExternalLinkedAccounts == other.HasExternalLinkedAccounts ||
                    this.HasExternalLinkedAccounts != null &&
                    this.HasExternalLinkedAccounts.Equals(other.HasExternalLinkedAccounts)
                ) && 
                (
                    this.HasExternalLinkedAccountsMetadata == other.HasExternalLinkedAccountsMetadata ||
                    this.HasExternalLinkedAccountsMetadata != null &&
                    this.HasExternalLinkedAccountsMetadata.Equals(other.HasExternalLinkedAccountsMetadata)
                ) && 
                (
                    this.HideSendAnEnvelope == other.HideSendAnEnvelope ||
                    this.HideSendAnEnvelope != null &&
                    this.HideSendAnEnvelope.Equals(other.HideSendAnEnvelope)
                ) && 
                (
                    this.HideSendAnEnvelopeMetadata == other.HideSendAnEnvelopeMetadata ||
                    this.HideSendAnEnvelopeMetadata != null &&
                    this.HideSendAnEnvelopeMetadata.Equals(other.HideSendAnEnvelopeMetadata)
                ) && 
                (
                    this.HideUseATemplate == other.HideUseATemplate ||
                    this.HideUseATemplate != null &&
                    this.HideUseATemplate.Equals(other.HideUseATemplate)
                ) && 
                (
                    this.HideUseATemplateInPrepare == other.HideUseATemplateInPrepare ||
                    this.HideUseATemplateInPrepare != null &&
                    this.HideUseATemplateInPrepare.Equals(other.HideUseATemplateInPrepare)
                ) && 
                (
                    this.HideUseATemplateInPrepareMetadata == other.HideUseATemplateInPrepareMetadata ||
                    this.HideUseATemplateInPrepareMetadata != null &&
                    this.HideUseATemplateInPrepareMetadata.Equals(other.HideUseATemplateInPrepareMetadata)
                ) && 
                (
                    this.HideUseATemplateMetadata == other.HideUseATemplateMetadata ||
                    this.HideUseATemplateMetadata != null &&
                    this.HideUseATemplateMetadata.Equals(other.HideUseATemplateMetadata)
                ) && 
                (
                    this.OrderBasedRecipientIdGeneration == other.OrderBasedRecipientIdGeneration ||
                    this.OrderBasedRecipientIdGeneration != null &&
                    this.OrderBasedRecipientIdGeneration.Equals(other.OrderBasedRecipientIdGeneration)
                ) && 
                (
                    this.OrderBasedRecipientIdGenerationMetadata == other.OrderBasedRecipientIdGenerationMetadata ||
                    this.OrderBasedRecipientIdGenerationMetadata != null &&
                    this.OrderBasedRecipientIdGenerationMetadata.Equals(other.OrderBasedRecipientIdGenerationMetadata)
                ) && 
                (
                    this.RemoveEnvelopeForwarding == other.RemoveEnvelopeForwarding ||
                    this.RemoveEnvelopeForwarding != null &&
                    this.RemoveEnvelopeForwarding.Equals(other.RemoveEnvelopeForwarding)
                ) && 
                (
                    this.RemoveEnvelopeForwardingMetadata == other.RemoveEnvelopeForwardingMetadata ||
                    this.RemoveEnvelopeForwardingMetadata != null &&
                    this.RemoveEnvelopeForwardingMetadata.Equals(other.RemoveEnvelopeForwardingMetadata)
                ) && 
                (
                    this.ShouldRedactAccessCode == other.ShouldRedactAccessCode ||
                    this.ShouldRedactAccessCode != null &&
                    this.ShouldRedactAccessCode.Equals(other.ShouldRedactAccessCode)
                ) && 
                (
                    this.ShouldRedactAccessCodeMetadata == other.ShouldRedactAccessCodeMetadata ||
                    this.ShouldRedactAccessCodeMetadata != null &&
                    this.ShouldRedactAccessCodeMetadata.Equals(other.ShouldRedactAccessCodeMetadata)
                ) && 
                (
                    this.UploadNewImageToSignOrInitial == other.UploadNewImageToSignOrInitial ||
                    this.UploadNewImageToSignOrInitial != null &&
                    this.UploadNewImageToSignOrInitial.Equals(other.UploadNewImageToSignOrInitial)
                ) && 
                (
                    this.UploadNewImageToSignOrInitialMetadata == other.UploadNewImageToSignOrInitialMetadata ||
                    this.UploadNewImageToSignOrInitialMetadata != null &&
                    this.UploadNewImageToSignOrInitialMetadata.Equals(other.UploadNewImageToSignOrInitialMetadata)
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
                if (this.AdminMessage != null)
                    hash = hash * 59 + this.AdminMessage.GetHashCode();
                if (this.AskAnAdmin != null)
                    hash = hash * 59 + this.AskAnAdmin.GetHashCode();
                if (this.EnableAdminMessage != null)
                    hash = hash * 59 + this.EnableAdminMessage.GetHashCode();
                if (this.EnableAdminMessageMetadata != null)
                    hash = hash * 59 + this.EnableAdminMessageMetadata.GetHashCode();
                if (this.EnableAdvancedPaymentsReactEdit != null)
                    hash = hash * 59 + this.EnableAdvancedPaymentsReactEdit.GetHashCode();
                if (this.EnableEasySignCanUseMultiTemplateApply != null)
                    hash = hash * 59 + this.EnableEasySignCanUseMultiTemplateApply.GetHashCode();
                if (this.EnableEasySignCanUseMultiTemplateApplyMetadata != null)
                    hash = hash * 59 + this.EnableEasySignCanUseMultiTemplateApplyMetadata.GetHashCode();
                if (this.EnableEasySignTemplateUpload != null)
                    hash = hash * 59 + this.EnableEasySignTemplateUpload.GetHashCode();
                if (this.EnableEasySignTemplateUploadMetadata != null)
                    hash = hash * 59 + this.EnableEasySignTemplateUploadMetadata.GetHashCode();
                if (this.EnableEnvelopeCopyWithData != null)
                    hash = hash * 59 + this.EnableEnvelopeCopyWithData.GetHashCode();
                if (this.EnableEnvelopeCopyWithDataMetadata != null)
                    hash = hash * 59 + this.EnableEnvelopeCopyWithDataMetadata.GetHashCode();
                if (this.EnableLegacyHomepageLink != null)
                    hash = hash * 59 + this.EnableLegacyHomepageLink.GetHashCode();
                if (this.EnableLegacyHomepageLinkMetadata != null)
                    hash = hash * 59 + this.EnableLegacyHomepageLinkMetadata.GetHashCode();
                if (this.HasExternalLinkedAccounts != null)
                    hash = hash * 59 + this.HasExternalLinkedAccounts.GetHashCode();
                if (this.HasExternalLinkedAccountsMetadata != null)
                    hash = hash * 59 + this.HasExternalLinkedAccountsMetadata.GetHashCode();
                if (this.HideSendAnEnvelope != null)
                    hash = hash * 59 + this.HideSendAnEnvelope.GetHashCode();
                if (this.HideSendAnEnvelopeMetadata != null)
                    hash = hash * 59 + this.HideSendAnEnvelopeMetadata.GetHashCode();
                if (this.HideUseATemplate != null)
                    hash = hash * 59 + this.HideUseATemplate.GetHashCode();
                if (this.HideUseATemplateInPrepare != null)
                    hash = hash * 59 + this.HideUseATemplateInPrepare.GetHashCode();
                if (this.HideUseATemplateInPrepareMetadata != null)
                    hash = hash * 59 + this.HideUseATemplateInPrepareMetadata.GetHashCode();
                if (this.HideUseATemplateMetadata != null)
                    hash = hash * 59 + this.HideUseATemplateMetadata.GetHashCode();
                if (this.OrderBasedRecipientIdGeneration != null)
                    hash = hash * 59 + this.OrderBasedRecipientIdGeneration.GetHashCode();
                if (this.OrderBasedRecipientIdGenerationMetadata != null)
                    hash = hash * 59 + this.OrderBasedRecipientIdGenerationMetadata.GetHashCode();
                if (this.RemoveEnvelopeForwarding != null)
                    hash = hash * 59 + this.RemoveEnvelopeForwarding.GetHashCode();
                if (this.RemoveEnvelopeForwardingMetadata != null)
                    hash = hash * 59 + this.RemoveEnvelopeForwardingMetadata.GetHashCode();
                if (this.ShouldRedactAccessCode != null)
                    hash = hash * 59 + this.ShouldRedactAccessCode.GetHashCode();
                if (this.ShouldRedactAccessCodeMetadata != null)
                    hash = hash * 59 + this.ShouldRedactAccessCodeMetadata.GetHashCode();
                if (this.UploadNewImageToSignOrInitial != null)
                    hash = hash * 59 + this.UploadNewImageToSignOrInitial.GetHashCode();
                if (this.UploadNewImageToSignOrInitialMetadata != null)
                    hash = hash * 59 + this.UploadNewImageToSignOrInitialMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
