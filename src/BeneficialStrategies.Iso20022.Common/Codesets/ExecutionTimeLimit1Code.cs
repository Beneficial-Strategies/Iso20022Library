// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates from/until when an order must be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ak11x9p-Ed-ak6NoX_4Aeg_1168575945")]
[Description(@"Indicates from/until when an order must be executed.")]
[DerivedFrom(typeof(ExecutionTimeLimitCode))]
public enum ExecutionTimeLimit1Code
{
    /// <summary>
    /// A round lot order to be executed at the opening of the market.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ak11yNp-Ed-ak6NoX_4Aeg_1612789296")]
    [Description(@"A round lot order to be executed at the opening of the market.")]
    AtTheOpening = ExecutionTimeLimitCode.AtTheOpening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order to buy or sell at the closing price or an odd lot order to buy or sell to be filled at the closing of the round lot offer, plus a differential for a buy order or minus the differential on a sell order.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_ak_mwNp-Ed-ak6NoX_4Aeg_1212901803")]
    [Description(
        @"An order to buy or sell at the closing price or an odd lot order to buy or sell to be filled at the closing of the round lot offer, plus a differential for a buy order or minus the differential on a sell order."
    )]
    AtTheClosing = ExecutionTimeLimitCode.AtTheClosing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order that, if not executed, expires at the end of the trading day on which the order is entered.
    /// Encoded/decoded by serializers as &quot;GDAY&quot;.
    /// </summary>
    [EnumMember(Value = "GDAY")]
    [IsoId("_ak_mwdp-Ed-ak6NoX_4Aeg_1243378321")]
    [Description(
        @"An order that, if not executed, expires at the end of the trading day on which the order is entered."
    )]
    GoodForTheDay = ExecutionTimeLimitCode.GoodForTheDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order that remains in effect until it is either executed or cancelled.
    /// Encoded/decoded by serializers as &quot;GTCA&quot;.
    /// </summary>
    [EnumMember(Value = "GTCA")]
    [IsoId("_ak_mwtp-Ed-ak6NoX_4Aeg_1266466316")]
    [Description(@"An order that remains in effect until it is either executed or cancelled.")]
    GoodUntilCancelled = ExecutionTimeLimitCode.GoodUntilCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An Order that if not executed, expires at the end of the specified expiry date.
    /// Encoded/decoded by serializers as &quot;GTHD&quot;.
    /// </summary>
    [EnumMember(Value = "GTHD")]
    [IsoId("_ak_mw9p-Ed-ak6NoX_4Aeg_1525053559")]
    [Description(
        @"An Order that if not executed, expires at the end of the specified expiry date."
    )]
    GoodThroughDate = ExecutionTimeLimitCode.GoodThroughDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order that, if not executed, expires at the end of the month on which the order is entered.
    /// Encoded/decoded by serializers as &quot;GTMO&quot;.
    /// </summary>
    [EnumMember(Value = "GTMO")]
    [IsoId("_ak_mxNp-Ed-ak6NoX_4Aeg_1540753480")]
    [Description(
        @"An order that, if not executed, expires at the end of the month on which the order is entered."
    )]
    GoodForTheMonth = ExecutionTimeLimitCode.GoodForTheMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled.
    /// Encoded/decoded by serializers as &quot;FIKI&quot;.
    /// </summary>
    [EnumMember(Value = "FIKI")]
    [IsoId("_ak_mxdp-Ed-ak6NoX_4Aeg_1559224088")]
    [Description(
        @"A market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled."
    )]
    FillOrKill = ExecutionTimeLimitCode.FillOrKill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates an order that is good until the end of next month.
    /// Encoded/decoded by serializers as &quot;GTNM&quot;.
    /// </summary>
    [EnumMember(Value = "GTNM")]
    [IsoId("_ak_mxtp-Ed-ak6NoX_4Aeg_1580465504")]
    [Description(@"Indicates an order that is good until the end of next month.")]
    GoodUntilTheEndOfNextMonth = ExecutionTimeLimitCode.GoodUntilTheEndOfNextMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates an order that is good till crossed.
    /// Encoded/decoded by serializers as &quot;GTXO&quot;.
    /// </summary>
    [EnumMember(Value = "GTXO")]
    [IsoId("_ak_mx9p-Ed-ak6NoX_4Aeg_1597089688")]
    [Description(@"Indicates an order that is good till crossed.")]
    GoodTillCrossed = ExecutionTimeLimitCode.GoodTillCrossed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled.
    /// Encoded/decoded by serializers as &quot;IOCA&quot;.
    /// </summary>
    [EnumMember(Value = "IOCA")]
    [IsoId("_ak_myNp-Ed-ak6NoX_4Aeg_1655271016")]
    [Description(
        @"A market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled."
    )]
    ImmediateOrCancel = ExecutionTimeLimitCode.ImmediateOrCancel, // same ordinal as derivation source for type conversions
}
