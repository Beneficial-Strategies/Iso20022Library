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
[IsoId("_3kwR0cNSEeWGDrnsYu2p6g")]
[DisplayName("Trade Delivery")]
public record TradeDelivery2
{
    /// <summary>
    /// Actual delivery period of the products and/or services.
    /// </summary>
    [IsoId("_3xZmscNSEeWGDrnsYu2p6g")]
    [DisplayName("Delivery Period")]
    [IsoXmlTag("DlvryPrd")]
    public Period1? DeliveryPeriod { get; init; }

    /// <summary>
    /// Actual delivery date/time of the products and/or services.
    /// </summary>
    [IsoId("_3xZms8NSEeWGDrnsYu2p6g")]
    [DisplayName("Delivery Date Time")]
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeliveryDateTime { get; init; }

    /// <summary>
    /// Party from whom the goods are dispatched.
    /// </summary>
    [IsoId("_3xZmtcNSEeWGDrnsYu2p6g")]
    [DisplayName("Ship From")]
    [IsoXmlTag("ShipFr")]
    public TradeParty3? ShipFrom { get; init; }

    /// <summary>
    /// Party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_3xZmt8NSEeWGDrnsYu2p6g")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public TradeParty3? ShipTo { get; init; }

    /// <summary>
    /// Final party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_3xZmucNSEeWGDrnsYu2p6g")]
    [DisplayName("Ultimate Ship To")]
    [IsoXmlTag("UltmtShipTo")]
    public TradeParty3? UltimateShipTo { get; init; }

    /// <summary>
    /// Delivery note related to the delivery of the products and/or services.
    /// </summary>
    [IsoId("_3xZmu8NSEeWGDrnsYu2p6g")]
    [DisplayName("Delivery Note")]
    [IsoXmlTag("DlvryNote")]
    public DocumentIdentification22? DeliveryNote { get; init; }

    /// <summary>
    /// Physical consolidation of goods for transport.
    /// </summary>
    [IsoId("_3xZmvcNSEeWGDrnsYu2p6g")]
    [DisplayName("Consignment")]
    [IsoXmlTag("Consgnmt")]
    public ValueList<Consignment4> Consignment { get; init; } = [];
}
