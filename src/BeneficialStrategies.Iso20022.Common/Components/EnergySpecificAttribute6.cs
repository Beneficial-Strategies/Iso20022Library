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
[IsoId("_b-a7sZjgEeqkLZLH6DK3UQ")]
[DisplayName("Energy Specific Attribute")]
public record EnergySpecificAttribute6
{
    /// <summary>
    /// Indicates the delivery point(s) of market area(s) for energy derivative contracts.
    /// </summary>
    [IsoId("_b-3noZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Point Or Zone")]
    [IsoXmlTag("DlvryPtOrZone")]
    public ValueList<DeliveryInterconnectionPoint1Choice_> DeliveryPointOrZone { get; init; } = [];

    /// <summary>
    /// Identification of the border(s) or border point(s) of a transportation contract.
    /// </summary>
    [IsoId("_b-3no5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Inter Connection Point")]
    [IsoXmlTag("IntrCnnctnPt")]
    public DeliveryInterconnectionPoint1Choice_? InterConnectionPoint { get; init; }

    /// <summary>
    /// Identification of the delivery profile.
    /// </summary>
    [IsoId("_b-3npZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Load Type")]
    [IsoXmlTag("LdTp")]
    public EnergyLoadType1Code? LoadType { get; init; }

    /// <summary>
    /// Attributes related to delivery of derivative contracts.
    /// </summary>
    [IsoId("_b-3np5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Attribute")]
    [IsoXmlTag("DlvryAttr")]
    public ValueList<EnergyDeliveryAttribute5> DeliveryAttribute { get; init; } = [];
}
