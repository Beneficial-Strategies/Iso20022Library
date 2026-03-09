// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of executed order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__yXpJdojEeC60axPepSq7g_-56889578")]
[Description(@"Specifies the type of executed order.")]
[DerivedFrom(typeof(TradeTypeCode))]
public enum TradeType3Code
{
    /// <summary>
    /// A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("__ygzENojEeC60axPepSq7g_729173022")]
    [Description(@"A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.")]
    Basket = TradeTypeCode.Basket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A trade of a predetermined set of financial instruments.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("__ygzEdojEeC60axPepSq7g_-979794862")]
    [Description(@"A trade of a predetermined set of financial instruments.")]
    Index = TradeTypeCode.Index, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an Initial Public Offer (IPO) order.
    /// Encoded/decoded by serializers as &quot;IPOO&quot;.
    /// </summary>
    [EnumMember(Value = "IPOO")]
    [IsoId("__ygzEtojEeC60axPepSq7g_-1817983282")]
    [Description(@"Transaction is an Initial Public Offer (IPO) order.")]
    IPO = TradeTypeCode.IPO, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A trade of a predetermined set of financial instruments.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("__yqkENojEeC60axPepSq7g_-1863028149")]
    [Description(@"A trade of a predetermined set of financial instruments.")]
    List = TradeTypeCode.List, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A pre-allocated trade.
    /// Encoded/decoded by serializers as &quot;PRAL&quot;.
    /// </summary>
    [EnumMember(Value = "PRAL")]
    [IsoId("__yqkEdojEeC60axPepSq7g_1471303445")]
    [Description(@"A pre-allocated trade.")]
    PreAllocation = TradeTypeCode.PreAllocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.
    /// Encoded/decoded by serializers as &quot;PROG&quot;.
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("__yqkEtojEeC60axPepSq7g_-2062898698")]
    [Description(@"A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.")]
    Program = TradeTypeCode.Program, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An executed order.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("__yqkE9ojEeC60axPepSq7g_1348835311")]
    [Description(@"An executed order.")]
    Trade = TradeTypeCode.Trade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A trade from a broker to another broker.
    /// Encoded/decoded by serializers as &quot;BRBR&quot;.
    /// </summary>
    [EnumMember(Value = "BRBR")]
    [IsoId("__yqkFNojEeC60axPepSq7g_1914291937")]
    [Description(@"A trade from a broker to another broker.")]
    BrokerToBroker = TradeTypeCode.BrokerToBroker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade involving risk.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("__yqkFdojEeC60axPepSq7g_222111740")]
    [Description(@"Trade involving risk.")]
    RiskTrade = TradeTypeCode.RiskTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("__yqkFtojEeC60axPepSq7g_-1359538318")]
    [Description(@"Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.")]
    VWAPGuarantee = TradeTypeCode.VWAPGuarantee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade in which an agent intermediates between a buyer and a seller.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("__y0VENojEeC60axPepSq7g_2052195691")]
    [Description(@"Trade in which an agent intermediates between a buyer and a seller.")]
    Agency = TradeTypeCode.Agency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("__y0VEdojEeC60axPepSq7g_665100232")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GuaranteedClose = TradeTypeCode.GuaranteedClose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction relates to employee trade reporting.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("__y0VEtojEeC60axPepSq7g_1587263542")]
    [Description(@"Transaction relates to employee trade reporting.")]
    EmployeeTradeReporting = TradeTypeCode.EmployeeTradeReporting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("__y0VE9ojEeC60axPepSq7g_-1050760413")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance = TradeTypeCode.Issuance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The trade is a Bond start.
    /// Encoded/decoded by serializers as &quot;BOST&quot;.
    /// </summary>
    [EnumMember(Value = "BOST")]
    [IsoId("__y0VFNojEeC60axPepSq7g_594507022")]
    [Description(@"The trade is a Bond start.")]
    BondStart = TradeTypeCode.BondStart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The trade is a Bond end.
    /// Encoded/decoded by serializers as &quot;BOEN&quot;.
    /// </summary>
    [EnumMember(Value = "BOEN")]
    [IsoId("__y0VFdojEeC60axPepSq7g_1428180849")]
    [Description(@"The trade is a Bond end.")]
    BondEnd = TradeTypeCode.BondEnd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is a Lending and borrowing.
    /// Encoded/decoded by serializers as &quot;LABO&quot;.
    /// </summary>
    [EnumMember(Value = "LABO")]
    [IsoId("__y0VFtojEeC60axPepSq7g_252989824")]
    [Description(@"Indicates that the trade is a Lending and borrowing.")]
    LendingAndBorrowing = TradeTypeCode.LendingAndBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The trade is a Bond repricing.
    /// Encoded/decoded by serializers as &quot;BORE&quot;.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("__y9fANojEeC60axPepSq7g_-857921595")]
    [Description(@"The trade is a Bond repricing.")]
    BondRepricing = TradeTypeCode.BondRepricing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is a Offering issue trade.
    /// Encoded/decoded by serializers as &quot;OFIT&quot;.
    /// </summary>
    [EnumMember(Value = "OFIT")]
    [IsoId("__y9fAdojEeC60axPepSq7g_-1563036210")]
    [Description(@"Indicates that the trade is a Offering issue trade.")]
    OfferingIssuingTrade = TradeTypeCode.OfferingIssuingTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The trade is a Bond substitution.
    /// Encoded/decoded by serializers as &quot;BOSU&quot;.
    /// </summary>
    [EnumMember(Value = "BOSU")]
    [IsoId("__y9fAtojEeC60axPepSq7g_1556740061")]
    [Description(@"The trade is a Bond substitution.")]
    BondSubstitution = TradeTypeCode.BondSubstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The security will be bought back in the future.
    /// Encoded/decoded by serializers as &quot;FBBT&quot;.
    /// </summary>
    [EnumMember(Value = "FBBT")]
    [IsoId("__y9fA9ojEeC60axPepSq7g_932775317")]
    [Description(@"The security will be bought back in the future.")]
    FutureBuyBackTrade = TradeTypeCode.FutureBuyBackTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is a Option contract trade.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("__y9fBNojEeC60axPepSq7g_-577397526")]
    [Description(@"Indicates that the trade is a Option contract trade.")]
    Options = TradeTypeCode.Options, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is a Futures option contract trade.
    /// Encoded/decoded by serializers as &quot;FUOP&quot;.
    /// </summary>
    [EnumMember(Value = "FUOP")]
    [IsoId("__y9fBdojEeC60axPepSq7g_1067869909")]
    [Description(@"Indicates that the trade is a Futures option contract trade.")]
    FuturesOption = TradeTypeCode.FuturesOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is a Futures contract trade.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("__y9fBtojEeC60axPepSq7g_-1688308945")]
    [Description(@"Indicates that the trade is a Futures contract trade.")]
    Futures = TradeTypeCode.Futures, // same ordinal as derivation source for type conversions
    
}
