// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial product is in scope of a target market parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t_HHUNdjEeibyvRfU9vJ7w")]
[Description(@"Specifies whether a financial product is in scope of a target market parameter.")]
[DerivedFrom(typeof(TargetMarketCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TargetMarket2Code>))]
#endif
public enum TargetMarket2Code
{
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_w63t0ddjEeibyvRfU9vJ7w")]
    [Description(@"Neutral or has no impact.")]
    Neutral = TargetMarketCode.Neutral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_xEinMddjEeibyvRfU9vJ7w")]
    [Description(@"Yes, is applicable.")]
    InScope = TargetMarketCode.InScope, // same ordinal as derivation source for type conversions
}
