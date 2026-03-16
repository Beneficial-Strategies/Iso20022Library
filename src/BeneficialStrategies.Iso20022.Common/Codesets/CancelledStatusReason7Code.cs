// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1F4Rtp-Ed-ak6NoX_4Aeg_-1968314240")]
[Description(
    @"Specifies the underlying reason for the cancellation of the associated transaction."
)]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason7Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a1F4R9p-Ed-ak6NoX_4Aeg_-1968314209")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a1F4SNp-Ed-ak6NoX_4Aeg_-1968313962")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonV2Code.CancelledBySystem, // same ordinal as derivation source for type conversions
}
