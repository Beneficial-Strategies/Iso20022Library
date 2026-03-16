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
[IsoId("_2ul9weWhEeevU7McUP3D1w")]
[DisplayName("Trade Delivery")]
public record TradeDelivery3
{
    /// <summary>
    /// Actual delivery period of the products and/or services.
    /// </summary>
    [IsoId("_23eM8eWhEeevU7McUP3D1w")]
    [DisplayName("Delivery Period")]
    [IsoXmlTag("DlvryPrd")]
    public Period14? DeliveryPeriod { get; init; }

    /// <summary>
    /// Actual delivery date/time of the products and/or services.
    /// </summary>
    [IsoId("_23eM8-WhEeevU7McUP3D1w")]
    [DisplayName("Delivery Date Time")]
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeliveryDateTime { get; init; }

    /// <summary>
    /// Party from whom the goods are dispatched.
    /// </summary>
    [IsoId("_23eM9eWhEeevU7McUP3D1w")]
    [DisplayName("Ship From")]
    [IsoXmlTag("ShipFr")]
    public TradeParty4? ShipFrom { get; init; }

    /// <summary>
    /// Party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_23eM9-WhEeevU7McUP3D1w")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public TradeParty4? ShipTo { get; init; }

    /// <summary>
    /// Final party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_23eM-eWhEeevU7McUP3D1w")]
    [DisplayName("Ultimate Ship To")]
    [IsoXmlTag("UltmtShipTo")]
    public TradeParty4? UltimateShipTo { get; init; }

    /// <summary>
    /// Delivery note related to the delivery of the products and/or services.
    /// </summary>
    [IsoId("_23eM--WhEeevU7McUP3D1w")]
    [DisplayName("Delivery Note")]
    [IsoXmlTag("DlvryNote")]
    public DocumentIdentification22? DeliveryNote { get; init; }

    /// <summary>
    /// Physical consolidation of goods for transport.
    /// </summary>
    [IsoId("_23eM_eWhEeevU7McUP3D1w")]
    [DisplayName("Consignment")]
    [IsoXmlTag("Consgnmt")]
    public Consignment5? Consignment { get; init; }
}
