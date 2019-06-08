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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// An array of email notifications that specifies the email the user receives when they are a sender. When the specific email notification is set to true, the user receives those types of email notifications from DocuSign. The user inherits the default account sender email notification settings when the user is created.
    /// </summary>
    [DataContract]
    public partial class SignerEmailNotifications :  IEquatable<SignerEmailNotifications>, IValidatableObject
    {
        public SignerEmailNotifications()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignerEmailNotifications" /> class.
        /// </summary>
        /// <param name="AgentNotification">When set to **true**, the user receives agent notification emails..</param>
        /// <param name="CarbonCopyNotification">When set to **true**, the user receives notifications of carbon copy deliveries..</param>
        /// <param name="CertifiedDeliveryNotification">When set to **true**, the user receives notifications of certified deliveries..</param>
        /// <param name="CommentsOnlyPrivateAndMention">.</param>
        /// <param name="CommentsReceiveAll">.</param>
        /// <param name="DocumentMarkupActivation">When set to **true**, the user receives notification that document markup has been activated..</param>
        /// <param name="EnvelopeActivation">When set to **true**, the user receives notification that the envelope has been activated..</param>
        /// <param name="EnvelopeComplete">When set to **true**, the user receives notification that the envelope has been completed..</param>
        /// <param name="EnvelopeCorrected">When set to **true**, the user receives notification that the envelope has been corrected..</param>
        /// <param name="EnvelopeDeclined">When set to **true**, the user receives notification that the envelope has been declined..</param>
        /// <param name="EnvelopeVoided">When set to **true**, the user receives notification that the envelope has been voided..</param>
        /// <param name="FaxReceived">Reserved:.</param>
        /// <param name="OfflineSigningFailed">When set to **true**, the user receives notification if the offline signing failed..</param>
        /// <param name="PurgeDocuments">When set to **true**, the user receives notification of document purges..</param>
        /// <param name="ReassignedSigner">When set to **true**, the user receives notification that the envelope has been reassigned..</param>
        /// <param name="WhenSigningGroupMember">.</param>
        public SignerEmailNotifications(string AgentNotification = default(string), string CarbonCopyNotification = default(string), string CertifiedDeliveryNotification = default(string), string CommentsOnlyPrivateAndMention = default(string), string CommentsReceiveAll = default(string), string DocumentMarkupActivation = default(string), string EnvelopeActivation = default(string), string EnvelopeComplete = default(string), string EnvelopeCorrected = default(string), string EnvelopeDeclined = default(string), string EnvelopeVoided = default(string), string FaxReceived = default(string), string OfflineSigningFailed = default(string), string PurgeDocuments = default(string), string ReassignedSigner = default(string), string WhenSigningGroupMember = default(string))
        {
            this.AgentNotification = AgentNotification;
            this.CarbonCopyNotification = CarbonCopyNotification;
            this.CertifiedDeliveryNotification = CertifiedDeliveryNotification;
            this.CommentsOnlyPrivateAndMention = CommentsOnlyPrivateAndMention;
            this.CommentsReceiveAll = CommentsReceiveAll;
            this.DocumentMarkupActivation = DocumentMarkupActivation;
            this.EnvelopeActivation = EnvelopeActivation;
            this.EnvelopeComplete = EnvelopeComplete;
            this.EnvelopeCorrected = EnvelopeCorrected;
            this.EnvelopeDeclined = EnvelopeDeclined;
            this.EnvelopeVoided = EnvelopeVoided;
            this.FaxReceived = FaxReceived;
            this.OfflineSigningFailed = OfflineSigningFailed;
            this.PurgeDocuments = PurgeDocuments;
            this.ReassignedSigner = ReassignedSigner;
            this.WhenSigningGroupMember = WhenSigningGroupMember;
        }
        
        /// <summary>
        /// When set to **true**, the user receives agent notification emails.
        /// </summary>
        /// <value>When set to **true**, the user receives agent notification emails.</value>
        [DataMember(Name="agentNotification", EmitDefaultValue=false)]
        public string AgentNotification { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notifications of carbon copy deliveries.
        /// </summary>
        /// <value>When set to **true**, the user receives notifications of carbon copy deliveries.</value>
        [DataMember(Name="carbonCopyNotification", EmitDefaultValue=false)]
        public string CarbonCopyNotification { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notifications of certified deliveries.
        /// </summary>
        /// <value>When set to **true**, the user receives notifications of certified deliveries.</value>
        [DataMember(Name="certifiedDeliveryNotification", EmitDefaultValue=false)]
        public string CertifiedDeliveryNotification { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commentsOnlyPrivateAndMention", EmitDefaultValue=false)]
        public string CommentsOnlyPrivateAndMention { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commentsReceiveAll", EmitDefaultValue=false)]
        public string CommentsReceiveAll { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that document markup has been activated.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that document markup has been activated.</value>
        [DataMember(Name="documentMarkupActivation", EmitDefaultValue=false)]
        public string DocumentMarkupActivation { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been activated.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been activated.</value>
        [DataMember(Name="envelopeActivation", EmitDefaultValue=false)]
        public string EnvelopeActivation { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been completed.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been completed.</value>
        [DataMember(Name="envelopeComplete", EmitDefaultValue=false)]
        public string EnvelopeComplete { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been corrected.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been corrected.</value>
        [DataMember(Name="envelopeCorrected", EmitDefaultValue=false)]
        public string EnvelopeCorrected { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been declined.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been declined.</value>
        [DataMember(Name="envelopeDeclined", EmitDefaultValue=false)]
        public string EnvelopeDeclined { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been voided.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been voided.</value>
        [DataMember(Name="envelopeVoided", EmitDefaultValue=false)]
        public string EnvelopeVoided { get; set; }
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="faxReceived", EmitDefaultValue=false)]
        public string FaxReceived { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification if the offline signing failed.
        /// </summary>
        /// <value>When set to **true**, the user receives notification if the offline signing failed.</value>
        [DataMember(Name="offlineSigningFailed", EmitDefaultValue=false)]
        public string OfflineSigningFailed { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification of document purges.
        /// </summary>
        /// <value>When set to **true**, the user receives notification of document purges.</value>
        [DataMember(Name="purgeDocuments", EmitDefaultValue=false)]
        public string PurgeDocuments { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been reassigned.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been reassigned.</value>
        [DataMember(Name="reassignedSigner", EmitDefaultValue=false)]
        public string ReassignedSigner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="whenSigningGroupMember", EmitDefaultValue=false)]
        public string WhenSigningGroupMember { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignerEmailNotifications {\n");
            sb.Append("  AgentNotification: ").Append(AgentNotification).Append("\n");
            sb.Append("  CarbonCopyNotification: ").Append(CarbonCopyNotification).Append("\n");
            sb.Append("  CertifiedDeliveryNotification: ").Append(CertifiedDeliveryNotification).Append("\n");
            sb.Append("  CommentsOnlyPrivateAndMention: ").Append(CommentsOnlyPrivateAndMention).Append("\n");
            sb.Append("  CommentsReceiveAll: ").Append(CommentsReceiveAll).Append("\n");
            sb.Append("  DocumentMarkupActivation: ").Append(DocumentMarkupActivation).Append("\n");
            sb.Append("  EnvelopeActivation: ").Append(EnvelopeActivation).Append("\n");
            sb.Append("  EnvelopeComplete: ").Append(EnvelopeComplete).Append("\n");
            sb.Append("  EnvelopeCorrected: ").Append(EnvelopeCorrected).Append("\n");
            sb.Append("  EnvelopeDeclined: ").Append(EnvelopeDeclined).Append("\n");
            sb.Append("  EnvelopeVoided: ").Append(EnvelopeVoided).Append("\n");
            sb.Append("  FaxReceived: ").Append(FaxReceived).Append("\n");
            sb.Append("  OfflineSigningFailed: ").Append(OfflineSigningFailed).Append("\n");
            sb.Append("  PurgeDocuments: ").Append(PurgeDocuments).Append("\n");
            sb.Append("  ReassignedSigner: ").Append(ReassignedSigner).Append("\n");
            sb.Append("  WhenSigningGroupMember: ").Append(WhenSigningGroupMember).Append("\n");
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
            return this.Equals(obj as SignerEmailNotifications);
        }

        /// <summary>
        /// Returns true if SignerEmailNotifications instances are equal
        /// </summary>
        /// <param name="other">Instance of SignerEmailNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignerEmailNotifications other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AgentNotification == other.AgentNotification ||
                    this.AgentNotification != null &&
                    this.AgentNotification.Equals(other.AgentNotification)
                ) && 
                (
                    this.CarbonCopyNotification == other.CarbonCopyNotification ||
                    this.CarbonCopyNotification != null &&
                    this.CarbonCopyNotification.Equals(other.CarbonCopyNotification)
                ) && 
                (
                    this.CertifiedDeliveryNotification == other.CertifiedDeliveryNotification ||
                    this.CertifiedDeliveryNotification != null &&
                    this.CertifiedDeliveryNotification.Equals(other.CertifiedDeliveryNotification)
                ) && 
                (
                    this.CommentsOnlyPrivateAndMention == other.CommentsOnlyPrivateAndMention ||
                    this.CommentsOnlyPrivateAndMention != null &&
                    this.CommentsOnlyPrivateAndMention.Equals(other.CommentsOnlyPrivateAndMention)
                ) && 
                (
                    this.CommentsReceiveAll == other.CommentsReceiveAll ||
                    this.CommentsReceiveAll != null &&
                    this.CommentsReceiveAll.Equals(other.CommentsReceiveAll)
                ) && 
                (
                    this.DocumentMarkupActivation == other.DocumentMarkupActivation ||
                    this.DocumentMarkupActivation != null &&
                    this.DocumentMarkupActivation.Equals(other.DocumentMarkupActivation)
                ) && 
                (
                    this.EnvelopeActivation == other.EnvelopeActivation ||
                    this.EnvelopeActivation != null &&
                    this.EnvelopeActivation.Equals(other.EnvelopeActivation)
                ) && 
                (
                    this.EnvelopeComplete == other.EnvelopeComplete ||
                    this.EnvelopeComplete != null &&
                    this.EnvelopeComplete.Equals(other.EnvelopeComplete)
                ) && 
                (
                    this.EnvelopeCorrected == other.EnvelopeCorrected ||
                    this.EnvelopeCorrected != null &&
                    this.EnvelopeCorrected.Equals(other.EnvelopeCorrected)
                ) && 
                (
                    this.EnvelopeDeclined == other.EnvelopeDeclined ||
                    this.EnvelopeDeclined != null &&
                    this.EnvelopeDeclined.Equals(other.EnvelopeDeclined)
                ) && 
                (
                    this.EnvelopeVoided == other.EnvelopeVoided ||
                    this.EnvelopeVoided != null &&
                    this.EnvelopeVoided.Equals(other.EnvelopeVoided)
                ) && 
                (
                    this.FaxReceived == other.FaxReceived ||
                    this.FaxReceived != null &&
                    this.FaxReceived.Equals(other.FaxReceived)
                ) && 
                (
                    this.OfflineSigningFailed == other.OfflineSigningFailed ||
                    this.OfflineSigningFailed != null &&
                    this.OfflineSigningFailed.Equals(other.OfflineSigningFailed)
                ) && 
                (
                    this.PurgeDocuments == other.PurgeDocuments ||
                    this.PurgeDocuments != null &&
                    this.PurgeDocuments.Equals(other.PurgeDocuments)
                ) && 
                (
                    this.ReassignedSigner == other.ReassignedSigner ||
                    this.ReassignedSigner != null &&
                    this.ReassignedSigner.Equals(other.ReassignedSigner)
                ) && 
                (
                    this.WhenSigningGroupMember == other.WhenSigningGroupMember ||
                    this.WhenSigningGroupMember != null &&
                    this.WhenSigningGroupMember.Equals(other.WhenSigningGroupMember)
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
                if (this.AgentNotification != null)
                    hash = hash * 59 + this.AgentNotification.GetHashCode();
                if (this.CarbonCopyNotification != null)
                    hash = hash * 59 + this.CarbonCopyNotification.GetHashCode();
                if (this.CertifiedDeliveryNotification != null)
                    hash = hash * 59 + this.CertifiedDeliveryNotification.GetHashCode();
                if (this.CommentsOnlyPrivateAndMention != null)
                    hash = hash * 59 + this.CommentsOnlyPrivateAndMention.GetHashCode();
                if (this.CommentsReceiveAll != null)
                    hash = hash * 59 + this.CommentsReceiveAll.GetHashCode();
                if (this.DocumentMarkupActivation != null)
                    hash = hash * 59 + this.DocumentMarkupActivation.GetHashCode();
                if (this.EnvelopeActivation != null)
                    hash = hash * 59 + this.EnvelopeActivation.GetHashCode();
                if (this.EnvelopeComplete != null)
                    hash = hash * 59 + this.EnvelopeComplete.GetHashCode();
                if (this.EnvelopeCorrected != null)
                    hash = hash * 59 + this.EnvelopeCorrected.GetHashCode();
                if (this.EnvelopeDeclined != null)
                    hash = hash * 59 + this.EnvelopeDeclined.GetHashCode();
                if (this.EnvelopeVoided != null)
                    hash = hash * 59 + this.EnvelopeVoided.GetHashCode();
                if (this.FaxReceived != null)
                    hash = hash * 59 + this.FaxReceived.GetHashCode();
                if (this.OfflineSigningFailed != null)
                    hash = hash * 59 + this.OfflineSigningFailed.GetHashCode();
                if (this.PurgeDocuments != null)
                    hash = hash * 59 + this.PurgeDocuments.GetHashCode();
                if (this.ReassignedSigner != null)
                    hash = hash * 59 + this.ReassignedSigner.GetHashCode();
                if (this.WhenSigningGroupMember != null)
                    hash = hash * 59 + this.WhenSigningGroupMember.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
