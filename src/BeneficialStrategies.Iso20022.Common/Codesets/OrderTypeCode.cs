// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aTj4hNp-Ed-ak6NoX_4Aeg_-82501079")]
[Description(
    @"Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument."
)]
[Derivations(typeof(OrderType1Code), typeof(OrderType2Code))]
public enum OrderTypeCode
{
    /// <summary>
    /// A round-lot market or limit price order that must be executed in its entirety or not at all; unlike fill or kill orders, all or none orders are not treated as canceled if they are not executed as soon as represented in the trading crowd.
    /// Encoded/decoded by serializers as &quot;ALNO&quot;.
    /// </summary>
    [EnumMember(Value = "ALNO")]
    [IsoId("_aTj4hdp-Ed-ak6NoX_4Aeg_-82500853")]
    [Description(
        @"A round-lot market or limit price order that must be executed in its entirety or not at all; unlike fill or kill orders, all or none orders are not treated as canceled if they are not executed as soon as represented in the trading crowd."
    )]
    AllOrNone,

    /// <summary>
    /// A buy contra short exempt.
    /// Encoded/decoded by serializers as &quot;BCSE&quot;.
    /// </summary>
    [EnumMember(Value = "BCSE")]
    [IsoId("_aTj4htp-Ed-ak6NoX_4Aeg_-82500852")]
    [Description(@"A buy contra short exempt.")]
    BuyContraShortExempt,

    /// <summary>
    /// An order to buy contra short.
    /// Encoded/decoded by serializers as &quot;BCSH&quot;.
    /// </summary>
    [EnumMember(Value = "BCSH")]
    [IsoId("_aTj4h9p-Ed-ak6NoX_4Aeg_-82500851")]
    [Description(@"An order to buy contra short.")]
    BuyContraShort,

    /// <summary>
    /// An order to buy at a price lower than the current market price. This is an order to buy a stated amount of a financial instrument provided that its price is not higher than the last sale if the last sale was a minus or zero minus tick, not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick. The price limit indicates the highest price at which the order can be executed.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_aTj4iNp-Ed-ak6NoX_4Aeg_-82500845")]
    [Description(
        @"An order to buy at a price lower than the current market price. This is an order to buy a stated amount of a financial instrument provided that its price is not higher than the last sale if the last sale was a minus or zero minus tick, not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick. The price limit indicates the highest price at which the order can be executed."
    )]
    BuyMinus,

    /// <summary>
    /// An order which is not to be executed as a whole if the executing broker judges that it may disturb the price.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_aTtpgNp-Ed-ak6NoX_4Aeg_-82500844")]
    [Description(
        @"An order which is not to be executed as a whole if the executing broker judges that it may disturb the price."
    )]
    Carefully,

    /// <summary>
    /// An order which is linked to another order to buy or sell and must be executed as a unit, both or none, or cancelled as a unit. The linkage sequence must be completed with a reference to the linked order.
    /// Encoded/decoded by serializers as &quot;COMB&quot;.
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_aTtpgdp-Ed-ak6NoX_4Aeg_-82500836")]
    [Description(
        @"An order which is linked to another order to buy or sell and must be executed as a unit, both or none, or cancelled as a unit. The linkage sequence must be completed with a reference to the linked order."
    )]
    Combination,

    /// <summary>
    /// An order where the executing broker or investment manager decides on the quantity or price.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aTtpgtp-Ed-ak6NoX_4Aeg_-82500835")]
    [Description(
        @"An order where the executing broker or investment manager decides on the quantity or price."
    )]
    Discretionary,

    /// <summary>
    /// An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher.
    /// Encoded/decoded by serializers as &quot;LMTO&quot;.
    /// </summary>
    [EnumMember(Value = "LMTO")]
    [IsoId("_aTtpg9p-Ed-ak6NoX_4Aeg_-82500834")]
    [Description(
        @"An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher."
    )]
    Limit,

    /// <summary>
    /// Indicates that if the limit conditions are not satisfied, it should not be executed.
    /// Encoded/decoded by serializers as &quot;LMCO&quot;.
    /// </summary>
    [EnumMember(Value = "LMCO")]
    [IsoId("_aTtphNp-Ed-ak6NoX_4Aeg_-82500833")]
    [Description(
        @"Indicates that if the limit conditions are not satisfied, it should not be executed."
    )]
    LimitOnClose,

    /// <summary>
    /// A trade at this specified price or better.
    /// Encoded/decoded by serializers as &quot;LMBT&quot;.
    /// </summary>
    [EnumMember(Value = "LMBT")]
    [IsoId("_aTtphdp-Ed-ak6NoX_4Aeg_-82500832")]
    [Description(@"A trade at this specified price or better.")]
    LimitOrBetter,

    /// <summary>
    /// An order to be executed at a limit price, with a round-lot (or board-lot) sales; valid only for odd lot orders.
    /// Encoded/decoded by serializers as &quot;LIWI&quot;.
    /// </summary>
    [EnumMember(Value = "LIWI")]
    [IsoId("_aTtphtp-Ed-ak6NoX_4Aeg_-82500831")]
    [Description(
        @"An order to be executed at a limit price, with a round-lot (or board-lot) sales; valid only for odd lot orders."
    )]
    LimitWith,

    /// <summary>
    /// An order to be executed at a limit price, without a round-lot (or board-lot) sales; valid only for odd lot orders.
    /// Encoded/decoded by serializers as &quot;LIWO&quot;.
    /// </summary>
    [EnumMember(Value = "LIWO")]
    [IsoId("_aTtph9p-Ed-ak6NoX_4Aeg_-82500822")]
    [Description(
        @"An order to be executed at a limit price, without a round-lot (or board-lot) sales; valid only for odd lot orders."
    )]
    LimitWithout,

    /// <summary>
    /// An order to buy or sell a specified amount of a financial instrument at the quoted market price or better.
    /// Encoded/decoded by serializers as &quot;MRKT&quot;.
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_aTtpiNp-Ed-ak6NoX_4Aeg_-82500821")]
    [Description(
        @"An order to buy or sell a specified amount of a financial instrument at the quoted market price or better."
    )]
    Market,

    /// <summary>
    /// An order to buy or sell a stated amount of a financial instrument at the quoted market price or better with some discretion on the price limit.
    /// Encoded/decoded by serializers as &quot;MANH&quot;.
    /// </summary>
    [EnumMember(Value = "MANH")]
    [IsoId("_aTtpidp-Ed-ak6NoX_4Aeg_-82500820")]
    [Description(
        @"An order to buy or sell a stated amount of a financial instrument at the quoted market price or better with some discretion on the price limit."
    )]
    MarketNotHeld,

    /// <summary>
    /// An order which becomes a market order once the market price is reached.
    /// Encoded/decoded by serializers as &quot;MATH&quot;.
    /// </summary>
    [EnumMember(Value = "MATH")]
    [IsoId("_aT2zcNp-Ed-ak6NoX_4Aeg_-82500818")]
    [Description(@"An order which becomes a market order once the market price is reached.")]
    MarketTouched,

    /// <summary>
    /// An order which may be executed in partials or outside the hours of the exchange or other exchange rules.
    /// Encoded/decoded by serializers as &quot;NOHE&quot;.
    /// </summary>
    [EnumMember(Value = "NOHE")]
    [IsoId("_aT2zcdp-Ed-ak6NoX_4Aeg_-82500817")]
    [Description(
        @"An order which may be executed in partials or outside the hours of the exchange or other exchange rules."
    )]
    NotHeld,

    /// <summary>
    /// An order which is related to another order where the second part may be cancelled without canceling the first. In this case, the second order is identified as the second part. Normally the sell order must be executed before the buy order. The linkage sequence must be completed with a reference to the linked order.
    /// Encoded/decoded by serializers as &quot;ORLI&quot;.
    /// </summary>
    [EnumMember(Value = "ORLI")]
    [IsoId("_aT2zctp-Ed-ak6NoX_4Aeg_-82500816")]
    [Description(
        @"An order which is related to another order where the second part may be cancelled without canceling the first. In this case, the second order is identified as the second part. Normally the sell order must be executed before the buy order. The linkage sequence must be completed with a reference to the linked order."
    )]
    OrderLie,

    /// <summary>
    /// A price established by joint agreement of odd-lot dealers for as illiquid financial instrument.
    /// Encoded/decoded by serializers as &quot;BAPR&quot;.
    /// </summary>
    [EnumMember(Value = "BAPR")]
    [IsoId("_aT2zc9p-Ed-ak6NoX_4Aeg_-82500815")]
    [Description(
        @"A price established by joint agreement of odd-lot dealers for as illiquid financial instrument."
    )]
    OnBasisPrice,

    /// <summary>
    /// An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_aT2zdNp-Ed-ak6NoX_4Aeg_-82500813")]
    [Description(
        @"An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted."
    )]
    Stop,

    /// <summary>
    /// A stop order to buy which becomes a limit order at the limit price when the financial instrument trades at or above the stop price after the order is submitted. A stop order to sell which becomes a limit order at the limit price when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STLI&quot;.
    /// </summary>
    [EnumMember(Value = "STLI")]
    [IsoId("_aT2zddp-Ed-ak6NoX_4Aeg_-82500805")]
    [Description(
        @"A stop order to buy which becomes a limit order at the limit price when the financial instrument trades at or above the stop price after the order is submitted. A stop order to sell which becomes a limit order at the limit price when the financial instrument trades at or below the stop price after the order is submitted."
    )]
    StopLimit,

    /// <summary>
    /// An order to sell that sets the sell price below the market price.
    /// Encoded/decoded by serializers as &quot;SLOS&quot;.
    /// </summary>
    [EnumMember(Value = "SLOS")]
    [IsoId("_aT2zdtp-Ed-ak6NoX_4Aeg_-82500804")]
    [Description(@"An order to sell that sets the sell price below the market price.")]
    StopLoss,

    /// <summary>
    /// An order to sell a stated amount provided that the price is not lower than the last sale price if the last sale was a plus or zero plus tick and not lower than the last sale minus the minimum fractional change in the financial instrument if the last sale was a minus or zero minus tick.
    /// Encoded/decoded by serializers as &quot;SPLU&quot;.
    /// </summary>
    [EnumMember(Value = "SPLU")]
    [IsoId("_aT2zd9p-Ed-ak6NoX_4Aeg_-82500803")]
    [Description(
        @"An order to sell a stated amount provided that the price is not lower than the last sale price if the last sale was a plus or zero plus tick and not lower than the last sale minus the minimum fractional change in the financial instrument if the last sale was a minus or zero minus tick."
    )]
    SellPlus,

    /// <summary>
    /// An order to sell that the seller does not own; a sale effected by delivering a financial instrument borrowed by or for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSHO&quot;.
    /// </summary>
    [EnumMember(Value = "SSHO")]
    [IsoId("_aT2zeNp-Ed-ak6NoX_4Aeg_-82500760")]
    [Description(
        @"An order to sell that the seller does not own; a sale effected by delivering a financial instrument borrowed by or for the account of the seller."
    )]
    SellShort,

    /// <summary>
    /// An order to sell short which is exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SSEX&quot;.
    /// </summary>
    [EnumMember(Value = "SSEX")]
    [IsoId("_aT2zedp-Ed-ak6NoX_4Aeg_-82500759")]
    [Description(@"An order to sell short which is exempt from short-sale rules.")]
    SellShortExempt,

    /// <summary>
    /// An odd lot order filled on an effective round lot transaction, or on an effective bid or offer, whichever occurs first after the specialist receives the order. (e.g. NYSE order type).
    /// Encoded/decoded by serializers as &quot;WTWO&quot;.
    /// </summary>
    [EnumMember(Value = "WTWO")]
    [IsoId("_aUAkcNp-Ed-ak6NoX_4Aeg_-82500758")]
    [Description(
        @"An odd lot order filled on an effective round lot transaction, or on an effective bid or offer, whichever occurs first after the specialist receives the order. (e.g. NYSE order type)."
    )]
    WithOrWithout,

    /// <summary>
    /// An order sent in response to a Quote message.
    /// Encoded/decoded by serializers as &quot;PRQT&quot;.
    /// </summary>
    [EnumMember(Value = "PRQT")]
    [IsoId("_aUAkcdp-Ed-ak6NoX_4Aeg_-82500757")]
    [Description(@"An order sent in response to a Quote message.")]
    PreviouslyQuoted,

    /// <summary>
    /// An order sent in response to an Indication of Interest message.
    /// Encoded/decoded by serializers as &quot;PRID&quot;.
    /// </summary>
    [EnumMember(Value = "PRID")]
    [IsoId("_aUAkctp-Ed-ak6NoX_4Aeg_-82500756")]
    [Description(@"An order sent in response to an Indication of Interest message.")]
    PreviouslyIndicated,

    /// <summary>
    /// A &quot;Swap&quot; order for Foreign Exchange (currency trading).
    /// Encoded/decoded by serializers as &quot;FXSW&quot;.
    /// </summary>
    [EnumMember(Value = "FXSW")]
    [IsoId("_aUAkc9p-Ed-ak6NoX_4Aeg_-82500755")]
    [Description(@"A ""Swap"" order for Foreign Exchange (currency trading).")]
    ForexSwap,

    /// <summary>
    /// Japanese term for an order to buy or sell a stated amount of a security at a specified limit price. Any unexecuted (leftover) quantity becomes a Market On Close order.
    /// Encoded/decoded by serializers as &quot;FNRI&quot;.
    /// </summary>
    [EnumMember(Value = "FNRI")]
    [IsoId("_aUAkdNp-Ed-ak6NoX_4Aeg_-82500754")]
    [Description(
        @"Japanese term for an order to buy or sell a stated amount of a security at a specified limit price. Any unexecuted (leftover) quantity becomes a Market On Close order."
    )]
    Funari,

    /// <summary>
    /// Indicates an order to buy or sell a stated amount of a security at the prevailing market price with any unexecuted (leftover) quantity becoming a Limit order at the last executed price.
    /// Encoded/decoded by serializers as &quot;MKLO&quot;.
    /// </summary>
    [EnumMember(Value = "MKLO")]
    [IsoId("_aUAkddp-Ed-ak6NoX_4Aeg_-82500753")]
    [Description(
        @"Indicates an order to buy or sell a stated amount of a security at the prevailing market price with any unexecuted (leftover) quantity becoming a Limit order at the last executed price."
    )]
    MarketWithLeftover,

    /// <summary>
    /// Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).
    /// Encoded/decoded by serializers as &quot;PGGD&quot;.
    /// </summary>
    [EnumMember(Value = "PGGD")]
    [IsoId("_aUAkdtp-Ed-ak6NoX_4Aeg_-82500743")]
    [Description(
        @"Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price)."
    )]
    Pegged,

    /// <summary>
    /// Indicates that the order is a counter order.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aUAkd9p-Ed-ak6NoX_4Aeg_324472971")]
    [Description(@"Indicates that the order is a counter order.")]
    CounterOrderSelection,
}
