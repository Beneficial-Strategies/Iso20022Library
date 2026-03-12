// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Possible valuation factors.
/// </summary>
[IsoId("_Lh2DkDYoEeuD7rm9md9zvg")]
[DisplayName("Valuation Factor Breakdown")]
public partial record ValuationFactorBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Aggregated adjustment applied on the liability/collateral to calculate the position. It is the sum of the inflation, the haircut/margin and pool factors.
    /// </summary>
    [IsoId("_wQR6YTYoEeuD7rm9md9zvg")]
    [DisplayName("Valuation Factor")]
    [IsoXmlTag("ValtnFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ValuationFactor { get; init; } 
    
    /// <summary>
    /// Adjustment related to inflation applied on the liability/collateral to calculate the position. 
    /// </summary>
    [IsoId("_w_l3cTYoEeuD7rm9md9zvg")]
    [DisplayName("Inflation Factor")]
    [IsoXmlTag("InfltnFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? InflationFactor { get; init; } 
    
    /// <summary>
    /// Haircut or margin on the security  expressed as a percentage.
    /// </summary>
    [IsoId("_xxRzETYoEeuD7rm9md9zvg")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? Haircut { get; init; } 
    
    /// <summary>
    /// Percentage that applies to price of the securities following a redemption.
    /// </summary>
    [IsoId("_yzoA4TYoEeuD7rm9md9zvg")]
    [DisplayName("Pool Factor")]
    [IsoXmlTag("PoolFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? PoolFactor { get; init; } 
    
    
    #nullable disable
    
}
