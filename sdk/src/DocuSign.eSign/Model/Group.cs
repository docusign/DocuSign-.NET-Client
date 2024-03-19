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
    /// This object contains information about a group.
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>, IValidatableObject
    {
        public Group()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="AccessType">AccessType.</param>
        /// <param name="DsGroupId">DsGroupId.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="GroupId">The DocuSign group ID for the group..</param>
        /// <param name="GroupName">The name of the group..</param>
        /// <param name="GroupType">The group type..</param>
        /// <param name="PermissionProfileId">The ID of the permission profile associated with the group..</param>
        /// <param name="Users">Users.</param>
        /// <param name="UsersCount">UsersCount.</param>
        public Group(string AccessType = default(string), string DsGroupId = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string GroupId = default(string), string GroupName = default(string), string GroupType = default(string), string PermissionProfileId = default(string), List<UserInfo> Users = default(List<UserInfo>), string UsersCount = default(string))
        {
            this.AccessType = AccessType;
            this.DsGroupId = DsGroupId;
            this.ErrorDetails = ErrorDetails;
            this.GroupId = GroupId;
            this.GroupName = GroupName;
            this.GroupType = GroupType;
            this.PermissionProfileId = PermissionProfileId;
            this.Users = Users;
            this.UsersCount = UsersCount;
        }
        
        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name="accessType", EmitDefaultValue=false)]
        public string AccessType { get; set; }
        /// <summary>
        /// Gets or Sets DsGroupId
        /// </summary>
        [DataMember(Name="dsGroupId", EmitDefaultValue=false)]
        public string DsGroupId { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// The DocuSign group ID for the group.
        /// </summary>
        /// <value>The DocuSign group ID for the group.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        /// <summary>
        /// The name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
        /// <summary>
        /// The group type.
        /// </summary>
        /// <value>The group type.</value>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public string GroupType { get; set; }
        /// <summary>
        /// The ID of the permission profile associated with the group.
        /// </summary>
        /// <value>The ID of the permission profile associated with the group.</value>
        [DataMember(Name="permissionProfileId", EmitDefaultValue=false)]
        public string PermissionProfileId { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserInfo> Users { get; set; }
        /// <summary>
        /// Gets or Sets UsersCount
        /// </summary>
        [DataMember(Name="usersCount", EmitDefaultValue=false)]
        public string UsersCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  DsGroupId: ").Append(DsGroupId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  PermissionProfileId: ").Append(PermissionProfileId).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  UsersCount: ").Append(UsersCount).Append("\n");
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
            return this.Equals(obj as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="other">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessType == other.AccessType ||
                    this.AccessType != null &&
                    this.AccessType.Equals(other.AccessType)
                ) && 
                (
                    this.DsGroupId == other.DsGroupId ||
                    this.DsGroupId != null &&
                    this.DsGroupId.Equals(other.DsGroupId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
                ) && 
                (
                    this.GroupType == other.GroupType ||
                    this.GroupType != null &&
                    this.GroupType.Equals(other.GroupType)
                ) && 
                (
                    this.PermissionProfileId == other.PermissionProfileId ||
                    this.PermissionProfileId != null &&
                    this.PermissionProfileId.Equals(other.PermissionProfileId)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) && 
                (
                    this.UsersCount == other.UsersCount ||
                    this.UsersCount != null &&
                    this.UsersCount.Equals(other.UsersCount)
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
                if (this.AccessType != null)
                    hash = hash * 59 + this.AccessType.GetHashCode();
                if (this.DsGroupId != null)
                    hash = hash * 59 + this.DsGroupId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
                if (this.GroupType != null)
                    hash = hash * 59 + this.GroupType.GetHashCode();
                if (this.PermissionProfileId != null)
                    hash = hash * 59 + this.PermissionProfileId.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.UsersCount != null)
                    hash = hash * 59 + this.UsersCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
