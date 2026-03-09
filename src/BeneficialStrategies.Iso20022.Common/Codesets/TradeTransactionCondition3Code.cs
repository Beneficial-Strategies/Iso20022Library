// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YobMYNp-Ed-ak6NoX_4Aeg_1891584902")]
[Description(@"Specifies the conditions under which the order/trade is to be/was executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
public enum TradeTransactionCondition3Code
{
    /// <summary>
    /// Indicates whether the trade is executed cum bonus.
    /// Encoded/decoded by serializers as &quot;CBNS&quot;.
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_YobMYdp-Ed-ak6NoX_4Aeg_1891584904")]
    [Description(@"Indicates whether the trade is executed cum bonus.")]
    CumBonus = TradeTransactionConditionCode.CumBonus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex bonus.
    /// Encoded/decoded by serializers as &quot;XBNS&quot;.
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_YobMYtp-Ed-ak6NoX_4Aeg_1891584919")]
    [Description(@"Indicates whether the trade is executed ex bonus.")]
    ExBonus = TradeTransactionConditionCode.ExBonus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_YobMY9p-Ed-ak6NoX_4Aeg_1891584920")]
    [Description(@"Indicates whether the trade is executed cum coupon.")]
    CumCoupon = TradeTransactionConditionCode.CumCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_YobMZNp-Ed-ak6NoX_4Aeg_1891584937")]
    [Description(@"Indicates whether the trade is executed ex coupon.")]
    ExCoupon = TradeTransactionConditionCode.ExCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum dividend.
    /// Encoded/decoded by serializers as &quot;CDIV&quot;.
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_YobMZdp-Ed-ak6NoX_4Aeg_1891584938")]
    [Description(@"Indicates whether the trade is executed cum dividend.")]
    CumDividend = TradeTransactionConditionCode.CumDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex dividend.
    /// Encoded/decoded by serializers as &quot;XDIV&quot;.
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_YobMZtp-Ed-ak6NoX_4Aeg_1898972621")]
    [Description(@"Indicates whether the trade is executed ex dividend.")]
    ExDividend = TradeTransactionConditionCode.ExDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum rights.
    /// Encoded/decoded by serializers as &quot;CRTS&quot;.
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_YobMZ9p-Ed-ak6NoX_4Aeg_1898972622")]
    [Description(@"Indicates whether the trade is executed cum rights.")]
    CumRights = TradeTransactionConditionCode.CumRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex rights.
    /// Encoded/decoded by serializers as &quot;XRTS&quot;.
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_YobMaNp-Ed-ak6NoX_4Aeg_1898972639")]
    [Description(@"Indicates whether the trade is executed ex rights.")]
    ExRights = TradeTransactionConditionCode.ExRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum warrant.
    /// Encoded/decoded by serializers as &quot;CWAR&quot;.
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_YokWUNp-Ed-ak6NoX_4Aeg_1898972640")]
    [Description(@"Indicates whether the trade is executed cum warrant.")]
    CumWarrant = TradeTransactionConditionCode.CumWarrant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex warrant.
    /// Encoded/decoded by serializers as &quot;XWAR&quot;.
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_YokWUdp-Ed-ak6NoX_4Aeg_1898972656")]
    [Description(@"Indicates whether the trade is executed ex warrant.")]
    ExWarrant = TradeTransactionConditionCode.ExWarrant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special cum 
    /// dividend, that is, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_YokWUtp-Ed-ak6NoX_4Aeg_1898972657")]
    [Description(@"Indicates whether the trade is executed with a special cum |dividend, that is, buying after the ex date and getting the dividend.")]
    SpecialCumDividend = TradeTransactionConditionCode.SpecialCumDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special ex 
    /// dividend, that is, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as &quot;SPEX&quot;.
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_YokWU9p-Ed-ak6NoX_4Aeg_1898972666")]
    [Description(@"Indicates whether the trade is executed with a special ex |dividend, that is, selling before the ex date without the coupon.")]
    SpecialExDividend = TradeTransactionConditionCode.SpecialExDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.
    /// Encoded/decoded by serializers as &quot;DUEB&quot;.
    /// </summary>
    [EnumMember(Value = "DUEB")]
    [IsoId("_YokWVNp-Ed-ak6NoX_4Aeg_1898972674")]
    [Description(@"Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.")]
    BrokerDueBill = TradeTransactionConditionCode.BrokerDueBill, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSTI&quot;.
    /// </summary>
    [EnumMember(Value = "SSTI")]
    [IsoId("_YokWVdp-Ed-ak6NoX_4Aeg_1898972675")]
    [Description(@"Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.")]
    SoldShort = TradeTransactionConditionCode.SoldShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_YokWVtp-Ed-ak6NoX_4Aeg_1898972699")]
    [Description(@"Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.")]
    Dirty = TradeTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_YokWV9p-Ed-ak6NoX_4Aeg_1898972700")]
    [Description(@"Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.")]
    Clean = TradeTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.
    /// Encoded/decoded by serializers as &quot;BLKO&quot;.
    /// </summary>
    [EnumMember(Value = "BLKO")]
    [IsoId("_YokWWNp-Ed-ak6NoX_4Aeg_1898972716")]
    [Description(@"Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.")]
    Block = TradeTransactionConditionCode.Block, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_YokWWdp-Ed-ak6NoX_4Aeg_1898972717")]
    [Description(@"Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.")]
    GuaranteedDelivery = TradeTransactionConditionCode.GuaranteedDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether fractional parts are allowed.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_YouHUNp-Ed-ak6NoX_4Aeg_1898972734")]
    [Description(@"Indicates whether fractional parts are allowed.")]
    Fractions = TradeTransactionConditionCode.Fractions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.
    /// Encoded/decoded by serializers as &quot;CRST&quot;.
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_YouHUdp-Ed-ak6NoX_4Aeg_1898972735")]
    [Description(@"Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.")]
    CrossTrade = TradeTransactionConditionCode.CrossTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.
    /// Encoded/decoded by serializers as &quot;NCRS&quot;.
    /// </summary>
    [EnumMember(Value = "NCRS")]
    [IsoId("_YouHUtp-Ed-ak6NoX_4Aeg_1898972976")]
    [Description(@"Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.")]
    NoCrossTrade = TradeTransactionConditionCode.NoCrossTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_YouHU9p-Ed-ak6NoX_4Aeg_1898972977")]
    [Description(@"Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.")]
    DirectOrder = TradeTransactionConditionCode.DirectOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order must be executed with a specific trading party.
    /// Encoded/decoded by serializers as &quot;DIOR&quot;.
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_YouHVNp-Ed-ak6NoX_4Aeg_1898972978")]
    [Description(@"Indicates that the order must be executed with a specific trading party.")]
    DirectedOrder = TradeTransactionConditionCode.DirectedOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warehouse Trade.
    /// Encoded/decoded by serializers as &quot;WARE&quot;.
    /// </summary>
    [EnumMember(Value = "WARE")]
    [IsoId("_YouHVdp-Ed-ak6NoX_4Aeg_1898972993")]
    [Description(@"Warehouse Trade.")]
    WarehouseTrade = TradeTransactionConditionCode.WarehouseTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.
    /// Encoded/decoded by serializers as &quot;DNIN&quot;.
    /// </summary>
    [EnumMember(Value = "DNIN")]
    [IsoId("_YouHVtp-Ed-ak6NoX_4Aeg_1898973011")]
    [Description(@"A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.")]
    NotIncrease = TradeTransactionConditionCode.NotIncrease, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes &apos;ex&apos; stock dividend or rights.
    /// Encoded/decoded by serializers as &quot;DNRE&quot;.
    /// </summary>
    [EnumMember(Value = "DNRE")]
    [IsoId("_YouHV9p-Ed-ak6NoX_4Aeg_1898973028")]
    [Description(@"A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes 'ex' stock dividend or rights.")]
    NotReduce = TradeTransactionConditionCode.NotReduce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is based on a forward price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_YouHWNp-Ed-ak6NoX_4Aeg_1898973029")]
    [Description(@"Indicates that the order is based on a forward price.")]
    ForwardPriceTrade = TradeTransactionConditionCode.ForwardPriceTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is based on a historic price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_YouHWdp-Ed-ak6NoX_4Aeg_1898973046")]
    [Description(@"Indicates that the order is based on a historic price.")]
    HistoricPriceTrade = TradeTransactionConditionCode.HistoricPriceTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Result of option when set. (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRO&quot;.
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_Yo3RQNp-Ed-ak6NoX_4Aeg_1898973047")]
    [Description(@"Result of option when set. (UK specific).")]
    ResultOption = TradeTransactionConditionCode.ResultOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRP&quot;.
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_Yo3RQdp-Ed-ak6NoX_4Aeg_1898973071")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo = TradeTransactionConditionCode.ResultRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCPD&quot;.
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_Yo3RQtp-Ed-ak6NoX_4Aeg_1898973072")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation = TradeTransactionConditionCode.DeliverCountryIncorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCFD&quot;.
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_Yo3RQ9p-Ed-ak6NoX_4Aeg_1898973088")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm = TradeTransactionConditionCode.DeliveryForm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBL&quot;.
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_Yo3RRNp-Ed-ak6NoX_4Aeg_1898973089")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot = TradeTransactionConditionCode.BoardLot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBN&quot;.
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_Yo3RRdp-Ed-ak6NoX_4Aeg_1898973106")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName = TradeTransactionConditionCode.BadName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade was executed at market price.
    /// Encoded/decoded by serializers as &quot;MAPR&quot;.
    /// </summary>
    [EnumMember(Value = "MAPR")]
    [IsoId("_Yo3RRtp-Ed-ak6NoX_4Aeg_-2079226165")]
    [Description(@"Trade was executed at market price.")]
    MarketPrice = TradeTransactionConditionCode.MarketPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_Yo3RR9p-Ed-ak6NoX_4Aeg_-2003495363")]
    [Description(@"Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.")]
    NegotiatedTrade = TradeTransactionConditionCode.NegotiatedTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.
    /// Encoded/decoded by serializers as &quot;NMPR&quot;.
    /// </summary>
    [EnumMember(Value = "NMPR")]
    [IsoId("_Yo3RSNp-Ed-ak6NoX_4Aeg_1216951482")]
    [Description(@"Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.")]
    NonMarketPrice = TradeTransactionConditionCode.NonMarketPrice, // same ordinal as derivation source for type conversions
    
}
