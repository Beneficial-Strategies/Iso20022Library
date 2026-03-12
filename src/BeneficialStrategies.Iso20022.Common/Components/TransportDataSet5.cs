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
[IsoId("_2DIaMTckEeSaC-PiOaz_KQ")]
[DisplayName("Transport Data Set")]
public partial record TransportDataSet5
{
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted transport data set.
    /// </summary>
    [IsoId("_2ZcocTckEeSaC-PiOaz_KQ")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_2ZcoczckEeSaC-PiOaz_KQ")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification26? Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_2ZcodTckEeSaC-PiOaz_KQ")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PartyIdentification26? Seller { get; init; } 
    
    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_2ZcodzckEeSaC-PiOaz_KQ")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public required PartyIdentification26 Consignor { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_2ZcoeTckEeSaC-PiOaz_KQ")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_2ZcoezckEeSaC-PiOaz_KQ")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public PartyIdentification26? ShipTo { get; init; } 
    
    /// <summary>
    /// Specifies the shipment date, the charges, the routing and the goods that are described in the transport document.
    /// </summary>
    [IsoId("_2ZcofTckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport Information")]
    [IsoXmlTag("TrnsprtInf")]
    public required TransportDetails4 TransportInformation { get; init; } 
    
    
    #nullable disable
    
}
