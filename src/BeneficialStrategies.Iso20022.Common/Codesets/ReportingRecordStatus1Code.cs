// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the processing of an individual record within a message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KATXoNHEEeaokquJJ-K6uA")]
[Description(@"Specifies the status of the processing of an individual record within a message.")]
[DerivedFrom(typeof(RecordStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReportingRecordStatus1Code>))]
#endif
public enum ReportingRecordStatus1Code
{
    /// <summary>
    /// Record has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_MJ6IcdHEEeaokquJJ-K6uA")]
    [Description(@"Record has been accepted.")]
    Accepted = RecordStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record has been accepted, following a pending status.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_MOBMYdHEEeaokquJJ-K6uA")]
    [Description(@"Record has been accepted, following a pending status.")]
    AcceptedAfterPending = RecordStatusCode.AcceptedAfterPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of the record is pending (some validation rules have been executed but some have not and the final status is not known yet).
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_MhF5YtHEEeaokquJJ-K6uA")]
    [Description(
        @"Processing of the record is pending (some validation rules have been executed but some have not and the final status is not known yet)."
    )]
    Pending = RecordStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recrod has been received but not processed yet.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_MiV2kdHEEeaokquJJ-K6uA")]
    [Description(@"Recrod has been received but not processed yet.")]
    Received = RecordStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_MjqFMdHEEeaokquJJ-K6uA")]
    [Description(@"Record has been rejected.")]
    Rejected = RecordStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record has been rejected, following a pending status.
    /// Encoded/decoded by serializers as &quot;RJPD&quot;.
    /// </summary>
    [EnumMember(Value = "RJPD")]
    [IsoId("_MlNkYdHEEeaokquJJ-K6uA")]
    [Description(@"Record has been rejected, following a pending status.")]
    RejectedAfterPending = RecordStatusCode.RejectedAfterPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_Mt0t0dHEEeaokquJJ-K6uA")]
    [Description(@"Record has been accepted with warnings.")]
    Warning = RecordStatusCode.Warning, // same ordinal as derivation source for type conversions
}
