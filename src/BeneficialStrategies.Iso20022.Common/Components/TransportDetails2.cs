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
[IsoId("_Ste39tp-Ed-ak6NoX_4Aeg_-1923970939")]
[DisplayName("Transport Details")]
public partial record TransportDetails2
{
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying transport document.
    /// </summary>
    [IsoId("_Ste399p-Ed-ak6NoX_4Aeg_-1923970514")]
    [DisplayName("Transport Document Reference")]
    [IsoXmlTag("TrnsprtDocRef")]
    public ValueList<DocumentIdentification7> TransportDocumentReference { get; init; } = new ValueList<DocumentIdentification7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Ste399p-Ed-ak6NoX_4Aeg_-1923970514
    
    /// <summary>
    /// Goods that are transported.
    /// </summary>
    [IsoId("_Ste3-Np-Ed-ak6NoX_4Aeg_-1923969895")]
    [DisplayName("Transported Goods")]
    [IsoXmlTag("TrnsprtdGoods")]
    public ValueList<TransportedGoods1> TransportedGoods { get; init; } = new ValueList<TransportedGoods1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Ste3-Np-Ed-ak6NoX_4Aeg_-1923969895
    
    /// <summary>
    /// Physical packaging of goods for transport.
    /// </summary>
    [IsoId("_Ste3-dp-Ed-ak6NoX_4Aeg_-492454414")]
    [DisplayName("Consignment")]
    [IsoXmlTag("Consgnmt")]
    public Consignment1? Consignment { get; init; } 
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_Stoo8Np-Ed-ak6NoX_4Aeg_-1923970164")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public required TransportMeans2 RoutingSummary { get; init; } 
    
    /// <summary>
    /// Proposed date on which the goods should be shipped.
    /// </summary>
    [IsoId("_Stoo8dp-Ed-ak6NoX_4Aeg_-1923970904")]
    [DisplayName("Proposed Shipment Date")]
    [IsoXmlTag("PropsdShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ProposedShipmentDate { get; init; } 
    
    /// <summary>
    /// Actual date whereby the goods were shipped.
    /// </summary>
    [IsoId("_Stoo8tp-Ed-ak6NoX_4Aeg_-1923970627")]
    [DisplayName("Actual Shipment Date")]
    [IsoXmlTag("ActlShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ActualShipmentDate { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_Stoo89p-Ed-ak6NoX_4Aeg_-1923970093")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms2? Incoterms { get; init; } 
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_Stoo9Np-Ed-ak6NoX_4Aeg_-1923969990")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge13? FreightCharges { get; init; } 
    
    
    #nullable disable
    
}
