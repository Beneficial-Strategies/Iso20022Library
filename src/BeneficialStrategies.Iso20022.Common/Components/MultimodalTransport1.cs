// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to multimodal transportation of goods.
/// </summary>
[IsoId("_U7C7ttp-Ed-ak6NoX_4Aeg_1362405173")]
[DisplayName("Multimodal Transport")]
public partial record MultimodalTransport1
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_U7C7t9p-Ed-ak6NoX_4Aeg_707023270")]
    [DisplayName("Departure Airport")]
    [IsoXmlTag("DprtureAirprt")]
    public AirportName1Choice_? DepartureAirport { get; init; } 
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_U7C7uNp-Ed-ak6NoX_4Aeg_696865440")]
    [DisplayName("Destination Airport")]
    [IsoXmlTag("DstnAirprt")]
    public AirportName1Choice_? DestinationAirport { get; init; } 
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_U7C7udp-Ed-ak6NoX_4Aeg_1824419961")]
    [DisplayName("Port Of Loading")]
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PortOfLoading { get; init; } 
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_U7C7utp-Ed-ak6NoX_4Aeg_1824419670")]
    [DisplayName("Port Of Discharge")]
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PortOfDischarge { get; init; } 
    
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_U7MssNp-Ed-ak6NoX_4Aeg_-2012481632")]
    [DisplayName("Place Of Receipt")]
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PlaceOfReceipt { get; init; } 
    
    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_U7Mssdp-Ed-ak6NoX_4Aeg_-2012481657")]
    [DisplayName("Place Of Delivery")]
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PlaceOfDelivery { get; init; } 
    
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    [IsoId("_U7Msstp-Ed-ak6NoX_4Aeg_-1684632772")]
    [DisplayName("Taking In Charge")]
    [IsoXmlTag("TakngInChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TakingInCharge { get; init; } 
    
    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    [IsoId("_U7Mss9p-Ed-ak6NoX_4Aeg_-1684632807")]
    [DisplayName("Place Of Final Destination")]
    [IsoXmlTag("PlcOfFnlDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PlaceOfFinalDestination { get; init; } 
    
    
    #nullable disable
    
}
