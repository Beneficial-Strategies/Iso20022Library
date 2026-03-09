// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of executed order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqNVE9p-Ed-ak6NoX_4Aeg_1275192520")]
[Description(@"Specifies the type of executed order.")]
[Derivations(typeof(TradeType3Code),typeof(TradeType1Code),typeof(TradeType2Code))]
public enum TradeTypeCode
{
    /// <summary>
    /// A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_YqNVFNp-Ed-ak6NoX_4Aeg_1180327952")]
    [Description(@"A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.")]
    Basket,
    
    /// <summary>
    /// A trade of a predetermined set of financial instruments.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_YqNVFdp-Ed-ak6NoX_4Aeg_1200645094")]
    [Description(@"A trade of a predetermined set of financial instruments.")]
    Index,
    
    /// <summary>
    /// A trade of a predetermined set of financial instruments.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_YqNVFtp-Ed-ak6NoX_4Aeg_1221883891")]
    [Description(@"A trade of a predetermined set of financial instruments.")]
    List,
    
    /// <summary>
    /// A pre-allocated trade.
    /// Encoded/decoded by serializers as &quot;PRAL&quot;.
    /// </summary>
    [EnumMember(Value = "PRAL")]
    [IsoId("_YqNVF9p-Ed-ak6NoX_4Aeg_1236661357")]
    [Description(@"A pre-allocated trade.")]
    PreAllocation,
    
    /// <summary>
    /// A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.
    /// Encoded/decoded by serializers as &quot;PROG&quot;.
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("_YqNVGNp-Ed-ak6NoX_4Aeg_1250513614")]
    [Description(@"A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.")]
    Program,
    
    /// <summary>
    /// An executed order.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_YqNVGdp-Ed-ak6NoX_4Aeg_1268984128")]
    [Description(@"An executed order.")]
    Trade,
    
    /// <summary>
    /// A trade from a broker to another broker.
    /// Encoded/decoded by serializers as &quot;BRBR&quot;.
    /// </summary>
    [EnumMember(Value = "BRBR")]
    [IsoId("_YqXGENp-Ed-ak6NoX_4Aeg_-57032311")]
    [Description(@"A trade from a broker to another broker.")]
    BrokerToBroker,
    
    /// <summary>
    /// A trade from an investment fund to another investment fund.
    /// Encoded/decoded by serializers as &quot;FDFD&quot;.
    /// </summary>
    [EnumMember(Value = "FDFD")]
    [IsoId("_YqXGEdp-Ed-ak6NoX_4Aeg_227581")]
    [Description(@"A trade from an investment fund to another investment fund.")]
    FundToFund,
    
    /// <summary>
    /// Trade involving risk.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_YqXGEtp-Ed-ak6NoX_4Aeg_1363842325")]
    [Description(@"Trade involving risk.")]
    RiskTrade,
    
    /// <summary>
    /// Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_YqXGE9p-Ed-ak6NoX_4Aeg_1363842326")]
    [Description(@"Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.")]
    VWAPGuarantee,
    
    /// <summary>
    /// Trade in which an agent intermediates between a buyer and a seller.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YqXGFNp-Ed-ak6NoX_4Aeg_1363842334")]
    [Description(@"Trade in which an agent intermediates between a buyer and a seller.")]
    Agency,
    
    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_YqXGFdp-Ed-ak6NoX_4Aeg_1363842335")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GuaranteedClose,
    
    /// <summary>
    /// On order book/market trade.
    /// Encoded/decoded by serializers as &quot;OOBK&quot;.
    /// </summary>
    [EnumMember(Value = "OOBK")]
    [IsoId("_YqXGFtp-Ed-ak6NoX_4Aeg_-390833182")]
    [Description(@"On order book/market trade.")]
    OnOrderBookTrade,
    
    /// <summary>
    /// Trades coming from the application of a coorporate event.
    /// Encoded/decoded by serializers as &quot;LKTR&quot;.
    /// </summary>
    [EnumMember(Value = "LKTR")]
    [IsoId("_YqXGF9p-Ed-ak6NoX_4Aeg_-220495244")]
    [Description(@"Trades coming from the application of a coorporate event.")]
    LinkedTrade,
    
    /// <summary>
    /// Trade generated by a give-up.
    /// Encoded/decoded by serializers as &quot;GUTR&quot;.
    /// </summary>
    [EnumMember(Value = "GUTR")]
    [IsoId("_YqXGGNp-Ed-ak6NoX_4Aeg_415878249")]
    [Description(@"Trade generated by a give-up.")]
    TradeGiveUp,
    
    /// <summary>
    /// Trade that is generated following a corporate action.
    /// Encoded/decoded by serializers as &quot;COTR&quot;.
    /// </summary>
    [EnumMember(Value = "COTR")]
    [IsoId("_YqXGGdp-Ed-ak6NoX_4Aeg_-2057393937")]
    [Description(@"Trade that is generated following a corporate action.")]
    CorrectiveTrade,
    
    /// <summary>
    /// Trade that is input manually in case of issue on the original trade that either was not processed or not received.
    /// Encoded/decoded by serializers as &quot;BKTR&quot;.
    /// </summary>
    [EnumMember(Value = "BKTR")]
    [IsoId("_YqgQANp-Ed-ak6NoX_4Aeg_-1994813658")]
    [Description(@"Trade that is input manually in case of issue on the original trade that either was not processed or not received.")]
    BackUpTrade,
    
    /// <summary>
    /// Trade that is over the counter.
    /// Encoded/decoded by serializers as &quot;OFBK&quot;.
    /// </summary>
    [EnumMember(Value = "OFBK")]
    [IsoId("_YqgQAdp-Ed-ak6NoX_4Aeg_-707208703")]
    [Description(@"Trade that is over the counter.")]
    OffOrderBookTrade,
    
    /// <summary>
    /// Transaction relates to employee trade reporting.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("__5EuENojEeC60axPepSq7g_-1320847336")]
    [Description(@"Transaction relates to employee trade reporting.")]
    EmployeeTradeReporting,
    
    /// <summary>
    /// Transaction is an Initial Public Offer (IPO) order.
    /// Encoded/decoded by serializers as &quot;IPOO&quot;.
    /// </summary>
    [EnumMember(Value = "IPOO")]
    [IsoId("__5EuEdojEeC60axPepSq7g_-1097946825")]
    [Description(@"Transaction is an Initial Public Offer (IPO) order.")]
    IPO,
    
    /// <summary>
    /// Indicates that the trade is a Offering issue trade.
    /// Encoded/decoded by serializers as &quot;OFIT&quot;.
    /// </summary>
    [EnumMember(Value = "OFIT")]
    [IsoId("__5EuEtojEeC60axPepSq7g_-1779724746")]
    [Description(@"Indicates that the trade is a Offering issue trade.")]
    OfferingIssuingTrade,
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("__5EuE9ojEeC60axPepSq7g_-178168873")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance,
    
    /// <summary>
    /// The trade is a Bond repricing.
    /// Encoded/decoded by serializers as &quot;BORE&quot;.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("__5OfENojEeC60axPepSq7g_1746600155")]
    [Description(@"The trade is a Bond repricing.")]
    BondRepricing,
    
    /// <summary>
    /// The trade is a Bond substitution.
    /// Encoded/decoded by serializers as &quot;BOSU&quot;.
    /// </summary>
    [EnumMember(Value = "BOSU")]
    [IsoId("__5OfEdojEeC60axPepSq7g_2018650338")]
    [Description(@"The trade is a Bond substitution.")]
    BondSubstitution,
    
    /// <summary>
    /// The trade is a Bond end.
    /// Encoded/decoded by serializers as &quot;BOEN&quot;.
    /// </summary>
    [EnumMember(Value = "BOEN")]
    [IsoId("__5OfEtojEeC60axPepSq7g_343765467")]
    [Description(@"The trade is a Bond end.")]
    BondEnd,
    
    /// <summary>
    /// The trade is a Bond start.
    /// Encoded/decoded by serializers as &quot;BOST&quot;.
    /// </summary>
    [EnumMember(Value = "BOST")]
    [IsoId("__5OfE9ojEeC60axPepSq7g_-1022334635")]
    [Description(@"The trade is a Bond start.")]
    BondStart,
    
    /// <summary>
    /// Indicates that the trade is a Lending and borrowing.
    /// Encoded/decoded by serializers as &quot;LABO&quot;.
    /// </summary>
    [EnumMember(Value = "LABO")]
    [IsoId("__5OfFNojEeC60axPepSq7g_-272127876")]
    [Description(@"Indicates that the trade is a Lending and borrowing.")]
    LendingAndBorrowing,
    
    /// <summary>
    /// Indicates that the trade is a Futures contract trade.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("__5OfFdojEeC60axPepSq7g_1805283326")]
    [Description(@"Indicates that the trade is a Futures contract trade.")]
    Futures,
    
    /// <summary>
    /// Indicates that the trade is a Option contract trade.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("__5OfFtojEeC60axPepSq7g_-429155997")]
    [Description(@"Indicates that the trade is a Option contract trade.")]
    Options,
    
    /// <summary>
    /// Indicates that the trade is a Futures option contract trade.
    /// Encoded/decoded by serializers as &quot;FUOP&quot;.
    /// </summary>
    [EnumMember(Value = "FUOP")]
    [IsoId("__5XpANojEeC60axPepSq7g_1586587105")]
    [Description(@"Indicates that the trade is a Futures option contract trade.")]
    FuturesOption,
    
    /// <summary>
    /// The security will be bought back in the future.
    /// Encoded/decoded by serializers as &quot;FBBT&quot;.
    /// </summary>
    [EnumMember(Value = "FBBT")]
    [IsoId("__5XpAdojEeC60axPepSq7g_-432324318")]
    [Description(@"The security will be bought back in the future.")]
    FutureBuyBackTrade,
    
}
