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
/// Specifies two values to compare related energy derivatives attributes.
/// </summary>
[IsoId("_YR3eIVo0Ee23K4GXSpBSeg")]
[DisplayName("Compare Energy Delivery Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompareEnergyDeliveryAttribute1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the delivery intervals are matching or not.
    /// </summary>
    [IsoId("_YTTokVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Delivery Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyDlvryIntrvl")]
    #endif
    [IsoXmlTag("NrgyDlvryIntrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTimePeriod2? EnergyDeliveryInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTimePeriod2? EnergyDeliveryInterval { get; init; } 
    #else
    public CompareTimePeriod2? EnergyDeliveryInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the delivery start date and end date are matching or not.
    /// </summary>
    [IsoId("_YTTok1o0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyDt")]
    #endif
    [IsoXmlTag("NrgyDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDatePeriod2? EnergyDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDatePeriod2? EnergyDate { get; init; } 
    #else
    public CompareDatePeriod2? EnergyDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the energy durations are matching or not.
    /// </summary>
    [IsoId("_YTTolVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyDrtn")]
    #endif
    [IsoXmlTag("NrgyDrtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDurationType1? EnergyDuration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDurationType1? EnergyDuration { get; init; } 
    #else
    public CompareDurationType1? EnergyDuration { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the week days are matching or not.
    /// </summary>
    [IsoId("_YTTol1o0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Week Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyWkDay")]
    #endif
    [IsoXmlTag("NrgyWkDay")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareWeekDay1? EnergyWeekDay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareWeekDay1? EnergyWeekDay { get; init; } 
    #else
    public CompareWeekDay1? EnergyWeekDay { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the delivery capacity are matching or not.
    /// </summary>
    [IsoId("_YTTomVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Delivery Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyDlvryCpcty")]
    #endif
    [IsoXmlTag("NrgyDlvryCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareLongFraction19DecimalNumber1? EnergyDeliveryCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareLongFraction19DecimalNumber1? EnergyDeliveryCapacity { get; init; } 
    #else
    public CompareLongFraction19DecimalNumber1? EnergyDeliveryCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the energy quantity units are matching or not.
    /// </summary>
    [IsoId("_YTTom1o0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Quantity Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyQtyUnit")]
    #endif
    [IsoXmlTag("NrgyQtyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareEnergyQuantityUnit1? EnergyQuantityUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareEnergyQuantityUnit1? EnergyQuantityUnit { get; init; } 
    #else
    public CompareEnergyQuantityUnit1? EnergyQuantityUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the price time interval quantity are matching or not.
    /// </summary>
    [IsoId("_YTTonVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Price Time Interval Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyPricTmIntrvlQty")]
    #endif
    [IsoXmlTag("NrgyPricTmIntrvlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection3? EnergyPriceTimeIntervalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection3? EnergyPriceTimeIntervalQuantity { get; init; } 
    #else
    public CompareAmountAndDirection3? EnergyPriceTimeIntervalQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
