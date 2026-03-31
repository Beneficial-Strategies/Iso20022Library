// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the holding is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lwDTkxKfEeKj15WxqwlXPw")]
[Description(@"Specifies how the holding is blocked.")]
[Derivations(typeof(Holding1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<HoldingCode>))]
#endif
public enum HoldingCode
{
    /// <summary>
    /// Partial holding.
    /// Encoded/decoded by serializers as &quot;PRTH&quot;.
    /// </summary>
    [EnumMember(Value = "PRTH")]
    [IsoId("_qyrf8BKfEeKj15WxqwlXPw")]
    [Description(@"Partial holding.")]
    PartialHolding,

    /// <summary>
    /// Non partial holding.
    /// Encoded/decoded by serializers as &quot;NPRH&quot;.
    /// </summary>
    [EnumMember(Value = "NPRH")]
    [IsoId("_q7nZgBKfEeKj15WxqwlXPw")]
    [Description(@"Non partial holding.")]
    NonPartialHolding,

    /// <summary>
    /// Certificate.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_5Y4UUBKfEeKj15WxqwlXPw")]
    [Description(@"Certificate.")]
    Certificate,
}
