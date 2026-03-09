// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ve9hENp-Ed-ak6NoX_4Aeg_1602081773")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus1Code
{
    /// <summary>
    /// Cancellation instruction/request has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_Ve9hEdp-Ed-ak6NoX_4Aeg_1711057455")]
    [Description(@"Cancellation instruction/request has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty = CancellationStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_Ve9hEtp-Ed-ak6NoX_4Aeg_1711057480")]
    [Description(@"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.")]
    Accepted = CancellationStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_Ve9hE9p-Ed-ak6NoX_4Aeg_1711057497")]
    [Description(@"Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.")]
    Pending = CancellationStatusCode.Pending, // same ordinal as derivation source for type conversions
    
}
