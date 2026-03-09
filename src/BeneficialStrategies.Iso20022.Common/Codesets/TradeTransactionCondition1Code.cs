// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YnO5ltp-Ed-ak6NoX_4Aeg_-1817676119")]
[Description(@"Indicates the conditions under which the order/trade is to be/was executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
public enum TradeTransactionCondition1Code
{
    /// <summary>
    /// Indicates whether the trade is executed cum bonus.
    /// Encoded/decoded by serializers as &quot;CBNS&quot;.
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_YnO5l9p-Ed-ak6NoX_4Aeg_-704549493")]
    [Description(@"Indicates whether the trade is executed cum bonus.")]
    CumBonus = TradeTransactionConditionCode.CumBonus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex bonus.
    /// Encoded/decoded by serializers as &quot;XBNS&quot;.
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_YnYDgNp-Ed-ak6NoX_4Aeg_2141408482")]
    [Description(@"Indicates whether the trade is executed ex bonus.")]
    ExBonus = TradeTransactionConditionCode.ExBonus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_YnYDgdp-Ed-ak6NoX_4Aeg_-158749591")]
    [Description(@"Indicates whether the trade is executed cum coupon.")]
    CumCoupon = TradeTransactionConditionCode.CumCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_YnYDgtp-Ed-ak6NoX_4Aeg_-733180804")]
    [Description(@"Indicates whether the trade is executed ex coupon.")]
    ExCoupon = TradeTransactionConditionCode.ExCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum dividend.
    /// Encoded/decoded by serializers as &quot;CDIV&quot;.
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_YnYDg9p-Ed-ak6NoX_4Aeg_-131045922")]
    [Description(@"Indicates whether the trade is executed cum dividend.")]
    CumDividend = TradeTransactionConditionCode.CumDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex dividend.
    /// Encoded/decoded by serializers as &quot;XDIV&quot;.
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_YnYDhNp-Ed-ak6NoX_4Aeg_-206775274")]
    [Description(@"Indicates whether the trade is executed ex dividend.")]
    ExDividend = TradeTransactionConditionCode.ExDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum rights.
    /// Encoded/decoded by serializers as &quot;CRTS&quot;.
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_YnYDhdp-Ed-ak6NoX_4Aeg_-117190100")]
    [Description(@"Indicates whether the trade is executed cum rights.")]
    CumRights = TradeTransactionConditionCode.CumRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex rights.
    /// Encoded/decoded by serializers as &quot;XRTS&quot;.
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_YnYDhtp-Ed-ak6NoX_4Aeg_724133070")]
    [Description(@"Indicates whether the trade is executed ex rights.")]
    ExRights = TradeTransactionConditionCode.ExRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed cum warrant.
    /// Encoded/decoded by serializers as &quot;CWAR&quot;.
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_YnYDh9p-Ed-ak6NoX_4Aeg_1245924860")]
    [Description(@"Indicates whether the trade is executed cum warrant.")]
    CumWarrant = TradeTransactionConditionCode.CumWarrant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed ex warrant.
    /// Encoded/decoded by serializers as &quot;XWAR&quot;.
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_YnYDiNp-Ed-ak6NoX_4Aeg_1573774329")]
    [Description(@"Indicates whether the trade is executed ex warrant.")]
    ExWarrant = TradeTransactionConditionCode.ExWarrant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special cum 
    /// dividend, that is, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_YnYDidp-Ed-ak6NoX_4Aeg_197729967")]
    [Description(@"Indicates whether the trade is executed with a special cum |dividend, that is, buying after the ex date and getting the dividend.")]
    SpecialCumDividend = TradeTransactionConditionCode.SpecialCumDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special ex 
    /// dividend, that is, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as &quot;SPEX&quot;.
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_Ynh0gNp-Ed-ak6NoX_4Aeg_2002285748")]
    [Description(@"Indicates whether the trade is executed with a special ex |dividend, that is, selling before the ex date without the coupon.")]
    SpecialExDividend = TradeTransactionConditionCode.SpecialExDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.
    /// Encoded/decoded by serializers as &quot;DUEB&quot;.
    /// </summary>
    [EnumMember(Value = "DUEB")]
    [IsoId("_Ynh0gdp-Ed-ak6NoX_4Aeg_1202519061")]
    [Description(@"Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.")]
    BrokerDueBill = TradeTransactionConditionCode.BrokerDueBill, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSTI&quot;.
    /// </summary>
    [EnumMember(Value = "SSTI")]
    [IsoId("_Ynh0gtp-Ed-ak6NoX_4Aeg_215276027")]
    [Description(@"Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.")]
    SoldShort = TradeTransactionConditionCode.SoldShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_Ynh0g9p-Ed-ak6NoX_4Aeg_259605997")]
    [Description(@"Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.")]
    Dirty = TradeTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_Ynh0hNp-Ed-ak6NoX_4Aeg_-946185711")]
    [Description(@"Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.")]
    Clean = TradeTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.
    /// Encoded/decoded by serializers as &quot;BLKO&quot;.
    /// </summary>
    [EnumMember(Value = "BLKO")]
    [IsoId("_Ynh0hdp-Ed-ak6NoX_4Aeg_341444021")]
    [Description(@"Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.")]
    Block = TradeTransactionConditionCode.Block, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_Ynh0htp-Ed-ak6NoX_4Aeg_340874857")]
    [Description(@"Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.")]
    GuaranteedDelivery = TradeTransactionConditionCode.GuaranteedDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether fractional parts are allowed.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_Ynh0h9p-Ed-ak6NoX_4Aeg_1506931675")]
    [Description(@"Indicates whether fractional parts are allowed.")]
    Fractions = TradeTransactionConditionCode.Fractions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.
    /// Encoded/decoded by serializers as &quot;CRST&quot;.
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_Ynh0iNp-Ed-ak6NoX_4Aeg_1513399286")]
    [Description(@"Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.")]
    CrossTrade = TradeTransactionConditionCode.CrossTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.
    /// Encoded/decoded by serializers as &quot;NCRS&quot;.
    /// </summary>
    [EnumMember(Value = "NCRS")]
    [IsoId("_Ynh0idp-Ed-ak6NoX_4Aeg_-1286814700")]
    [Description(@"Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.")]
    NoCrossTrade = TradeTransactionConditionCode.NoCrossTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_Ynh0itp-Ed-ak6NoX_4Aeg_1854178870")]
    [Description(@"Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.")]
    DirectOrder = TradeTransactionConditionCode.DirectOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order must be executed with a specific trading party.
    /// Encoded/decoded by serializers as &quot;DIOR&quot;.
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_Ynq-cNp-Ed-ak6NoX_4Aeg_1879112901")]
    [Description(@"Indicates that the order must be executed with a specific trading party.")]
    DirectedOrder = TradeTransactionConditionCode.DirectedOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warehouse Trade.
    /// Encoded/decoded by serializers as &quot;WARE&quot;.
    /// </summary>
    [EnumMember(Value = "WARE")]
    [IsoId("_Ynq-cdp-Ed-ak6NoX_4Aeg_1273630984")]
    [Description(@"Warehouse Trade.")]
    WarehouseTrade = TradeTransactionConditionCode.WarehouseTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.
    /// Encoded/decoded by serializers as &quot;DNIN&quot;.
    /// </summary>
    [EnumMember(Value = "DNIN")]
    [IsoId("_Ynq-ctp-Ed-ak6NoX_4Aeg_1048705364")]
    [Description(@"A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.")]
    NotIncrease = TradeTransactionConditionCode.NotIncrease, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes &apos;ex&apos; stock dividend or rights.
    /// Encoded/decoded by serializers as &quot;DNRE&quot;.
    /// </summary>
    [EnumMember(Value = "DNRE")]
    [IsoId("_Ynq-c9p-Ed-ak6NoX_4Aeg_1075487335")]
    [Description(@"A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes 'ex' stock dividend or rights.")]
    NotReduce = TradeTransactionConditionCode.NotReduce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is based on a forward price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_Yn0vcNp-Ed-ak6NoX_4Aeg_-1385270994")]
    [Description(@"Indicates that the order is based on a forward price.")]
    ForwardPriceTrade = TradeTransactionConditionCode.ForwardPriceTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order is based on a historic price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_Yn0vcdp-Ed-ak6NoX_4Aeg_-1198720742")]
    [Description(@"Indicates that the order is based on a historic price.")]
    HistoricPriceTrade = TradeTransactionConditionCode.HistoricPriceTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Result of option when set. (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRO&quot;.
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_Yn0vctp-Ed-ak6NoX_4Aeg_-954962851")]
    [Description(@"Result of option when set. (UK specific).")]
    ResultOption = TradeTransactionConditionCode.ResultOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRP&quot;.
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_Yn0vc9p-Ed-ak6NoX_4Aeg_-695452037")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo = TradeTransactionConditionCode.ResultRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCPD&quot;.
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_Yn0vdNp-Ed-ak6NoX_4Aeg_-666825366")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation = TradeTransactionConditionCode.DeliverCountryIncorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCFD&quot;.
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_Yn0vddp-Ed-ak6NoX_4Aeg_-608641063")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm = TradeTransactionConditionCode.DeliveryForm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBL&quot;.
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_Yn0vdtp-Ed-ak6NoX_4Aeg_-580937096")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot = TradeTransactionConditionCode.BoardLot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBN&quot;.
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_Yn0vd9p-Ed-ak6NoX_4Aeg_-324196110")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName = TradeTransactionConditionCode.BadName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed done at best execution.
    /// Encoded/decoded by serializers as &quot;BTEX&quot;.
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_Yn0veNp-Ed-ak6NoX_4Aeg_-1830642528")]
    [Description(@"Trade to be executed done at best execution.")]
    BestExecution = TradeTransactionConditionCode.BestExecution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed following the exercise of a call option on the security.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_Yn0vedp-Ed-ak6NoX_4Aeg_-1500947484")]
    [Description(@"Trade to be executed following the exercise of a call option on the security.")]
    Call = TradeTransactionConditionCode.Call, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;CLBR&quot;.
    /// </summary>
    [EnumMember(Value = "CLBR")]
    [IsoId("_Yn-gcNp-Ed-ak6NoX_4Aeg_-1445535231")]
    [Description(@"Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service).")]
    ClosureBeforeRollOver = TradeTransactionConditionCode.ClosureBeforeRollOver, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed for month-end settlement (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_Yn-gcdp-Ed-ak6NoX_4Aeg_-1282071931")]
    [Description(@"Trade to be executed for month-end settlement (Deferred Settlement Service).")]
    Monthly = TradeTransactionConditionCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;NBFR&quot;.
    /// </summary>
    [EnumMember(Value = "NBFR")]
    [IsoId("_Yn-gctp-Ed-ak6NoX_4Aeg_-1042879916")]
    [Description(@"Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service).")]
    NewTradeFollowingRollover = TradeTransactionConditionCode.NewTradeFollowingRollover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed on the next month following the roll-over of positions.
    /// Encoded/decoded by serializers as &quot;TRFR&quot;.
    /// </summary>
    [EnumMember(Value = "TRFR")]
    [IsoId("_Yn-gc9p-Ed-ak6NoX_4Aeg_-1025330865")]
    [Description(@"Trade to be executed on the next month following the roll-over of positions.")]
    TradeFollowingRollover = TradeTransactionConditionCode.TradeFollowingRollover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade to be executed following the exercise of a put option on the security.
    /// Encoded/decoded by serializers as &quot;PUTT&quot;.
    /// </summary>
    [EnumMember(Value = "PUTT")]
    [IsoId("_Yn-gdNp-Ed-ak6NoX_4Aeg_-946834322")]
    [Description(@"Trade to be executed following the exercise of a put option on the security.")]
    Putt = TradeTransactionConditionCode.Putt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special cum coupon.
    /// Encoded/decoded by serializers as &quot;SPCC&quot;.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_Yn-gddp-Ed-ak6NoX_4Aeg_-929287064")]
    [Description(@"Indicates whether the trade is executed with a special cum coupon.")]
    SpecialCumCoupon = TradeTransactionConditionCode.SpecialCumCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special ex coupon.
    /// Encoded/decoded by serializers as &quot;SECN&quot;.
    /// </summary>
    [EnumMember(Value = "SECN")]
    [IsoId("_Yn-gdtp-Ed-ak6NoX_4Aeg_-169229268")]
    [Description(@"Indicates whether the trade is executed with a special ex coupon.")]
    SpecialExCoupon = TradeTransactionConditionCode.SpecialExCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed special ex bonus.
    /// Encoded/decoded by serializers as &quot;SEBN&quot;.
    /// </summary>
    [EnumMember(Value = "SEBN")]
    [IsoId("_Yn-gd9p-Ed-ak6NoX_4Aeg_-169229130")]
    [Description(@"Indicates whether the trade is executed special ex bonus.")]
    SpecialExBonus = TradeTransactionConditionCode.SpecialExBonus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed special cum bonus.
    /// Encoded/decoded by serializers as &quot;SCBN&quot;.
    /// </summary>
    [EnumMember(Value = "SCBN")]
    [IsoId("_Yn-geNp-Ed-ak6NoX_4Aeg_-169228793")]
    [Description(@"Indicates whether the trade is executed special cum bonus.")]
    SpecialCumBonus = TradeTransactionConditionCode.SpecialCumBonus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed special cum rights.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_Yn-gedp-Ed-ak6NoX_4Aeg_-169228663")]
    [Description(@"Indicates whether the trade is executed special cum rights.")]
    SpecialCumRights = TradeTransactionConditionCode.SpecialCumRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed special ex rights.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("_YoHqYNp-Ed-ak6NoX_4Aeg_-169228373")]
    [Description(@"Indicates whether the trade is executed special ex rights.")]
    SpecialExRights = TradeTransactionConditionCode.SpecialExRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed special cum capital repayments.
    /// Encoded/decoded by serializers as &quot;SCCR&quot;.
    /// </summary>
    [EnumMember(Value = "SCCR")]
    [IsoId("_YoHqYdp-Ed-ak6NoX_4Aeg_-169228320")]
    [Description(@"Indicates whether the trade is executed special cum capital repayments.")]
    SpecialCumCapitalRepayments = TradeTransactionConditionCode.SpecialCumCapitalRepayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed special ex capital repayments.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_YoHqYtp-Ed-ak6NoX_4Aeg_-169228278")]
    [Description(@"Indicates whether the trade is executed special ex capital repayments.")]
    SpecialExCapitalRepayments = TradeTransactionConditionCode.SpecialExCapitalRepayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a cash settlement.
    /// Encoded/decoded by serializers as &quot;CAST&quot;.
    /// </summary>
    [EnumMember(Value = "CAST")]
    [IsoId("_YoHqY9p-Ed-ak6NoX_4Aeg_-169228218")]
    [Description(@"Indicates whether the trade is executed with a cash settlement.")]
    CashSettlement = TradeTransactionConditionCode.CashSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the trade is executed with a special price.
    /// Encoded/decoded by serializers as &quot;SPPR&quot;.
    /// </summary>
    [EnumMember(Value = "SPPR")]
    [IsoId("_YoHqZNp-Ed-ak6NoX_4Aeg_-169228165")]
    [Description(@"Indicates whether the trade is executed with a special price.")]
    SpecialPrice = TradeTransactionConditionCode.SpecialPrice, // same ordinal as derivation source for type conversions
    
}
