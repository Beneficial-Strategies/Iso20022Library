// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of structured securities product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tIOpsNAKEeuSBa1PsnseFg")]
[Description(@"Specifies the category of structured securities product.")]
[DerivedFrom(typeof(ESGCategoryGermanStructuredSecuritiesMarketCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ESGCategoryGermanStructuredSecuritiesMarket1Code>))]
#endif
public enum ESGCategoryGermanStructuredSecuritiesMarket1Code
{
    /// <summary>
    /// Netural or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_v07ggdAKEeuSBa1PsnseFg")]
    [Description(@"Netural or has no impact.")]
    Neutral = ESGCategoryGermanStructuredSecuritiesMarketCode.Neutral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).
    /// Encoded/decoded by serializers as &quot;IMPS&quot;.
    /// </summary>
    [EnumMember(Value = "IMPS")]
    [IsoId("_v7CvkdAKEeuSBa1PsnseFg")]
    [Description(
        @"Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards)."
    )]
    ImpactSS = ESGCategoryGermanStructuredSecuritiesMarketCode.ImpactSS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Product manufacturer attains at least with one rating agency the status of a sustainable company.
    /// Encoded/decoded by serializers as &quot;ESGS&quot;.
    /// </summary>
    [EnumMember(Value = "ESGS")]
    [IsoId("_v_9r0dAKEeuSBa1PsnseFg")]
    [Description(
        @"Product manufacturer attains at least with one rating agency the status of a sustainable company."
    )]
    ESGStrategySS = ESGCategoryGermanStructuredSecuritiesMarketCode.ESGStrategySS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.
    /// Encoded/decoded by serializers as &quot;BASS&quot;.
    /// </summary>
    [EnumMember(Value = "BASS")]
    [IsoId("_wHHcsdAKEeuSBa1PsnseFg")]
    [Description(
        @"Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard."
    )]
    BasicCategorySS = ESGCategoryGermanStructuredSecuritiesMarketCode.BasicCategorySS, // same ordinal as derivation source for type conversions
}
