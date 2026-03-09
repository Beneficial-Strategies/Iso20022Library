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
/// Information related to the transportation of goods by road.
/// </summary>
[IsoId("_Nh2S0dQxEeK0PPbKncCqzA")]
[DisplayName("Transport By Road")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportByRoad4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportByRoad4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportByRoad4( System.String reqPlaceOfReceipt,System.String reqPlaceOfDelivery )
    {
        PlaceOfReceipt = reqPlaceOfReceipt;
        PlaceOfDelivery = reqPlaceOfDelivery;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_N9DoIdQxEeK0PPbKncCqzA")]
    [DisplayName("Place Of Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfRct")]
    #endif
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PlaceOfReceipt { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceOfReceipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceOfReceipt { get; init; } 
    #else
    public System.String PlaceOfReceipt { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_N9DoI9QxEeK0PPbKncCqzA")]
    [DisplayName("Place Of Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfDlvry")]
    #endif
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PlaceOfDelivery { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceOfDelivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceOfDelivery { get; init; } 
    #else
    public System.String PlaceOfDelivery { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_N9DoJdQxEeK0PPbKncCqzA")]
    [DisplayName("Road Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RoadCrrierNm")]
    #endif
    [IsoXmlTag("RoadCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? RoadCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RoadCarrierName { get; init; } 
    #else
    public System.String? RoadCarrierName { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_1Xt0gBUzEeOCqpkCrPgk4g")]
    [DisplayName("Road Carrier Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RoadCrrierCtry")]
    #endif
    [IsoXmlTag("RoadCrrierCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RoadCarrierCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RoadCarrierCountry { get; init; } 
    #else
    public string? RoadCarrierCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_6f1k4BUzEeOCqpkCrPgk4g")]
    [DisplayName("Carrier Agent Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierAgtNm")]
    #endif
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CarrierAgentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CarrierAgentName { get; init; } 
    #else
    public System.String? CarrierAgentName { get; set; } 
    #endif
    
    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_3vLE8BriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierAgtCtry")]
    #endif
    [IsoXmlTag("CrrierAgtCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CarrierAgentCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CarrierAgentCountry { get; init; } 
    #else
    public string? CarrierAgentCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
