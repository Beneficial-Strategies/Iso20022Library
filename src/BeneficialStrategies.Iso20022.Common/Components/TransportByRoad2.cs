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
[IsoId("_SuOe2dp-Ed-ak6NoX_4Aeg_-77444670")]
[DisplayName("Transport By Road")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportByRoad2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportByRoad2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportByRoad2( System.String reqPlaceOfReceipt,System.String reqPlaceOfDelivery )
    {
        PlaceOfReceipt = reqPlaceOfReceipt;
        PlaceOfDelivery = reqPlaceOfDelivery;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_SuOe2tp-Ed-ak6NoX_4Aeg_-1400067178")]
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
    [IsoId("_SuOe29p-Ed-ak6NoX_4Aeg_-1400067238")]
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
    [IsoId("_SuOe3Np-Ed-ak6NoX_4Aeg_994762252")]
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
    
    
    #nullable disable
    
}
