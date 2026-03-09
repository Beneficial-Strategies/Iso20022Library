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
[IsoId("_U7C7ttp-Ed-ak6NoX_4Aeg_1362405173")]
[DisplayName("Multimodal Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MultimodalTransport1
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
    [IsoId("_U7C7t9p-Ed-ak6NoX_4Aeg_707023270")]
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
    [IsoId("_U7C7uNp-Ed-ak6NoX_4Aeg_696865440")]
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
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_U7C7udp-Ed-ak6NoX_4Aeg_1824419961")]
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
    [IsoId("_U7C7utp-Ed-ak6NoX_4Aeg_1824419670")]
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
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_U7MssNp-Ed-ak6NoX_4Aeg_-2012481632")]
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
    [IsoId("_U7Mssdp-Ed-ak6NoX_4Aeg_-2012481657")]
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
    [IsoId("_U7Msstp-Ed-ak6NoX_4Aeg_-1684632772")]
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
    [IsoId("_U7Mss9p-Ed-ak6NoX_4Aeg_-1684632807")]
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
    
    
    #nullable disable
    
}
