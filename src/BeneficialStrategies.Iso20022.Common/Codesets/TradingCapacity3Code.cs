// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqgQBtp-Ed-ak6NoX_4Aeg_-161164047")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
public enum TradingCapacity3Code
{
    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_YqgQB9p-Ed-ak6NoX_4Aeg_-72074817")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crossing as a principal.
    /// Encoded/decoded by serializers as &quot;CPRN&quot;.
    /// </summary>
    [EnumMember(Value = "CPRN")]
    [IsoId("_YqgQCNp-Ed-ak6NoX_4Aeg_-72074799")]
    [Description(@"Crossing as a principal.")]
    CrossingPrincipal = TradingCapacityCode.CrossingPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("_YqqBANp-Ed-ak6NoX_4Aeg_-72074774")]
    [Description(
        @"Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party."
    )]
    RisklessPrincipal = TradingCapacityCode.RisklessPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading for its firm. The transaction affects the firm&apos;s own account, not that of its customers.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_YqqBAdp-Ed-ak6NoX_4Aeg_-72074773")]
    [Description(
        @"Trading for its firm. The transaction affects the firm's own account, not that of its customers."
    )]
    Proprietary = TradingCapacityCode.Proprietary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YqqBAtp-Ed-ak6NoX_4Aeg_-72074757")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crossing as an agent.
    /// Encoded/decoded by serializers as &quot;CAGN&quot;.
    /// </summary>
    [EnumMember(Value = "CAGN")]
    [IsoId("_YqqBA9p-Ed-ak6NoX_4Aeg_-72074739")]
    [Description(@"Crossing as an agent.")]
    CrossingAgent = TradingCapacityCode.CrossingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acting as an agent for a party other than a customer.
    /// Encoded/decoded by serializers as &quot;OAGN&quot;.
    /// </summary>
    [EnumMember(Value = "OAGN")]
    [IsoId("_YqqBBNp-Ed-ak6NoX_4Aeg_-72074738")]
    [Description(@"Acting as an agent for a party other than a customer.")]
    OtherAgent = TradingCapacityCode.OtherAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acting as an agent for some executions and principal for others in the same transaction.
    /// Encoded/decoded by serializers as &quot;PRAG&quot;.
    /// </summary>
    [EnumMember(Value = "PRAG")]
    [IsoId("_YqqBBdp-Ed-ak6NoX_4Aeg_-71154750")]
    [Description(
        @"Acting as an agent for some executions and principal for others in the same transaction."
    )]
    PrincipalAgent = TradingCapacityCode.PrincipalAgent, // same ordinal as derivation source for type conversions
}
