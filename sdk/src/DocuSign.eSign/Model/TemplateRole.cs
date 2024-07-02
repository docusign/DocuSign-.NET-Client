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
    /// Information about a specific role.
    /// </summary>
    [DataContract]
    public partial class TemplateRole :  IEquatable<TemplateRole>, IValidatableObject
    {
        public TemplateRole()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRole" /> class.
        /// </summary>
        /// <param name="AccessCode">If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required..</param>
        /// <param name="AdditionalNotifications">AdditionalNotifications.</param>
        /// <param name="ClientUserId">Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. .</param>
        /// <param name="DefaultRecipient">When set to **true**, this recipient is the default recipient and any tabs generated by the transformPdfFields option are mapped to this recipient..</param>
        /// <param name="DeliveryMethod">Reserved: For DocuSign use only..</param>
        /// <param name="Email">Specifies the email associated with a role name..</param>
        /// <param name="EmailNotification">A complex type that contains information sets the language of the recipient&#39;s email information.   **IMPORTANT**: If you enable email notification for one recipient, you must enable email notification for all recipients as it overrides the Envelope Subject and &#x60;EmailBlurb&#x60; property settings. .</param>
        /// <param name="EmbeddedRecipientStartURL">Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender&#39;s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient&#39;s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60; .</param>
        /// <param name="InPersonSignerName">Specifies the full legal name of the signer in person signer template roles.  Maximum Length: 100 characters..</param>
        /// <param name="Name">Specifies the recipient&#39;s name..</param>
        /// <param name="PhoneNumber">Describes the recipient phone number..</param>
        /// <param name="RecipientSignatureProviders">RecipientSignatureProviders.</param>
        /// <param name="RoleName">Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients..</param>
        /// <param name="RoutingOrder">Specifies the routing order of the recipient in the envelope. .</param>
        /// <param name="SigningGroupId">When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once)..</param>
        /// <param name="Tabs">A list of tabs, which are represented graphically as symbols on documents at the time of signing. Tabs show recipients where to sign, initial, or enter data. They may also display data to the recipients..</param>
        public TemplateRole(string AccessCode = default(string), List<RecipientAdditionalNotification> AdditionalNotifications = default(List<RecipientAdditionalNotification>), string ClientUserId = default(string), string DefaultRecipient = default(string), string DeliveryMethod = default(string), string Email = default(string), RecipientEmailNotification EmailNotification = default(RecipientEmailNotification), string EmbeddedRecipientStartURL = default(string), string InPersonSignerName = default(string), string Name = default(string), RecipientPhoneNumber PhoneNumber = default(RecipientPhoneNumber), List<RecipientSignatureProvider> RecipientSignatureProviders = default(List<RecipientSignatureProvider>), string RoleName = default(string), string RoutingOrder = default(string), string SigningGroupId = default(string), Tabs Tabs = default(Tabs))
        {
            this.AccessCode = AccessCode;
            this.AdditionalNotifications = AdditionalNotifications;
            this.ClientUserId = ClientUserId;
            this.DefaultRecipient = DefaultRecipient;
            this.DeliveryMethod = DeliveryMethod;
            this.Email = Email;
            this.EmailNotification = EmailNotification;
            this.EmbeddedRecipientStartURL = EmbeddedRecipientStartURL;
            this.InPersonSignerName = InPersonSignerName;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.RecipientSignatureProviders = RecipientSignatureProviders;
            this.RoleName = RoleName;
            this.RoutingOrder = RoutingOrder;
            this.SigningGroupId = SigningGroupId;
            this.Tabs = Tabs;
        }
        
        /// <summary>
        /// If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.
        /// </summary>
        /// <value>If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.</value>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalNotifications
        /// </summary>
        [DataMember(Name="additionalNotifications", EmitDefaultValue=false)]
        public List<RecipientAdditionalNotification> AdditionalNotifications { get; set; }
        /// <summary>
        /// Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. 
        /// </summary>
        /// <value>Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. </value>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
        /// <summary>
        /// When set to **true**, this recipient is the default recipient and any tabs generated by the transformPdfFields option are mapped to this recipient.
        /// </summary>
        /// <value>When set to **true**, this recipient is the default recipient and any tabs generated by the transformPdfFields option are mapped to this recipient.</value>
        [DataMember(Name="defaultRecipient", EmitDefaultValue=false)]
        public string DefaultRecipient { get; set; }
        /// <summary>
        /// Reserved: For DocuSign use only.
        /// </summary>
        /// <value>Reserved: For DocuSign use only.</value>
        [DataMember(Name="deliveryMethod", EmitDefaultValue=false)]
        public string DeliveryMethod { get; set; }
        /// <summary>
        /// Specifies the email associated with a role name.
        /// </summary>
        /// <value>Specifies the email associated with a role name.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// A complex type that contains information sets the language of the recipient&#39;s email information.   **IMPORTANT**: If you enable email notification for one recipient, you must enable email notification for all recipients as it overrides the Envelope Subject and &#x60;EmailBlurb&#x60; property settings. 
        /// </summary>
        /// <value>A complex type that contains information sets the language of the recipient&#39;s email information.   **IMPORTANT**: If you enable email notification for one recipient, you must enable email notification for all recipients as it overrides the Envelope Subject and &#x60;EmailBlurb&#x60; property settings. </value>
        [DataMember(Name="emailNotification", EmitDefaultValue=false)]
        public RecipientEmailNotification EmailNotification { get; set; }
        /// <summary>
        /// Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender&#39;s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient&#39;s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60; 
        /// </summary>
        /// <value>Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender&#39;s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient&#39;s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60; </value>
        [DataMember(Name="embeddedRecipientStartURL", EmitDefaultValue=false)]
        public string EmbeddedRecipientStartURL { get; set; }
        /// <summary>
        /// Specifies the full legal name of the signer in person signer template roles.  Maximum Length: 100 characters.
        /// </summary>
        /// <value>Specifies the full legal name of the signer in person signer template roles.  Maximum Length: 100 characters.</value>
        [DataMember(Name="inPersonSignerName", EmitDefaultValue=false)]
        public string InPersonSignerName { get; set; }
        /// <summary>
        /// Specifies the recipient&#39;s name.
        /// </summary>
        /// <value>Specifies the recipient&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Describes the recipient phone number.
        /// </summary>
        /// <value>Describes the recipient phone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public RecipientPhoneNumber PhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets RecipientSignatureProviders
        /// </summary>
        [DataMember(Name="recipientSignatureProviders", EmitDefaultValue=false)]
        public List<RecipientSignatureProvider> RecipientSignatureProviders { get; set; }
        /// <summary>
        /// Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients.
        /// </summary>
        /// <value>Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients.</value>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }
        /// <summary>
        /// Specifies the routing order of the recipient in the envelope. 
        /// </summary>
        /// <value>Specifies the routing order of the recipient in the envelope. </value>
        [DataMember(Name="routingOrder", EmitDefaultValue=false)]
        public string RoutingOrder { get; set; }
        /// <summary>
        /// When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).
        /// </summary>
        /// <value>When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).</value>
        [DataMember(Name="signingGroupId", EmitDefaultValue=false)]
        public string SigningGroupId { get; set; }
        /// <summary>
        /// A list of tabs, which are represented graphically as symbols on documents at the time of signing. Tabs show recipients where to sign, initial, or enter data. They may also display data to the recipients.
        /// </summary>
        /// <value>A list of tabs, which are represented graphically as symbols on documents at the time of signing. Tabs show recipients where to sign, initial, or enter data. They may also display data to the recipients.</value>
        [DataMember(Name="tabs", EmitDefaultValue=false)]
        public Tabs Tabs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRole {\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  AdditionalNotifications: ").Append(AdditionalNotifications).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  DefaultRecipient: ").Append(DefaultRecipient).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  EmbeddedRecipientStartURL: ").Append(EmbeddedRecipientStartURL).Append("\n");
            sb.Append("  InPersonSignerName: ").Append(InPersonSignerName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  RecipientSignatureProviders: ").Append(RecipientSignatureProviders).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  RoutingOrder: ").Append(RoutingOrder).Append("\n");
            sb.Append("  SigningGroupId: ").Append(SigningGroupId).Append("\n");
            sb.Append("  Tabs: ").Append(Tabs).Append("\n");
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
            return this.Equals(obj as TemplateRole);
        }

        /// <summary>
        /// Returns true if TemplateRole instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRole other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.AdditionalNotifications == other.AdditionalNotifications ||
                    this.AdditionalNotifications != null &&
                    this.AdditionalNotifications.SequenceEqual(other.AdditionalNotifications)
                ) && 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.DefaultRecipient == other.DefaultRecipient ||
                    this.DefaultRecipient != null &&
                    this.DefaultRecipient.Equals(other.DefaultRecipient)
                ) && 
                (
                    this.DeliveryMethod == other.DeliveryMethod ||
                    this.DeliveryMethod != null &&
                    this.DeliveryMethod.Equals(other.DeliveryMethod)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailNotification == other.EmailNotification ||
                    this.EmailNotification != null &&
                    this.EmailNotification.Equals(other.EmailNotification)
                ) && 
                (
                    this.EmbeddedRecipientStartURL == other.EmbeddedRecipientStartURL ||
                    this.EmbeddedRecipientStartURL != null &&
                    this.EmbeddedRecipientStartURL.Equals(other.EmbeddedRecipientStartURL)
                ) && 
                (
                    this.InPersonSignerName == other.InPersonSignerName ||
                    this.InPersonSignerName != null &&
                    this.InPersonSignerName.Equals(other.InPersonSignerName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.RecipientSignatureProviders == other.RecipientSignatureProviders ||
                    this.RecipientSignatureProviders != null &&
                    this.RecipientSignatureProviders.SequenceEqual(other.RecipientSignatureProviders)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.RoutingOrder == other.RoutingOrder ||
                    this.RoutingOrder != null &&
                    this.RoutingOrder.Equals(other.RoutingOrder)
                ) && 
                (
                    this.SigningGroupId == other.SigningGroupId ||
                    this.SigningGroupId != null &&
                    this.SigningGroupId.Equals(other.SigningGroupId)
                ) && 
                (
                    this.Tabs == other.Tabs ||
                    this.Tabs != null &&
                    this.Tabs.Equals(other.Tabs)
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
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                if (this.AdditionalNotifications != null)
                    hash = hash * 59 + this.AdditionalNotifications.GetHashCode();
                if (this.ClientUserId != null)
                    hash = hash * 59 + this.ClientUserId.GetHashCode();
                if (this.DefaultRecipient != null)
                    hash = hash * 59 + this.DefaultRecipient.GetHashCode();
                if (this.DeliveryMethod != null)
                    hash = hash * 59 + this.DeliveryMethod.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailNotification != null)
                    hash = hash * 59 + this.EmailNotification.GetHashCode();
                if (this.EmbeddedRecipientStartURL != null)
                    hash = hash * 59 + this.EmbeddedRecipientStartURL.GetHashCode();
                if (this.InPersonSignerName != null)
                    hash = hash * 59 + this.InPersonSignerName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.RecipientSignatureProviders != null)
                    hash = hash * 59 + this.RecipientSignatureProviders.GetHashCode();
                if (this.RoleName != null)
                    hash = hash * 59 + this.RoleName.GetHashCode();
                if (this.RoutingOrder != null)
                    hash = hash * 59 + this.RoutingOrder.GetHashCode();
                if (this.SigningGroupId != null)
                    hash = hash * 59 + this.SigningGroupId.GetHashCode();
                if (this.Tabs != null)
                    hash = hash * 59 + this.Tabs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
