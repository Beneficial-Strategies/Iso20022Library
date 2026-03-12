// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the shipment date, the charges, the routing and the goods described in the transport document.
/// </summary>
[IsoId("_Eb4JodQtEeK0PPbKncCqzA")]
[DisplayName("Transport Details")]
public partial record TransportDetails3
{
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying transport document.
    /// </summary>
    [IsoId("_E3H7M9QtEeK0PPbKncCqzA")]
    [DisplayName("Transport Document Reference")]
    [IsoXmlTag("TrnsprtDocRef")]
    public ValueList<DocumentIdentification7> TransportDocumentReference { get; init; } = new ValueList<DocumentIdentification7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _E3H7M9QtEeK0PPbKncCqzA
    
    /// <summary>
    /// Goods that are transported.
    /// </summary>
    [IsoId("_E3H7NdQtEeK0PPbKncCqzA")]
    [DisplayName("Transported Goods")]
    [IsoXmlTag("TrnsprtdGoods")]
    public ValueList<TransportedGoods1> TransportedGoods { get; init; } = new ValueList<TransportedGoods1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _E3H7NdQtEeK0PPbKncCqzA
    
    /// <summary>
    /// Physical packaging of goods for transport.
    /// </summary>
    [IsoId("_E3H7N9QtEeK0PPbKncCqzA")]
    [DisplayName("Consignment")]
    [IsoXmlTag("Consgnmt")]
    public Consignment3? Consignment { get; init; } 
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_E3H7OdQtEeK0PPbKncCqzA")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public required TransportMeans4 RoutingSummary { get; init; } 
    
    /// <summary>
    /// Shipment date, actual or proposed.
    /// </summary>
    [IsoId("_FewXQDAUEeOKib24wnHaFg")]
    [DisplayName("Shipment Date")]
    [IsoXmlTag("ShipmntDt")]
    public required ShipmentDate1Choice_ ShipmentDate { get; init; } 
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_E3H7QdQtEeK0PPbKncCqzA")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge25? FreightCharges { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_E3H7P9QtEeK0PPbKncCqzA")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; } 
    
    
    #nullable disable
    
}
