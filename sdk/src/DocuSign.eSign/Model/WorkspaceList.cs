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
    /// Provides properties that describe the workspaces avaialble.
    /// </summary>
    [DataContract]
    public partial class WorkspaceList :  IEquatable<WorkspaceList>, IValidatableObject
    {
        public WorkspaceList()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceList" /> class.
        /// </summary>
        /// <param name="EndPosition">The last position in the result set. .</param>
        /// <param name="ResultSetSize">The number of results returned in this response. .</param>
        /// <param name="StartPosition">Starting position of the current result set..</param>
        /// <param name="TotalSetSize">The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response..</param>
        /// <param name="Workspaces">A list of workspaces..</param>
        public WorkspaceList(string EndPosition = default(string), string ResultSetSize = default(string), string StartPosition = default(string), string TotalSetSize = default(string), List<Workspace> Workspaces = default(List<Workspace>))
        {
            this.EndPosition = EndPosition;
            this.ResultSetSize = ResultSetSize;
            this.StartPosition = StartPosition;
            this.TotalSetSize = TotalSetSize;
            this.Workspaces = Workspaces;
        }
        
        /// <summary>
        /// The last position in the result set. 
        /// </summary>
        /// <value>The last position in the result set. </value>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public string EndPosition { get; set; }
        /// <summary>
        /// The number of results returned in this response. 
        /// </summary>
        /// <value>The number of results returned in this response. </value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
        /// <summary>
        /// Starting position of the current result set.
        /// </summary>
        /// <value>Starting position of the current result set.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public string StartPosition { get; set; }
        /// <summary>
        /// The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.
        /// </summary>
        /// <value>The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.</value>
        [DataMember(Name="totalSetSize", EmitDefaultValue=false)]
        public string TotalSetSize { get; set; }
        /// <summary>
        /// A list of workspaces.
        /// </summary>
        /// <value>A list of workspaces.</value>
        [DataMember(Name="workspaces", EmitDefaultValue=false)]
        public List<Workspace> Workspaces { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceList {\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
            sb.Append("  Workspaces: ").Append(Workspaces).Append("\n");
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
            return this.Equals(obj as WorkspaceList);
        }

        /// <summary>
        /// Returns true if WorkspaceList instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkspaceList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.TotalSetSize == other.TotalSetSize ||
                    this.TotalSetSize != null &&
                    this.TotalSetSize.Equals(other.TotalSetSize)
                ) && 
                (
                    this.Workspaces == other.Workspaces ||
                    this.Workspaces != null &&
                    this.Workspaces.SequenceEqual(other.Workspaces)
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
                if (this.EndPosition != null)
                    hash = hash * 59 + this.EndPosition.GetHashCode();
                if (this.ResultSetSize != null)
                    hash = hash * 59 + this.ResultSetSize.GetHashCode();
                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();
                if (this.TotalSetSize != null)
                    hash = hash * 59 + this.TotalSetSize.GetHashCode();
                if (this.Workspaces != null)
                    hash = hash * 59 + this.Workspaces.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
