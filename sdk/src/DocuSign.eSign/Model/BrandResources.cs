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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// BrandResources
    /// </summary>
    [DataContract]
    public partial class BrandResources :  IEquatable<BrandResources>, IValidatableObject
    {
        public BrandResources()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandResources" /> class.
        /// </summary>
        /// <param name="CreatedByUserInfo">CreatedByUserInfo.</param>
        /// <param name="CreatedDate">.</param>
        /// <param name="DataNotSavedNotInMaster">.</param>
        /// <param name="ModifiedByUserInfo">ModifiedByUserInfo.</param>
        /// <param name="ModifiedDate">.</param>
        /// <param name="ModifiedTemplates">.</param>
        /// <param name="ResourcesContentType">.</param>
        /// <param name="ResourcesContentUri">.</param>
        public BrandResources(UserInfo CreatedByUserInfo = default(UserInfo), string CreatedDate = default(string), List<string> DataNotSavedNotInMaster = default(List<string>), UserInfo ModifiedByUserInfo = default(UserInfo), string ModifiedDate = default(string), List<string> ModifiedTemplates = default(List<string>), string ResourcesContentType = default(string), string ResourcesContentUri = default(string))
        {
            this.CreatedByUserInfo = CreatedByUserInfo;
            this.CreatedDate = CreatedDate;
            this.DataNotSavedNotInMaster = DataNotSavedNotInMaster;
            this.ModifiedByUserInfo = ModifiedByUserInfo;
            this.ModifiedDate = ModifiedDate;
            this.ModifiedTemplates = ModifiedTemplates;
            this.ResourcesContentType = ResourcesContentType;
            this.ResourcesContentUri = ResourcesContentUri;
        }
        
        /// <summary>
        /// Gets or Sets CreatedByUserInfo
        /// </summary>
        [DataMember(Name="createdByUserInfo", EmitDefaultValue=false)]
        public UserInfo CreatedByUserInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dataNotSavedNotInMaster", EmitDefaultValue=false)]
        public List<string> DataNotSavedNotInMaster { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedByUserInfo
        /// </summary>
        [DataMember(Name="modifiedByUserInfo", EmitDefaultValue=false)]
        public UserInfo ModifiedByUserInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public string ModifiedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedTemplates", EmitDefaultValue=false)]
        public List<string> ModifiedTemplates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="resourcesContentType", EmitDefaultValue=false)]
        public string ResourcesContentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="resourcesContentUri", EmitDefaultValue=false)]
        public string ResourcesContentUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandResources {\n");
            sb.Append("  CreatedByUserInfo: ").Append(CreatedByUserInfo).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  DataNotSavedNotInMaster: ").Append(DataNotSavedNotInMaster).Append("\n");
            sb.Append("  ModifiedByUserInfo: ").Append(ModifiedByUserInfo).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedTemplates: ").Append(ModifiedTemplates).Append("\n");
            sb.Append("  ResourcesContentType: ").Append(ResourcesContentType).Append("\n");
            sb.Append("  ResourcesContentUri: ").Append(ResourcesContentUri).Append("\n");
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
            return this.Equals(obj as BrandResources);
        }

        /// <summary>
        /// Returns true if BrandResources instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandResources other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedByUserInfo == other.CreatedByUserInfo ||
                    this.CreatedByUserInfo != null &&
                    this.CreatedByUserInfo.Equals(other.CreatedByUserInfo)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.DataNotSavedNotInMaster == other.DataNotSavedNotInMaster ||
                    this.DataNotSavedNotInMaster != null &&
                    this.DataNotSavedNotInMaster.SequenceEqual(other.DataNotSavedNotInMaster)
                ) && 
                (
                    this.ModifiedByUserInfo == other.ModifiedByUserInfo ||
                    this.ModifiedByUserInfo != null &&
                    this.ModifiedByUserInfo.Equals(other.ModifiedByUserInfo)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.ModifiedTemplates == other.ModifiedTemplates ||
                    this.ModifiedTemplates != null &&
                    this.ModifiedTemplates.SequenceEqual(other.ModifiedTemplates)
                ) && 
                (
                    this.ResourcesContentType == other.ResourcesContentType ||
                    this.ResourcesContentType != null &&
                    this.ResourcesContentType.Equals(other.ResourcesContentType)
                ) && 
                (
                    this.ResourcesContentUri == other.ResourcesContentUri ||
                    this.ResourcesContentUri != null &&
                    this.ResourcesContentUri.Equals(other.ResourcesContentUri)
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
                if (this.CreatedByUserInfo != null)
                    hash = hash * 59 + this.CreatedByUserInfo.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.DataNotSavedNotInMaster != null)
                    hash = hash * 59 + this.DataNotSavedNotInMaster.GetHashCode();
                if (this.ModifiedByUserInfo != null)
                    hash = hash * 59 + this.ModifiedByUserInfo.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.ModifiedTemplates != null)
                    hash = hash * 59 + this.ModifiedTemplates.GetHashCode();
                if (this.ResourcesContentType != null)
                    hash = hash * 59 + this.ResourcesContentType.GetHashCode();
                if (this.ResourcesContentUri != null)
                    hash = hash * 59 + this.ResourcesContentUri.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
