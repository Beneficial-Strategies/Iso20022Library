// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards central counterparty.
/// </summary>
[IsoId("_Uk2CN9p-Ed-ak6NoX_4Aeg_1785473393")]
[DisplayName("Variation Margin")]
public partial record VariationMargin2
{
    #nullable enable
    
    /// <summary>
    /// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
    /// </summary>
    [IsoId("_Uk2CONp-Ed-ak6NoX_4Aeg_-292711042")]
    [DisplayName("Total Variation Margin")]
    [IsoXmlTag("TtlVartnMrgn")]
    public ValueList<TotalVariationMargin1> TotalVariationMargin { get; init; } = new ValueList<TotalVariationMargin1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Uk2CONp-Ed-ak6NoX_4Aeg_-292711042
    
    /// <summary>
    /// Net unrealised profit or loss on the value of the netted, gross and failing positions.
    /// </summary>
    [IsoId("_Uk_MINp-Ed-ak6NoX_4Aeg_-514484433")]
    [DisplayName("Total Mark To Market")]
    [IsoXmlTag("TtlMrkToMkt")]
    public required Amount2 TotalMarkToMarket { get; init; } 
    
    /// <summary>
    /// Unrealised net loss calculated at the participant portfolio level.
    /// </summary>
    [IsoId("_Uk_MIdp-Ed-ak6NoX_4Aeg_526741485")]
    [DisplayName("Mark To Market Netted")]
    [IsoXmlTag("MrkToMktNetd")]
    public Amount2? MarkToMarketNetted { get; init; } 
    
    /// <summary>
    /// Unrealised net loss calculated in that market/boundary.
    /// </summary>
    [IsoId("_Uk_MItp-Ed-ak6NoX_4Aeg_-859385259")]
    [DisplayName("Mark To Market Gross")]
    [IsoXmlTag("MrkToMktGrss")]
    public Amount2? MarkToMarketGross { get; init; } 
    
    /// <summary>
    /// Sum of the unrealised loss without taking profit into consideration.
    /// </summary>
    [IsoId("_Uk_MI9p-Ed-ak6NoX_4Aeg_-781100489")]
    [DisplayName("Mark To Market Fails")]
    [IsoXmlTag("MrkToMktFls")]
    public Amount2? MarkToMarketFails { get; init; } 
    
    /// <summary>
    /// Haircut applied to the absolute value of the participants net positions. Calculation depends on a participants credit rating.
    /// </summary>
    [IsoId("_Uk_MJNp-Ed-ak6NoX_4Aeg_1551318789")]
    [DisplayName("Fails Haircut")]
    [IsoXmlTag("FlsHrcut")]
    public required Amount2 FailsHaircut { get; init; } 
    
    
    #nullable disable
    
}
