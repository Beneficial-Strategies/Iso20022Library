// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates from/until when an order must be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ak_mydp-Ed-ak6NoX_4Aeg_1584923071")]
[Description(@"Indicates from/until when an order must be executed.")]
[Derivations(typeof(ExecutionTimeLimit1Code))]
public enum ExecutionTimeLimitCode
{
    /// <summary>
    /// A round lot order to be executed at the opening of the market.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_alJXwNp-Ed-ak6NoX_4Aeg_1584923072")]
    [Description(@"A round lot order to be executed at the opening of the market.")]
    AtTheOpening,

    /// <summary>
    /// An order to buy or sell at the closing price or an odd lot order to buy or sell to be filled at the closing of the round lot offer, plus a differential for a buy order or minus the differential on a sell order.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_alJXwdp-Ed-ak6NoX_4Aeg_1584923073")]
    [Description(
        @"An order to buy or sell at the closing price or an odd lot order to buy or sell to be filled at the closing of the round lot offer, plus a differential for a buy order or minus the differential on a sell order."
    )]
    AtTheClosing,

    /// <summary>
    /// An order that remains in effect until it is either executed or cancelled.
    /// Encoded/decoded by serializers as &quot;GTCA&quot;.
    /// </summary>
    [EnumMember(Value = "GTCA")]
    [IsoId("_alJXwtp-Ed-ak6NoX_4Aeg_1584923083")]
    [Description(@"An order that remains in effect until it is either executed or cancelled.")]
    GoodUntilCancelled,

    /// <summary>
    /// An order that, if not executed, expires at the end of the trading day on which the order is entered.
    /// Encoded/decoded by serializers as &quot;GDAY&quot;.
    /// </summary>
    [EnumMember(Value = "GDAY")]
    [IsoId("_alJXw9p-Ed-ak6NoX_4Aeg_1584923074")]
    [Description(
        @"An order that, if not executed, expires at the end of the trading day on which the order is entered."
    )]
    GoodForTheDay,

    /// <summary>
    /// An Order that if not executed, expires at the end of the specified expiry date.
    /// Encoded/decoded by serializers as &quot;GTHD&quot;.
    /// </summary>
    [EnumMember(Value = "GTHD")]
    [IsoId("_alJXxNp-Ed-ak6NoX_4Aeg_1584923084")]
    [Description(
        @"An Order that if not executed, expires at the end of the specified expiry date."
    )]
    GoodThroughDate,

    /// <summary>
    /// An order that, if not executed, expires at the end of the month on which the order is entered.
    /// Encoded/decoded by serializers as &quot;GTMO&quot;.
    /// </summary>
    [EnumMember(Value = "GTMO")]
    [IsoId("_alJXxdp-Ed-ak6NoX_4Aeg_1584923085")]
    [Description(
        @"An order that, if not executed, expires at the end of the month on which the order is entered."
    )]
    GoodForTheMonth,

    /// <summary>
    /// A market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled.
    /// Encoded/decoded by serializers as &quot;FIKI&quot;.
    /// </summary>
    [EnumMember(Value = "FIKI")]
    [IsoId("_alJXxtp-Ed-ak6NoX_4Aeg_1584923086")]
    [Description(
        @"A market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled."
    )]
    FillOrKill,

    /// <summary>
    /// Indicates an order that is good until the end of next month.
    /// Encoded/decoded by serializers as &quot;GTNM&quot;.
    /// </summary>
    [EnumMember(Value = "GTNM")]
    [IsoId("_alJXx9p-Ed-ak6NoX_4Aeg_1584923087")]
    [Description(@"Indicates an order that is good until the end of next month.")]
    GoodUntilTheEndOfNextMonth,

    /// <summary>
    /// Indicates an order that is good till crossed.
    /// Encoded/decoded by serializers as &quot;GTXO&quot;.
    /// </summary>
    [EnumMember(Value = "GTXO")]
    [IsoId("_alJXyNp-Ed-ak6NoX_4Aeg_1584923088")]
    [Description(@"Indicates an order that is good till crossed.")]
    GoodTillCrossed,

    /// <summary>
    /// A market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled.
    /// Encoded/decoded by serializers as &quot;IOCA&quot;.
    /// </summary>
    [EnumMember(Value = "IOCA")]
    [IsoId("_alShsNp-Ed-ak6NoX_4Aeg_1584923089")]
    [Description(
        @"A market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled."
    )]
    ImmediateOrCancel,
}
