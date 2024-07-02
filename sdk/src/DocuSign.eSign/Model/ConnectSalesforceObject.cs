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
    /// A &#x60;connectSalesforceObject&#x60; is an object that updates envelope and document status or recipient status in your Salesforce account.  When you install DocuSign Connect for Salesforce, the service automatically sets up two Connect objects: one that updates envelope status and documents and one that updates recipient status. You can also customize DocuSign Connect for Salesforce by associating DocuSign objects with Salesforce objects so that DocuSign Connect for Salesforce updates or inserts the information into the Salesforce object. For more information, see  [DocuSign for Salesforce - Adding Completed Documents to the Notes and Attachments](https://support.docusign.com/articles/DocuSign-for-Salesforce-Adding-Completed-Documents-to-the-Notes-and-Attachments-New).
    /// </summary>
    [DataContract]
    public partial class ConnectSalesforceObject :  IEquatable<ConnectSalesforceObject>, IValidatableObject
    {
        public ConnectSalesforceObject()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectSalesforceObject" /> class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Insert">Insert.</param>
        /// <param name="OnCompleteOnly">OnCompleteOnly.</param>
        /// <param name="SelectFields">SelectFields.</param>
        /// <param name="SfObject">SfObject.</param>
        /// <param name="SfObjectName">SfObjectName.</param>
        /// <param name="UpdateFields">UpdateFields.</param>
        public ConnectSalesforceObject(string Active = default(string), string Description = default(string), string Id = default(string), string Insert = default(string), string OnCompleteOnly = default(string), List<ConnectSalesforceField> SelectFields = default(List<ConnectSalesforceField>), string SfObject = default(string), string SfObjectName = default(string), List<ConnectSalesforceField> UpdateFields = default(List<ConnectSalesforceField>))
        {
            this.Active = Active;
            this.Description = Description;
            this.Id = Id;
            this.Insert = Insert;
            this.OnCompleteOnly = OnCompleteOnly;
            this.SelectFields = SelectFields;
            this.SfObject = SfObject;
            this.SfObjectName = SfObjectName;
            this.UpdateFields = UpdateFields;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public string Active { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Insert
        /// </summary>
        [DataMember(Name="insert", EmitDefaultValue=false)]
        public string Insert { get; set; }
        /// <summary>
        /// Gets or Sets OnCompleteOnly
        /// </summary>
        [DataMember(Name="onCompleteOnly", EmitDefaultValue=false)]
        public string OnCompleteOnly { get; set; }
        /// <summary>
        /// Gets or Sets SelectFields
        /// </summary>
        [DataMember(Name="selectFields", EmitDefaultValue=false)]
        public List<ConnectSalesforceField> SelectFields { get; set; }
        /// <summary>
        /// Gets or Sets SfObject
        /// </summary>
        [DataMember(Name="sfObject", EmitDefaultValue=false)]
        public string SfObject { get; set; }
        /// <summary>
        /// Gets or Sets SfObjectName
        /// </summary>
        [DataMember(Name="sfObjectName", EmitDefaultValue=false)]
        public string SfObjectName { get; set; }
        /// <summary>
        /// Gets or Sets UpdateFields
        /// </summary>
        [DataMember(Name="updateFields", EmitDefaultValue=false)]
        public List<ConnectSalesforceField> UpdateFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectSalesforceObject {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Insert: ").Append(Insert).Append("\n");
            sb.Append("  OnCompleteOnly: ").Append(OnCompleteOnly).Append("\n");
            sb.Append("  SelectFields: ").Append(SelectFields).Append("\n");
            sb.Append("  SfObject: ").Append(SfObject).Append("\n");
            sb.Append("  SfObjectName: ").Append(SfObjectName).Append("\n");
            sb.Append("  UpdateFields: ").Append(UpdateFields).Append("\n");
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
            return this.Equals(obj as ConnectSalesforceObject);
        }

        /// <summary>
        /// Returns true if ConnectSalesforceObject instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectSalesforceObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectSalesforceObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Insert == other.Insert ||
                    this.Insert != null &&
                    this.Insert.Equals(other.Insert)
                ) && 
                (
                    this.OnCompleteOnly == other.OnCompleteOnly ||
                    this.OnCompleteOnly != null &&
                    this.OnCompleteOnly.Equals(other.OnCompleteOnly)
                ) && 
                (
                    this.SelectFields == other.SelectFields ||
                    this.SelectFields != null &&
                    this.SelectFields.SequenceEqual(other.SelectFields)
                ) && 
                (
                    this.SfObject == other.SfObject ||
                    this.SfObject != null &&
                    this.SfObject.Equals(other.SfObject)
                ) && 
                (
                    this.SfObjectName == other.SfObjectName ||
                    this.SfObjectName != null &&
                    this.SfObjectName.Equals(other.SfObjectName)
                ) && 
                (
                    this.UpdateFields == other.UpdateFields ||
                    this.UpdateFields != null &&
                    this.UpdateFields.SequenceEqual(other.UpdateFields)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Insert != null)
                    hash = hash * 59 + this.Insert.GetHashCode();
                if (this.OnCompleteOnly != null)
                    hash = hash * 59 + this.OnCompleteOnly.GetHashCode();
                if (this.SelectFields != null)
                    hash = hash * 59 + this.SelectFields.GetHashCode();
                if (this.SfObject != null)
                    hash = hash * 59 + this.SfObject.GetHashCode();
                if (this.SfObjectName != null)
                    hash = hash * 59 + this.SfObjectName.GetHashCode();
                if (this.UpdateFields != null)
                    hash = hash * 59 + this.UpdateFields.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
