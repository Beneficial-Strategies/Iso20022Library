// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details for a freight commodity.
/// </summary>
[IsoId("_zwLKxWlHEeaLAKoEUNsD9g")]
[DisplayName("Commodity Derivate")]
public partial record CommodityDerivate5
{
    #nullable enable
    
    /// <summary>
    /// Specification of the size related to the freight sub type. Field to be populated when the base product field is equal to freight.
    /// </summary>
    [IsoId("_z5EBAWlHEeaLAKoEUNsD9g")]
    [DisplayName("Size")]
    [IsoXmlTag("Sz")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    public required IsoMax25Text Size { get; init; } 
    
    /// <summary>
    /// Details the specific route or time charter average. Field to be populated when the base product field is equal to freight.
    /// </summary>
    [IsoId("_z5EBA2lHEeaLAKoEUNsD9g")]
    [DisplayName("Average Time Charter")]
    [IsoXmlTag("AvrgTmChrtr")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    public required IsoMax25Text AverageTimeCharter { get; init; } 
    
    
    #nullable disable
    
}
