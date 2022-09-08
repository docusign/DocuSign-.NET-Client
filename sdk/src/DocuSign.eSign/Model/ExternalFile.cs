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
    /// This object contains information about a file or folder in cloud storage.
    /// </summary>
    [DataContract]
    public partial class ExternalFile :  IEquatable<ExternalFile>, IValidatableObject
    {
        public ExternalFile()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFile" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="HasCompositeTemplate">HasCompositeTemplate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Img">Img.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OwnerName">OwnerName.</param>
        /// <param name="Size">Reserved: TBD.</param>
        /// <param name="Supported">Supported.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Uri">Uri.</param>
        public ExternalFile(string Date = default(string), string HasCompositeTemplate = default(string), string Id = default(string), string Img = default(string), string Name = default(string), string OwnerName = default(string), string Size = default(string), string Supported = default(string), string Type = default(string), string Uri = default(string))
        {
            this.Date = Date;
            this.HasCompositeTemplate = HasCompositeTemplate;
            this.Id = Id;
            this.Img = Img;
            this.Name = Name;
            this.OwnerName = OwnerName;
            this.Size = Size;
            this.Supported = Supported;
            this.Type = Type;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }
        /// <summary>
        /// Gets or Sets HasCompositeTemplate
        /// </summary>
        [DataMember(Name="hasCompositeTemplate", EmitDefaultValue=false)]
        public string HasCompositeTemplate { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Img
        /// </summary>
        [DataMember(Name="img", EmitDefaultValue=false)]
        public string Img { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name="ownerName", EmitDefaultValue=false)]
        public string OwnerName { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }
        /// <summary>
        /// Gets or Sets Supported
        /// </summary>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public string Supported { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalFile {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  HasCompositeTemplate: ").Append(HasCompositeTemplate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Img: ").Append(Img).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as ExternalFile);
        }

        /// <summary>
        /// Returns true if ExternalFile instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalFile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.HasCompositeTemplate == other.HasCompositeTemplate ||
                    this.HasCompositeTemplate != null &&
                    this.HasCompositeTemplate.Equals(other.HasCompositeTemplate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Img == other.Img ||
                    this.Img != null &&
                    this.Img.Equals(other.Img)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OwnerName == other.OwnerName ||
                    this.OwnerName != null &&
                    this.OwnerName.Equals(other.OwnerName)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.Equals(other.Supported)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.HasCompositeTemplate != null)
                    hash = hash * 59 + this.HasCompositeTemplate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Img != null)
                    hash = hash * 59 + this.Img.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OwnerName != null)
                    hash = hash * 59 + this.OwnerName.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Supported != null)
                    hash = hash * 59 + this.Supported.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
