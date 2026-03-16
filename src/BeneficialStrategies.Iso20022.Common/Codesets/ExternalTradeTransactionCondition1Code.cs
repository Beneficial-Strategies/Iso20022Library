// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2iXdNojEeC60axPepSq7g_398197023")]
[Description(
    @"Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalTradeTransactionConditionCode))]
public enum ExternalTradeTransactionCondition1Code
{
    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBL&quot;.
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_uJn5HvRYEeuLhpyIdtJzwg")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot = ExternalTradeTransactionConditionCode.BoardLot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBN&quot;.
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_uJxqEvRYEeuLhpyIdtJzwg")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName = ExternalTradeTransactionConditionCode.BadName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCFD&quot;.
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_uJxqFfRYEeuLhpyIdtJzwg")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm = ExternalTradeTransactionConditionCode.DeliveryForm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCPD&quot;.
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_uJxqGPRYEeuLhpyIdtJzwg")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation = ExternalTradeTransactionConditionCode.DeliverCountryIncorporation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Result of option when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRO&quot;.
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_uJxqG_RYEeuLhpyIdtJzwg")]
    [Description(@"Result of option when set (UK specific).")]
    ResultOption = ExternalTradeTransactionConditionCode.ResultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRP&quot;.
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_uJ60AvRYEeuLhpyIdtJzwg")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo = ExternalTradeTransactionConditionCode.ResultRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is a block trade or not, ie, whether allocation instruction will follow or not.
    /// Encoded/decoded by serializers as &quot;BLKO&quot;.
    /// </summary>
    [EnumMember(Value = "BLKO")]
    [IsoId("_uJ60BfRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is a block trade or not, ie, whether allocation instruction will follow or not."
    )]
    Block = ExternalTradeTransactionConditionCode.Block, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed done at best execution.
    /// Encoded/decoded by serializers as &quot;BTEX&quot;.
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_uJ60CPRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed done at best execution.")]
    BestExecution = ExternalTradeTransactionConditionCode.BestExecution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bought minus indicator.
    /// Encoded/decoded by serializers as &quot;BTMI&quot;.
    /// </summary>
    [EnumMember(Value = "BTMI")]
    [IsoId("_uJ60C_RYEeuLhpyIdtJzwg")]
    [Description(@"Bought minus indicator.")]
    BoughtMinus = ExternalTradeTransactionConditionCode.BoughtMinus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed following the exercise of a call option on the security.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_uJ60DvRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed following the exercise of a call option on the security.")]
    Call = ExternalTradeTransactionConditionCode.Call, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed cum bonus.
    /// Encoded/decoded by serializers as &quot;CBNS&quot;.
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_uKElAvRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum bonus.")]
    CumBonus = ExternalTradeTransactionConditionCode.CumBonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_uKElBfRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum coupon.")]
    CumCoupon = ExternalTradeTransactionConditionCode.CumCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed cum dividend.
    /// Encoded/decoded by serializers as &quot;CDIV&quot;.
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_uKElCPRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum dividend.")]
    CumDividend = ExternalTradeTransactionConditionCode.CumDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;CLBR&quot;.
    /// </summary>
    [EnumMember(Value = "CLBR")]
    [IsoId("_uKElC_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade to be executed for closure of a previous position before the rollover of a position (Deferred Settlement Service). "
    )]
    ClosureBeforeRollOver = ExternalTradeTransactionConditionCode.ClosureBeforeRollOver, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_uKNu8vRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed clean, ie government tax must not be paid on the accrued interest on the bond."
    )]
    Clean = ExternalTradeTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange
    /// Encoded/decoded by serializers as &quot;CRST&quot;.
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_uKNu9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange"
    )]
    CrossTrade = ExternalTradeTransactionConditionCode.CrossTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed cum rights.
    /// Encoded/decoded by serializers as &quot;CRTS&quot;.
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_uKNu-PRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum rights.")]
    CumRights = ExternalTradeTransactionConditionCode.CumRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed cum warrant.
    /// Encoded/decoded by serializers as &quot;CWAR&quot;.
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_uKNu-_RYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed cum warrant.")]
    CumWarrant = ExternalTradeTransactionConditionCode.CumWarrant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A customer order where the customer gives specific instructions to the broker concerning the orders routing destination.
    /// Encoded/decoded by serializers as &quot;DIOR&quot;.
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_uKNu_vRYEeuLhpyIdtJzwg")]
    [Description(
        @"A customer order where the customer gives specific instructions to the broker concerning the orders routing destination."
    )]
    DirectedOrder = ExternalTradeTransactionConditionCode.DirectedOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_uKXf8vRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed dirty, ie government tax must be paid on the accrued interest on the bond."
    )]
    Dirty = ExternalTradeTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The order is to be executed by a trading party other than the trading party to which the order is sent. In this case, the instructing party has traded with another broker which will subsequently send an advice of execution to the executing party who received the order and which is acting as clearing broker.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_uKXf9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"The order is to be executed by a trading party other than the trading party to which the order is sent. In this case, the instructing party has traded with another broker which will subsequently send an advice of execution to the executing party who received the order and which is acting as clearing broker."
    )]
    DirectOrder = ExternalTradeTransactionConditionCode.DirectOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The order is based on a forward price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_uKXf-PRYEeuLhpyIdtJzwg")]
    [Description(@"The order is based on a forward price.")]
    ForwardPriceTrade = ExternalTradeTransactionConditionCode.ForwardPriceTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fractional parts are allowed.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_uKXf-_RYEeuLhpyIdtJzwg")]
    [Description(@"Fractional parts are allowed.")]
    Fractions = ExternalTradeTransactionConditionCode.Fractions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The delivery of the financial instrument on settlement date is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_uKXf_vRYEeuLhpyIdtJzwg")]
    [Description(@"The delivery of the financial instrument on settlement date is guaranteed.")]
    GuaranteedDelivery = ExternalTradeTransactionConditionCode.GuaranteedDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The order is based on a historic price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_uKhQ8vRYEeuLhpyIdtJzwg")]
    [Description(@"The order is based on a historic price.")]
    HistoricPriceTrade = ExternalTradeTransactionConditionCode.HistoricPriceTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade was executed at market price.
    /// Encoded/decoded by serializers as &quot;MAPR&quot;.
    /// </summary>
    [EnumMember(Value = "MAPR")]
    [IsoId("_uKhQ9fRYEeuLhpyIdtJzwg")]
    [Description(@"Trade was executed at market price.")]
    MarketPrice = ExternalTradeTransactionConditionCode.MarketPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed for month-end settlement (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_uKhQ-PRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed for month-end settlement (Deferred Settlement Service). ")]
    Monthly = ExternalTradeTransactionConditionCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service).
    /// Encoded/decoded by serializers as &quot;NBFR&quot;.
    /// </summary>
    [EnumMember(Value = "NBFR")]
    [IsoId("_uKhQ-_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade to be executed for a new trade position on the next month following the roll-over of a position (Deferred Settlement Service). "
    )]
    NewTradeFollowingRollover = ExternalTradeTransactionConditionCode.NewTradeFollowingRollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.
    /// Encoded/decoded by serializers as &quot;NCRS&quot;.
    /// </summary>
    [EnumMember(Value = "NCRS")]
    [IsoId("_uKrB8vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed."
    )]
    NoCrossTrade = ExternalTradeTransactionConditionCode.NoCrossTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_uKrB9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade for which the price is not the one quoted but an improved one, that is, the negotiated price."
    )]
    NegotiatedTrade = ExternalTradeTransactionConditionCode.NegotiatedTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.
    /// Encoded/decoded by serializers as &quot;NMPR&quot;.
    /// </summary>
    [EnumMember(Value = "NMPR")]
    [IsoId("_uKrB-PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Trade was executed outside of normal market conditions, for example, in the case of an iceberg order."
    )]
    NonMarketPrice = ExternalTradeTransactionConditionCode.NonMarketPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allows trader to explicitly request anonymity or disclosure in pre-trade market data feeds. Anonymity is relevant in markets where counterparties are regularly disclosed in order depth feeds. Disclosure is relevant when counterparties are not normally visible.
    /// Encoded/decoded by serializers as &quot;PETA&quot;.
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_uKrB-_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Allows trader to explicitly request anonymity or disclosure in pre-trade market data feeds. Anonymity is relevant in markets where counterparties are regularly disclosed in order depth feeds. Disclosure is relevant when counterparties are not normally visible."
    )]
    PreTradeAnonimity = ExternalTradeTransactionConditionCode.PreTradeAnonimity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed following the exercise of a put option on the security.
    /// Encoded/decoded by serializers as &quot;PUTT&quot;.
    /// </summary>
    [EnumMember(Value = "PUTT")]
    [IsoId("_uKrB_vRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed following the exercise of a put option on the security. ")]
    Putt = ExternalTradeTransactionConditionCode.Putt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SETI&quot;.
    /// </summary>
    [EnumMember(Value = "SETI")]
    [IsoId("_uK0L4vRYEeuLhpyIdtJzwg")]
    [Description(@"Trade is exempt from short-sale rules.")]
    SoldExempt = ExternalTradeTransactionConditionCode.SoldExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed  with a special cum dividend, ie, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_uK0L5fRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed  with a special cum dividend, ie, buying after the ex date and getting the dividend."
    )]
    SpecialCumDividend = ExternalTradeTransactionConditionCode.SpecialCumDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed  with a special ex dividend, ie, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as &quot;SPEX&quot;.
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_uK0L6PRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is executed  with a special ex dividend, ie, selling before the ex date without the coupon. "
    )]
    SpecialExDividend = ExternalTradeTransactionConditionCode.SpecialExDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sold plus indication.
    /// Encoded/decoded by serializers as &quot;SPSI&quot;.
    /// </summary>
    [EnumMember(Value = "SPSI")]
    [IsoId("_uK0L6_RYEeuLhpyIdtJzwg")]
    [Description(@"Sold plus indication.")]
    SoldPlus = ExternalTradeTransactionConditionCode.SoldPlus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is sold short. When the seller does not have the financial instrument, the delivery is effected by borrowing the financial instrument by or for the account of the seller.
    /// Encoded/decoded by serializers as &quot;SSTI&quot;.
    /// </summary>
    [EnumMember(Value = "SSTI")]
    [IsoId("_uK0L7vRYEeuLhpyIdtJzwg")]
    [Description(
        @"The trade is sold short. When the seller does not have the financial instrument, the delivery is effected by borrowing the financial instrument by or for the account of the seller."
    )]
    SoldShort = ExternalTradeTransactionConditionCode.SoldShort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade executed this month following the rollover of positions.
    /// Encoded/decoded by serializers as &quot;TEFR&quot;.
    /// </summary>
    [EnumMember(Value = "TEFR")]
    [IsoId("_uK984vRYEeuLhpyIdtJzwg")]
    [Description(@"Trade executed this month following the rollover of positions. ")]
    TradeExecutedFollowingRollover =
        ExternalTradeTransactionConditionCode.TradeExecutedFollowingRollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade to be executed on the next month following the roll-over of positions.
    /// Encoded/decoded by serializers as &quot;TRFR&quot;.
    /// </summary>
    [EnumMember(Value = "TRFR")]
    [IsoId("_uK985fRYEeuLhpyIdtJzwg")]
    [Description(@"Trade to be executed on the next month following the roll-over of positions. ")]
    TradeFollowingRollover = ExternalTradeTransactionConditionCode.TradeFollowingRollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is before the issue date after announcement of the auction.
    /// Encoded/decoded by serializers as &quot;WIBC&quot;.
    /// </summary>
    [EnumMember(Value = "WIBC")]
    [IsoId("_uK986PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is before the issue date after announcement of the auction.")]
    BeforeAuction = ExternalTradeTransactionConditionCode.BeforeAuction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is after the issue date after announcement of the auction.
    /// Encoded/decoded by serializers as &quot;WICD&quot;.
    /// </summary>
    [EnumMember(Value = "WICD")]
    [IsoId("_uK986_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is after the issue date after announcement of the auction.")]
    AfterAuction = ExternalTradeTransactionConditionCode.AfterAuction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed ex bonus.
    /// Encoded/decoded by serializers as &quot;XBNS&quot;.
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_uK987vRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex bonus.")]
    ExBonus = ExternalTradeTransactionConditionCode.ExBonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_uLHG0vRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex coupon.")]
    ExCoupon = ExternalTradeTransactionConditionCode.ExCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed ex dividend.
    /// Encoded/decoded by serializers as &quot;XDIV&quot;.
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_uLHG1fRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex dividend.")]
    ExDividend = ExternalTradeTransactionConditionCode.ExDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed ex rights.
    /// Encoded/decoded by serializers as &quot;XRTS&quot;.
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_uLHG2PRYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex rights.")]
    ExRights = ExternalTradeTransactionConditionCode.ExRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The trade is executed ex warrant.
    /// Encoded/decoded by serializers as &quot;XWAR&quot;.
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_uLHG2_RYEeuLhpyIdtJzwg")]
    [Description(@"The trade is executed ex warrant.")]
    ExWarrant = ExternalTradeTransactionConditionCode.ExWarrant, // same ordinal as derivation source for type conversions
}
