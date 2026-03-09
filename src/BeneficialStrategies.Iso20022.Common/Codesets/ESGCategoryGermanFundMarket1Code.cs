// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of fund product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FFM6IM6gEeuxwOWq_hqWVg")]
[Description(@"Specifies the category of fund product.")]
[DerivedFrom(typeof(ESGCategoryGermanFundMarketCode))]
public enum ESGCategoryGermanFundMarket1Code
{
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_dI3ugM6gEeuxwOWq_hqWVg")]
    [Description(@"Neutral or has no impact.")]
    Neutral = ESGCategoryGermanFundMarketCode.Neutral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product with impact-related investment (pursuant to Article 9 Disclosure Regulation):
    /// - No serious breach of the United Nations Global Compact (UNGC);
    /// - Relevant for both individual products and those in a portfolio/basket (shares/bonds);
    /// - Product manager follows a recognised industry standard (UN PRI).
    /// Encoded/decoded by serializers as &quot;IMPF&quot;.
    /// </summary>
    [EnumMember(Value = "IMPF")]
    [IsoId("_dPWJ8c6gEeuxwOWq_hqWVg")]
    [Description(@"Product with impact-related investment (pursuant to Article 9 Disclosure Regulation):|- No serious breach of the United Nations Global Compact (UNGC);|- Relevant for both individual products and those in a portfolio/basket (shares/bonds);|- Product manager follows a recognised industry standard (UN PRI).")]
    Impact = ESGCategoryGermanFundMarketCode.Impact, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product with a dedicated environmental, social and corporate governance (ESG) strategy (pursuant to Article 8 Disclosure Regulation).
    /// Encoded/decoded by serializers as &quot;ESGF&quot;.
    /// </summary>
    [EnumMember(Value = "ESGF")]
    [IsoId("_dVM6Uc6gEeuxwOWq_hqWVg")]
    [Description(@"Product with a dedicated environmental, social and corporate governance (ESG) strategy (pursuant to Article 8 Disclosure Regulation).")]
    ESGStrategy = ESGCategoryGermanFundMarketCode.ESGStrategy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product having environmental, social and corporate governance (ESG) characteristics, opportunities or risks according to the &quot;ESG integration enhanced&quot; criteria.
    /// Product integration approach is disclosed and the product manager follows a recognised industry standard (UN PRI).
    /// Encoded/decoded by serializers as &quot;BASF&quot;.
    /// </summary>
    [EnumMember(Value = "BASF")]
    [IsoId("_dbS7Qc6gEeuxwOWq_hqWVg")]
    [Description(@"Product having environmental, social and corporate governance (ESG) characteristics, opportunities or risks according to the ""ESG integration enhanced"" criteria.|Product integration approach is disclosed and the product manager follows a recognised industry standard (UN PRI).")]
    BasicCategory = ESGCategoryGermanFundMarketCode.BasicCategory, // same ordinal as derivation source for type conversions
    
}
