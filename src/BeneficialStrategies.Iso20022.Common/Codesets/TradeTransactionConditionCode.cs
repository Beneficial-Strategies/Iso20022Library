// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YpT9Mtp-Ed-ak6NoX_4Aeg_-1512742367")]
[Description(@"Indicates the conditions under which the order/trade is to be/was executed.")]
[Derivations(
    typeof(TradeTransactionCondition5Code),
    typeof(TradeTransactionCondition2Code),
    typeof(TradeTransactionCondition3Code),
    typeof(TradeTransactionCondition1Code),
    typeof(TradeTransactionCondition4Code)
)]
public enum TradeTransactionConditionCode
{
    /// <summary>
    /// Indicates whether the trade is executed cum bonus.
    /// Encoded/decoded by serializers as &quot;CBNS&quot;.
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_YpT9M9p-Ed-ak6NoX_4Aeg_-1512742366")]
    [Description(@"Indicates whether the trade is executed cum bonus.")]
    CumBonus,

    /// <summary>
    /// Indicates whether the trade is executed ex bonus.
    /// Encoded/decoded by serializers as &quot;XBNS&quot;.
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_YpT9NNp-Ed-ak6NoX_4Aeg_-1512742365")]
    [Description(@"Indicates whether the trade is executed ex bonus.")]
    ExBonus,

    /// <summary>
    /// Indicates whether the trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_YpT9Ndp-Ed-ak6NoX_4Aeg_-1512742364")]
    [Description(@"Indicates whether the trade is executed cum coupon.")]
    CumCoupon,

    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_YpT9Ntp-Ed-ak6NoX_4Aeg_-1512742336")]
    [Description(@"Indicates whether the trade is executed ex coupon.")]
    ExCoupon,

    /// <summary>
    /// Indicates whether the trade is executed cum dividend.
    /// Encoded/decoded by serializers as &quot;CDIV&quot;.
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_YpT9N9p-Ed-ak6NoX_4Aeg_-1512742335")]
    [Description(@"Indicates whether the trade is executed cum dividend.")]
    CumDividend,

    /// <summary>
    /// Indicates whether the trade is executed ex dividend.
    /// Encoded/decoded by serializers as &quot;XDIV&quot;.
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_YpT9ONp-Ed-ak6NoX_4Aeg_-1512742334")]
    [Description(@"Indicates whether the trade is executed ex dividend.")]
    ExDividend,

    /// <summary>
    /// Indicates whether the trade is executed cum rights.
    /// Encoded/decoded by serializers as &quot;CRTS&quot;.
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_YpT9Odp-Ed-ak6NoX_4Aeg_-1512742306")]
    [Description(@"Indicates whether the trade is executed cum rights.")]
    CumRights,

    /// <summary>
    /// Indicates whether the trade is executed ex rights.
    /// Encoded/decoded by serializers as &quot;XRTS&quot;.
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_YpduMNp-Ed-ak6NoX_4Aeg_-1512742305")]
    [Description(@"Indicates whether the trade is executed ex rights.")]
    ExRights,

    /// <summary>
    /// Indicates whether the trade is executed cum warrant.
    /// Encoded/decoded by serializers as &quot;CWAR&quot;.
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_YpduMdp-Ed-ak6NoX_4Aeg_-1512742304")]
    [Description(@"Indicates whether the trade is executed cum warrant.")]
    CumWarrant,

    /// <summary>
    /// Indicates whether the trade is executed ex warrant.
    /// Encoded/decoded by serializers as &quot;XWAR&quot;.
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_YpduMtp-Ed-ak6NoX_4Aeg_-1512742303")]
    [Description(@"Indicates whether the trade is executed ex warrant.")]
    ExWarrant,

    /// <summary>
    /// Indicates whether the trade is executed with a special cum
    /// dividend, that is, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_YpduM9p-Ed-ak6NoX_4Aeg_-1512742058")]
    [Description(
        @"Indicates whether the trade is executed with a special cum |dividend, that is, buying after the ex date and getting the dividend."
    )]
    SpecialCumDividend,

    /// <summary>
    /// Indicates whether the trade is executed with a special ex
    /// dividend, that is, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as &quot;SPEX&quot;.
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_YpduNNp-Ed-ak6NoX_4Aeg_-1512742057")]
    [Description(
        @"Indicates whether the trade is executed with a special ex |dividend, that is, selling before the ex date without the coupon."
    )]
    SpecialExDividend,

    /// <summary>
    /// Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.
    /// Encoded/decoded by serializers as &quot;DUEB&quot;.
    /// </summary>
    [EnumMember(Value = "DUEB")]
    [IsoId("_YpduNdp-Ed-ak6NoX_4Aeg_-1512742056")]
    [Description(
        @"Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument."
    )]
    BrokerDueBill,

    /// <summary>
    /// Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSTI&quot;.
    /// </summary>
    [EnumMember(Value = "SSTI")]
    [IsoId("_YpduNtp-Ed-ak6NoX_4Aeg_-1512742027")]
    [Description(
        @"Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller."
    )]
    SoldShort,

    /// <summary>
    /// Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_YpduN9p-Ed-ak6NoX_4Aeg_-1512742026")]
    [Description(
        @"Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond."
    )]
    Dirty,

    /// <summary>
    /// Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_YpduONp-Ed-ak6NoX_4Aeg_-1512742025")]
    [Description(
        @"Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond."
    )]
    Clean,

    /// <summary>
    /// Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.
    /// Encoded/decoded by serializers as &quot;BLKO&quot;.
    /// </summary>
    [EnumMember(Value = "BLKO")]
    [IsoId("_YpduOdp-Ed-ak6NoX_4Aeg_-1512742024")]
    [Description(
        @"Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not."
    )]
    Block,

    /// <summary>
    /// Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_YpnfMNp-Ed-ak6NoX_4Aeg_-1512741997")]
    [Description(
        @"Indicates whether the delivery of the financial instrument on settlement date |is guaranteed."
    )]
    GuaranteedDelivery,

    /// <summary>
    /// Indicates whether fractional parts are allowed.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_YpnfMdp-Ed-ak6NoX_4Aeg_-1512741996")]
    [Description(@"Indicates whether fractional parts are allowed.")]
    Fractions,

    /// <summary>
    /// Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.
    /// Encoded/decoded by serializers as &quot;CRST&quot;.
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_YpnfMtp-Ed-ak6NoX_4Aeg_-1512741995")]
    [Description(
        @"Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange."
    )]
    CrossTrade,

    /// <summary>
    /// Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.
    /// Encoded/decoded by serializers as &quot;NCRS&quot;.
    /// </summary>
    [EnumMember(Value = "NCRS")]
    [IsoId("_YpnfM9p-Ed-ak6NoX_4Aeg_-1512741966")]
    [Description(
        @"Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed."
    )]
    NoCrossTrade,

    /// <summary>
    /// Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_YpnfNNp-Ed-ak6NoX_4Aeg_-1512741965")]
    [Description(
        @"Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker."
    )]
    DirectOrder,

    /// <summary>
    /// Indicates that the order must be executed with a specific trading party.
    /// Encoded/decoded by serializers as &quot;DIOR&quot;.
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_YpnfNdp-Ed-ak6NoX_4Aeg_-1512741964")]
    [Description(@"Indicates that the order must be executed with a specific trading party.")]
    DirectedOrder,

    /// <summary>
    /// Warehouse Trade.
    /// Encoded/decoded by serializers as &quot;WARE&quot;.
    /// </summary>
    [EnumMember(Value = "WARE")]
    [IsoId("_YpnfNtp-Ed-ak6NoX_4Aeg_-1512741963")]
    [Description(@"Warehouse Trade.")]
    WarehouseTrade,

    /// <summary>
    /// A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.
    /// Encoded/decoded by serializers as &quot;DNIN&quot;.
    /// </summary>
    [EnumMember(Value = "DNIN")]
    [IsoId("_YpnfN9p-Ed-ak6NoX_4Aeg_-1512741935")]
    [Description(
        @"A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution."
    )]
    NotIncrease,

    /// <summary>
    /// A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes &apos;ex&apos; stock dividend or rights.
    /// Encoded/decoded by serializers as &quot;DNRE&quot;.
    /// </summary>
    [EnumMember(Value = "DNRE")]
    [IsoId("_YpnfONp-Ed-ak6NoX_4Aeg_-1512741934")]
    [Description(
        @"A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes 'ex' stock dividend or rights."
    )]
    NotReduce,

    /// <summary>
    /// Indicates that the order is based on a forward price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_YpnfOdp-Ed-ak6NoX_4Aeg_-1512741933")]
    [Description(@"Indicates that the order is based on a forward price.")]
    ForwardPriceTrade,

    /// <summary>
    /// Indicates that the order is based on a historic price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_YpwpINp-Ed-ak6NoX_4Aeg_-1512741912")]
    [Description(@"Indicates that the order is based on a historic price.")]
    HistoricPriceTrade,

    /// <summary>
    /// Result of option when set. (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRO&quot;.
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_YpwpIdp-Ed-ak6NoX_4Aeg_-1512741904")]
    [Description(@"Result of option when set. (UK specific).")]
    ResultOption,

    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRP&quot;.
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_YpwpItp-Ed-ak6NoX_4Aeg_-1512741903")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo,

    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCPD&quot;.
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_YpwpI9p-Ed-ak6NoX_4Aeg_-1512741902")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation,

    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCFD&quot;.
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_YpwpJNp-Ed-ak6NoX_4Aeg_-1512741633")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm,

    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBL&quot;.
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_YpwpJdp-Ed-ak6NoX_4Aeg_-1512741625")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot,

    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBN&quot;.
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_YpwpJtp-Ed-ak6NoX_4Aeg_-1512741624")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName,

    /// <summary>
    /// Automated.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_YpwpJ9p-Ed-ak6NoX_4Aeg_-1111934489")]
    [Description(@"Automated.")]
    Automated,

    /// <summary>
    /// Trade to be executed done at best execution.
    /// Encoded/decoded by serializers as &quot;BTEX&quot;.
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_YpwpKNp-Ed-ak6NoX_4Aeg_59624950")]
    [Description(@"Trade to be executed done at best execution.")]
    BestExecution,

    /// <summary>
    /// Trade to be executed following the exercise of a call option on the security.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_YpwpKdp-Ed-ak6NoX_4Aeg_171370929")]
    [Description(@"Trade to be executed following the exercise of a call option on the security.")]
    Call,

    /// <summary>
    /// Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;CLBR&quot;.
    /// </summary>
    [EnumMember(Value = "CLBR")]
    [IsoId("_YpwpKtp-Ed-ak6NoX_4Aeg_227706748")]
    [Description(
        @"Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service)."
    )]
    ClosureBeforeRollOver,

    /// <summary>
    /// Trade to be executed for month-end settlement (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_Yp6aINp-Ed-ak6NoX_4Aeg_530622968")]
    [Description(@"Trade to be executed for month-end settlement (Deferred Settlement Service).")]
    Monthly,

    /// <summary>
    /// Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;NBFR&quot;.
    /// </summary>
    [EnumMember(Value = "NBFR")]
    [IsoId("_Yp6aIdp-Ed-ak6NoX_4Aeg_949901022")]
    [Description(
        @"Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service)."
    )]
    NewTradeFollowingRollover,

    /// <summary>
    /// Trade to be executed following the exercise of a put option on the security.
    /// Encoded/decoded by serializers as &quot;PUTT&quot;.
    /// </summary>
    [EnumMember(Value = "PUTT")]
    [IsoId("_Yp6aItp-Ed-ak6NoX_4Aeg_1063494538")]
    [Description(@"Trade to be executed following the exercise of a put option on the security.")]
    Putt,

    /// <summary>
    /// Trade to be executed on the next month following the roll-over of positions.
    /// Encoded/decoded by serializers as &quot;TRFR&quot;.
    /// </summary>
    [EnumMember(Value = "TRFR")]
    [IsoId("_Yp6aI9p-Ed-ak6NoX_4Aeg_1475383600")]
    [Description(@"Trade to be executed on the next month following the roll-over of positions.")]
    TradeFollowingRollover,

    /// <summary>
    /// Indicates whether the trade is executed with a special cum coupon.
    /// Encoded/decoded by serializers as &quot;SPCC&quot;.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_Yp6aJNp-Ed-ak6NoX_4Aeg_-1515572062")]
    [Description(@"Indicates whether the trade is executed with a special cum coupon.")]
    SpecialCumCoupon,

    /// <summary>
    /// Indicates whether the trade is executed with a special ex coupon.
    /// Encoded/decoded by serializers as &quot;SECN&quot;.
    /// </summary>
    [EnumMember(Value = "SECN")]
    [IsoId("_Yp6aJdp-Ed-ak6NoX_4Aeg_-1045498067")]
    [Description(@"Indicates whether the trade is executed with a special ex coupon.")]
    SpecialExCoupon,

    /// <summary>
    /// Indicates whether the trade is executed special ex bonus.
    /// Encoded/decoded by serializers as &quot;SEBN&quot;.
    /// </summary>
    [EnumMember(Value = "SEBN")]
    [IsoId("_Yp6aJtp-Ed-ak6NoX_4Aeg_139378350")]
    [Description(@"Indicates whether the trade is executed special ex bonus.")]
    SpecialExBonus,

    /// <summary>
    /// Indicates whether the trade is executed special cum bonus.
    /// Encoded/decoded by serializers as &quot;SCBN&quot;.
    /// </summary>
    [EnumMember(Value = "SCBN")]
    [IsoId("_Yp6aJ9p-Ed-ak6NoX_4Aeg_258512774")]
    [Description(@"Indicates whether the trade is executed special cum bonus.")]
    SpecialCumBonus,

    /// <summary>
    /// Indicates whether the trade is executed special cum rights.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_Yp6aKNp-Ed-ak6NoX_4Aeg_-1905890723")]
    [Description(@"Indicates whether the trade is executed special cum rights.")]
    SpecialCumRights,

    /// <summary>
    /// Indicates whether the trade is executed special ex rights.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("_Yp6aKdp-Ed-ak6NoX_4Aeg_-1763669001")]
    [Description(@"Indicates whether the trade is executed special ex rights.")]
    SpecialExRights,

    /// <summary>
    /// Indicates whether the trade is executed special cum capital repayments.
    /// Encoded/decoded by serializers as &quot;SCCR&quot;.
    /// </summary>
    [EnumMember(Value = "SCCR")]
    [IsoId("_YqDkENp-Ed-ak6NoX_4Aeg_-1373020083")]
    [Description(@"Indicates whether the trade is executed special cum capital repayments.")]
    SpecialCumCapitalRepayments,

    /// <summary>
    /// Indicates whether the trade is executed special ex capital repayments.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_YqDkEdp-Ed-ak6NoX_4Aeg_-1000839689")]
    [Description(@"Indicates whether the trade is executed special ex capital repayments.")]
    SpecialExCapitalRepayments,

    /// <summary>
    /// Indicates whether the trade is executed with a cash settlement.
    /// Encoded/decoded by serializers as &quot;CAST&quot;.
    /// </summary>
    [EnumMember(Value = "CAST")]
    [IsoId("_YqDkEtp-Ed-ak6NoX_4Aeg_-883553036")]
    [Description(@"Indicates whether the trade is executed with a cash settlement.")]
    CashSettlement,

    /// <summary>
    /// Indicates whether the trade is executed with a special price.
    /// Encoded/decoded by serializers as &quot;SPPR&quot;.
    /// </summary>
    [EnumMember(Value = "SPPR")]
    [IsoId("_YqDkE9p-Ed-ak6NoX_4Aeg_-416252847")]
    [Description(@"Indicates whether the trade is executed with a special price.")]
    SpecialPrice,

    /// <summary>
    /// Trade was executed at market price.
    /// Encoded/decoded by serializers as &quot;MAPR&quot;.
    /// </summary>
    [EnumMember(Value = "MAPR")]
    [IsoId("_YqDkFNp-Ed-ak6NoX_4Aeg_-5753414")]
    [Description(@"Trade was executed at market price.")]
    MarketPrice,

    /// <summary>
    /// Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_YqDkFdp-Ed-ak6NoX_4Aeg_-5752983")]
    [Description(
        @"Trade for which the price is not the one quoted but an improved one, that is, the negotiated price."
    )]
    NegotiatedTrade,

    /// <summary>
    /// Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.
    /// Encoded/decoded by serializers as &quot;NMPR&quot;.
    /// </summary>
    [EnumMember(Value = "NMPR")]
    [IsoId("_YqDkFtp-Ed-ak6NoX_4Aeg_-5752806")]
    [Description(
        @"Trade was executed outside of normal market conditions, for example, in the case of an iceberg order."
    )]
    NonMarketPrice,
}
