// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aS0Rpdp-Ed-ak6NoX_4Aeg_-2117834119")]
[Description(@"Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.")]
[DerivedFrom(typeof(OrderTypeCode))]
public enum OrderType1Code
{
    /// <summary>
    /// A round-lot market or limit price order that must be executed in its entirety or not at all; unlike fill or kill orders, all or none orders are not treated as canceled if they are not executed as soon as represented in the trading crowd.
    /// Encoded/decoded by serializers as &quot;ALNO&quot;.
    /// </summary>
    [EnumMember(Value = "ALNO")]
    [IsoId("_aS0Rptp-Ed-ak6NoX_4Aeg_-152464306")]
    [Description(@"A round-lot market or limit price order that must be executed in its entirety or not at all; unlike fill or kill orders, all or none orders are not treated as canceled if they are not executed as soon as represented in the trading crowd.")]
    AllOrNone = OrderTypeCode.AllOrNone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A buy contra short exempt.
    /// Encoded/decoded by serializers as &quot;BCSE&quot;.
    /// </summary>
    [EnumMember(Value = "BCSE")]
    [IsoId("_aS0Rp9p-Ed-ak6NoX_4Aeg_135408026")]
    [Description(@"A buy contra short exempt.")]
    BuyContraShortExempt = OrderTypeCode.BuyContraShortExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy contra short.
    /// Encoded/decoded by serializers as &quot;BCSH&quot;.
    /// </summary>
    [EnumMember(Value = "BCSH")]
    [IsoId("_aS0RqNp-Ed-ak6NoX_4Aeg_159420439")]
    [Description(@"An order to buy contra short.")]
    BuyContraShort = OrderTypeCode.BuyContraShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy at a price lower than the current market price. This is an order to buy a stated amount of a financial instrument provided that its price is not higher than the last sale if the last sale was a minus or zero minus tick, not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick. The price limit indicates the highest price at which the order can be executed.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_aS9bkNp-Ed-ak6NoX_4Aeg_173273332")]
    [Description(@"An order to buy at a price lower than the current market price. This is an order to buy a stated amount of a financial instrument provided that its price is not higher than the last sale if the last sale was a minus or zero minus tick, not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick. The price limit indicates the highest price at which the order can be executed.")]
    BuyMinus = OrderTypeCode.BuyMinus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order which is not to be executed as a whole if the executing broker judges that it may disturb the price.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_aS9bkdp-Ed-ak6NoX_4Aeg_-109983318")]
    [Description(@"An order which is not to be executed as a whole if the executing broker judges that it may disturb the price.")]
    Carefully = OrderTypeCode.Carefully, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order which is linked to another order to buy or sell and must be executed as a unit, both or none, or cancelled as a unit. The linkage sequence must be completed with a reference to the linked order.
    /// Encoded/decoded by serializers as &quot;COMB&quot;.
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_aS9bktp-Ed-ak6NoX_4Aeg_-1259109163")]
    [Description(@"An order which is linked to another order to buy or sell and must be executed as a unit, both or none, or cancelled as a unit. The linkage sequence must be completed with a reference to the linked order.")]
    Combination = OrderTypeCode.Combination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order where the executing broker or investment manager decides on the quantity or price.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aS9bk9p-Ed-ak6NoX_4Aeg_1432954067")]
    [Description(@"An order where the executing broker or investment manager decides on the quantity or price.")]
    Discretionary = OrderTypeCode.Discretionary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher.
    /// Encoded/decoded by serializers as &quot;LMTO&quot;.
    /// </summary>
    [EnumMember(Value = "LMTO")]
    [IsoId("_aS9blNp-Ed-ak6NoX_4Aeg_-2085508947")]
    [Description(@"An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher.")]
    Limit = OrderTypeCode.Limit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to be executed at a limit price, with a round-lot (or board-lot) sales; valid only for odd lot orders.
    /// Encoded/decoded by serializers as &quot;LIWI&quot;.
    /// </summary>
    [EnumMember(Value = "LIWI")]
    [IsoId("_aS9bldp-Ed-ak6NoX_4Aeg_13651342")]
    [Description(@"An order to be executed at a limit price, with a round-lot (or board-lot) sales; valid only for odd lot orders.")]
    LimitWith = OrderTypeCode.LimitWith, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to be executed at a limit price, without a round-lot (or board-lot) sales; valid only for odd lot orders.
    /// Encoded/decoded by serializers as &quot;LIWO&quot;.
    /// </summary>
    [EnumMember(Value = "LIWO")]
    [IsoId("_aS9bltp-Ed-ak6NoX_4Aeg_645342047")]
    [Description(@"An order to be executed at a limit price, without a round-lot (or board-lot) sales; valid only for odd lot orders.")]
    LimitWithout = OrderTypeCode.LimitWithout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy or sell a specified amount of a financial instrument at the quoted market price or better.
    /// Encoded/decoded by serializers as &quot;MRKT&quot;.
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_aS9bl9p-Ed-ak6NoX_4Aeg_-2090127772")]
    [Description(@"An order to buy or sell a specified amount of a financial instrument at the quoted market price or better.")]
    Market = OrderTypeCode.Market, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy or sell a stated amount of a financial instrument at the quoted market price or better with some discretion on the price limit.
    /// Encoded/decoded by serializers as &quot;MANH&quot;.
    /// </summary>
    [EnumMember(Value = "MANH")]
    [IsoId("_aS9bmNp-Ed-ak6NoX_4Aeg_1508619597")]
    [Description(@"An order to buy or sell a stated amount of a financial instrument at the quoted market price or better with some discretion on the price limit.")]
    MarketNotHeld = OrderTypeCode.MarketNotHeld, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order which becomes a market order once the market price is reached.
    /// Encoded/decoded by serializers as &quot;MATH&quot;.
    /// </summary>
    [EnumMember(Value = "MATH")]
    [IsoId("_aS9bmdp-Ed-ak6NoX_4Aeg_1394103999")]
    [Description(@"An order which becomes a market order once the market price is reached.")]
    MarketTouched = OrderTypeCode.MarketTouched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order which may be executed in partials or outside the hours of the exchange or other exchange rules.
    /// Encoded/decoded by serializers as &quot;NOHE&quot;.
    /// </summary>
    [EnumMember(Value = "NOHE")]
    [IsoId("_aS9bmtp-Ed-ak6NoX_4Aeg_1795836797")]
    [Description(@"An order which may be executed in partials or outside the hours of the exchange or other exchange rules.")]
    NotHeld = OrderTypeCode.NotHeld, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order which is related to another order where the second part may be cancelled without canceling the first. In this case, the second order is identified as the second part. Normally the sell order must be executed before the buy order. The linkage sequence must be completed with a reference to the linked order.
    /// Encoded/decoded by serializers as &quot;ORLI&quot;.
    /// </summary>
    [EnumMember(Value = "ORLI")]
    [IsoId("_aTHMkNp-Ed-ak6NoX_4Aeg_1878030194")]
    [Description(@"An order which is related to another order where the second part may be cancelled without canceling the first. In this case, the second order is identified as the second part. Normally the sell order must be executed before the buy order. The linkage sequence must be completed with a reference to the linked order.")]
    OrderLie = OrderTypeCode.OrderLie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A price established by joint agreement of odd-lot dealers for as illiquid financial instrument.
    /// Encoded/decoded by serializers as &quot;BAPR&quot;.
    /// </summary>
    [EnumMember(Value = "BAPR")]
    [IsoId("_aTHMkdp-Ed-ak6NoX_4Aeg_1602766946")]
    [Description(@"A price established by joint agreement of odd-lot dealers for as illiquid financial instrument.")]
    OnBasisPrice = OrderTypeCode.OnBasisPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_aTHMktp-Ed-ak6NoX_4Aeg_-2074426913")]
    [Description(@"An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted.")]
    Stop = OrderTypeCode.Stop, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A stop order to buy which becomes a limit order at the limit price when the financial instrument trades at or above the stop price after the order is submitted. A stop order to sell which becomes a limit order at the limit price when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STLI&quot;.
    /// </summary>
    [EnumMember(Value = "STLI")]
    [IsoId("_aTHMk9p-Ed-ak6NoX_4Aeg_-2060575959")]
    [Description(@"A stop order to buy which becomes a limit order at the limit price when the financial instrument trades at or above the stop price after the order is submitted. A stop order to sell which becomes a limit order at the limit price when the financial instrument trades at or below the stop price after the order is submitted.")]
    StopLimit = OrderTypeCode.StopLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to sell that sets the sell price below the market price.
    /// Encoded/decoded by serializers as &quot;SLOS&quot;.
    /// </summary>
    [EnumMember(Value = "SLOS")]
    [IsoId("_aTHMlNp-Ed-ak6NoX_4Aeg_530675618")]
    [Description(@"An order to sell that sets the sell price below the market price.")]
    StopLoss = OrderTypeCode.StopLoss, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to sell a stated amount provided that the price is not lower than the last sale price if the last sale was a plus or zero plus tick and not lower than the last sale minus the minimum fractional change in the financial instrument if the last sale was a minus or zero minus tick.
    /// Encoded/decoded by serializers as &quot;SPLU&quot;.
    /// </summary>
    [EnumMember(Value = "SPLU")]
    [IsoId("_aTHMldp-Ed-ak6NoX_4Aeg_557457295")]
    [Description(@"An order to sell a stated amount provided that the price is not lower than the last sale price if the last sale was a plus or zero plus tick and not lower than the last sale minus the minimum fractional change in the financial instrument if the last sale was a minus or zero minus tick.")]
    SellPlus = OrderTypeCode.SellPlus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to sell that the seller does not own; a sale effected by delivering a financial instrument borrowed by or for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSHO&quot;.
    /// </summary>
    [EnumMember(Value = "SSHO")]
    [IsoId("_aTHMltp-Ed-ak6NoX_4Aeg_575928489")]
    [Description(@"An order to sell that the seller does not own; a sale effected by delivering a financial instrument borrowed by or for the account of the seller.")]
    SellShort = OrderTypeCode.SellShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to sell short which is exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SSEX&quot;.
    /// </summary>
    [EnumMember(Value = "SSEX")]
    [IsoId("_aTHMl9p-Ed-ak6NoX_4Aeg_563919866")]
    [Description(@"An order to sell short which is exempt from short-sale rules.")]
    SellShortExempt = OrderTypeCode.SellShortExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An odd lot order filled on an effective round lot transaction, or on an effective bid or offer, whichever occurs first after the specialist receives the order. (e.g. NYSE order type).
    /// Encoded/decoded by serializers as &quot;WTWO&quot;.
    /// </summary>
    [EnumMember(Value = "WTWO")]
    [IsoId("_aTHMmNp-Ed-ak6NoX_4Aeg_370947495")]
    [Description(@"An odd lot order filled on an effective round lot transaction, or on an effective bid or offer, whichever occurs first after the specialist receives the order. (e.g. NYSE order type).")]
    WithOrWithout = OrderTypeCode.WithOrWithout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order sent in response to a Quote message.
    /// Encoded/decoded by serializers as &quot;PRQT&quot;.
    /// </summary>
    [EnumMember(Value = "PRQT")]
    [IsoId("_aTHMmdp-Ed-ak6NoX_4Aeg_370947710")]
    [Description(@"An order sent in response to a Quote message.")]
    PreviouslyQuoted = OrderTypeCode.PreviouslyQuoted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order sent in response to an Indication of Interest message.
    /// Encoded/decoded by serializers as &quot;PRID&quot;.
    /// </summary>
    [EnumMember(Value = "PRID")]
    [IsoId("_aTQ9kNp-Ed-ak6NoX_4Aeg_371868072")]
    [Description(@"An order sent in response to an Indication of Interest message.")]
    PreviouslyIndicated = OrderTypeCode.PreviouslyIndicated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A &quot;Swap&quot; order for Foreign Exchange (currency trading).
    /// Encoded/decoded by serializers as &quot;FXSW&quot;.
    /// </summary>
    [EnumMember(Value = "FXSW")]
    [IsoId("_aTQ9kdp-Ed-ak6NoX_4Aeg_371868227")]
    [Description(@"A ""Swap"" order for Foreign Exchange (currency trading).")]
    ForexSwap = OrderTypeCode.ForexSwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Japanese term for an order to buy or sell a stated amount of a security at a specified limit price. Any unexecuted (leftover) quantity becomes a Market On Close order.
    /// Encoded/decoded by serializers as &quot;FNRI&quot;.
    /// </summary>
    [EnumMember(Value = "FNRI")]
    [IsoId("_aTQ9ktp-Ed-ak6NoX_4Aeg_371868599")]
    [Description(@"Japanese term for an order to buy or sell a stated amount of a security at a specified limit price. Any unexecuted (leftover) quantity becomes a Market On Close order.")]
    Funari = OrderTypeCode.Funari, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates an order to buy or sell a stated amount of a security at the prevailing market price with any unexecuted (leftover) quantity becoming a Limit order at the last executed price.
    /// Encoded/decoded by serializers as &quot;MKLO&quot;.
    /// </summary>
    [EnumMember(Value = "MKLO")]
    [IsoId("_aTQ9k9p-Ed-ak6NoX_4Aeg_371870519")]
    [Description(@"Indicates an order to buy or sell a stated amount of a security at the prevailing market price with any unexecuted (leftover) quantity becoming a Limit order at the last executed price.")]
    MarketWithLeftover = OrderTypeCode.MarketWithLeftover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).
    /// Encoded/decoded by serializers as &quot;PGGD&quot;.
    /// </summary>
    [EnumMember(Value = "PGGD")]
    [IsoId("_aTQ9lNp-Ed-ak6NoX_4Aeg_371871605")]
    [Description(@"Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).")]
    Pegged = OrderTypeCode.Pegged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is a counter order.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aTQ9ldp-Ed-ak6NoX_4Aeg_-929676213")]
    [Description(@"Indicates that the order is a counter order.")]
    CounterOrderSelection = OrderTypeCode.CounterOrderSelection, // same ordinal as derivation source for type conversions
    
}
