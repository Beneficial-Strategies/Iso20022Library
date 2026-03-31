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
[IsoId("__zaK9NojEeC60axPepSq7g_276330764")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradingCapacity6Code>))]
#endif
public enum TradingCapacity6Code
{
    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("__zaK9dojEeC60axPepSq7g_946389513")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as an agent for both customer and another person.
    /// Encoded/decoded by serializers as &quot;BAGN&quot;.
    /// </summary>
    [EnumMember(Value = "BAGN")]
    [IsoId("__zaK9tojEeC60axPepSq7g_-729579691")]
    [Description(@"Party acting as an agent for both customer and another person.")]
    ActingAgent = TradingCapacityCode.ActingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crossing as an agent.
    /// Encoded/decoded by serializers as &quot;CAGN&quot;.
    /// </summary>
    [EnumMember(Value = "CAGN")]
    [IsoId("__zj78NojEeC60axPepSq7g_-1990766827")]
    [Description(@"Crossing as an agent.")]
    CrossingAgent = TradingCapacityCode.CrossingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crossing as a principal.
    /// Encoded/decoded by serializers as &quot;CPRN&quot;.
    /// </summary>
    [EnumMember(Value = "CPRN")]
    [IsoId("__zj78dojEeC60axPepSq7g_1386150177")]
    [Description(@"Crossing as a principal.")]
    CrossingPrincipal = TradingCapacityCode.CrossingPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acting as an agent for a party other than a customer.
    /// Encoded/decoded by serializers as &quot;OAGN&quot;.
    /// </summary>
    [EnumMember(Value = "OAGN")]
    [IsoId("__zj78tojEeC60axPepSq7g_1420967182")]
    [Description(@"Acting as an agent for a party other than a customer.")]
    OtherAgent = TradingCapacityCode.OtherAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acting as an agent for some executions and principal for others in the same transaction.
    /// Encoded/decoded by serializers as &quot;PRAG&quot;.
    /// </summary>
    [EnumMember(Value = "PRAG")]
    [IsoId("__zj789ojEeC60axPepSq7g_153653596")]
    [Description(
        @"Acting as an agent for some executions and principal for others in the same transaction."
    )]
    PrincipalAgent = TradingCapacityCode.PrincipalAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("__zj79NojEeC60axPepSq7g_-2025583832")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions
}
