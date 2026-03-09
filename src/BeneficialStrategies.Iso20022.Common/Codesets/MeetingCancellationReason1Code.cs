// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039")]
[Description(@"Specifies the reason for cancelling a meeting.")]
[DerivedFrom(typeof(MeetingCancellationReasonCode))]
public enum MeetingCancellationReason1Code
{
    /// <summary>
    /// Cancellation due to insufficient participation to the vote.
    /// Encoded/decoded by serializers as &quot;QORM&quot;.
    /// </summary>
    [EnumMember(Value = "QORM")]
    [IsoId("_Vp_FUNp-Ed-ak6NoX_4Aeg_-1410451064")]
    [Description(@"Cancellation due to insufficient participation to the vote.")]
    Quorum = MeetingCancellationReasonCode.Quorum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_Vp_FUdp-Ed-ak6NoX_4Aeg_-1398443912")]
    [Description(@"Cancellation due to a processing error.")]
    Processing = MeetingCancellationReasonCode.Processing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation due to another reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vp_FUtp-Ed-ak6NoX_4Aeg_-1315309873")]
    [Description(@"Cancellation due to another reason.")]
    Other = MeetingCancellationReasonCode.Other, // same ordinal as derivation source for type conversions
    
}
