// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the transportation of goods that are part of a commercial trade agreement.
/// </summary>
[IsoId("_StVuB9p-Ed-ak6NoX_4Aeg_1434989448")]
[DisplayName("Transport Data Set")]
public partial record TransportDataSet3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted transport data set.
    /// </summary>
    [IsoId("_StVuCNp-Ed-ak6NoX_4Aeg_1434989481")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Ste38Np-Ed-ak6NoX_4Aeg_1434990214")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification26? Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Ste38dp-Ed-ak6NoX_4Aeg_1434990244")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PartyIdentification26? Seller { get; init; } 
    
    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_Ste38tp-Ed-ak6NoX_4Aeg_-1373071617")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public required PartyIdentification26 Consignor { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_Ste389p-Ed-ak6NoX_4Aeg_1434989843")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_Ste39Np-Ed-ak6NoX_4Aeg_1434989904")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public PartyIdentification26? ShipTo { get; init; } 
    
    /// <summary>
    /// Specifies the shipment date, the charges, the routing and the goods that are described in the transport document.
    /// </summary>
    [IsoId("_Ste39dp-Ed-ak6NoX_4Aeg_1434989758")]
    [DisplayName("Transport Information")]
    [IsoXmlTag("TrnsprtInf")]
    public required TransportDetails2 TransportInformation { get; init; } 
    
    
    #nullable disable
    
}
