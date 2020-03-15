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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>, IValidatableObject
    {
        public Document()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="ApplyAnchorTabs">Reserved: TBD.</param>
        /// <param name="AuthoritativeCopy">Specifies the Authoritative copy feature. If set to true the Authoritative copy feature is enabled..</param>
        /// <param name="Display">.</param>
        /// <param name="DocumentBase64">The document&#39;s bytes. This field can be used to include a base64 version of the document bytes within an envelope definition instead of sending the document using a multi-part HTTP request. The maximum document size is smaller if this field is used due to the overhead of the base64 encoding..</param>
        /// <param name="DocumentFields">.</param>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="EncryptedWithKeyManager">When set to **true**, the document is been already encrypted by the sender for use with the DocuSign Key Manager Security Appliance.  .</param>
        /// <param name="FileExtension">The file extension type of the document. If the document is not a PDF it is converted to a PDF.  .</param>
        /// <param name="FileFormatHint">.</param>
        /// <param name="HtmlDefinition">HtmlDefinition.</param>
        /// <param name="IncludeInDownload">.</param>
        /// <param name="MatchBoxes">Matchboxes define areas in a document for document matching when you are creating envelopes. They are only used when you upload and edit a template.   A matchbox consists of 5 elements:  * pageNumber - The document page number  on which the matchbox will appear.  * xPosition - The x position of the matchbox on a page.  * yPosition - The y position of the matchbox on a page. * width - The width of the matchbox.  * height - The height of the matchbox.  .</param>
        /// <param name="Name">.</param>
        /// <param name="Order">.</param>
        /// <param name="Pages">.</param>
        /// <param name="Password">.</param>
        /// <param name="RemoteUrl">The file id from the cloud storage service where the document is located. This information is returned using [ML:GET /folders] or [ML:/folders/{folderid}]. .</param>
        /// <param name="SignerMustAcknowledge">.</param>
        /// <param name="TemplateLocked">When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. .</param>
        /// <param name="TemplateRequired">When set to **true**, the sender may not remove the recipient. Used only when working with template recipients..</param>
        /// <param name="TransformPdfFields">When set to **true**, PDF form field data is transformed into document tab values when the PDF form field name matches the DocuSign custom tab tabLabel. The resulting PDF form data is also returned in the PDF meta data when requesting the document PDF. See the [ML:Transform PDF Fields] section for more information about how fields are transformed into DocuSign tabs. .</param>
        /// <param name="Uri">.</param>
        public Document(string ApplyAnchorTabs = default(string), bool? AuthoritativeCopy = default(bool?), string Display = default(string), string DocumentBase64 = default(string), List<NameValue> DocumentFields = default(List<NameValue>), string DocumentId = default(string), string EncryptedWithKeyManager = default(string), string FileExtension = default(string), string FileFormatHint = default(string), DocumentHtmlDefinition HtmlDefinition = default(DocumentHtmlDefinition), string IncludeInDownload = default(string), List<MatchBox> MatchBoxes = default(List<MatchBox>), string Name = default(string), string Order = default(string), string Pages = default(string), string Password = default(string), string RemoteUrl = default(string), string SignerMustAcknowledge = default(string), string TemplateLocked = default(string), string TemplateRequired = default(string), string TransformPdfFields = default(string), string Uri = default(string))
        {
            this.ApplyAnchorTabs = ApplyAnchorTabs;
            this.AuthoritativeCopy = AuthoritativeCopy;
            this.Display = Display;
            this.DocumentBase64 = DocumentBase64;
            this.DocumentFields = DocumentFields;
            this.DocumentId = DocumentId;
            this.EncryptedWithKeyManager = EncryptedWithKeyManager;
            this.FileExtension = FileExtension;
            this.FileFormatHint = FileFormatHint;
            this.HtmlDefinition = HtmlDefinition;
            this.IncludeInDownload = IncludeInDownload;
            this.MatchBoxes = MatchBoxes;
            this.Name = Name;
            this.Order = Order;
            this.Pages = Pages;
            this.Password = Password;
            this.RemoteUrl = RemoteUrl;
            this.SignerMustAcknowledge = SignerMustAcknowledge;
            this.TemplateLocked = TemplateLocked;
            this.TemplateRequired = TemplateRequired;
            this.TransformPdfFields = TransformPdfFields;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="applyAnchorTabs", EmitDefaultValue=false)]
        public string ApplyAnchorTabs { get; set; }
        /// <summary>
        /// Specifies the Authoritative copy feature. If set to true the Authoritative copy feature is enabled.
        /// </summary>
        /// <value>Specifies the Authoritative copy feature. If set to true the Authoritative copy feature is enabled.</value>
        [DataMember(Name="authoritativeCopy", EmitDefaultValue=false)]
        public bool? AuthoritativeCopy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }
        /// <summary>
        /// The document&#39;s bytes. This field can be used to include a base64 version of the document bytes within an envelope definition instead of sending the document using a multi-part HTTP request. The maximum document size is smaller if this field is used due to the overhead of the base64 encoding.
        /// </summary>
        /// <value>The document&#39;s bytes. This field can be used to include a base64 version of the document bytes within an envelope definition instead of sending the document using a multi-part HTTP request. The maximum document size is smaller if this field is used due to the overhead of the base64 encoding.</value>
        [DataMember(Name="documentBase64", EmitDefaultValue=false)]
        public string DocumentBase64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentFields", EmitDefaultValue=false)]
        public List<NameValue> DocumentFields { get; set; }
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// When set to **true**, the document is been already encrypted by the sender for use with the DocuSign Key Manager Security Appliance.  
        /// </summary>
        /// <value>When set to **true**, the document is been already encrypted by the sender for use with the DocuSign Key Manager Security Appliance.  </value>
        [DataMember(Name="encryptedWithKeyManager", EmitDefaultValue=false)]
        public string EncryptedWithKeyManager { get; set; }
        /// <summary>
        /// The file extension type of the document. If the document is not a PDF it is converted to a PDF.  
        /// </summary>
        /// <value>The file extension type of the document. If the document is not a PDF it is converted to a PDF.  </value>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fileFormatHint", EmitDefaultValue=false)]
        public string FileFormatHint { get; set; }
        /// <summary>
        /// Gets or Sets HtmlDefinition
        /// </summary>
        [DataMember(Name="htmlDefinition", EmitDefaultValue=false)]
        public DocumentHtmlDefinition HtmlDefinition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="includeInDownload", EmitDefaultValue=false)]
        public string IncludeInDownload { get; set; }
        /// <summary>
        /// Matchboxes define areas in a document for document matching when you are creating envelopes. They are only used when you upload and edit a template.   A matchbox consists of 5 elements:  * pageNumber - The document page number  on which the matchbox will appear.  * xPosition - The x position of the matchbox on a page.  * yPosition - The y position of the matchbox on a page. * width - The width of the matchbox.  * height - The height of the matchbox.  
        /// </summary>
        /// <value>Matchboxes define areas in a document for document matching when you are creating envelopes. They are only used when you upload and edit a template.   A matchbox consists of 5 elements:  * pageNumber - The document page number  on which the matchbox will appear.  * xPosition - The x position of the matchbox on a page.  * yPosition - The y position of the matchbox on a page. * width - The width of the matchbox.  * height - The height of the matchbox.  </value>
        [DataMember(Name="matchBoxes", EmitDefaultValue=false)]
        public List<MatchBox> MatchBoxes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public string Pages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// The file id from the cloud storage service where the document is located. This information is returned using [ML:GET /folders] or [ML:/folders/{folderid}]. 
        /// </summary>
        /// <value>The file id from the cloud storage service where the document is located. This information is returned using [ML:GET /folders] or [ML:/folders/{folderid}]. </value>
        [DataMember(Name="remoteUrl", EmitDefaultValue=false)]
        public string RemoteUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signerMustAcknowledge", EmitDefaultValue=false)]
        public string SignerMustAcknowledge { get; set; }
        /// <summary>
        /// When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. 
        /// </summary>
        /// <value>When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. </value>
        [DataMember(Name="templateLocked", EmitDefaultValue=false)]
        public string TemplateLocked { get; set; }
        /// <summary>
        /// When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.
        /// </summary>
        /// <value>When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.</value>
        [DataMember(Name="templateRequired", EmitDefaultValue=false)]
        public string TemplateRequired { get; set; }
        /// <summary>
        /// When set to **true**, PDF form field data is transformed into document tab values when the PDF form field name matches the DocuSign custom tab tabLabel. The resulting PDF form data is also returned in the PDF meta data when requesting the document PDF. See the [ML:Transform PDF Fields] section for more information about how fields are transformed into DocuSign tabs. 
        /// </summary>
        /// <value>When set to **true**, PDF form field data is transformed into document tab values when the PDF form field name matches the DocuSign custom tab tabLabel. The resulting PDF form data is also returned in the PDF meta data when requesting the document PDF. See the [ML:Transform PDF Fields] section for more information about how fields are transformed into DocuSign tabs. </value>
        [DataMember(Name="transformPdfFields", EmitDefaultValue=false)]
        public string TransformPdfFields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  ApplyAnchorTabs: ").Append(ApplyAnchorTabs).Append("\n");
            sb.Append("  AuthoritativeCopy: ").Append(AuthoritativeCopy).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  DocumentBase64: ").Append(DocumentBase64).Append("\n");
            sb.Append("  DocumentFields: ").Append(DocumentFields).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  EncryptedWithKeyManager: ").Append(EncryptedWithKeyManager).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  FileFormatHint: ").Append(FileFormatHint).Append("\n");
            sb.Append("  HtmlDefinition: ").Append(HtmlDefinition).Append("\n");
            sb.Append("  IncludeInDownload: ").Append(IncludeInDownload).Append("\n");
            sb.Append("  MatchBoxes: ").Append(MatchBoxes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RemoteUrl: ").Append(RemoteUrl).Append("\n");
            sb.Append("  SignerMustAcknowledge: ").Append(SignerMustAcknowledge).Append("\n");
            sb.Append("  TemplateLocked: ").Append(TemplateLocked).Append("\n");
            sb.Append("  TemplateRequired: ").Append(TemplateRequired).Append("\n");
            sb.Append("  TransformPdfFields: ").Append(TransformPdfFields).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApplyAnchorTabs == other.ApplyAnchorTabs ||
                    this.ApplyAnchorTabs != null &&
                    this.ApplyAnchorTabs.Equals(other.ApplyAnchorTabs)
                ) && 
                (
                    this.AuthoritativeCopy == other.AuthoritativeCopy ||
                    this.AuthoritativeCopy != null &&
                    this.AuthoritativeCopy.Equals(other.AuthoritativeCopy)
                ) && 
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) && 
                (
                    this.DocumentBase64 == other.DocumentBase64 ||
                    this.DocumentBase64 != null &&
                    this.DocumentBase64.Equals(other.DocumentBase64)
                ) && 
                (
                    this.DocumentFields == other.DocumentFields ||
                    this.DocumentFields != null &&
                    this.DocumentFields.SequenceEqual(other.DocumentFields)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.EncryptedWithKeyManager == other.EncryptedWithKeyManager ||
                    this.EncryptedWithKeyManager != null &&
                    this.EncryptedWithKeyManager.Equals(other.EncryptedWithKeyManager)
                ) && 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
                ) && 
                (
                    this.FileFormatHint == other.FileFormatHint ||
                    this.FileFormatHint != null &&
                    this.FileFormatHint.Equals(other.FileFormatHint)
                ) && 
                (
                    this.HtmlDefinition == other.HtmlDefinition ||
                    this.HtmlDefinition != null &&
                    this.HtmlDefinition.Equals(other.HtmlDefinition)
                ) && 
                (
                    this.IncludeInDownload == other.IncludeInDownload ||
                    this.IncludeInDownload != null &&
                    this.IncludeInDownload.Equals(other.IncludeInDownload)
                ) && 
                (
                    this.MatchBoxes == other.MatchBoxes ||
                    this.MatchBoxes != null &&
                    this.MatchBoxes.SequenceEqual(other.MatchBoxes)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.Equals(other.Pages)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.RemoteUrl == other.RemoteUrl ||
                    this.RemoteUrl != null &&
                    this.RemoteUrl.Equals(other.RemoteUrl)
                ) && 
                (
                    this.SignerMustAcknowledge == other.SignerMustAcknowledge ||
                    this.SignerMustAcknowledge != null &&
                    this.SignerMustAcknowledge.Equals(other.SignerMustAcknowledge)
                ) && 
                (
                    this.TemplateLocked == other.TemplateLocked ||
                    this.TemplateLocked != null &&
                    this.TemplateLocked.Equals(other.TemplateLocked)
                ) && 
                (
                    this.TemplateRequired == other.TemplateRequired ||
                    this.TemplateRequired != null &&
                    this.TemplateRequired.Equals(other.TemplateRequired)
                ) && 
                (
                    this.TransformPdfFields == other.TransformPdfFields ||
                    this.TransformPdfFields != null &&
                    this.TransformPdfFields.Equals(other.TransformPdfFields)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.ApplyAnchorTabs != null)
                    hash = hash * 59 + this.ApplyAnchorTabs.GetHashCode();
                if (this.AuthoritativeCopy != null)
                    hash = hash * 59 + this.AuthoritativeCopy.GetHashCode();
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                if (this.DocumentBase64 != null)
                    hash = hash * 59 + this.DocumentBase64.GetHashCode();
                if (this.DocumentFields != null)
                    hash = hash * 59 + this.DocumentFields.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.EncryptedWithKeyManager != null)
                    hash = hash * 59 + this.EncryptedWithKeyManager.GetHashCode();
                if (this.FileExtension != null)
                    hash = hash * 59 + this.FileExtension.GetHashCode();
                if (this.FileFormatHint != null)
                    hash = hash * 59 + this.FileFormatHint.GetHashCode();
                if (this.HtmlDefinition != null)
                    hash = hash * 59 + this.HtmlDefinition.GetHashCode();
                if (this.IncludeInDownload != null)
                    hash = hash * 59 + this.IncludeInDownload.GetHashCode();
                if (this.MatchBoxes != null)
                    hash = hash * 59 + this.MatchBoxes.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Pages != null)
                    hash = hash * 59 + this.Pages.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.RemoteUrl != null)
                    hash = hash * 59 + this.RemoteUrl.GetHashCode();
                if (this.SignerMustAcknowledge != null)
                    hash = hash * 59 + this.SignerMustAcknowledge.GetHashCode();
                if (this.TemplateLocked != null)
                    hash = hash * 59 + this.TemplateLocked.GetHashCode();
                if (this.TemplateRequired != null)
                    hash = hash * 59 + this.TemplateRequired.GetHashCode();
                if (this.TransformPdfFields != null)
                    hash = hash * 59 + this.TransformPdfFields.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
