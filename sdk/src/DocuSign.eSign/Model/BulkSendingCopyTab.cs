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
    /// A tab associated with the bulk send recipient. In a bulk send request, each recipient tab must match a recipient tab on the envelope or template that you want to send. To match up, the &#x60;tabLabel&#x60; for this tab and the &#x60;tabLabel&#x60; for the corresponding tab on the envelope or template must be the same.  For example, if the envelope has a placeholder text tab with the &#x60;tabLabel&#x60; &#x60;childName&#x60;, you must assign the same &#x60;tabLabel&#x60; &#x60;childName&#x60; to the tab here that you are populating with that information.
    /// </summary>
    [DataContract]
    public partial class BulkSendingCopyTab :  IEquatable<BulkSendingCopyTab>, IValidatableObject
    {
        public BulkSendingCopyTab()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendingCopyTab" /> class.
        /// </summary>
        /// <param name="InitialValue">The original value of the tab..</param>
        /// <param name="TabLabel">The label string associated with the tab..</param>
        public BulkSendingCopyTab(string InitialValue = default(string), string TabLabel = default(string))
        {
            this.InitialValue = InitialValue;
            this.TabLabel = TabLabel;
        }
        
        /// <summary>
        /// The original value of the tab.
        /// </summary>
        /// <value>The original value of the tab.</value>
        [DataMember(Name="initialValue", EmitDefaultValue=false)]
        public string InitialValue { get; set; }
        /// <summary>
        /// The label string associated with the tab.
        /// </summary>
        /// <value>The label string associated with the tab.</value>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendingCopyTab {\n");
            sb.Append("  InitialValue: ").Append(InitialValue).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
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
            return this.Equals(obj as BulkSendingCopyTab);
        }

        /// <summary>
        /// Returns true if BulkSendingCopyTab instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendingCopyTab to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendingCopyTab other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InitialValue == other.InitialValue ||
                    this.InitialValue != null &&
                    this.InitialValue.Equals(other.InitialValue)
                ) && 
                (
                    this.TabLabel == other.TabLabel ||
                    this.TabLabel != null &&
                    this.TabLabel.Equals(other.TabLabel)
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
                if (this.InitialValue != null)
                    hash = hash * 59 + this.InitialValue.GetHashCode();
                if (this.TabLabel != null)
                    hash = hash * 59 + this.TabLabel.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
