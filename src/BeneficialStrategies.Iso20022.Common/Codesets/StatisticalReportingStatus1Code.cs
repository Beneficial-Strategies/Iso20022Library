// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of statistical reporting transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8W46ANjEEeSdIOSPwTkydQ")]
[Description(@"Specifies the status of a group of statistical reporting transactions.")]
[DerivedFrom(typeof(StatisticalReportingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StatisticalReportingStatus1Code>))]
#endif
public enum StatisticalReportingStatus1Code
{
    /// <summary>
    /// Transaction or report has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_iNhH8djFEeSD0e0ybx5L5Q")]
    [Description(@"Transaction or report has been accepted.")]
    Accepted = StatisticalReportingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction or report has passed syntactical and semantical validation.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_iUXW0djFEeSD0e0ybx5L5Q")]
    [Description(@"Transaction or report has passed syntactical and semantical validation.")]
    AcceptedTechnicalValidation = StatisticalReportingStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_iaw5wdjFEeSD0e0ybx5L5Q")]
    [Description(
        @"Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted."
    )]
    PartiallyAccepted = StatisticalReportingStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of transaction or report is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ijYqQdjFEeSD0e0ybx5L5Q")]
    [Description(@"Processing of transaction or report is pending.")]
    Pending = StatisticalReportingStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report has been received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_ipfSQdjFEeSD0e0ybx5L5Q")]
    [Description(@"Report has been received.")]
    Received = StatisticalReportingStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_ixYC8djFEeSD0e0ybx5L5Q")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected = StatisticalReportingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reminder of a non received report.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_2_4jUe2wEeS-SNPe_7uMwA")]
    [Description(@"Reminder of a non received report.")]
    Reminder = StatisticalReportingStatusCode.Reminder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_c9R3Ye8AEeSo-uJuUW33Ew")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename = StatisticalReportingStatusCode.IncorrectFilename, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_urYQ0e8AEeSo-uJuUW33Ew")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile = StatisticalReportingStatusCode.CorruptedFile, // same ordinal as derivation source for type conversions
}
