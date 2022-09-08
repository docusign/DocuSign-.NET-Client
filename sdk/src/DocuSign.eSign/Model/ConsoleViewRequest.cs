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
    /// The request object for the [EnvelopeViews: createConsole](/docs/esign-rest-api/reference/envelopes/envelopeviews/createconsole/) method.
    /// </summary>
    [DataContract]
    public partial class ConsoleViewRequest :  IEquatable<ConsoleViewRequest>, IValidatableObject
    {
        public ConsoleViewRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleViewRequest" /> class.
        /// </summary>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="ReturnUrl">The URL to be redirected to after the console view session has ended..</param>
        public ConsoleViewRequest(string EnvelopeId = default(string), string ReturnUrl = default(string))
        {
            this.EnvelopeId = EnvelopeId;
            this.ReturnUrl = ReturnUrl;
        }
        
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// The URL to be redirected to after the console view session has ended.
        /// </summary>
        /// <value>The URL to be redirected to after the console view session has ended.</value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsoleViewRequest {\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
            return this.Equals(obj as ConsoleViewRequest);
        }

        /// <summary>
        /// Returns true if ConsoleViewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsoleViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsoleViewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
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
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
