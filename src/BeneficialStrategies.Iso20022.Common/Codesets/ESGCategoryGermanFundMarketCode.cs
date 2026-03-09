// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of fund product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hih3QM2sEeuAE-cYsQdwHQ")]
[Description(@"Specifies the category of fund product.")]
[Derivations(typeof(ESGCategoryGermanFundMarket1Code))]
public enum ESGCategoryGermanFundMarketCode
{
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_mxEYsM2sEeuAE-cYsQdwHQ")]
    [Description(@"Neutral or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Product having environmental, social and corporate governance (ESG) characteristics, opportunities or risks according to the &quot;ESG integration enhanced&quot; criteria.
    /// Product integration approach is disclosed and the product manager follows a recognised industry standard (UN PRI).
    /// Encoded/decoded by serializers as &quot;BASF&quot;.
    /// </summary>
    [EnumMember(Value = "BASF")]
    [IsoId("_q7RvUM2sEeuAE-cYsQdwHQ")]
    [Description(@"Product having environmental, social and corporate governance (ESG) characteristics, opportunities or risks according to the ""ESG integration enhanced"" criteria.|Product integration approach is disclosed and the product manager follows a recognised industry standard (UN PRI).")]
    BasicCategory,
    
    /// <summary>
    /// Product with a dedicated environmental, social and corporate governance (ESG) strategy (pursuant to Article 8 Disclosure Regulation).
    /// Encoded/decoded by serializers as &quot;ESGF&quot;.
    /// </summary>
    [EnumMember(Value = "ESGF")]
    [IsoId("_vk3woM2sEeuAE-cYsQdwHQ")]
    [Description(@"Product with a dedicated environmental, social and corporate governance (ESG) strategy (pursuant to Article 8 Disclosure Regulation).")]
    ESGStrategy,
    
    /// <summary>
    /// Product with impact-related investment (pursuant to Article 9 Disclosure Regulation):
    /// - No serious breach of the United Nations Global Compact (UNGC);
    /// - Relevant for both individual products and those in a portfolio/basket (shares/bonds);
    /// - Product manager follows a recognised industry standard (UN PRI).
    /// Encoded/decoded by serializers as &quot;IMPF&quot;.
    /// </summary>
    [EnumMember(Value = "IMPF")]
    [IsoId("_0MKr4M2sEeuAE-cYsQdwHQ")]
    [Description(@"Product with impact-related investment (pursuant to Article 9 Disclosure Regulation):|- No serious breach of the United Nations Global Compact (UNGC);|- Relevant for both individual products and those in a portfolio/basket (shares/bonds);|- Product manager follows a recognised industry standard (UN PRI).")]
    Impact,
    
}
