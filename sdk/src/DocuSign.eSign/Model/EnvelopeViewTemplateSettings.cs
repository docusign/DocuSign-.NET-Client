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
    /// EnvelopeViewTemplateSettings
    /// </summary>
    [DataContract]
    public partial class EnvelopeViewTemplateSettings :  IEquatable<EnvelopeViewTemplateSettings>, IValidatableObject
    {
        public EnvelopeViewTemplateSettings()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeViewTemplateSettings" /> class.
        /// </summary>
        /// <param name="ShowMatchingTemplatesPrompt">ShowMatchingTemplatesPrompt.</param>
        public EnvelopeViewTemplateSettings(string ShowMatchingTemplatesPrompt = default(string))
        {
            this.ShowMatchingTemplatesPrompt = ShowMatchingTemplatesPrompt;
        }
        
        /// <summary>
        /// Gets or Sets ShowMatchingTemplatesPrompt
        /// </summary>
        [DataMember(Name="showMatchingTemplatesPrompt", EmitDefaultValue=false)]
        public string ShowMatchingTemplatesPrompt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeViewTemplateSettings {\n");
            sb.Append("  ShowMatchingTemplatesPrompt: ").Append(ShowMatchingTemplatesPrompt).Append("\n");
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
            return this.Equals(obj as EnvelopeViewTemplateSettings);
        }

        /// <summary>
        /// Returns true if EnvelopeViewTemplateSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeViewTemplateSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeViewTemplateSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShowMatchingTemplatesPrompt == other.ShowMatchingTemplatesPrompt ||
                    this.ShowMatchingTemplatesPrompt != null &&
                    this.ShowMatchingTemplatesPrompt.Equals(other.ShowMatchingTemplatesPrompt)
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
                if (this.ShowMatchingTemplatesPrompt != null)
                    hash = hash * 59 + this.ShowMatchingTemplatesPrompt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
