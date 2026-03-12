// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a collateral.
/// </summary>
[IsoId("_bPnyNaoxEemhJ7JnT2LsoQ")]
[DisplayName("Collateral Matching Criteria")]
public partial record CollateralMatchingCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_bTWboaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Uncollateralised Flag")]
    [IsoXmlTag("UncollsdFlg")]
    public CompareTrueFalseIndicator2? UncollateralisedFlag { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_bTWbo6oxEemhJ7JnT2LsoQ")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    [IsoXmlTag("NetXpsrCollstnInd")]
    public CompareTrueFalseIndicator2? NetExposureCollateralisationIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_bTWbpaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Collateral Value Date")]
    [IsoXmlTag("CollValDt")]
    public CompareDate2? CollateralValueDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the infromation on the component type is matching or not.
    /// </summary>
    [IsoId("_bTWbqaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public SecurityCommodityCash1? ComponentType { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as security identification are matching or not.
    /// </summary>
    [IsoId("_bTWbyaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Basket Identifier")]
    [IsoXmlTag("BsktIdr")]
    public CompareSecurityIdentification2? BasketIdentifier { get; init; } 
    
    
    #nullable disable
    
}
