// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the precise type of liquidity management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afVDoNp-Ed-ak6NoX_4Aeg_-1698330271")]
[Description(@"Specifies the precise type of liquidity management limit.")]
[Derivations(typeof(LiquidityLimitType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LiquidityLimitTypeCode>))]
#endif
public enum LiquidityLimitTypeCode
{
    /// <summary>
    /// Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_afVDodp-Ed-ak6NoX_4Aeg_-1698330270")]
    [Description(
        @"Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments."
    )]
    Global,

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_afVDotp-Ed-ak6NoX_4Aeg_-1698330269")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals."
    )]
    CashReservation,

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as &quot;CPAR&quot;.
    /// </summary>
    [EnumMember(Value = "CPAR")]
    [IsoId("_afVDo9p-Ed-ak6NoX_4Aeg_-1698330268")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments."
    )]
    CriticalPaymentReservation,

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as &quot;NSSR&quot;.
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_afVDpNp-Ed-ak6NoX_4Aeg_-1698330267")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System."
    )]
    NetSSSReservation,
}
