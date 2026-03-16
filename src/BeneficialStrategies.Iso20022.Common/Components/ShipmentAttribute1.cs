// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further details on the shipment conditions.
/// </summary>
[IsoId("_wGRaAdM_EeSDLevdaFPXHw")]
[DisplayName("Shipment Attribute")]
public record ShipmentAttribute1
{
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
}
