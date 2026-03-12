// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further details on the shipment conditions.
/// </summary>
[IsoId("_wGRaAdM_EeSDLevdaFPXHw")]
[DisplayName("Shipment Attribute")]
public partial record ShipmentAttribute1
{
    #nullable enable
    
    /// <summary>
    /// Shipment conditions.
    /// </summary>
    [IsoId("_6NKKcNM_EeSDLevdaFPXHw")]
    [DisplayName("Conditions")]
    [IsoXmlTag("Conds")]
    public ExternalShipmentCondition1Code? Conditions { get; init; } 
    
    /// <summary>
    /// Expected shipment date.
    /// </summary>
    [IsoId("_-CyYMNM_EeSDLevdaFPXHw")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedDate { get; init; } 
    
    /// <summary>
    /// Country in which the counter party is located.
    /// </summary>
    [IsoId("_ibf2oNNAEeSDLevdaFPXHw")]
    [DisplayName("Country Of Counter Party")]
    [IsoXmlTag("CtryOfCntrPty")]
    public required CountryCode CountryOfCounterParty { get; init; } 
    
    
    #nullable disable
    
}
