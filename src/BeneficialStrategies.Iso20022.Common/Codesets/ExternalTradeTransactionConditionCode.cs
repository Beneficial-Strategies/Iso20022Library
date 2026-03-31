// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VMYA4OCaEeuz9f5u6OS5Lg")]
[Description(
    @"Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalTradeTransactionCondition1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalTradeTransactionConditionCode>))]
#endif
public enum ExternalTradeTransactionConditionCode
{
    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBL&quot;.
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_uJn5HPRYEeuLhpyIdtJzwg")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot,

    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBN&quot;.
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_uJxqEPRYEeuLhpyIdtJzwg")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName,

    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCFD&quot;.
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_uJxqE_RYEeuLhpyIdtJzwg")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm,

    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCPD&quot;.
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_uJxqFvRYEeuLhpyIdtJzwg")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation,

    /// <summary>
    /// Result of option when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRO&quot;.
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_uJxqGfRYEeuLhpyIdtJzwg")]
    [Description(@"Result of option when set (UK specific).")]
    ResultOption,

    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRP&quot;.
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_uJ60APRYEeuLhpyIdtJzwg")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo,

    /// <summary>
    /// The trade is a block trade or not, ie, whether allocation instruction will follow or not.
    /// Encoded/decoded by serializers as &quot;BLKO&quot;.
    /// </summary>
    [EnumMember(Value = "BLKO")]
    [IsoId("_uJ60A_RYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is a block trade or not, ie, whether allocation instruction will follow or not."
    )]
    Block,

    /// <summary>
    /// Trade to be executed done at best execution.
    /// Encoded/decoded by serializers as &quot;BTEX&quot;.
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_uJ60BvRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed done at best execution.")]
    BestExecution,

    /// <summary>
    /// Bought minus indicator.
    /// Encoded/decoded by serializers as &quot;BTMI&quot;.
    /// </summary>
    [EnumMember(Value = "BTMI")]
    [IsoId("_uJ60CfRYEeuLhpyIdtJzwg")]
    [Description(@"Bought minus indicator.")]
    BoughtMinus,

    /// <summary>
    /// Trade to be executed following the exercise of a call option on the security.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_uJ60DPRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed following the exercise of a call option on the security.")]
    Call,

    /// <summary>
    /// The trade is executed cum bonus.
    /// Encoded/decoded by serializers as &quot;CBNS&quot;.
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_uKElAPRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum bonus.")]
    CumBonus,

    /// <summary>
    /// The trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_uKElA_RYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum coupon.")]
    CumCoupon,

    /// <summary>
    /// The trade is executed cum dividend.
    /// Encoded/decoded by serializers as &quot;CDIV&quot;.
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_uKElBvRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum dividend.")]
    CumDividend,

    /// <summary>
    /// Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;CLBR&quot;.
    /// </summary>
    [EnumMember(Value = "CLBR")]
    [IsoId("_uKElCfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service). "
    )]
    ClosureBeforeRollOver,

    /// <summary>
    /// The trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_uKNu8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed clean, ie government tax must not be paid on the accrued interest on the bond."
    )]
    Clean,

    /// <summary>
    /// Cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange
    /// Encoded/decoded by serializers as &quot;CRST&quot;.
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_uKNu8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange"
    )]
    CrossTrade,

    /// <summary>
    /// The trade is executed cum rights.
    /// Encoded/decoded by serializers as &quot;CRTS&quot;.
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_uKNu9vRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum rights.")]
    CumRights,

    /// <summary>
    /// The trade is executed cum warrant.
    /// Encoded/decoded by serializers as &quot;CWAR&quot;.
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_uKNu-fRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum warrant.")]
    CumWarrant,

    /// <summary>
    /// A customer order where the customer gives specific instructions to the broker concerning the orders routing destination.
    /// Encoded/decoded by serializers as &quot;DIOR&quot;.
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_uKNu_PRYEeuLhpyIdtJzwg")]
    [Description(
        @"A customer order where the customer gives specific instructions to the broker concerning the orders routing destination."
    )]
    DirectedOrder,

    /// <summary>
    /// The trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_uKXf8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed dirty, ie government tax must be paid on the accrued interest on the bond."
    )]
    Dirty,

    /// <summary>
    /// The order is to be executed by a trading party other than the trading party to which the order is sent. In this case, the instructing party has traded with another broker which will subsequently send an advice of execution to the executing party who received the order and which is acting as clearing broker.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_uKXf8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"The order is to be executed by a trading party other than the trading party to which the order is sent. In this case, the instructing party has traded with another broker which will subsequently send an advice of execution to the executing party who received the order and which is acting as clearing broker."
    )]
    DirectOrder,

    /// <summary>
    /// The order is based on a forward price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_uKXf9vRYEeuLhpyIdtJzwg")]
    [Description(@"The order is based on a forward price.")]
    ForwardPriceTrade,

    /// <summary>
    /// Fractional parts are allowed.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_uKXf-fRYEeuLhpyIdtJzwg")]
    [Description(@"Fractional parts are allowed.")]
    Fractions,

    /// <summary>
    /// The delivery of the financial instrument on settlement date is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_uKXf_PRYEeuLhpyIdtJzwg")]
    [Description(@"The delivery of the financial instrument on settlement date is guaranteed.")]
    GuaranteedDelivery,

    /// <summary>
    /// The order is based on a historic price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_uKhQ8PRYEeuLhpyIdtJzwg")]
    [Description(@"The order is based on a historic price.")]
    HistoricPriceTrade,

    /// <summary>
    /// Trade was executed at market price.
    /// Encoded/decoded by serializers as &quot;MAPR&quot;.
    /// </summary>
    [EnumMember(Value = "MAPR")]
    [IsoId("_uKhQ8_RYEeuLhpyIdtJzwg")]
    [Description(@"Trade was executed at market price.")]
    MarketPrice,

    /// <summary>
    /// Trade to be executed for month-end settlement (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_uKhQ9vRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed for month-end settlement (Deferred Settlement Service). ")]
    Monthly,

    /// <summary>
    /// Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;NBFR&quot;.
    /// </summary>
    [EnumMember(Value = "NBFR")]
    [IsoId("_uKhQ-fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service). "
    )]
    NewTradeFollowingRollover,

    /// <summary>
    /// Cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.
    /// Encoded/decoded by serializers as &quot;NCRS&quot;.
    /// </summary>
    [EnumMember(Value = "NCRS")]
    [IsoId("_uKrB8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed."
    )]
    NoCrossTrade,

    /// <summary>
    /// Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_uKrB8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade for which the price is not the one quoted but an improved one, that is, the negotiated price."
    )]
    NegotiatedTrade,

    /// <summary>
    /// Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.
    /// Encoded/decoded by serializers as &quot;NMPR&quot;.
    /// </summary>
    [EnumMember(Value = "NMPR")]
    [IsoId("_uKrB9vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade was executed outside of normal market conditions, for example, in the case of an iceberg order."
    )]
    NonMarketPrice,

    /// <summary>
    /// Allows trader to explicitly request anonymity or disclosure in pre-trade market data feeds. Anonymity is relevant in markets where counterparties are regularly disclosed in order depth feeds. Disclosure is relevant when counterparties are not normally visible.
    /// Encoded/decoded by serializers as &quot;PETA&quot;.
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_uKrB-fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Allows trader to explicitly request anonymity or disclosure in pre-trade market data feeds. Anonymity is relevant in markets where counterparties are regularly disclosed in order depth feeds. Disclosure is relevant when counterparties are not normally visible."
    )]
    PreTradeAnonimity,

    /// <summary>
    /// Trade to be executed following the exercise of a put option on the security.
    /// Encoded/decoded by serializers as &quot;PUTT&quot;.
    /// </summary>
    [EnumMember(Value = "PUTT")]
    [IsoId("_uKrB_PRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed following the exercise of a put option on the security. ")]
    Putt,

    /// <summary>
    /// Trade is exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SETI&quot;.
    /// </summary>
    [EnumMember(Value = "SETI")]
    [IsoId("_uK0L4PRYEeuLhpyIdtJzwg")]
    [Description(@"Trade is exempt from short-sale rules.")]
    SoldExempt,

    /// <summary>
    /// The trade is executed  with a special cum dividend, ie, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_uK0L4_RYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed  with a special cum dividend, ie, buying after the ex date and getting the dividend."
    )]
    SpecialCumDividend,

    /// <summary>
    /// The trade is executed  with a special ex dividend, ie, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as &quot;SPEX&quot;.
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_uK0L5vRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed  with a special ex dividend, ie, selling before the ex date without the coupon. "
    )]
    SpecialExDividend,

    /// <summary>
    /// Sold plus indication.
    /// Encoded/decoded by serializers as &quot;SPSI&quot;.
    /// </summary>
    [EnumMember(Value = "SPSI")]
    [IsoId("_uK0L6fRYEeuLhpyIdtJzwg")]
    [Description(@"Sold plus indication.")]
    SoldPlus,

    /// <summary>
    /// The trade is sold short. When the seller does not have the financial instrument, the delivery is effected by borrowing the financial instrument by or for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSTI&quot;.
    /// </summary>
    [EnumMember(Value = "SSTI")]
    [IsoId("_uK0L7PRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is sold short. When the seller does not have the financial instrument, the delivery is effected by borrowing the financial instrument by or for the account of the seller."
    )]
    SoldShort,

    /// <summary>
    /// Trade executed this month following the rollover of positions.
    /// Encoded/decoded by serializers as &quot;TEFR&quot;.
    /// </summary>
    [EnumMember(Value = "TEFR")]
    [IsoId("_uK984PRYEeuLhpyIdtJzwg")]
    [Description(@"Trade executed this month following the rollover of positions. ")]
    TradeExecutedFollowingRollover,

    /// <summary>
    /// Trade to be executed on the next month following the roll-over of positions.
    /// Encoded/decoded by serializers as &quot;TRFR&quot;.
    /// </summary>
    [EnumMember(Value = "TRFR")]
    [IsoId("_uK984_RYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed on the next month following the roll-over of positions. ")]
    TradeFollowingRollover,

    /// <summary>
    /// Transaction is before the issue date after announcement of the auction.
    /// Encoded/decoded by serializers as &quot;WIBC&quot;.
    /// </summary>
    [EnumMember(Value = "WIBC")]
    [IsoId("_uK985vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is before the issue date after announcement of the auction.")]
    BeforeAuction,

    /// <summary>
    /// Transaction is after the issue date after announcement of the auction.
    /// Encoded/decoded by serializers as &quot;WICD&quot;.
    /// </summary>
    [EnumMember(Value = "WICD")]
    [IsoId("_uK986fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is after the issue date after announcement of the auction.")]
    AfterAuction,

    /// <summary>
    /// The trade is executed ex bonus.
    /// Encoded/decoded by serializers as &quot;XBNS&quot;.
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_uK987PRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex bonus.")]
    ExBonus,

    /// <summary>
    /// The trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_uLHG0PRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex coupon.")]
    ExCoupon,

    /// <summary>
    /// The trade is executed ex dividend.
    /// Encoded/decoded by serializers as &quot;XDIV&quot;.
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_uLHG0_RYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex dividend.")]
    ExDividend,

    /// <summary>
    /// The trade is executed ex rights.
    /// Encoded/decoded by serializers as &quot;XRTS&quot;.
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_uLHG1vRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex rights.")]
    ExRights,

    /// <summary>
    /// The trade is executed ex warrant.
    /// Encoded/decoded by serializers as &quot;XWAR&quot;.
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_uLHG2fRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex warrant.")]
    ExWarrant,
}
