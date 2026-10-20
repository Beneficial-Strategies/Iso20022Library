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
[IsoId("a9379ba7-e95d-4c14-91fa-58ef67702abc")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingCapacity10Code>))]
public enum TradingCapacity10Code
{
    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("72911961-9ac1-44c7-be86-9dcf35e1ed8b")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as an agent on behalf of the customer and as a principal.
    /// Encoded/decoded by serializers as &quot;MIXC&quot;.
    /// </summary>
    [EnumMember(Value = "MIXC")]
    [IsoId("88415639-013c-4783-9210-9224480d153b")]
    [Description(@"Trading as an agent on behalf of the customer and as a principal.")]
    Mixed = TradingCapacityCode.Mixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("f7d290bd-e914-41d2-9cc8-b77d5a7e0c87")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("f70f8242-69d8-4ba4-ada7-badbdbef826b")]
    [Description(@"Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.")]
    RisklessPrincipal = TradingCapacityCode.RisklessPrincipal, // same ordinal as derivation source for type conversions
}
