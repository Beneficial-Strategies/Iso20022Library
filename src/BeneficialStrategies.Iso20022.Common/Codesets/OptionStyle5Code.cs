// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how an option is exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZHDZgMRyEeOg-a7zWL_U0A")]
[Description(@"Specifies how an option is exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle5Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_bD4SkcRyEeOg-a7zWL_U0A")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_bJTlIcRyEeOg-a7zWL_U0A")]
    [Description(
        @"Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time."
    )]
    Asian = OptionStyleCode.Asian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_bOhcUcRyEeOg-a7zWL_U0A")]
    [Description(
        @"Option that can be exercised on multiple discrete dates prior to, or on expiry date."
    )]
    Bermudan = OptionStyleCode.Bermudan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_bVkfgcRyEeOg-a7zWL_U0A")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions
}
