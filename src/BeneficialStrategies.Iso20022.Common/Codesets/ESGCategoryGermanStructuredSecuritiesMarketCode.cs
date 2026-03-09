// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of structured securities product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qiEvsM2tEeuAE-cYsQdwHQ")]
[Description(@"Specifies the category of structured securities product.")]
[Derivations(typeof(ESGCategoryGermanStructuredSecuritiesMarket1Code))]
public enum ESGCategoryGermanStructuredSecuritiesMarketCode
{
    /// <summary>
    /// Netural or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_ysRxAM2tEeuAE-cYsQdwHQ")]
    [Description(@"Netural or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.
    /// Encoded/decoded by serializers as &quot;BASS&quot;.
    /// </summary>
    [EnumMember(Value = "BASS")]
    [IsoId("_4WMm4M2tEeuAE-cYsQdwHQ")]
    [Description(@"Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.")]
    BasicCategorySS,
    
    /// <summary>
    /// Product manufacturer attains at least with one rating agency the status of a sustainable company.
    /// Encoded/decoded by serializers as &quot;ESGS&quot;.
    /// </summary>
    [EnumMember(Value = "ESGS")]
    [IsoId("_AdHDoM2uEeuAE-cYsQdwHQ")]
    [Description(@"Product manufacturer attains at least with one rating agency the status of a sustainable company.")]
    ESGStrategySS,
    
    /// <summary>
    /// Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).
    /// Encoded/decoded by serializers as &quot;IMPS&quot;.
    /// </summary>
    [EnumMember(Value = "IMPS")]
    [IsoId("_GGaOcM2uEeuAE-cYsQdwHQ")]
    [Description(@"Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).")]
    ImpactSS,
    
}
