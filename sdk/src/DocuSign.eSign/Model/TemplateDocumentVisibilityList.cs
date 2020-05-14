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
    /// TemplateDocumentVisibilityList
    /// </summary>
    [DataContract]
    public partial class TemplateDocumentVisibilityList :  IEquatable<TemplateDocumentVisibilityList>, IValidatableObject
    {
        public TemplateDocumentVisibilityList()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDocumentVisibilityList" /> class.
        /// </summary>
        /// <param name="DocumentVisibility">DocumentVisibility.</param>
        public TemplateDocumentVisibilityList(List<DocumentVisibility> DocumentVisibility = default(List<DocumentVisibility>))
        {
            this.DocumentVisibility = DocumentVisibility;
        }
        
        /// <summary>
        /// Gets or Sets DocumentVisibility
        /// </summary>
        [DataMember(Name="documentVisibility", EmitDefaultValue=false)]
        public List<DocumentVisibility> DocumentVisibility { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateDocumentVisibilityList {\n");
            sb.Append("  DocumentVisibility: ").Append(DocumentVisibility).Append("\n");
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
            return this.Equals(obj as TemplateDocumentVisibilityList);
        }

        /// <summary>
        /// Returns true if TemplateDocumentVisibilityList instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateDocumentVisibilityList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateDocumentVisibilityList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentVisibility == other.DocumentVisibility ||
                    this.DocumentVisibility != null &&
                    this.DocumentVisibility.SequenceEqual(other.DocumentVisibility)
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
                if (this.DocumentVisibility != null)
                    hash = hash * 59 + this.DocumentVisibility.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
