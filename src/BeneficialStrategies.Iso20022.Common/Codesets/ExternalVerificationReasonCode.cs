// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external verification reason code, as published in an external verification code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jcPvQBLeEeumtumXS98aGg")]
[Description(
    @"Specifies the external verification reason code, as published in an external verification code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalVerificationReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalVerificationReasonCode>))]
#endif
public enum ExternalVerificationReasonCode
{
    /// <summary>
    /// Account number provided in the request is invalid or missing.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_uG8YjPRYEeuLhpyIdtJzwg")]
    [Description(@"Account number provided in the request is invalid or missing.")]
    IncorrectAccountNumber,

    /// <summary>
    /// Agent identification provided in the request is incorrect
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_uHFicPRYEeuLhpyIdtJzwg")]
    [Description(@"Agent identification provided in the request is incorrect")]
    IncorrectAgent,

    /// <summary>
    /// Request is a duplicate of another request
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_uHFic_RYEeuLhpyIdtJzwg")]
    [Description(@"Request is a duplicate of another request")]
    DuplicateRequest,
}
