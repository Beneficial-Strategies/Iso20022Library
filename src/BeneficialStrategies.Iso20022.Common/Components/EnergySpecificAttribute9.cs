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
[IsoId("_d_O8oQzwEe2YoLD-1vFj0g")]
[DisplayName("Energy Specific Attribute")]
public record EnergySpecificAttribute9
{
    /// <summary>
    /// Indicates the delivery point(s) of market area(s) for energy derivative contracts.
    /// </summary>
    [IsoId("_eAuKYQzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Point Or Zone")]
    [IsoXmlTag("DlvryPtOrZone")]
    public ValueList<DeliveryInterconnectionPoint1Choice_> DeliveryPointOrZone { get; init; } = [];

    /// <summary>
    /// Identification of the border(s) or border point(s) of a transportation contract.
    /// </summary>
    [IsoId("_eAuKYwzwEe2YoLD-1vFj0g")]
    [DisplayName("Inter Connection Point")]
    [IsoXmlTag("IntrCnnctnPt")]
    public DeliveryInterconnectionPoint1Choice_? InterConnectionPoint { get; init; }

    /// <summary>
    /// Identification of the delivery profile.
    /// </summary>
    [IsoId("_eAuKZQzwEe2YoLD-1vFj0g")]
    [DisplayName("Load Type")]
    [IsoXmlTag("LdTp")]
    public EnergyLoadType1Code? LoadType { get; init; }

    /// <summary>
    /// Attributes related to delivery of derivative contracts.
    /// </summary>
    [IsoId("_eAuKZwzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Attribute")]
    [IsoXmlTag("DlvryAttr")]
    public ValueList<EnergyDeliveryAttribute10> DeliveryAttribute { get; init; } = [];
}
