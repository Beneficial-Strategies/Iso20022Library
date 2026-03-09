// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WxrMP9jEEeSdIOSPwTkydQ")]
[Description(@"Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.")]
[Derivations(typeof(StatisticalReportingStatus2Code),typeof(StatisticalReportingStatus1Code),typeof(TaxReportingStatus2Code),typeof(TaxReportingStatus1Code))]
public enum StatisticalReportingStatusCode
{
    /// <summary>
    /// Transaction or report has passed syntactical and semantical validation.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_WxrMTNjEEeSdIOSPwTkydQ")]
    [Description(@"Transaction or report has passed syntactical and semantical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Report has been received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_WxrMRtjEEeSdIOSPwTkydQ")]
    [Description(@"Report has been received.")]
    Received,
    
    /// <summary>
    /// Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_WxrMSNjEEeSdIOSPwTkydQ")]
    [Description(@"Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.")]
    PartiallyAccepted,
    
    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_WxrMRdjEEeSdIOSPwTkydQ")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Processing of transaction or report is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_WxrMQdjEEeSdIOSPwTkydQ")]
    [Description(@"Processing of transaction or report is pending.")]
    Pending,
    
    /// <summary>
    /// Transaction or report has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_WxrMQNjEEeSdIOSPwTkydQ")]
    [Description(@"Transaction or report has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Transaction has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_j11wUO2wEeS-SNPe_7uMwA")]
    [Description(@"Transaction has been accepted with warnings.")]
    Warning,
    
    /// <summary>
    /// Reminder of a non received report.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_s-hMEO2wEeS-SNPe_7uMwA")]
    [Description(@"Reminder of a non received report.")]
    Reminder,
    
    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_PQjosO8AEeSo-uJuUW33Ew")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile,
    
    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_m-pOoe8AEeSo-uJuUW33Ew")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename,
    
    /// <summary>
    /// Transaction or report has been accepted, following a pending status.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_FI0VcLX6EeWOIMMXtF0SdQ")]
    [Description(@"Transaction or report has been accepted, following a pending status.")]
    AcceptedAfterPending,
    
    /// <summary>
    /// Transaction or report has been rejected, following a pending status.
    /// Encoded/decoded by serializers as &quot;RJPD&quot;.
    /// </summary>
    [EnumMember(Value = "RJPD")]
    [IsoId("_J33egLX6EeWOIMMXtF0SdQ")]
    [Description(@"Transaction or report has been rejected, following a pending status.")]
    RejectedAfterPending,
    
}
