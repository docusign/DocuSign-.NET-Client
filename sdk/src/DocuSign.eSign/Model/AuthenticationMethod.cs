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
    /// Contains information about the method used for authentication.
    /// </summary>
    [DataContract]
    public partial class AuthenticationMethod :  IEquatable<AuthenticationMethod>, IValidatableObject
    {
        public AuthenticationMethod()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationMethod" /> class.
        /// </summary>
        /// <param name="AuthenticationType">Indicates the type of authentication. Valid values are: PhoneAuth, STAN, ISCheck, OFAC, AccessCode, AgeVerify, or SSOAuth. .</param>
        /// <param name="LastProvider">The last provider that authenticated the user. .</param>
        /// <param name="LastTimestamp"> The data and time the user last used the authentication method. .</param>
        /// <param name="TotalCount">The number of times the authentication method was used. .</param>
        public AuthenticationMethod(string AuthenticationType = default(string), string LastProvider = default(string), string LastTimestamp = default(string), string TotalCount = default(string))
        {
            this.AuthenticationType = AuthenticationType;
            this.LastProvider = LastProvider;
            this.LastTimestamp = LastTimestamp;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// Indicates the type of authentication. Valid values are: PhoneAuth, STAN, ISCheck, OFAC, AccessCode, AgeVerify, or SSOAuth. 
        /// </summary>
        /// <value>Indicates the type of authentication. Valid values are: PhoneAuth, STAN, ISCheck, OFAC, AccessCode, AgeVerify, or SSOAuth. </value>
        [DataMember(Name="authenticationType", EmitDefaultValue=false)]
        public string AuthenticationType { get; set; }
        /// <summary>
        /// The last provider that authenticated the user. 
        /// </summary>
        /// <value>The last provider that authenticated the user. </value>
        [DataMember(Name="lastProvider", EmitDefaultValue=false)]
        public string LastProvider { get; set; }
        /// <summary>
        ///  The data and time the user last used the authentication method. 
        /// </summary>
        /// <value> The data and time the user last used the authentication method. </value>
        [DataMember(Name="lastTimestamp", EmitDefaultValue=false)]
        public string LastTimestamp { get; set; }
        /// <summary>
        /// The number of times the authentication method was used. 
        /// </summary>
        /// <value>The number of times the authentication method was used. </value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public string TotalCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationMethod {\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  LastProvider: ").Append(LastProvider).Append("\n");
            sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(obj as AuthenticationMethod);
        }

        /// <summary>
        /// Returns true if AuthenticationMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationType == other.AuthenticationType ||
                    this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(other.AuthenticationType)
                ) && 
                (
                    this.LastProvider == other.LastProvider ||
                    this.LastProvider != null &&
                    this.LastProvider.Equals(other.LastProvider)
                ) && 
                (
                    this.LastTimestamp == other.LastTimestamp ||
                    this.LastTimestamp != null &&
                    this.LastTimestamp.Equals(other.LastTimestamp)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
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
                if (this.AuthenticationType != null)
                    hash = hash * 59 + this.AuthenticationType.GetHashCode();
                if (this.LastProvider != null)
                    hash = hash * 59 + this.LastProvider.GetHashCode();
                if (this.LastTimestamp != null)
                    hash = hash * 59 + this.LastTimestamp.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
