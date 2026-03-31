// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a partially settled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxSR59p-Ed-ak6NoX_4Aeg_-674686926")]
[Description(@"Specifies the reason for a partially settled status.")]
[DerivedFrom(typeof(PartiallySettledStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartiallySettledStatusReason1Code>))]
#endif
public enum PartiallySettledStatusReason1Code
{
    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as &quot;UPST&quot;.
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_ZxSR6Np-Ed-ak6NoX_4Aeg_289532051")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled = PartiallySettledStatusReasonCode.UnitsPartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_ZxSR6dp-Ed-ak6NoX_4Aeg_289532363")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled = PartiallySettledStatusReasonCode.CashPartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as &quot;UCPS&quot;.
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_ZxcC4Np-Ed-ak6NoX_4Aeg_289532483")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled = PartiallySettledStatusReasonCode.UnitsCashPartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final redemption proceeds are held back, pending annual financial audit approval.
    /// Encoded/decoded by serializers as &quot;HOLA&quot;.
    /// </summary>
    [EnumMember(Value = "HOLA")]
    [IsoId("_ZxcC4dp-Ed-ak6NoX_4Aeg_237753692")]
    [Description(
        @"Final redemption proceeds are held back, pending annual financial audit approval."
    )]
    HoldBackPendingAudit = PartiallySettledStatusReasonCode.HoldBackPendingAudit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final redemption proceeds are held back as the fund has been liquidated and is pending audit approval.
    /// Encoded/decoded by serializers as &quot;HOLL&quot;.
    /// </summary>
    [EnumMember(Value = "HOLL")]
    [IsoId("_ZxcC4tp-Ed-ak6NoX_4Aeg_237753727")]
    [Description(
        @"Final redemption proceeds are held back as the fund has been liquidated and is pending audit approval."
    )]
    HoldBackLiquidation = PartiallySettledStatusReasonCode.HoldBackLiquidation, // same ordinal as derivation source for type conversions
}
