// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVM3QNp-Ed-ak6NoX_4Aeg_-990079523")]
[Description(@"Specifies the reason for cancelling a meeting.")]
[DerivedFrom(typeof(MeetingCancellationReasonCode))]
public enum MeetingCancellationReason2Code
{
    /// <summary>
    /// Cancellation due to insufficient participation to the vote.
    /// Encoded/decoded by serializers as &quot;QORM&quot;.
    /// </summary>
    [EnumMember(Value = "QORM")]
    [IsoId("_aVM3Qdp-Ed-ak6NoX_4Aeg_-990079521")]
    [Description(@"Cancellation due to insufficient participation to the vote.")]
    Quorum = MeetingCancellationReasonCode.Quorum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_aVM3Qtp-Ed-ak6NoX_4Aeg_-990079505")]
    [Description(@"Cancellation due to a processing error.")]
    Processing = MeetingCancellationReasonCode.Processing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation due to the meeting being cancelled by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aVM3Q9p-Ed-ak6NoX_4Aeg_-918047442")]
    [Description(@"Cancellation due to the meeting being cancelled by the issuer.")]
    Withdrawal = MeetingCancellationReasonCode.Withdrawal, // same ordinal as derivation source for type conversions
}
