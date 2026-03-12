// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransportMeans2Choice
{
    /// <summary>
    /// Specifies the different movements and places and their role in a multimodal conveyance of goods.
    /// </summary>
    [IsoId("_U7oxk9p-Ed-ak6NoX_4Aeg_205481039")]
    [DisplayName("Multimodal Transport")]
    public partial record MultimodalTransport : TransportMeans2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Place from where the goods must leave.
        /// </summary>
        [IsoId("_U7Mstdp-Ed-ak6NoX_4Aeg_296981374")]
        [DisplayName("Departure Airport")]
        [IsoXmlTag("DprtureAirprt")]
        public AirportName1Choice_? DepartureAirport { get; init; } 
        
        /// <summary>
        /// Place where the goods must arrive.
        /// </summary>
        [IsoId("_U7Msttp-Ed-ak6NoX_4Aeg_322836634")]
        [DisplayName("Destination Airport")]
        [IsoXmlTag("DstnAirprt")]
        public AirportName1Choice_? DestinationAirport { get; init; } 
        
        /// <summary>
        /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
        /// </summary>
        [IsoId("_U7Mst9p-Ed-ak6NoX_4Aeg_-1343729756")]
        [DisplayName("Air Carrier Name")]
        [IsoXmlTag("AirCrrierNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? AirCarrierName { get; init; } 
        
        /// <summary>
        /// Identifies the port where the goods are loaded on board the ship.
        /// </summary>
        [IsoId("_U7MsuNp-Ed-ak6NoX_4Aeg_564401895")]
        [DisplayName("Port Of Loading")]
        [IsoXmlTag("PortOfLoadng")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? PortOfLoading { get; init; } 
        
        /// <summary>
        /// Identifies the port where the goods are discharged.
        /// </summary>
        [IsoId("_U7Msudp-Ed-ak6NoX_4Aeg_564401870")]
        [DisplayName("Port Of Discharge")]
        [IsoXmlTag("PortOfDschrge")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? PortOfDischarge { get; init; } 
        
        /// <summary>
        /// Name of a vessel.
        /// </summary>
        [IsoId("_U7V2oNp-Ed-ak6NoX_4Aeg_-1115621713")]
        [DisplayName("Vessel Name")]
        [IsoXmlTag("VsslNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? VesselName { get; init; } 
        
        /// <summary>
        /// Identifies the location where the goods are received for transportation.
        /// </summary>
        [IsoId("_U7V2odp-Ed-ak6NoX_4Aeg_564401852")]
        [DisplayName("Place Of Receipt")]
        [IsoXmlTag("PlcOfRct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? PlaceOfReceipt { get; init; } 
        
        /// <summary>
        /// Identifies the location of delivery of the goods.
        /// </summary>
        [IsoId("_U7V2otp-Ed-ak6NoX_4Aeg_564401583")]
        [DisplayName("Place Of Delivery")]
        [IsoXmlTag("PlcOfDlvry")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? PlaceOfDelivery { get; init; } 
        
        /// <summary>
        /// Identifies the location where the goods are take in charge for transportation.
        /// </summary>
        [IsoId("_U7V2o9p-Ed-ak6NoX_4Aeg_564401912")]
        [DisplayName("Taking In Charge")]
        [IsoXmlTag("TakngInChrg")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TakingInCharge { get; init; } 
        
        /// <summary>
        /// Identifies the location of the final destination of the goods.
        /// </summary>
        [IsoId("_U7V2pNp-Ed-ak6NoX_4Aeg_564401600")]
        [DisplayName("Place Of Final Destination")]
        [IsoXmlTag("PlcOfFnlDstn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? PlaceOfFinalDestination { get; init; } 
        
        /// <summary>
        /// Specifies a place in a country.
        /// </summary>
        [IsoId("_U7V2pdp-Ed-ak6NoX_4Aeg_1426049424")]
        [DisplayName("Transit Location")]
        [IsoXmlTag("TrnstLctn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TransitLocation { get; init; } 
        
        /// <summary>
        /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
        /// </summary>
        [IsoId("_U7V2ptp-Ed-ak6NoX_4Aeg_-1810586494")]
        [DisplayName("Road Carrier Name")]
        [IsoXmlTag("RoadCrrierNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? RoadCarrierName { get; init; } 
        
        /// <summary>
        /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
        /// </summary>
        [IsoId("_U7V2p9p-Ed-ak6NoX_4Aeg_-1809659783")]
        [DisplayName("Rail Carrier Name")]
        [IsoXmlTag("RailCrrierNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? RailCarrierName { get; init; } 
        
        
        #nullable disable
        
    }
}
