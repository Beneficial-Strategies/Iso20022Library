// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rank of an element (party, market) in a specific environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_luIM4C1hEeGp2Zpvgj9Dtw_108025912")]
[Description(@"Specifies the rank of an element (party, market) in a specific environment.")]
[Derivations(typeof(Rank1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RankCode>))]
#endif
public enum RankCode
{
    /// <summary>
    /// Element is the primary one.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_vYs0wC1hEeGp2Zpvgj9Dtw_-405919000")]
    [Description(@"Element is the primary one.")]
    Primary,

    /// <summary>
    /// Element is the primary one.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_vYs0wS1hEeGp2Zpvgj9Dtw_-1963655238")]
    [Description(@"Element is the primary one.")]
    Secondary,
}
