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
    /// ResourceInformation
    /// </summary>
    [DataContract]
    public partial class ResourceInformation :  IEquatable<ResourceInformation>, IValidatableObject
    {
        public ResourceInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInformation" /> class.
        /// </summary>
        /// <param name="Resources">Resources.</param>
        public ResourceInformation(List<NameValue> Resources = default(List<NameValue>))
        {
            this.Resources = Resources;
        }
        
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<NameValue> Resources { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceInformation {\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(obj as ResourceInformation);
        }

        /// <summary>
        /// Returns true if ResourceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(other.Resources)
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
                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
