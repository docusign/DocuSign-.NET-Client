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
    /// UserProfile
    /// </summary>
    [DataContract]
    public partial class UserProfile :  IEquatable<UserProfile>, IValidatableObject
    {
        public UserProfile()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="Address">The user&#39;s address..</param>
        /// <param name="AuthenticationMethods">These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user..</param>
        /// <param name="CompanyName">The name of the user&#39;s Company..</param>
        /// <param name="DisplayOrganizationInfo"> When set to **true**, the user&#39;s company and title information are shown on the ID card. .</param>
        /// <param name="DisplayPersonalInfo">When set to **true**, the user&#39;s Address and Phone number are shown on the ID card..</param>
        /// <param name="DisplayProfile">When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history..</param>
        /// <param name="DisplayUsageHistory">When set to **true**, the user&#39;s usage information is shown on the ID card..</param>
        /// <param name="ProfileImageUri">ProfileImageUri.</param>
        /// <param name="Title">Title.</param>
        /// <param name="UsageHistory">A complex element consisting of:   - &#x60;lastSentDateTime&#x60;: The date and time the user last sent an envelope.  - &#x60;lastSignedDateTime&#x60;: The date and time the user last signed an envelope. - &#x60;sentCount&#x60;: The number of envelopes the user has sent. - &#x60;signedCount&#x60;: The number of envelopes the user has signed.  .</param>
        /// <param name="UserDetails">UserDetails.</param>
        /// <param name="UserProfileLastModifiedDate">UserProfileLastModifiedDate.</param>
        public UserProfile(AddressInformation Address = default(AddressInformation), List<AuthenticationMethod> AuthenticationMethods = default(List<AuthenticationMethod>), string CompanyName = default(string), string DisplayOrganizationInfo = default(string), string DisplayPersonalInfo = default(string), string DisplayProfile = default(string), string DisplayUsageHistory = default(string), string ProfileImageUri = default(string), string Title = default(string), UsageHistory UsageHistory = default(UsageHistory), UserInformation UserDetails = default(UserInformation), string UserProfileLastModifiedDate = default(string))
        {
            this.Address = Address;
            this.AuthenticationMethods = AuthenticationMethods;
            this.CompanyName = CompanyName;
            this.DisplayOrganizationInfo = DisplayOrganizationInfo;
            this.DisplayPersonalInfo = DisplayPersonalInfo;
            this.DisplayProfile = DisplayProfile;
            this.DisplayUsageHistory = DisplayUsageHistory;
            this.ProfileImageUri = ProfileImageUri;
            this.Title = Title;
            this.UsageHistory = UsageHistory;
            this.UserDetails = UserDetails;
            this.UserProfileLastModifiedDate = UserProfileLastModifiedDate;
        }
        
        /// <summary>
        /// The user&#39;s address.
        /// </summary>
        /// <value>The user&#39;s address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressInformation Address { get; set; }
        /// <summary>
        /// These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user.
        /// </summary>
        /// <value>These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user.</value>
        [DataMember(Name="authenticationMethods", EmitDefaultValue=false)]
        public List<AuthenticationMethod> AuthenticationMethods { get; set; }
        /// <summary>
        /// The name of the user&#39;s Company.
        /// </summary>
        /// <value>The name of the user&#39;s Company.</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        ///  When set to **true**, the user&#39;s company and title information are shown on the ID card. 
        /// </summary>
        /// <value> When set to **true**, the user&#39;s company and title information are shown on the ID card. </value>
        [DataMember(Name="displayOrganizationInfo", EmitDefaultValue=false)]
        public string DisplayOrganizationInfo { get; set; }
        /// <summary>
        /// When set to **true**, the user&#39;s Address and Phone number are shown on the ID card.
        /// </summary>
        /// <value>When set to **true**, the user&#39;s Address and Phone number are shown on the ID card.</value>
        [DataMember(Name="displayPersonalInfo", EmitDefaultValue=false)]
        public string DisplayPersonalInfo { get; set; }
        /// <summary>
        /// When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history.
        /// </summary>
        /// <value>When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history.</value>
        [DataMember(Name="displayProfile", EmitDefaultValue=false)]
        public string DisplayProfile { get; set; }
        /// <summary>
        /// When set to **true**, the user&#39;s usage information is shown on the ID card.
        /// </summary>
        /// <value>When set to **true**, the user&#39;s usage information is shown on the ID card.</value>
        [DataMember(Name="displayUsageHistory", EmitDefaultValue=false)]
        public string DisplayUsageHistory { get; set; }
        /// <summary>
        /// Gets or Sets ProfileImageUri
        /// </summary>
        [DataMember(Name="profileImageUri", EmitDefaultValue=false)]
        public string ProfileImageUri { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// A complex element consisting of:   - &#x60;lastSentDateTime&#x60;: The date and time the user last sent an envelope.  - &#x60;lastSignedDateTime&#x60;: The date and time the user last signed an envelope. - &#x60;sentCount&#x60;: The number of envelopes the user has sent. - &#x60;signedCount&#x60;: The number of envelopes the user has signed.  
        /// </summary>
        /// <value>A complex element consisting of:   - &#x60;lastSentDateTime&#x60;: The date and time the user last sent an envelope.  - &#x60;lastSignedDateTime&#x60;: The date and time the user last signed an envelope. - &#x60;sentCount&#x60;: The number of envelopes the user has sent. - &#x60;signedCount&#x60;: The number of envelopes the user has signed.  </value>
        [DataMember(Name="usageHistory", EmitDefaultValue=false)]
        public UsageHistory UsageHistory { get; set; }
        /// <summary>
        /// Gets or Sets UserDetails
        /// </summary>
        [DataMember(Name="userDetails", EmitDefaultValue=false)]
        public UserInformation UserDetails { get; set; }
        /// <summary>
        /// Gets or Sets UserProfileLastModifiedDate
        /// </summary>
        [DataMember(Name="userProfileLastModifiedDate", EmitDefaultValue=false)]
        public string UserProfileLastModifiedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfile {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AuthenticationMethods: ").Append(AuthenticationMethods).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  DisplayOrganizationInfo: ").Append(DisplayOrganizationInfo).Append("\n");
            sb.Append("  DisplayPersonalInfo: ").Append(DisplayPersonalInfo).Append("\n");
            sb.Append("  DisplayProfile: ").Append(DisplayProfile).Append("\n");
            sb.Append("  DisplayUsageHistory: ").Append(DisplayUsageHistory).Append("\n");
            sb.Append("  ProfileImageUri: ").Append(ProfileImageUri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UsageHistory: ").Append(UsageHistory).Append("\n");
            sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
            sb.Append("  UserProfileLastModifiedDate: ").Append(UserProfileLastModifiedDate).Append("\n");
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
            return this.Equals(obj as UserProfile);
        }

        /// <summary>
        /// Returns true if UserProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.AuthenticationMethods == other.AuthenticationMethods ||
                    this.AuthenticationMethods != null &&
                    this.AuthenticationMethods.SequenceEqual(other.AuthenticationMethods)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.DisplayOrganizationInfo == other.DisplayOrganizationInfo ||
                    this.DisplayOrganizationInfo != null &&
                    this.DisplayOrganizationInfo.Equals(other.DisplayOrganizationInfo)
                ) && 
                (
                    this.DisplayPersonalInfo == other.DisplayPersonalInfo ||
                    this.DisplayPersonalInfo != null &&
                    this.DisplayPersonalInfo.Equals(other.DisplayPersonalInfo)
                ) && 
                (
                    this.DisplayProfile == other.DisplayProfile ||
                    this.DisplayProfile != null &&
                    this.DisplayProfile.Equals(other.DisplayProfile)
                ) && 
                (
                    this.DisplayUsageHistory == other.DisplayUsageHistory ||
                    this.DisplayUsageHistory != null &&
                    this.DisplayUsageHistory.Equals(other.DisplayUsageHistory)
                ) && 
                (
                    this.ProfileImageUri == other.ProfileImageUri ||
                    this.ProfileImageUri != null &&
                    this.ProfileImageUri.Equals(other.ProfileImageUri)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.UsageHistory == other.UsageHistory ||
                    this.UsageHistory != null &&
                    this.UsageHistory.Equals(other.UsageHistory)
                ) && 
                (
                    this.UserDetails == other.UserDetails ||
                    this.UserDetails != null &&
                    this.UserDetails.Equals(other.UserDetails)
                ) && 
                (
                    this.UserProfileLastModifiedDate == other.UserProfileLastModifiedDate ||
                    this.UserProfileLastModifiedDate != null &&
                    this.UserProfileLastModifiedDate.Equals(other.UserProfileLastModifiedDate)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.AuthenticationMethods != null)
                    hash = hash * 59 + this.AuthenticationMethods.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.DisplayOrganizationInfo != null)
                    hash = hash * 59 + this.DisplayOrganizationInfo.GetHashCode();
                if (this.DisplayPersonalInfo != null)
                    hash = hash * 59 + this.DisplayPersonalInfo.GetHashCode();
                if (this.DisplayProfile != null)
                    hash = hash * 59 + this.DisplayProfile.GetHashCode();
                if (this.DisplayUsageHistory != null)
                    hash = hash * 59 + this.DisplayUsageHistory.GetHashCode();
                if (this.ProfileImageUri != null)
                    hash = hash * 59 + this.ProfileImageUri.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.UsageHistory != null)
                    hash = hash * 59 + this.UsageHistory.GetHashCode();
                if (this.UserDetails != null)
                    hash = hash * 59 + this.UserDetails.GetHashCode();
                if (this.UserProfileLastModifiedDate != null)
                    hash = hash * 59 + this.UserProfileLastModifiedDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
