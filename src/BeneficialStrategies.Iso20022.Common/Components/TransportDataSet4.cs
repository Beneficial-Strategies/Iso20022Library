// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the transportation of goods that are part of a commercial trade agreement.
/// </summary>
[IsoId("_LhNqEdQsEeK0PPbKncCqzA")]
[DisplayName("Transport Data Set")]
public record TransportDataSet4
{
    /// <summary>
    /// Identifies the submitted transport data set.
    /// </summary>
    [IsoId("_L8aYUdQsEeK0PPbKncCqzA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; }

    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_L8aYU9QsEeK0PPbKncCqzA")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification26? Buyer { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_L8aYVdQsEeK0PPbKncCqzA")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PartyIdentification26? Seller { get; init; }

    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_L8a_YdQsEeK0PPbKncCqzA")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public required PartyIdentification26 Consignor { get; init; }

    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_L8a_Y9QsEeK0PPbKncCqzA")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; }

    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_L8a_ZdQsEeK0PPbKncCqzA")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public PartyIdentification26? ShipTo { get; init; }

    /// <summary>
    /// Specifies the shipment date, the charges, the routing and the goods that are described in the transport document.
    /// </summary>
    [IsoId("_L8a_Z9QsEeK0PPbKncCqzA")]
    [DisplayName("Transport Information")]
    [IsoXmlTag("TrnsprtInf")]
    public required TransportDetails3 TransportInformation { get; init; }
}
