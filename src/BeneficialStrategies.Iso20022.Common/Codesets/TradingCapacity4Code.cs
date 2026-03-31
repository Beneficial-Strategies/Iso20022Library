// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__zHQANojEeC60axPepSq7g_1923931952")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradingCapacity4Code>))]
#endif
public enum TradingCapacity4Code
{
    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("__zHQAdojEeC60axPepSq7g_-86024906")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crossing as a principal.
    /// Encoded/decoded by serializers as &quot;CPRN&quot;.
    /// </summary>
    [EnumMember(Value = "CPRN")]
    [IsoId("__zHQAtojEeC60axPepSq7g_-199863972")]
    [Description(@"Crossing as a principal.")]
    CrossingPrincipal = TradingCapacityCode.CrossingPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("__zHQA9ojEeC60axPepSq7g_-52865137")]
    [Description(
        @"Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party."
    )]
    RisklessPrincipal = TradingCapacityCode.RisklessPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading for its firm. The transaction affects the firm&apos;s own account, not that of its customers.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("__zHQBNojEeC60axPepSq7g_1471203159")]
    [Description(
        @"Trading for its firm. The transaction affects the firm's own account, not that of its customers."
    )]
    Proprietary = TradingCapacityCode.Proprietary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("__zHQBdojEeC60axPepSq7g_1622201004")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crossing as an agent.
    /// Encoded/decoded by serializers as &quot;CAGN&quot;.
    /// </summary>
    [EnumMember(Value = "CAGN")]
    [IsoId("__zHQBtojEeC60axPepSq7g_-1148697996")]
    [Description(@"Crossing as an agent.")]
    CrossingAgent = TradingCapacityCode.CrossingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acting as an agent for a party other than a customer.
    /// Encoded/decoded by serializers as &quot;OAGN&quot;.
    /// </summary>
    [EnumMember(Value = "OAGN")]
    [IsoId("__zRBANojEeC60axPepSq7g_-845601054")]
    [Description(@"Acting as an agent for a party other than a customer.")]
    OtherAgent = TradingCapacityCode.OtherAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acting as an agent for some executions and principal for others in the same transaction.
    /// Encoded/decoded by serializers as &quot;PRAG&quot;.
    /// </summary>
    [EnumMember(Value = "PRAG")]
    [IsoId("__zRBAdojEeC60axPepSq7g_678467242")]
    [Description(
        @"Acting as an agent for some executions and principal for others in the same transaction."
    )]
    PrincipalAgent = TradingCapacityCode.PrincipalAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as an agent for both customer and another person.
    /// Encoded/decoded by serializers as &quot;BAGN&quot;.
    /// </summary>
    [EnumMember(Value = "BAGN")]
    [IsoId("__zRBAtojEeC60axPepSq7g_232419284")]
    [Description(@"Party acting as an agent for both customer and another person.")]
    ActingAgent = TradingCapacityCode.ActingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any legal person whose regular occupation or business is the provision of one or more investment services to third parties and/or the performance of one or more investment activities on a professional basis.
    /// Encoded/decoded by serializers as &quot;INFI&quot;.
    /// </summary>
    [EnumMember(Value = "INFI")]
    [IsoId("__zRBA9ojEeC60axPepSq7g_1756487580")]
    [Description(
        @"Any legal person whose regular occupation or business is the provision of one or more investment services to third parties and/or the performance of one or more investment activities on a professional basis."
    )]
    InvestmentFirm = TradingCapacityCode.InvestmentFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.
    /// Encoded/decoded by serializers as &quot;MKTM&quot;.
    /// </summary>
    [EnumMember(Value = "MKTM")]
    [IsoId("__zRBBNojEeC60axPepSq7g_686506553")]
    [Description(
        @"Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell."
    )]
    MarketMaker = TradingCapacityCode.MarketMaker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Multilateral Trading Facility (MTF) is a multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("__zaK8NojEeC60axPepSq7g_-2084392447")]
    [Description(
        @"Multilateral Trading Facility (MTF) is a multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract."
    )]
    MultilateralTradingFacility = TradingCapacityCode.MultilateralTradingFacility, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulated market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("__zaK8dojEeC60axPepSq7g_-1777537574")]
    [Description(
        @"Regulated market on which financial instruments can be traded according to rules defined by the stock exchange."
    )]
    RegulatedMarket = TradingCapacityCode.RegulatedMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Firms which, on an organised, frequent and systematic basis, deal on their own account by executing client orders outside a regulated market or an MTF. SIs have the obligation to provide, and make public, a definite bid and offer quote for liquid securities.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("__zaK8tojEeC60axPepSq7g_-253469278")]
    [Description(
        @"Firms which, on an organised, frequent and systematic basis, deal on their own account by executing client orders outside a regulated market or an MTF. SIs have the obligation to provide, and make public, a definite bid and offer quote for liquid securities."
    )]
    SystematicInternaliser = TradingCapacityCode.SystematicInternaliser, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party appointed by the Fund Management Company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TAGT&quot;.
    /// </summary>
    [EnumMember(Value = "TAGT")]
    [IsoId("__zaK89ojEeC60axPepSq7g_-1016772421")]
    [Description(
        @"Party appointed by the Fund Management Company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution."
    )]
    TransferAgent = TradingCapacityCode.TransferAgent, // same ordinal as derivation source for type conversions
}
