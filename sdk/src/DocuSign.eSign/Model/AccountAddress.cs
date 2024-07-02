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
    /// Contains information about an account address.
    /// </summary>
    [DataContract]
    public partial class AccountAddress :  IEquatable<AccountAddress>, IValidatableObject
    {
        public AccountAddress()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAddress" /> class.
        /// </summary>
        /// <param name="Address1">First Line of the address. Maximum length: 100 characters..</param>
        /// <param name="Address2">Second Line of the address. Maximum length: 100 characters..</param>
        /// <param name="City">The city value of the address..</param>
        /// <param name="Country">Specifies the country associated with the address..</param>
        /// <param name="Email">Email.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="FirstName">The user&#39;s first name.  Maximum Length: 50 characters..</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="PostalCode">PostalCode.</param>
        /// <param name="State">The state or province associated with the address..</param>
        /// <param name="SupportedCountries">Contains an array of countries supported by the billing plan..</param>
        public AccountAddress(string Address1 = default(string), string Address2 = default(string), string City = default(string), string Country = default(string), string Email = default(string), string Fax = default(string), string FirstName = default(string), string LastName = default(string), string Phone = default(string), string PostalCode = default(string), string State = default(string), List<Country> SupportedCountries = default(List<Country>))
        {
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.Country = Country;
            this.Email = Email;
            this.Fax = Fax;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.PostalCode = PostalCode;
            this.State = State;
            this.SupportedCountries = SupportedCountries;
        }
        
        /// <summary>
        /// First Line of the address. Maximum length: 100 characters.
        /// </summary>
        /// <value>First Line of the address. Maximum length: 100 characters.</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }
        /// <summary>
        /// Second Line of the address. Maximum length: 100 characters.
        /// </summary>
        /// <value>Second Line of the address. Maximum length: 100 characters.</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }
        /// <summary>
        /// The city value of the address.
        /// </summary>
        /// <value>The city value of the address.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Specifies the country associated with the address.
        /// </summary>
        /// <value>Specifies the country associated with the address.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
        /// <summary>
        /// The user&#39;s first name.  Maximum Length: 50 characters.
        /// </summary>
        /// <value>The user&#39;s first name.  Maximum Length: 50 characters.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// The state or province associated with the address.
        /// </summary>
        /// <value>The state or province associated with the address.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Contains an array of countries supported by the billing plan.
        /// </summary>
        /// <value>Contains an array of countries supported by the billing plan.</value>
        [DataMember(Name="supportedCountries", EmitDefaultValue=false)]
        public List<Country> SupportedCountries { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAddress {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SupportedCountries: ").Append(SupportedCountries).Append("\n");
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
            return this.Equals(obj as AccountAddress);
        }

        /// <summary>
        /// Returns true if AccountAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SupportedCountries == other.SupportedCountries ||
                    this.SupportedCountries != null &&
                    this.SupportedCountries.SequenceEqual(other.SupportedCountries)
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
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SupportedCountries != null)
                    hash = hash * 59 + this.SupportedCountries.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
