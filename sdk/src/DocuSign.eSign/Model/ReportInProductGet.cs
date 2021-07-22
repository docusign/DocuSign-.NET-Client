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
    /// ReportInProductGet
    /// </summary>
    [DataContract]
    public partial class ReportInProductGet :  IEquatable<ReportInProductGet>, IValidatableObject
    {
        public ReportInProductGet()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportInProductGet" /> class.
        /// </summary>
        /// <param name="AuthenticationSuccessFilter">AuthenticationSuccessFilter.</param>
        /// <param name="CustomFieldFilter">CustomFieldFilter.</param>
        /// <param name="DateRangeCustomFromDate">DateRangeCustomFromDate.</param>
        /// <param name="DateRangeCustomToDate">DateRangeCustomToDate.</param>
        /// <param name="DateRangeFilter">DateRangeFilter.</param>
        /// <param name="DisplayOrder">DisplayOrder.</param>
        /// <param name="EnvelopeDateTypeFilter">EnvelopeDateTypeFilter.</param>
        /// <param name="EnvelopeRecipientNameContainsFilter">EnvelopeRecipientNameContainsFilter.</param>
        /// <param name="EnvelopeStatusFilter">EnvelopeStatusFilter.</param>
        /// <param name="EnvelopeSubjectContainsFilter">EnvelopeSubjectContainsFilter.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="LastScheduledExecutionDate">LastScheduledExecutionDate.</param>
        /// <param name="LastScheduledExecutionSuccessDate">LastScheduledExecutionSuccessDate.</param>
        /// <param name="MaxDownloadRows">MaxDownloadRows.</param>
        /// <param name="MaxGridRows">MaxGridRows.</param>
        /// <param name="MaxScheduledRows">MaxScheduledRows.</param>
        /// <param name="PeriodLengthFilter">PeriodLengthFilter.</param>
        /// <param name="ReportCustomizedId">ReportCustomizedId.</param>
        /// <param name="ReportDescription">ReportDescription.</param>
        /// <param name="ReportId">ReportId.</param>
        /// <param name="ReportName">ReportName.</param>
        /// <param name="ReportType">ReportType.</param>
        /// <param name="RunUri">RunUri.</param>
        /// <param name="SaveUri">SaveUri.</param>
        /// <param name="ScheduleId">ScheduleId.</param>
        /// <param name="SentByDetails">SentByDetails.</param>
        /// <param name="SentByFilter">SentByFilter.</param>
        /// <param name="SentByIds">SentByIds.</param>
        /// <param name="SortFieldDirection">SortFieldDirection.</param>
        /// <param name="SortFieldName">SortFieldName.</param>
        /// <param name="VerificationStatusFilter">VerificationStatusFilter.</param>
        public ReportInProductGet(string AuthenticationSuccessFilter = default(string), string CustomFieldFilter = default(string), string DateRangeCustomFromDate = default(string), string DateRangeCustomToDate = default(string), string DateRangeFilter = default(string), string DisplayOrder = default(string), string EnvelopeDateTypeFilter = default(string), string EnvelopeRecipientNameContainsFilter = default(string), string EnvelopeStatusFilter = default(string), string EnvelopeSubjectContainsFilter = default(string), List<ReportInProductField> Fields = default(List<ReportInProductField>), string LastScheduledExecutionDate = default(string), string LastScheduledExecutionSuccessDate = default(string), string MaxDownloadRows = default(string), string MaxGridRows = default(string), string MaxScheduledRows = default(string), string PeriodLengthFilter = default(string), string ReportCustomizedId = default(string), string ReportDescription = default(string), string ReportId = default(string), string ReportName = default(string), string ReportType = default(string), string RunUri = default(string), string SaveUri = default(string), string ScheduleId = default(string), ReportInProductSentByDetails SentByDetails = default(ReportInProductSentByDetails), string SentByFilter = default(string), string SentByIds = default(string), string SortFieldDirection = default(string), string SortFieldName = default(string), string VerificationStatusFilter = default(string))
        {
            this.AuthenticationSuccessFilter = AuthenticationSuccessFilter;
            this.CustomFieldFilter = CustomFieldFilter;
            this.DateRangeCustomFromDate = DateRangeCustomFromDate;
            this.DateRangeCustomToDate = DateRangeCustomToDate;
            this.DateRangeFilter = DateRangeFilter;
            this.DisplayOrder = DisplayOrder;
            this.EnvelopeDateTypeFilter = EnvelopeDateTypeFilter;
            this.EnvelopeRecipientNameContainsFilter = EnvelopeRecipientNameContainsFilter;
            this.EnvelopeStatusFilter = EnvelopeStatusFilter;
            this.EnvelopeSubjectContainsFilter = EnvelopeSubjectContainsFilter;
            this.Fields = Fields;
            this.LastScheduledExecutionDate = LastScheduledExecutionDate;
            this.LastScheduledExecutionSuccessDate = LastScheduledExecutionSuccessDate;
            this.MaxDownloadRows = MaxDownloadRows;
            this.MaxGridRows = MaxGridRows;
            this.MaxScheduledRows = MaxScheduledRows;
            this.PeriodLengthFilter = PeriodLengthFilter;
            this.ReportCustomizedId = ReportCustomizedId;
            this.ReportDescription = ReportDescription;
            this.ReportId = ReportId;
            this.ReportName = ReportName;
            this.ReportType = ReportType;
            this.RunUri = RunUri;
            this.SaveUri = SaveUri;
            this.ScheduleId = ScheduleId;
            this.SentByDetails = SentByDetails;
            this.SentByFilter = SentByFilter;
            this.SentByIds = SentByIds;
            this.SortFieldDirection = SortFieldDirection;
            this.SortFieldName = SortFieldName;
            this.VerificationStatusFilter = VerificationStatusFilter;
        }
        
        /// <summary>
        /// Gets or Sets AuthenticationSuccessFilter
        /// </summary>
        [DataMember(Name="authenticationSuccessFilter", EmitDefaultValue=false)]
        public string AuthenticationSuccessFilter { get; set; }
        /// <summary>
        /// Gets or Sets CustomFieldFilter
        /// </summary>
        [DataMember(Name="customFieldFilter", EmitDefaultValue=false)]
        public string CustomFieldFilter { get; set; }
        /// <summary>
        /// Gets or Sets DateRangeCustomFromDate
        /// </summary>
        [DataMember(Name="dateRangeCustomFromDate", EmitDefaultValue=false)]
        public string DateRangeCustomFromDate { get; set; }
        /// <summary>
        /// Gets or Sets DateRangeCustomToDate
        /// </summary>
        [DataMember(Name="dateRangeCustomToDate", EmitDefaultValue=false)]
        public string DateRangeCustomToDate { get; set; }
        /// <summary>
        /// Gets or Sets DateRangeFilter
        /// </summary>
        [DataMember(Name="dateRangeFilter", EmitDefaultValue=false)]
        public string DateRangeFilter { get; set; }
        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public string DisplayOrder { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeDateTypeFilter
        /// </summary>
        [DataMember(Name="envelopeDateTypeFilter", EmitDefaultValue=false)]
        public string EnvelopeDateTypeFilter { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeRecipientNameContainsFilter
        /// </summary>
        [DataMember(Name="envelopeRecipientNameContainsFilter", EmitDefaultValue=false)]
        public string EnvelopeRecipientNameContainsFilter { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeStatusFilter
        /// </summary>
        [DataMember(Name="envelopeStatusFilter", EmitDefaultValue=false)]
        public string EnvelopeStatusFilter { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeSubjectContainsFilter
        /// </summary>
        [DataMember(Name="envelopeSubjectContainsFilter", EmitDefaultValue=false)]
        public string EnvelopeSubjectContainsFilter { get; set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<ReportInProductField> Fields { get; set; }
        /// <summary>
        /// Gets or Sets LastScheduledExecutionDate
        /// </summary>
        [DataMember(Name="lastScheduledExecutionDate", EmitDefaultValue=false)]
        public string LastScheduledExecutionDate { get; set; }
        /// <summary>
        /// Gets or Sets LastScheduledExecutionSuccessDate
        /// </summary>
        [DataMember(Name="lastScheduledExecutionSuccessDate", EmitDefaultValue=false)]
        public string LastScheduledExecutionSuccessDate { get; set; }
        /// <summary>
        /// Gets or Sets MaxDownloadRows
        /// </summary>
        [DataMember(Name="maxDownloadRows", EmitDefaultValue=false)]
        public string MaxDownloadRows { get; set; }
        /// <summary>
        /// Gets or Sets MaxGridRows
        /// </summary>
        [DataMember(Name="maxGridRows", EmitDefaultValue=false)]
        public string MaxGridRows { get; set; }
        /// <summary>
        /// Gets or Sets MaxScheduledRows
        /// </summary>
        [DataMember(Name="maxScheduledRows", EmitDefaultValue=false)]
        public string MaxScheduledRows { get; set; }
        /// <summary>
        /// Gets or Sets PeriodLengthFilter
        /// </summary>
        [DataMember(Name="periodLengthFilter", EmitDefaultValue=false)]
        public string PeriodLengthFilter { get; set; }
        /// <summary>
        /// Gets or Sets ReportCustomizedId
        /// </summary>
        [DataMember(Name="reportCustomizedId", EmitDefaultValue=false)]
        public string ReportCustomizedId { get; set; }
        /// <summary>
        /// Gets or Sets ReportDescription
        /// </summary>
        [DataMember(Name="reportDescription", EmitDefaultValue=false)]
        public string ReportDescription { get; set; }
        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }
        /// <summary>
        /// Gets or Sets ReportName
        /// </summary>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }
        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name="reportType", EmitDefaultValue=false)]
        public string ReportType { get; set; }
        /// <summary>
        /// Gets or Sets RunUri
        /// </summary>
        [DataMember(Name="runUri", EmitDefaultValue=false)]
        public string RunUri { get; set; }
        /// <summary>
        /// Gets or Sets SaveUri
        /// </summary>
        [DataMember(Name="saveUri", EmitDefaultValue=false)]
        public string SaveUri { get; set; }
        /// <summary>
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name="scheduleId", EmitDefaultValue=false)]
        public string ScheduleId { get; set; }
        /// <summary>
        /// Gets or Sets SentByDetails
        /// </summary>
        [DataMember(Name="sentByDetails", EmitDefaultValue=false)]
        public ReportInProductSentByDetails SentByDetails { get; set; }
        /// <summary>
        /// Gets or Sets SentByFilter
        /// </summary>
        [DataMember(Name="sentByFilter", EmitDefaultValue=false)]
        public string SentByFilter { get; set; }
        /// <summary>
        /// Gets or Sets SentByIds
        /// </summary>
        [DataMember(Name="sentByIds", EmitDefaultValue=false)]
        public string SentByIds { get; set; }
        /// <summary>
        /// Gets or Sets SortFieldDirection
        /// </summary>
        [DataMember(Name="sortFieldDirection", EmitDefaultValue=false)]
        public string SortFieldDirection { get; set; }
        /// <summary>
        /// Gets or Sets SortFieldName
        /// </summary>
        [DataMember(Name="sortFieldName", EmitDefaultValue=false)]
        public string SortFieldName { get; set; }
        /// <summary>
        /// Gets or Sets VerificationStatusFilter
        /// </summary>
        [DataMember(Name="verificationStatusFilter", EmitDefaultValue=false)]
        public string VerificationStatusFilter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportInProductGet {\n");
            sb.Append("  AuthenticationSuccessFilter: ").Append(AuthenticationSuccessFilter).Append("\n");
            sb.Append("  CustomFieldFilter: ").Append(CustomFieldFilter).Append("\n");
            sb.Append("  DateRangeCustomFromDate: ").Append(DateRangeCustomFromDate).Append("\n");
            sb.Append("  DateRangeCustomToDate: ").Append(DateRangeCustomToDate).Append("\n");
            sb.Append("  DateRangeFilter: ").Append(DateRangeFilter).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  EnvelopeDateTypeFilter: ").Append(EnvelopeDateTypeFilter).Append("\n");
            sb.Append("  EnvelopeRecipientNameContainsFilter: ").Append(EnvelopeRecipientNameContainsFilter).Append("\n");
            sb.Append("  EnvelopeStatusFilter: ").Append(EnvelopeStatusFilter).Append("\n");
            sb.Append("  EnvelopeSubjectContainsFilter: ").Append(EnvelopeSubjectContainsFilter).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  LastScheduledExecutionDate: ").Append(LastScheduledExecutionDate).Append("\n");
            sb.Append("  LastScheduledExecutionSuccessDate: ").Append(LastScheduledExecutionSuccessDate).Append("\n");
            sb.Append("  MaxDownloadRows: ").Append(MaxDownloadRows).Append("\n");
            sb.Append("  MaxGridRows: ").Append(MaxGridRows).Append("\n");
            sb.Append("  MaxScheduledRows: ").Append(MaxScheduledRows).Append("\n");
            sb.Append("  PeriodLengthFilter: ").Append(PeriodLengthFilter).Append("\n");
            sb.Append("  ReportCustomizedId: ").Append(ReportCustomizedId).Append("\n");
            sb.Append("  ReportDescription: ").Append(ReportDescription).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  RunUri: ").Append(RunUri).Append("\n");
            sb.Append("  SaveUri: ").Append(SaveUri).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  SentByDetails: ").Append(SentByDetails).Append("\n");
            sb.Append("  SentByFilter: ").Append(SentByFilter).Append("\n");
            sb.Append("  SentByIds: ").Append(SentByIds).Append("\n");
            sb.Append("  SortFieldDirection: ").Append(SortFieldDirection).Append("\n");
            sb.Append("  SortFieldName: ").Append(SortFieldName).Append("\n");
            sb.Append("  VerificationStatusFilter: ").Append(VerificationStatusFilter).Append("\n");
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
            return this.Equals(obj as ReportInProductGet);
        }

        /// <summary>
        /// Returns true if ReportInProductGet instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportInProductGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportInProductGet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationSuccessFilter == other.AuthenticationSuccessFilter ||
                    this.AuthenticationSuccessFilter != null &&
                    this.AuthenticationSuccessFilter.Equals(other.AuthenticationSuccessFilter)
                ) && 
                (
                    this.CustomFieldFilter == other.CustomFieldFilter ||
                    this.CustomFieldFilter != null &&
                    this.CustomFieldFilter.Equals(other.CustomFieldFilter)
                ) && 
                (
                    this.DateRangeCustomFromDate == other.DateRangeCustomFromDate ||
                    this.DateRangeCustomFromDate != null &&
                    this.DateRangeCustomFromDate.Equals(other.DateRangeCustomFromDate)
                ) && 
                (
                    this.DateRangeCustomToDate == other.DateRangeCustomToDate ||
                    this.DateRangeCustomToDate != null &&
                    this.DateRangeCustomToDate.Equals(other.DateRangeCustomToDate)
                ) && 
                (
                    this.DateRangeFilter == other.DateRangeFilter ||
                    this.DateRangeFilter != null &&
                    this.DateRangeFilter.Equals(other.DateRangeFilter)
                ) && 
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(other.DisplayOrder)
                ) && 
                (
                    this.EnvelopeDateTypeFilter == other.EnvelopeDateTypeFilter ||
                    this.EnvelopeDateTypeFilter != null &&
                    this.EnvelopeDateTypeFilter.Equals(other.EnvelopeDateTypeFilter)
                ) && 
                (
                    this.EnvelopeRecipientNameContainsFilter == other.EnvelopeRecipientNameContainsFilter ||
                    this.EnvelopeRecipientNameContainsFilter != null &&
                    this.EnvelopeRecipientNameContainsFilter.Equals(other.EnvelopeRecipientNameContainsFilter)
                ) && 
                (
                    this.EnvelopeStatusFilter == other.EnvelopeStatusFilter ||
                    this.EnvelopeStatusFilter != null &&
                    this.EnvelopeStatusFilter.Equals(other.EnvelopeStatusFilter)
                ) && 
                (
                    this.EnvelopeSubjectContainsFilter == other.EnvelopeSubjectContainsFilter ||
                    this.EnvelopeSubjectContainsFilter != null &&
                    this.EnvelopeSubjectContainsFilter.Equals(other.EnvelopeSubjectContainsFilter)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    this.LastScheduledExecutionDate == other.LastScheduledExecutionDate ||
                    this.LastScheduledExecutionDate != null &&
                    this.LastScheduledExecutionDate.Equals(other.LastScheduledExecutionDate)
                ) && 
                (
                    this.LastScheduledExecutionSuccessDate == other.LastScheduledExecutionSuccessDate ||
                    this.LastScheduledExecutionSuccessDate != null &&
                    this.LastScheduledExecutionSuccessDate.Equals(other.LastScheduledExecutionSuccessDate)
                ) && 
                (
                    this.MaxDownloadRows == other.MaxDownloadRows ||
                    this.MaxDownloadRows != null &&
                    this.MaxDownloadRows.Equals(other.MaxDownloadRows)
                ) && 
                (
                    this.MaxGridRows == other.MaxGridRows ||
                    this.MaxGridRows != null &&
                    this.MaxGridRows.Equals(other.MaxGridRows)
                ) && 
                (
                    this.MaxScheduledRows == other.MaxScheduledRows ||
                    this.MaxScheduledRows != null &&
                    this.MaxScheduledRows.Equals(other.MaxScheduledRows)
                ) && 
                (
                    this.PeriodLengthFilter == other.PeriodLengthFilter ||
                    this.PeriodLengthFilter != null &&
                    this.PeriodLengthFilter.Equals(other.PeriodLengthFilter)
                ) && 
                (
                    this.ReportCustomizedId == other.ReportCustomizedId ||
                    this.ReportCustomizedId != null &&
                    this.ReportCustomizedId.Equals(other.ReportCustomizedId)
                ) && 
                (
                    this.ReportDescription == other.ReportDescription ||
                    this.ReportDescription != null &&
                    this.ReportDescription.Equals(other.ReportDescription)
                ) && 
                (
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.ReportType == other.ReportType ||
                    this.ReportType != null &&
                    this.ReportType.Equals(other.ReportType)
                ) && 
                (
                    this.RunUri == other.RunUri ||
                    this.RunUri != null &&
                    this.RunUri.Equals(other.RunUri)
                ) && 
                (
                    this.SaveUri == other.SaveUri ||
                    this.SaveUri != null &&
                    this.SaveUri.Equals(other.SaveUri)
                ) && 
                (
                    this.ScheduleId == other.ScheduleId ||
                    this.ScheduleId != null &&
                    this.ScheduleId.Equals(other.ScheduleId)
                ) && 
                (
                    this.SentByDetails == other.SentByDetails ||
                    this.SentByDetails != null &&
                    this.SentByDetails.Equals(other.SentByDetails)
                ) && 
                (
                    this.SentByFilter == other.SentByFilter ||
                    this.SentByFilter != null &&
                    this.SentByFilter.Equals(other.SentByFilter)
                ) && 
                (
                    this.SentByIds == other.SentByIds ||
                    this.SentByIds != null &&
                    this.SentByIds.Equals(other.SentByIds)
                ) && 
                (
                    this.SortFieldDirection == other.SortFieldDirection ||
                    this.SortFieldDirection != null &&
                    this.SortFieldDirection.Equals(other.SortFieldDirection)
                ) && 
                (
                    this.SortFieldName == other.SortFieldName ||
                    this.SortFieldName != null &&
                    this.SortFieldName.Equals(other.SortFieldName)
                ) && 
                (
                    this.VerificationStatusFilter == other.VerificationStatusFilter ||
                    this.VerificationStatusFilter != null &&
                    this.VerificationStatusFilter.Equals(other.VerificationStatusFilter)
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
                if (this.AuthenticationSuccessFilter != null)
                    hash = hash * 59 + this.AuthenticationSuccessFilter.GetHashCode();
                if (this.CustomFieldFilter != null)
                    hash = hash * 59 + this.CustomFieldFilter.GetHashCode();
                if (this.DateRangeCustomFromDate != null)
                    hash = hash * 59 + this.DateRangeCustomFromDate.GetHashCode();
                if (this.DateRangeCustomToDate != null)
                    hash = hash * 59 + this.DateRangeCustomToDate.GetHashCode();
                if (this.DateRangeFilter != null)
                    hash = hash * 59 + this.DateRangeFilter.GetHashCode();
                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();
                if (this.EnvelopeDateTypeFilter != null)
                    hash = hash * 59 + this.EnvelopeDateTypeFilter.GetHashCode();
                if (this.EnvelopeRecipientNameContainsFilter != null)
                    hash = hash * 59 + this.EnvelopeRecipientNameContainsFilter.GetHashCode();
                if (this.EnvelopeStatusFilter != null)
                    hash = hash * 59 + this.EnvelopeStatusFilter.GetHashCode();
                if (this.EnvelopeSubjectContainsFilter != null)
                    hash = hash * 59 + this.EnvelopeSubjectContainsFilter.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this.LastScheduledExecutionDate != null)
                    hash = hash * 59 + this.LastScheduledExecutionDate.GetHashCode();
                if (this.LastScheduledExecutionSuccessDate != null)
                    hash = hash * 59 + this.LastScheduledExecutionSuccessDate.GetHashCode();
                if (this.MaxDownloadRows != null)
                    hash = hash * 59 + this.MaxDownloadRows.GetHashCode();
                if (this.MaxGridRows != null)
                    hash = hash * 59 + this.MaxGridRows.GetHashCode();
                if (this.MaxScheduledRows != null)
                    hash = hash * 59 + this.MaxScheduledRows.GetHashCode();
                if (this.PeriodLengthFilter != null)
                    hash = hash * 59 + this.PeriodLengthFilter.GetHashCode();
                if (this.ReportCustomizedId != null)
                    hash = hash * 59 + this.ReportCustomizedId.GetHashCode();
                if (this.ReportDescription != null)
                    hash = hash * 59 + this.ReportDescription.GetHashCode();
                if (this.ReportId != null)
                    hash = hash * 59 + this.ReportId.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.ReportType != null)
                    hash = hash * 59 + this.ReportType.GetHashCode();
                if (this.RunUri != null)
                    hash = hash * 59 + this.RunUri.GetHashCode();
                if (this.SaveUri != null)
                    hash = hash * 59 + this.SaveUri.GetHashCode();
                if (this.ScheduleId != null)
                    hash = hash * 59 + this.ScheduleId.GetHashCode();
                if (this.SentByDetails != null)
                    hash = hash * 59 + this.SentByDetails.GetHashCode();
                if (this.SentByFilter != null)
                    hash = hash * 59 + this.SentByFilter.GetHashCode();
                if (this.SentByIds != null)
                    hash = hash * 59 + this.SentByIds.GetHashCode();
                if (this.SortFieldDirection != null)
                    hash = hash * 59 + this.SortFieldDirection.GetHashCode();
                if (this.SortFieldName != null)
                    hash = hash * 59 + this.SortFieldName.GetHashCode();
                if (this.VerificationStatusFilter != null)
                    hash = hash * 59 + this.VerificationStatusFilter.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}