// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVM3RNp-Ed-ak6NoX_4Aeg_-1321527474")]
[Description(@"Specifies the reason for cancelling a meeting.")]
[Derivations(typeof(MeetingCancellationReason1Code),typeof(MeetingCancellationReason2Code))]
public enum MeetingCancellationReasonCode
{
    /// <summary>
    /// Cancellation due to insufficient participation to the vote.
    /// Encoded/decoded by serializers as &quot;QORM&quot;.
    /// </summary>
    [EnumMember(Value = "QORM")]
    [IsoId("_aVM3Rdp-Ed-ak6NoX_4Aeg_1851096275")]
    [Description(@"Cancellation due to insufficient participation to the vote.")]
    Quorum,
    
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_aVM3Rtp-Ed-ak6NoX_4Aeg_-2055992756")]
    [Description(@"Cancellation due to a processing error.")]
    Processing,
    
    /// <summary>
    /// Cancellation due to another reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aVM3R9p-Ed-ak6NoX_4Aeg_-1646853934")]
    [Description(@"Cancellation due to another reason.")]
    Other,
    
    /// <summary>
    /// Cancellation due to the meeting being cancelled by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aVWBMNp-Ed-ak6NoX_4Aeg_-2132220464")]
    [Description(@"Cancellation due to the meeting being cancelled by the issuer.")]
    Withdrawal,
    
}
