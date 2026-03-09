// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of order based on the Financial Information Exchange Protocol.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aTQ9ltp-Ed-ak6NoX_4Aeg_-82502166")]
[Description(@"Specifies a type of order based on the Financial Information Exchange Protocol.")]
[DerivedFrom(typeof(OrderTypeCode))]
public enum OrderType2Code
{
    /// <summary>
    /// An order to buy or sell a specified amount of a financial instrument at the quoted market price or better.
    /// Encoded/decoded by serializers as &quot;MRKT&quot;.
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_aTQ9l9p-Ed-ak6NoX_4Aeg_-82502164")]
    [Description(@"An order to buy or sell a specified amount of a financial instrument at the quoted market price or better.")]
    Market = OrderTypeCode.Market, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher.
    /// Encoded/decoded by serializers as &quot;LMTO&quot;.
    /// </summary>
    [EnumMember(Value = "LMTO")]
    [IsoId("_aTQ9mNp-Ed-ak6NoX_4Aeg_-82502148")]
    [Description(@"An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher.")]
    Limit = OrderTypeCode.Limit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_aTQ9mdp-Ed-ak6NoX_4Aeg_-82502147")]
    [Description(@"An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted.")]
    Stop = OrderTypeCode.Stop, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to be executed at a limit price, with a round-lot (or board-lot) sales; valid only for odd lot orders.
    /// Encoded/decoded by serializers as &quot;LIWI&quot;.
    /// </summary>
    [EnumMember(Value = "LIWI")]
    [IsoId("_aTaHgNp-Ed-ak6NoX_4Aeg_-82502138")]
    [Description(@"An order to be executed at a limit price, with a round-lot (or board-lot) sales; valid only for odd lot orders.")]
    LimitWith = OrderTypeCode.LimitWith, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to be executed at a limit price, without a round-lot (or board-lot) sales; valid only for odd lot orders.
    /// Encoded/decoded by serializers as &quot;LIWO&quot;.
    /// </summary>
    [EnumMember(Value = "LIWO")]
    [IsoId("_aTaHgdp-Ed-ak6NoX_4Aeg_-82502137")]
    [Description(@"An order to be executed at a limit price, without a round-lot (or board-lot) sales; valid only for odd lot orders.")]
    LimitWithout = OrderTypeCode.LimitWithout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A price established by joint agreement of odd-lot dealers for as illiquid financial instrument.
    /// Encoded/decoded by serializers as &quot;BAPR&quot;.
    /// </summary>
    [EnumMember(Value = "BAPR")]
    [IsoId("_aTaHgtp-Ed-ak6NoX_4Aeg_-82502136")]
    [Description(@"A price established by joint agreement of odd-lot dealers for as illiquid financial instrument.")]
    OnBasisPrice = OrderTypeCode.OnBasisPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order which becomes a market order once the market price is reached.
    /// Encoded/decoded by serializers as &quot;MATH&quot;.
    /// </summary>
    [EnumMember(Value = "MATH")]
    [IsoId("_aTaHg9p-Ed-ak6NoX_4Aeg_-82502135")]
    [Description(@"An order which becomes a market order once the market price is reached.")]
    MarketTouched = OrderTypeCode.MarketTouched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An odd lot order filled on an effective round lot transaction, or on an effective bid or offer, whichever occurs first after the specialist receives the order. (e.g. NYSE order type).
    /// Encoded/decoded by serializers as &quot;WTWO&quot;.
    /// </summary>
    [EnumMember(Value = "WTWO")]
    [IsoId("_aTaHhNp-Ed-ak6NoX_4Aeg_-82501097")]
    [Description(@"An odd lot order filled on an effective round lot transaction, or on an effective bid or offer, whichever occurs first after the specialist receives the order. (e.g. NYSE order type).")]
    WithOrWithout = OrderTypeCode.WithOrWithout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order sent in response to a Quote message.
    /// Encoded/decoded by serializers as &quot;PRQT&quot;.
    /// </summary>
    [EnumMember(Value = "PRQT")]
    [IsoId("_aTaHhdp-Ed-ak6NoX_4Aeg_-82501096")]
    [Description(@"An order sent in response to a Quote message.")]
    PreviouslyQuoted = OrderTypeCode.PreviouslyQuoted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order sent in response to an Indication of Interest message.
    /// Encoded/decoded by serializers as &quot;PRID&quot;.
    /// </summary>
    [EnumMember(Value = "PRID")]
    [IsoId("_aTaHhtp-Ed-ak6NoX_4Aeg_-82501095")]
    [Description(@"An order sent in response to an Indication of Interest message.")]
    PreviouslyIndicated = OrderTypeCode.PreviouslyIndicated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A &quot;Swap&quot; order for Foreign Exchange (currency trading).
    /// Encoded/decoded by serializers as &quot;FXSW&quot;.
    /// </summary>
    [EnumMember(Value = "FXSW")]
    [IsoId("_aTaHh9p-Ed-ak6NoX_4Aeg_-82501094")]
    [Description(@"A ""Swap"" order for Foreign Exchange (currency trading).")]
    ForexSwap = OrderTypeCode.ForexSwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Japanese term for an order to buy or sell a stated amount of a security at a specified limit price. Any unexecuted (leftover) quantity becomes a Market On Close order.
    /// Encoded/decoded by serializers as &quot;FNRI&quot;.
    /// </summary>
    [EnumMember(Value = "FNRI")]
    [IsoId("_aTaHiNp-Ed-ak6NoX_4Aeg_-82501093")]
    [Description(@"Japanese term for an order to buy or sell a stated amount of a security at a specified limit price. Any unexecuted (leftover) quantity becomes a Market On Close order.")]
    Funari = OrderTypeCode.Funari, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates an order to buy or sell a stated amount of a security at the prevailing market price with any unexecuted (leftover) quantity becoming a Limit order at the last executed price.
    /// Encoded/decoded by serializers as &quot;MKLO&quot;.
    /// </summary>
    [EnumMember(Value = "MKLO")]
    [IsoId("_aTaHidp-Ed-ak6NoX_4Aeg_-82501092")]
    [Description(@"Indicates an order to buy or sell a stated amount of a security at the prevailing market price with any unexecuted (leftover) quantity becoming a Limit order at the last executed price.")]
    MarketWithLeftover = OrderTypeCode.MarketWithLeftover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).
    /// Encoded/decoded by serializers as &quot;PGGD&quot;.
    /// </summary>
    [EnumMember(Value = "PGGD")]
    [IsoId("_aTj4gNp-Ed-ak6NoX_4Aeg_-82501082")]
    [Description(@"Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).")]
    Pegged = OrderTypeCode.Pegged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to sell that sets the sell price below the market price.
    /// Encoded/decoded by serializers as &quot;SLOS&quot;.
    /// </summary>
    [EnumMember(Value = "SLOS")]
    [IsoId("_aTj4gdp-Ed-ak6NoX_4Aeg_-885340544")]
    [Description(@"An order to sell that sets the sell price below the market price.")]
    StopLoss = OrderTypeCode.StopLoss, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A stop order to buy which becomes a limit order at the limit price when the financial instrument trades at or above the stop price after the order is submitted. A stop order to sell which becomes a limit order at the limit price when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STLI&quot;.
    /// </summary>
    [EnumMember(Value = "STLI")]
    [IsoId("_aTj4gtp-Ed-ak6NoX_4Aeg_-831777292")]
    [Description(@"A stop order to buy which becomes a limit order at the limit price when the financial instrument trades at or above the stop price after the order is submitted. A stop order to sell which becomes a limit order at the limit price when the financial instrument trades at or below the stop price after the order is submitted.")]
    StopLimit = OrderTypeCode.StopLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is a counter order.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aTj4g9p-Ed-ak6NoX_4Aeg_414977225")]
    [Description(@"Indicates that the order is a counter order.")]
    CounterOrderSelection = OrderTypeCode.CounterOrderSelection, // same ordinal as derivation source for type conversions
    
}
