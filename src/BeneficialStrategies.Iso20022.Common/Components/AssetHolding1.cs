// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Holding of a financial asset as collateral.
/// </summary>
[IsoId("_4DvF8K_5EeaE9YROwd69hA")]
[DisplayName("Asset Holding")]
public partial record AssetHolding1
{
    #nullable enable
    
    /// <summary>
    /// Mark-to-market post-haircut value of the collateral asset holding.
    /// </summary>
    [IsoId("_bH-r0K_6EeaE9YROwd69hA")]
    [DisplayName("Post Haircut Value")]
    [IsoXmlTag("PstHrcutVal")]
    public required ActiveCurrencyAnd24Amount PostHaircutValue { get; init; } 
    
    /// <summary>
    /// Specifies financial instrument pledged as collateral.
    /// </summary>
    [IsoId("_BrEMkK_6EeaE9YROwd69hA")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public required AssetHolding1Choice_ AssetType { get; init; } 
    
    /// <summary>
    /// Identifies whether collateral relates to default fund requirements or initial margin requirements.
    /// </summary>
    [IsoId("_6pTkAbbeEeaqL_M7XFD7PQ")]
    [DisplayName("Collateral Requirement")]
    [IsoXmlTag("CollRqrmnt")]
    public required CollateralAccountType3Code CollateralRequirement { get; init; } 
    
    
    #nullable disable
    
}
