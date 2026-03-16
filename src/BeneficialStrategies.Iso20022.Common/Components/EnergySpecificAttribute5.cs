// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of energy related derivatives.
/// </summary>
[IsoId("_FH-ooYeJEei3PYANOK_QWA")]
[DisplayName("Energy Specific Attribute")]
public record EnergySpecificAttribute5
{
    /// <summary>
    /// Indicates the delivery point(s) of market area(s) for energy derivative contracts.
    /// </summary>
    [IsoId("_FU8GkYeJEei3PYANOK_QWA")]
    [DisplayName("Delivery Point Or Zone")]
    [IsoXmlTag("DlvryPtOrZone")]
    public ValueList<DeliveryInterconnectionPoint1Choice_> DeliveryPointOrZone { get; init; } = [];

    /// <summary>
    /// Identification of the border(s) or border point(s) of a transportation contract.
    /// </summary>
    [IsoId("_FU8Gk4eJEei3PYANOK_QWA")]
    [DisplayName("Inter Connection Point")]
    [IsoXmlTag("IntrCnnctnPt")]
    public DeliveryInterconnectionPoint1Choice_? InterConnectionPoint { get; init; }

    /// <summary>
    /// Identification of the delivery profile.
    /// </summary>
    [IsoId("_FU8GlYeJEei3PYANOK_QWA")]
    [DisplayName("Load Type")]
    [IsoXmlTag("LdTp")]
    public EnergyLoadType1Code? LoadType { get; init; }

    /// <summary>
    /// Attributes related to delivery of derivative contracts.
    /// </summary>
    [IsoId("_FU8Gl4eJEei3PYANOK_QWA")]
    [DisplayName("Delivery Attribute")]
    [IsoXmlTag("DlvryAttr")]
    public ValueList<EnergyDeliveryAttribute4> DeliveryAttribute { get; init; } = [];
}
