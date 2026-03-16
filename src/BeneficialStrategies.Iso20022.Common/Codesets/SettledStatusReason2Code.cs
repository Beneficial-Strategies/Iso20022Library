// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Partial settlement status information or information about gating.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__AyMYEgWEea9YuSvQGoi-w")]
[Description(@"Partial settlement status information or information about gating.")]
[DerivedFrom(typeof(SettledStatusReasonCode))]
public enum SettledStatusReason2Code
{
    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_Bf1BsUgXEea9YuSvQGoi-w")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled = SettledStatusReasonCode.CashPartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redemption has been gated. Multiple redemptions and multiple prices will be required.
    /// Encoded/decoded by serializers as &quot;GATM&quot;.
    /// </summary>
    [EnumMember(Value = "GATM")]
    [IsoId("_BlVMwUgXEea9YuSvQGoi-w")]
    [Description(
        @"Redemption has been gated. Multiple redemptions and multiple prices will be required."
    )]
    GatedMultipleNAV = SettledStatusReasonCode.GatedMultipleNAV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redemption has been gated, all settlement will be done at the same price.
    /// Encoded/decoded by serializers as &quot;GAT1&quot;.
    /// </summary>
    [EnumMember(Value = "GAT1")]
    [IsoId("_BrbNsUgXEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated, all settlement will be done at the same price.")]
    GatedOneNAV = SettledStatusReasonCode.GatedOneNAV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as &quot;UCPS&quot;.
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_BwfT4UgXEea9YuSvQGoi-w")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled = SettledStatusReasonCode.UnitsCashPartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as &quot;UPST&quot;.
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_B11t8UgXEea9YuSvQGoi-w")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled = SettledStatusReasonCode.UnitsPartiallySettled, // same ordinal as derivation source for type conversions
}
