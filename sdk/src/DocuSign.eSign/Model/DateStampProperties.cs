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
    /// Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle.
    /// </summary>
    [DataContract]
    public partial class DateStampProperties :  IEquatable<DateStampProperties>, IValidatableObject
    {
        public DateStampProperties()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateStampProperties" /> class.
        /// </summary>
        /// <param name="DateAreaHeight">DateAreaHeight.</param>
        /// <param name="DateAreaWidth">DateAreaWidth.</param>
        /// <param name="DateAreaX">DateAreaX.</param>
        /// <param name="DateAreaY">DateAreaY.</param>
        public DateStampProperties(string DateAreaHeight = default(string), string DateAreaWidth = default(string), string DateAreaX = default(string), string DateAreaY = default(string))
        {
            this.DateAreaHeight = DateAreaHeight;
            this.DateAreaWidth = DateAreaWidth;
            this.DateAreaX = DateAreaX;
            this.DateAreaY = DateAreaY;
        }
        
        /// <summary>
        /// Gets or Sets DateAreaHeight
        /// </summary>
        [DataMember(Name="dateAreaHeight", EmitDefaultValue=false)]
        public string DateAreaHeight { get; set; }
        /// <summary>
        /// Gets or Sets DateAreaWidth
        /// </summary>
        [DataMember(Name="dateAreaWidth", EmitDefaultValue=false)]
        public string DateAreaWidth { get; set; }
        /// <summary>
        /// Gets or Sets DateAreaX
        /// </summary>
        [DataMember(Name="dateAreaX", EmitDefaultValue=false)]
        public string DateAreaX { get; set; }
        /// <summary>
        /// Gets or Sets DateAreaY
        /// </summary>
        [DataMember(Name="dateAreaY", EmitDefaultValue=false)]
        public string DateAreaY { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateStampProperties {\n");
            sb.Append("  DateAreaHeight: ").Append(DateAreaHeight).Append("\n");
            sb.Append("  DateAreaWidth: ").Append(DateAreaWidth).Append("\n");
            sb.Append("  DateAreaX: ").Append(DateAreaX).Append("\n");
            sb.Append("  DateAreaY: ").Append(DateAreaY).Append("\n");
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
            return this.Equals(obj as DateStampProperties);
        }

        /// <summary>
        /// Returns true if DateStampProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DateStampProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateStampProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateAreaHeight == other.DateAreaHeight ||
                    this.DateAreaHeight != null &&
                    this.DateAreaHeight.Equals(other.DateAreaHeight)
                ) && 
                (
                    this.DateAreaWidth == other.DateAreaWidth ||
                    this.DateAreaWidth != null &&
                    this.DateAreaWidth.Equals(other.DateAreaWidth)
                ) && 
                (
                    this.DateAreaX == other.DateAreaX ||
                    this.DateAreaX != null &&
                    this.DateAreaX.Equals(other.DateAreaX)
                ) && 
                (
                    this.DateAreaY == other.DateAreaY ||
                    this.DateAreaY != null &&
                    this.DateAreaY.Equals(other.DateAreaY)
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
                if (this.DateAreaHeight != null)
                    hash = hash * 59 + this.DateAreaHeight.GetHashCode();
                if (this.DateAreaWidth != null)
                    hash = hash * 59 + this.DateAreaWidth.GetHashCode();
                if (this.DateAreaX != null)
                    hash = hash * 59 + this.DateAreaX.GetHashCode();
                if (this.DateAreaY != null)
                    hash = hash * 59 + this.DateAreaY.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
