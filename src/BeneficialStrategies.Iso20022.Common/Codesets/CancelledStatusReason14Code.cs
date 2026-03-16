// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zfRGYCzzEeOsiuMH68so7Q")]
[Description(
    @"Specifies the underlying reason for the cancellation of the associated transaction."
)]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason14Code
{
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_LqRR0Sz0EeOsiuMH68so7Q")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = CancelledStatusReasonV2Code.NarrativeReason, // same ordinal as derivation source for type conversions
}
