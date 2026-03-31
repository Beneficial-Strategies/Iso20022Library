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
[IsoId("_ZxcC49p-Ed-ak6NoX_4Aeg_-609114754")]
[Description(@"Specifies the reason for a partially settled status.")]
[Derivations(typeof(PartiallySettledStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartiallySettledStatusReasonCode>))]
#endif
public enum PartiallySettledStatusReasonCode
{
    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as &quot;UPST&quot;.
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_ZxcC5Np-Ed-ak6NoX_4Aeg_-536158421")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled,

    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_ZxcC5dp-Ed-ak6NoX_4Aeg_-536158386")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled,

    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as &quot;UCPS&quot;.
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_ZxcC5tp-Ed-ak6NoX_4Aeg_-536158096")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled,

    /// <summary>
    /// Final redemption proceeds are held back, pending annual financial audit approval.
    /// Encoded/decoded by serializers as &quot;HOLA&quot;.
    /// </summary>
    [EnumMember(Value = "HOLA")]
    [IsoId("_ZxcC59p-Ed-ak6NoX_4Aeg_-107645612")]
    [Description(
        @"Final redemption proceeds are held back, pending annual financial audit approval."
    )]
    HoldBackPendingAudit,

    /// <summary>
    /// Final redemption proceeds are held back as the fund has been liquidated and is pending audit approval.
    /// Encoded/decoded by serializers as &quot;HOLL&quot;.
    /// </summary>
    [EnumMember(Value = "HOLL")]
    [IsoId("_ZxcC6Np-Ed-ak6NoX_4Aeg_156481860")]
    [Description(
        @"Final redemption proceeds are held back as the fund has been liquidated and is pending audit approval."
    )]
    HoldBackLiquidation,
}
