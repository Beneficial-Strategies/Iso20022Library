// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Basic valuation details of a collateral position.
/// </summary>
[IsoId("_UAL1-dp-Ed-ak6NoX_4Aeg_-606746879")]
[DisplayName("Basic Collateral Valuation 1 Details")]
public partial record BasicCollateralValuation1Details
{
    #nullable enable
    
    /// <summary>
    /// Haircut percentage applied to the market value of underlying assets used as collateral as a risk control measure. The institution valuating the collateral calculates the value of underlying assets based on its market value less a certain percentage (the haircut).
    /// </summary>
    [IsoId("_UAL1-tp-Ed-ak6NoX_4Aeg_-606746854")]
    [DisplayName("Valuation Haircut")]
    [IsoXmlTag("ValtnHrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ValuationHaircut { get; init; } 
    
    /// <summary>
    /// Place where the valuation haircut was calculated.
    /// </summary>
    [IsoId("_UAVm8Np-Ed-ak6NoX_4Aeg_-606746837")]
    [DisplayName("Haircut Source")]
    [IsoXmlTag("HrcutSrc")]
    public PartyIdentification15? HaircutSource { get; init; } 
    
    
    #nullable disable
    
}
