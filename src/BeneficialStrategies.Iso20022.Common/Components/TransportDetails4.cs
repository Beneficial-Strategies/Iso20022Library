// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the shipment date, the charges, the routing and the goods described in the transport document.
/// </summary>
[IsoId("_2ZcofzckEeSaC-PiOaz_KQ")]
[DisplayName("Transport Details")]
public record TransportDetails4
{
    /// <summary>
    /// Reference to the identification of the underlying transport document.
    /// </summary>
    [IsoId("_2vnswTckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport Document Reference")]
    [IsoXmlTag("TrnsprtDocRef")]
    public ValueList<DocumentIdentification7> TransportDocumentReference { get; init; } = [];

    // ID for the above is _2vnswTckEeSaC-PiOaz_KQ

    /// <summary>
    /// Goods that are transported.
    /// </summary>
    [IsoId("_2vnswzckEeSaC-PiOaz_KQ")]
    [DisplayName("Transported Goods")]
    [IsoXmlTag("TrnsprtdGoods")]
    public ValueList<TransportedGoods1> TransportedGoods { get; init; } = [];

    // ID for the above is _2vnswzckEeSaC-PiOaz_KQ

    /// <summary>
    /// Physical packaging of goods for transport.
    /// </summary>
    [IsoId("_2vnsxTckEeSaC-PiOaz_KQ")]
    [DisplayName("Consignment")]
    [IsoXmlTag("Consgnmt")]
    public Consignment3? Consignment { get; init; }

    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_2vnsxzckEeSaC-PiOaz_KQ")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public required TransportMeans6 RoutingSummary { get; init; }

    /// <summary>
    /// Shipment date, actual or proposed.
    /// </summary>
    [IsoId("_2vnsyTckEeSaC-PiOaz_KQ")]
    [DisplayName("Shipment Date")]
    [IsoXmlTag("ShipmntDt")]
    public required ShipmentDate1Choice_ ShipmentDate { get; init; }

    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_2vnsyzckEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge25? FreightCharges { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_2vnszTckEeSaC-PiOaz_KQ")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; }
}
