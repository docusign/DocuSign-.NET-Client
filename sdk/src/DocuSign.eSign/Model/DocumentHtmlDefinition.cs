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
    /// DocumentHtmlDefinition
    /// </summary>
    [DataContract]
    public partial class DocumentHtmlDefinition :  IEquatable<DocumentHtmlDefinition>, IValidatableObject
    {
        public DocumentHtmlDefinition()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentHtmlDefinition" /> class.
        /// </summary>
        /// <param name="DisplayAnchorPrefix">DisplayAnchorPrefix.</param>
        /// <param name="DisplayAnchors">DisplayAnchors.</param>
        /// <param name="DisplayOrder">DisplayOrder.</param>
        /// <param name="DisplayPageNumber">DisplayPageNumber.</param>
        /// <param name="DocumentGuid">DocumentGuid.</param>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="HeaderLabel">HeaderLabel.</param>
        /// <param name="MaxScreenWidth">MaxScreenWidth.</param>
        /// <param name="RemoveEmptyTags">RemoveEmptyTags.</param>
        /// <param name="ShowMobileOptimizedToggle">ShowMobileOptimizedToggle.</param>
        /// <param name="Source">Source.</param>
        public DocumentHtmlDefinition(string DisplayAnchorPrefix = default(string), List<DocumentHtmlDisplayAnchor> DisplayAnchors = default(List<DocumentHtmlDisplayAnchor>), string DisplayOrder = default(string), string DisplayPageNumber = default(string), string DocumentGuid = default(string), string DocumentId = default(string), string HeaderLabel = default(string), string MaxScreenWidth = default(string), string RemoveEmptyTags = default(string), string ShowMobileOptimizedToggle = default(string), string Source = default(string))
        {
            this.DisplayAnchorPrefix = DisplayAnchorPrefix;
            this.DisplayAnchors = DisplayAnchors;
            this.DisplayOrder = DisplayOrder;
            this.DisplayPageNumber = DisplayPageNumber;
            this.DocumentGuid = DocumentGuid;
            this.DocumentId = DocumentId;
            this.HeaderLabel = HeaderLabel;
            this.MaxScreenWidth = MaxScreenWidth;
            this.RemoveEmptyTags = RemoveEmptyTags;
            this.ShowMobileOptimizedToggle = ShowMobileOptimizedToggle;
            this.Source = Source;
        }
        
        /// <summary>
        /// Gets or Sets DisplayAnchorPrefix
        /// </summary>
        [DataMember(Name="displayAnchorPrefix", EmitDefaultValue=false)]
        public string DisplayAnchorPrefix { get; set; }
        /// <summary>
        /// Gets or Sets DisplayAnchors
        /// </summary>
        [DataMember(Name="displayAnchors", EmitDefaultValue=false)]
        public List<DocumentHtmlDisplayAnchor> DisplayAnchors { get; set; }
        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public string DisplayOrder { get; set; }
        /// <summary>
        /// Gets or Sets DisplayPageNumber
        /// </summary>
        [DataMember(Name="displayPageNumber", EmitDefaultValue=false)]
        public string DisplayPageNumber { get; set; }
        /// <summary>
        /// Gets or Sets DocumentGuid
        /// </summary>
        [DataMember(Name="documentGuid", EmitDefaultValue=false)]
        public string DocumentGuid { get; set; }
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// Gets or Sets HeaderLabel
        /// </summary>
        [DataMember(Name="headerLabel", EmitDefaultValue=false)]
        public string HeaderLabel { get; set; }
        /// <summary>
        /// Gets or Sets MaxScreenWidth
        /// </summary>
        [DataMember(Name="maxScreenWidth", EmitDefaultValue=false)]
        public string MaxScreenWidth { get; set; }
        /// <summary>
        /// Gets or Sets RemoveEmptyTags
        /// </summary>
        [DataMember(Name="removeEmptyTags", EmitDefaultValue=false)]
        public string RemoveEmptyTags { get; set; }
        /// <summary>
        /// Gets or Sets ShowMobileOptimizedToggle
        /// </summary>
        [DataMember(Name="showMobileOptimizedToggle", EmitDefaultValue=false)]
        public string ShowMobileOptimizedToggle { get; set; }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentHtmlDefinition {\n");
            sb.Append("  DisplayAnchorPrefix: ").Append(DisplayAnchorPrefix).Append("\n");
            sb.Append("  DisplayAnchors: ").Append(DisplayAnchors).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  DisplayPageNumber: ").Append(DisplayPageNumber).Append("\n");
            sb.Append("  DocumentGuid: ").Append(DocumentGuid).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  HeaderLabel: ").Append(HeaderLabel).Append("\n");
            sb.Append("  MaxScreenWidth: ").Append(MaxScreenWidth).Append("\n");
            sb.Append("  RemoveEmptyTags: ").Append(RemoveEmptyTags).Append("\n");
            sb.Append("  ShowMobileOptimizedToggle: ").Append(ShowMobileOptimizedToggle).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as DocumentHtmlDefinition);
        }

        /// <summary>
        /// Returns true if DocumentHtmlDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentHtmlDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentHtmlDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayAnchorPrefix == other.DisplayAnchorPrefix ||
                    this.DisplayAnchorPrefix != null &&
                    this.DisplayAnchorPrefix.Equals(other.DisplayAnchorPrefix)
                ) && 
                (
                    this.DisplayAnchors == other.DisplayAnchors ||
                    this.DisplayAnchors != null &&
                    this.DisplayAnchors.SequenceEqual(other.DisplayAnchors)
                ) && 
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(other.DisplayOrder)
                ) && 
                (
                    this.DisplayPageNumber == other.DisplayPageNumber ||
                    this.DisplayPageNumber != null &&
                    this.DisplayPageNumber.Equals(other.DisplayPageNumber)
                ) && 
                (
                    this.DocumentGuid == other.DocumentGuid ||
                    this.DocumentGuid != null &&
                    this.DocumentGuid.Equals(other.DocumentGuid)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.HeaderLabel == other.HeaderLabel ||
                    this.HeaderLabel != null &&
                    this.HeaderLabel.Equals(other.HeaderLabel)
                ) && 
                (
                    this.MaxScreenWidth == other.MaxScreenWidth ||
                    this.MaxScreenWidth != null &&
                    this.MaxScreenWidth.Equals(other.MaxScreenWidth)
                ) && 
                (
                    this.RemoveEmptyTags == other.RemoveEmptyTags ||
                    this.RemoveEmptyTags != null &&
                    this.RemoveEmptyTags.Equals(other.RemoveEmptyTags)
                ) && 
                (
                    this.ShowMobileOptimizedToggle == other.ShowMobileOptimizedToggle ||
                    this.ShowMobileOptimizedToggle != null &&
                    this.ShowMobileOptimizedToggle.Equals(other.ShowMobileOptimizedToggle)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                if (this.DisplayAnchorPrefix != null)
                    hash = hash * 59 + this.DisplayAnchorPrefix.GetHashCode();
                if (this.DisplayAnchors != null)
                    hash = hash * 59 + this.DisplayAnchors.GetHashCode();
                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();
                if (this.DisplayPageNumber != null)
                    hash = hash * 59 + this.DisplayPageNumber.GetHashCode();
                if (this.DocumentGuid != null)
                    hash = hash * 59 + this.DocumentGuid.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.HeaderLabel != null)
                    hash = hash * 59 + this.HeaderLabel.GetHashCode();
                if (this.MaxScreenWidth != null)
                    hash = hash * 59 + this.MaxScreenWidth.GetHashCode();
                if (this.RemoveEmptyTags != null)
                    hash = hash * 59 + this.RemoveEmptyTags.GetHashCode();
                if (this.ShowMobileOptimizedToggle != null)
                    hash = hash * 59 + this.ShowMobileOptimizedToggle.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
