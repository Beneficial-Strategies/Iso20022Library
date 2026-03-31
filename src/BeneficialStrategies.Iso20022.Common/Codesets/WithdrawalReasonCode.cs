// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason that an alleged trade is withdrawn.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1vTlA5EkEeKcLcxonNWTXg")]
[Description(@"Specifies the reason that an alleged trade is withdrawn.")]
[Derivations(typeof(WithdrawalReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<WithdrawalReasonCode>))]
#endif
public enum WithdrawalReasonCode
{
    /// <summary>
    /// Alleged trade is rescinded.
    /// Encoded/decoded by serializers as &quot;RSCD&quot;.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_N4ADUJElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is rescinded.")]
    Rescinded,

    /// <summary>
    /// Alleged trade is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_OBsK0JElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is rejected.")]
    Rejected,

    /// <summary>
    /// Alleged trade is withdrawn due to an amendment.
    /// Encoded/decoded by serializers as &quot;WTDN&quot;.
    /// </summary>
    [EnumMember(Value = "WTDN")]
    [IsoId("_OKLYcJElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is withdrawn due to an amendment.")]
    Withdrawn,
}
