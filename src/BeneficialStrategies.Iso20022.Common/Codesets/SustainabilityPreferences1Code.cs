// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the product is compatible with investors that have sustainability preferences.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DdXhIM0VEeuAE-cYsQdwHQ")]
[Description(
    @"Specifies whether the product is compatible with investors that have sustainability preferences."
)]
[DerivedFrom(typeof(SustainabilityPreferencesCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SustainabilityPreferences1Code>))]
#endif
public enum SustainabilityPreferences1Code
{
    /// <summary>
    /// Preference for products having environmental, social and corporate governance (ESG) characteristics.
    /// Encoded/decoded by serializers as &quot;CESG&quot;.
    /// </summary>
    [EnumMember(Value = "CESG")]
    [IsoId("_MmV30c0VEeuAE-cYsQdwHQ")]
    [Description(
        @"Preference for products having environmental, social and corporate governance (ESG) characteristics."
    )]
    ESGPreference = SustainabilityPreferencesCode.ESGPreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_MyNwoc0VEeuAE-cYsQdwHQ")]
    [Description(@"Neutral or has no impact.")]
    Neutral = SustainabilityPreferencesCode.Neutral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preference for products having sustainable objectives.
    /// Encoded/decoded by serializers as &quot;OSUS&quot;.
    /// </summary>
    [EnumMember(Value = "OSUS")]
    [IsoId("_M6uzcc0VEeuAE-cYsQdwHQ")]
    [Description(@"Preference for products having sustainable objectives.")]
    SustainablePreference = SustainabilityPreferencesCode.SustainablePreference, // same ordinal as derivation source for type conversions
}
