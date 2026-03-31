// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the network channel through which the vote should be sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9SiF8DT8Ee2tRf29bleifQ")]
[Description(@"Specifies the network channel through which the vote should be sent.")]
[Derivations(typeof(VoteChannel1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<VoteChannelCode>))]
#endif
public enum VoteChannelCode
{
    /// <summary>
    /// Vote is via the chain of intermediaries.
    /// Encoded/decoded by serializers as &quot;VOCI&quot;.
    /// </summary>
    [EnumMember(Value = "VOCI")]
    [IsoId("_KyqDEDT9Ee2tRf29bleifQ")]
    [Description(@"Vote is via the chain of intermediaries.")]
    VoteThroughChain,

    /// <summary>
    /// Vote is as per described in the processing text for next intermediary information field.
    /// Encoded/decoded by serializers as &quot;VOPI&quot;.
    /// </summary>
    [EnumMember(Value = "VOPI")]
    [IsoId("_TzLoYDT9Ee2tRf29bleifQ")]
    [Description(
        @"Vote is as per described in the processing text for next intermediary information field."
    )]
    VoteAsPerIntermediaryInformation,
}
