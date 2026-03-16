// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies how the supply chain shipping arrangements and the delivery of products and/or services as well as related documentation.
/// </summary>
[IsoId("_S5CHjgEcEeCQm6a_G2yO_w_-1855522854")]
[DisplayName("Trade Delivery")]
public record TradeDelivery1
{
    /// <summary>
    /// Actual delivery period of the products and/or services.
    /// </summary>
    [IsoId("_S5CHjwEcEeCQm6a_G2yO_w_570290002")]
    [DisplayName("Delivery Period")]
    [IsoXmlTag("DlvryPrd")]
    public Period1? DeliveryPeriod { get; init; }

    /// <summary>
    /// Actual delivery date/time of the products and/or services.
    /// </summary>
    [IsoId("_S5CHkAEcEeCQm6a_G2yO_w_2097470377")]
    [DisplayName("Delivery Date Time")]
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeliveryDateTime { get; init; }

    /// <summary>
    /// Party from whom the goods are dispatched.
    /// </summary>
    [IsoId("_S5CHkQEcEeCQm6a_G2yO_w_2113237791")]
    [DisplayName("Ship From")]
    [IsoXmlTag("ShipFr")]
    public TradeParty1? ShipFrom { get; init; }

    /// <summary>
    /// Party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_S5CHkgEcEeCQm6a_G2yO_w_-667544958")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public TradeParty1? ShipTo { get; init; }

    /// <summary>
    /// Final party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_S5LRYAEcEeCQm6a_G2yO_w_-645018365")]
    [DisplayName("Ultimate Ship To")]
    [IsoXmlTag("UltmtShipTo")]
    public TradeParty1? UltimateShipTo { get; init; }

    /// <summary>
    /// Delivery note related to the delivery of the products and/or services.
    /// </summary>
    [IsoId("_S5LRYQEcEeCQm6a_G2yO_w_1101392956")]
    [DisplayName("Delivery Note")]
    [IsoXmlTag("DlvryNote")]
    public DocumentIdentification22? DeliveryNote { get; init; }

    /// <summary>
    /// Physical consolidation of goods for transport.
    /// </summary>
    [IsoId("_S5LRYgEcEeCQm6a_G2yO_w_-3919121")]
    [DisplayName("Consignment")]
    [IsoXmlTag("Consgnmt")]
    public ValueList<Consignment2> Consignment { get; init; } = [];
}
