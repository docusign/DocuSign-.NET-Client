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
    /// FavoriteTemplatesInfo
    /// </summary>
    [DataContract]
    public partial class FavoriteTemplatesInfo :  IEquatable<FavoriteTemplatesInfo>, IValidatableObject
    {
        public FavoriteTemplatesInfo()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteTemplatesInfo" /> class.
        /// </summary>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="FavoriteTemplates">FavoriteTemplates.</param>
        /// <param name="TemplatesUpdatedCount">TemplatesUpdatedCount.</param>
        public FavoriteTemplatesInfo(ErrorDetails ErrorDetails = default(ErrorDetails), List<FavoriteTemplatesContentItem> FavoriteTemplates = default(List<FavoriteTemplatesContentItem>), int? TemplatesUpdatedCount = default(int?))
        {
            this.ErrorDetails = ErrorDetails;
            this.FavoriteTemplates = FavoriteTemplates;
            this.TemplatesUpdatedCount = TemplatesUpdatedCount;
        }
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets FavoriteTemplates
        /// </summary>
        [DataMember(Name="favoriteTemplates", EmitDefaultValue=false)]
        public List<FavoriteTemplatesContentItem> FavoriteTemplates { get; set; }
        /// <summary>
        /// Gets or Sets TemplatesUpdatedCount
        /// </summary>
        [DataMember(Name="templatesUpdatedCount", EmitDefaultValue=false)]
        public int? TemplatesUpdatedCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoriteTemplatesInfo {\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  FavoriteTemplates: ").Append(FavoriteTemplates).Append("\n");
            sb.Append("  TemplatesUpdatedCount: ").Append(TemplatesUpdatedCount).Append("\n");
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
            return this.Equals(obj as FavoriteTemplatesInfo);
        }

        /// <summary>
        /// Returns true if FavoriteTemplatesInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of FavoriteTemplatesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteTemplatesInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.FavoriteTemplates == other.FavoriteTemplates ||
                    this.FavoriteTemplates != null &&
                    this.FavoriteTemplates.SequenceEqual(other.FavoriteTemplates)
                ) && 
                (
                    this.TemplatesUpdatedCount == other.TemplatesUpdatedCount ||
                    this.TemplatesUpdatedCount != null &&
                    this.TemplatesUpdatedCount.Equals(other.TemplatesUpdatedCount)
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
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.FavoriteTemplates != null)
                    hash = hash * 59 + this.FavoriteTemplates.GetHashCode();
                if (this.TemplatesUpdatedCount != null)
                    hash = hash * 59 + this.TemplatesUpdatedCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
