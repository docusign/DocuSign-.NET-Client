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
    /// UserAuthorization
    /// </summary>
    [DataContract]
    public partial class UserAuthorization :  IEquatable<UserAuthorization>, IValidatableObject
    {
        public UserAuthorization()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthorization" /> class.
        /// </summary>
        /// <param name="AgentUser">AgentUser.</param>
        /// <param name="AuthorizationId">AuthorizationId.</param>
        /// <param name="Created">Created.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="Permission">Permission.</param>
        /// <param name="PrincipalUser">PrincipalUser.</param>
        /// <param name="StartDate">StartDate.</param>
        public UserAuthorization(AuthorizationUser AgentUser = default(AuthorizationUser), string AuthorizationId = default(string), string Created = default(string), string CreatedBy = default(string), string EndDate = default(string), string Modified = default(string), string ModifiedBy = default(string), string Permission = default(string), AuthorizationUser PrincipalUser = default(AuthorizationUser), string StartDate = default(string))
        {
            this.AgentUser = AgentUser;
            this.AuthorizationId = AuthorizationId;
            this.Created = Created;
            this.CreatedBy = CreatedBy;
            this.EndDate = EndDate;
            this.Modified = Modified;
            this.ModifiedBy = ModifiedBy;
            this.Permission = Permission;
            this.PrincipalUser = PrincipalUser;
            this.StartDate = StartDate;
        }
        
        /// <summary>
        /// Gets or Sets AgentUser
        /// </summary>
        [DataMember(Name="agentUser", EmitDefaultValue=false)]
        public AuthorizationUser AgentUser { get; set; }
        /// <summary>
        /// Gets or Sets AuthorizationId
        /// </summary>
        [DataMember(Name="authorizationId", EmitDefaultValue=false)]
        public string AuthorizationId { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }
        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public string Modified { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public string Permission { get; set; }
        /// <summary>
        /// Gets or Sets PrincipalUser
        /// </summary>
        [DataMember(Name="principalUser", EmitDefaultValue=false)]
        public AuthorizationUser PrincipalUser { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAuthorization {\n");
            sb.Append("  AgentUser: ").Append(AgentUser).Append("\n");
            sb.Append("  AuthorizationId: ").Append(AuthorizationId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  PrincipalUser: ").Append(PrincipalUser).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(obj as UserAuthorization);
        }

        /// <summary>
        /// Returns true if UserAuthorization instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthorization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AgentUser == other.AgentUser ||
                    this.AgentUser != null &&
                    this.AgentUser.Equals(other.AgentUser)
                ) && 
                (
                    this.AuthorizationId == other.AuthorizationId ||
                    this.AuthorizationId != null &&
                    this.AuthorizationId.Equals(other.AuthorizationId)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) && 
                (
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.PrincipalUser == other.PrincipalUser ||
                    this.PrincipalUser != null &&
                    this.PrincipalUser.Equals(other.PrincipalUser)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
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
                if (this.AgentUser != null)
                    hash = hash * 59 + this.AgentUser.GetHashCode();
                if (this.AuthorizationId != null)
                    hash = hash * 59 + this.AuthorizationId.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.PrincipalUser != null)
                    hash = hash * 59 + this.PrincipalUser.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
