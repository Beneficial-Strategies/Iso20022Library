// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yaalltp-Ed-ak6NoX_4Aeg_-1964739179")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
public enum TradingCapacity5Code
{
    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_Yaall9p-Ed-ak6NoX_4Aeg_524208854")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("_YaalmNp-Ed-ak6NoX_4Aeg_789078674")]
    [Description(
        @"Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party."
    )]
    RisklessPrincipal = TradingCapacityCode.RisklessPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YajvgNp-Ed-ak6NoX_4Aeg_1711241984")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions
}
