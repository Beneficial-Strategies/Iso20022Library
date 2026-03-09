// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to multimodal transportation of goods.
/// </summary>
[IsoId("_U7MstNp-Ed-ak6NoX_4Aeg_511762628")]
[DisplayName("Multimodal Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MultimodalTransport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_U7Mstdp-Ed-ak6NoX_4Aeg_296981374")]
    [DisplayName("Departure Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DprtureAirprt")]
    #endif
    [IsoXmlTag("DprtureAirprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AirportName1Choice_? DepartureAirport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AirportName1Choice_? DepartureAirport { get; init; } 
    #else
    public AirportName1Choice_? DepartureAirport { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_U7Msttp-Ed-ak6NoX_4Aeg_322836634")]
    [DisplayName("Destination Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAirprt")]
    #endif
    [IsoXmlTag("DstnAirprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AirportName1Choice_? DestinationAirport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AirportName1Choice_? DestinationAirport { get; init; } 
    #else
    public AirportName1Choice_? DestinationAirport { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_U7Mst9p-Ed-ak6NoX_4Aeg_-1343729756")]
    [DisplayName("Air Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AirCrrierNm")]
    #endif
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AirCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AirCarrierName { get; init; } 
    #else
    public System.String? AirCarrierName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_U7MsuNp-Ed-ak6NoX_4Aeg_564401895")]
    [DisplayName("Port Of Loading")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfLoadng")]
    #endif
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PortOfLoading { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PortOfLoading { get; init; } 
    #else
    public System.String? PortOfLoading { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_U7Msudp-Ed-ak6NoX_4Aeg_564401870")]
    [DisplayName("Port Of Discharge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfDschrge")]
    #endif
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PortOfDischarge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PortOfDischarge { get; init; } 
    #else
    public System.String? PortOfDischarge { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_U7V2oNp-Ed-ak6NoX_4Aeg_-1115621713")]
    [DisplayName("Vessel Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VsslNm")]
    #endif
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VesselName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VesselName { get; init; } 
    #else
    public System.String? VesselName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_U7V2odp-Ed-ak6NoX_4Aeg_564401852")]
    [DisplayName("Place Of Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfRct")]
    #endif
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PlaceOfReceipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfReceipt { get; init; } 
    #else
    public System.String? PlaceOfReceipt { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_U7V2otp-Ed-ak6NoX_4Aeg_564401583")]
    [DisplayName("Place Of Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfDlvry")]
    #endif
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PlaceOfDelivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfDelivery { get; init; } 
    #else
    public System.String? PlaceOfDelivery { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    [IsoId("_U7V2o9p-Ed-ak6NoX_4Aeg_564401912")]
    [DisplayName("Taking In Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TakngInChrg")]
    #endif
    [IsoXmlTag("TakngInChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TakingInCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TakingInCharge { get; init; } 
    #else
    public System.String? TakingInCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    [IsoId("_U7V2pNp-Ed-ak6NoX_4Aeg_564401600")]
    [DisplayName("Place Of Final Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfFnlDstn")]
    #endif
    [IsoXmlTag("PlcOfFnlDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PlaceOfFinalDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfFinalDestination { get; init; } 
    #else
    public System.String? PlaceOfFinalDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a place in a country.
    /// </summary>
    [IsoId("_U7V2pdp-Ed-ak6NoX_4Aeg_1426049424")]
    [DisplayName("Transit Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnstLctn")]
    #endif
    [IsoXmlTag("TrnstLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransitLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransitLocation { get; init; } 
    #else
    public System.String? TransitLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_U7V2ptp-Ed-ak6NoX_4Aeg_-1810586494")]
    [DisplayName("Road Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RoadCrrierNm")]
    #endif
    [IsoXmlTag("RoadCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RoadCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RoadCarrierName { get; init; } 
    #else
    public System.String? RoadCarrierName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_U7V2p9p-Ed-ak6NoX_4Aeg_-1809659783")]
    [DisplayName("Rail Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RailCrrierNm")]
    #endif
    [IsoXmlTag("RailCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RailCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RailCarrierName { get; init; } 
    #else
    public System.String? RailCarrierName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
