// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the impact of a vote on a proposal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MosJQK37EemG7MmivSuE5g")]
[Description(@"Specifies the impact of a vote on a proposal.")]
[Derivations(typeof(VoteType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<VoteTypeCode>))]
#endif
public enum VoteTypeCode
{
    /// <summary>
    /// Results of a vote on a proposal is binding.
    /// Encoded/decoded by serializers as &quot;BNDG&quot;.
    /// </summary>
    [EnumMember(Value = "BNDG")]
    [IsoId("_aq1OUK37EemG7MmivSuE5g")]
    [Description(@"Results of a vote on a proposal is binding.")]
    Binding,

    /// <summary>
    /// Results of a vote on a proposal is for advice only.
    /// Encoded/decoded by serializers as &quot;ADVI&quot;.
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_qJ910K37EemG7MmivSuE5g")]
    [Description(@"Results of a vote on a proposal is for advice only.")]
    Advisory,
}
