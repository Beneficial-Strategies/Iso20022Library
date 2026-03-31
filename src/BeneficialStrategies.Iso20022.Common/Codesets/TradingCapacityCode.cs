// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqqBBtp-Ed-ak6NoX_4Aeg_-1705783512")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[Derivations(
    typeof(TradingCapacity3Code),
    typeof(TradingCapacity4Code),
    typeof(TradingCapacity6Code),
    typeof(TradingCapacity5Code),
    typeof(TradingCapacity7Code),
    typeof(TradingCapacity8Code),
    typeof(TradingCapacity9Code)
)]
public enum TradingCapacityCode
{
    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_YqqBB9p-Ed-ak6NoX_4Aeg_-1235714544")]
    [Description(@"Trading as Principal.")]
    Principal,

    /// <summary>
    /// Crossing as a principal.
    /// Encoded/decoded by serializers as &quot;CPRN&quot;.
    /// </summary>
    [EnumMember(Value = "CPRN")]
    [IsoId("_YqqBCNp-Ed-ak6NoX_4Aeg_-1235714518")]
    [Description(@"Crossing as a principal.")]
    CrossingPrincipal,

    /// <summary>
    /// Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("_YqqBCdp-Ed-ak6NoX_4Aeg_-1235714457")]
    [Description(
        @"Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party."
    )]
    RisklessPrincipal,

    /// <summary>
    /// Trading for its firm. The transaction affects the firm&apos;s own account, not that of its customers.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_YqzyANp-Ed-ak6NoX_4Aeg_-1235714458")]
    [Description(
        @"Trading for its firm. The transaction affects the firm's own account, not that of its customers."
    )]
    Proprietary,

    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YqzyAdp-Ed-ak6NoX_4Aeg_-1235714536")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent,

    /// <summary>
    /// Crossing as an agent.
    /// Encoded/decoded by serializers as &quot;CAGN&quot;.
    /// </summary>
    [EnumMember(Value = "CAGN")]
    [IsoId("_YqzyAtp-Ed-ak6NoX_4Aeg_-1235714501")]
    [Description(@"Crossing as an agent.")]
    CrossingAgent,

    /// <summary>
    /// Acting as an agent for a party other than a customer.
    /// Encoded/decoded by serializers as &quot;OAGN&quot;.
    /// </summary>
    [EnumMember(Value = "OAGN")]
    [IsoId("_YqzyA9p-Ed-ak6NoX_4Aeg_-1235714500")]
    [Description(@"Acting as an agent for a party other than a customer.")]
    OtherAgent,

    /// <summary>
    /// Acting as an agent for some executions and principal for others in the same transaction.
    /// Encoded/decoded by serializers as &quot;PRAG&quot;.
    /// </summary>
    [EnumMember(Value = "PRAG")]
    [IsoId("_YqzyBNp-Ed-ak6NoX_4Aeg_-1235714483")]
    [Description(
        @"Acting as an agent for some executions and principal for others in the same transaction."
    )]
    PrincipalAgent,

    /// <summary>
    /// Party acting as an agent for both customer and another person.
    /// Encoded/decoded by serializers as &quot;BAGN&quot;.
    /// </summary>
    [EnumMember(Value = "BAGN")]
    [IsoId("__5XpAtojEeC60axPepSq7g_-733239966")]
    [Description(@"Party acting as an agent for both customer and another person.")]
    ActingAgent,

    /// <summary>
    /// Any legal person whose regular occupation or business is the provision of one or more investment services to third parties and/or the performance of one or more investment activities on a professional basis.
    /// Encoded/decoded by serializers as &quot;INFI&quot;.
    /// </summary>
    [EnumMember(Value = "INFI")]
    [IsoId("__5XpA9ojEeC60axPepSq7g_-19029889")]
    [Description(
        @"Any legal person whose regular occupation or business is the provision of one or more investment services to third parties and/or the performance of one or more investment activities on a professional basis."
    )]
    InvestmentFirm,

    /// <summary>
    /// Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.
    /// Encoded/decoded by serializers as &quot;MKTM&quot;.
    /// </summary>
    [EnumMember(Value = "MKTM")]
    [IsoId("__5XpBNojEeC60axPepSq7g_899052693")]
    [Description(
        @"Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell."
    )]
    MarketMaker,

    /// <summary>
    /// Multilateral Trading Facility (MTF) is a multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("__5XpBdojEeC60axPepSq7g_346468074")]
    [Description(
        @"Multilateral Trading Facility (MTF) is a multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract."
    )]
    MultilateralTradingFacility,

    /// <summary>
    /// Regulated market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("__5haANojEeC60axPepSq7g_-1947030189")]
    [Description(
        @"Regulated market on which financial instruments can be traded according to rules defined by the stock exchange."
    )]
    RegulatedMarket,

    /// <summary>
    /// Firms which, on an organised, frequent and systematic basis, deal on their own account by executing client orders outside a regulated market or an MTF. SIs have the obligation to provide, and make public, a definite bid and offer quote for liquid securities.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("__5haAdojEeC60axPepSq7g_259578030")]
    [Description(
        @"Firms which, on an organised, frequent and systematic basis, deal on their own account by executing client orders outside a regulated market or an MTF. SIs have the obligation to provide, and make public, a definite bid and offer quote for liquid securities."
    )]
    SystematicInternaliser,

    /// <summary>
    /// Party appointed by the Fund Management Company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TAGT&quot;.
    /// </summary>
    [EnumMember(Value = "TAGT")]
    [IsoId("__5haAtojEeC60axPepSq7g_1566773702")]
    [Description(
        @"Party appointed by the Fund Management Company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution."
    )]
    TransferAgent,

    /// <summary>
    /// Counterparties neogiate trading details to execute trades. Bilateral confirmation, that is, the Sender and the Receiver are the principals.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("")]
    [Description(
        @"Counterparties neogiate trading details to execute trades. Bilateral confirmation, that is, the Sender and the Receiver are the principals."
    )]
    Bilateral,

    /// <summary>
    /// Trade executed through a broker. The confirmation is sent by a money broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("")]
    [Description(@"Trade executed through a broker. The confirmation is sent by a money broker.")]
    Broker,
}
