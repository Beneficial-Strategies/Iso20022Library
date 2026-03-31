// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how an option for a derivative or securities derivative can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VUJB0ED8EeW1yage4PQ__A")]
[Description(
    @"Specifies how an option for a derivative or securities derivative can be exercised."
)]
[DerivedFrom(typeof(OptionStyleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionStyle7Code>))]
#endif
public enum OptionStyle7Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_b6m_gUD8EeW1yage4PQ__A")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_b_th8UD8EeW1yage4PQ__A")]
    [Description(
        @"Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time."
    )]
    Asian = OptionStyleCode.Asian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_cIaK8UD8EeW1yage4PQ__A")]
    [Description(
        @"Option that can be exercised on multiple discrete dates prior to, or on expiry date."
    )]
    Bermudan = OptionStyleCode.Bermudan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_cPlJ8UD8EeW1yage4PQ__A")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of option style.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_cTFw8UD8EeW1yage4PQ__A")]
    [Description(@"Other type of option style.")]
    Other = OptionStyleCode.Other, // same ordinal as derivation source for type conversions
}
