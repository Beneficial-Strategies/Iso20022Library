// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation details for the cash position.
/// </summary>
[IsoId("_LuJTafGMEei2UYJ62ws-Fw")]
[DisplayName("Valuations Details")]
public partial record ValuationsDetails2
{
    #nullable enable
    
    /// <summary>
    /// Securities collateral position valuation amounts.
    /// </summary>
    [IsoId("_LuJTcfGMEei2UYJ62ws-Fw")]
    [DisplayName("Valuation Details Amount")]
    [IsoXmlTag("ValtnDtlsAmt")]
    public ValueList<CollateralAmount9> ValuationDetailsAmount { get; init; } = [];
    // ID for the above is _LuJTcfGMEei2UYJ62ws-Fw
    
    /// <summary>
    /// Haircut or margin on the security  expressed as a percentage.
    /// </summary>
    [IsoId("_ZyuksTYnEeuD7rm9md9zvg")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate Haircut { get; init; } 
    
    
    #nullable disable
    
}
