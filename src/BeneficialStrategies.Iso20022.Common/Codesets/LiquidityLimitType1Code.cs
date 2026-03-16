// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the precise type of liquidity management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afL5tNp-Ed-ak6NoX_4Aeg_-1698330294")]
[Description(@"Specifies the precise type of liquidity management limit.")]
[DerivedFrom(typeof(LiquidityLimitTypeCode))]
public enum LiquidityLimitType1Code
{
    /// <summary>
    /// Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_afL5tdp-Ed-ak6NoX_4Aeg_-1698330285")]
    [Description(
        @"Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments."
    )]
    Global = LiquidityLimitTypeCode.Global, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_afL5ttp-Ed-ak6NoX_4Aeg_-1698330284")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals."
    )]
    CashReservation = LiquidityLimitTypeCode.CashReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as &quot;CPAR&quot;.
    /// </summary>
    [EnumMember(Value = "CPAR")]
    [IsoId("_afL5t9p-Ed-ak6NoX_4Aeg_-1698330283")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments."
    )]
    CriticalPaymentReservation = LiquidityLimitTypeCode.CriticalPaymentReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as &quot;NSSR&quot;.
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_afL5uNp-Ed-ak6NoX_4Aeg_-1698330282")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System."
    )]
    NetSSSReservation = LiquidityLimitTypeCode.NetSSSReservation, // same ordinal as derivation source for type conversions
}
