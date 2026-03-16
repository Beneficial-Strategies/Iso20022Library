// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Asset Holding3.
/// </summary>
[IsoId("_EuGbEZh6EeyJwbhKOp9Ehg")]
[DisplayName("Asset Holding3")]
public partial record AssetHolding3
{
    #nullable enable

    /// <summary>
    /// Asset Type.
    /// </summary>
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public required AssetHolding3Choice_ AssetType { get; init; } 

    /// <summary>
    /// Collateral Requirement.
    /// </summary>
    [DisplayName("Collateral Requirement")]
    [IsoXmlTag("CollRqrmnt")]
    public required CollateralAccountType3Code CollateralRequirement { get; init; } 

    /// <summary>
    /// Post Haircut Value.
    /// </summary>
    [DisplayName("Post Haircut Value")]
    [IsoXmlTag("PstHrcutVal")]
    public required ActiveCurrencyAnd24Amount PostHaircutValue { get; init; } 

    
    #nullable disable
    
}
