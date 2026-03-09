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
/// Information related to energy derivatives attributes.
/// </summary>
[IsoId("_iIa_kQzwEe2YoLD-1vFj0g")]
[DisplayName("Energy Delivery Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnergyDeliveryAttribute10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Time interval for each block or shape.
    /// </summary>
    [IsoId("_iJWMoQzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryIntrvl")]
    #endif
    [IsoXmlTag("DlvryIntrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimePeriodDetails1? DeliveryInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimePeriodDetails1? DeliveryInterval { get; init; } 
    #else
    public TimePeriodDetails1? DeliveryInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of delivery start date and end date.
    /// </summary>
    [IsoId("_iJWMowzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDt")]
    #endif
    [IsoXmlTag("DlvryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod1? DeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod1? DeliveryDate { get; init; } 
    #else
    public DatePeriod1? DeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of the delivery period.
    /// </summary>
    [IsoId("_iJWMpwzwEe2YoLD-1vFj0g")]
    [DisplayName("Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drtn")]
    #endif
    [IsoXmlTag("Drtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DurationType1Code? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DurationType1Code? Duration { get; init; } 
    #else
    public DurationType1Code? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Days of the week of the delivery.
    /// </summary>
    [IsoId("_iJWMqQzwEe2YoLD-1vFj0g")]
    [DisplayName("Week Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WkDay")]
    #endif
    [IsoXmlTag("WkDay")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public WeekDay3Code? WeekDay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WeekDay3Code? WeekDay { get; init; } 
    #else
    public WeekDay3Code? WeekDay { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery capacity for each delivery interval specified.
    /// </summary>
    [IsoId("_iJWMqwzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryCpcty")]
    #endif
    [IsoXmlTag("DlvryCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity47Choice_? DeliveryCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity47Choice_? DeliveryCapacity { get; init; } 
    #else
    public Quantity47Choice_? DeliveryCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Daily or hourly quantity in MWh or kWh/d which corresponds to the underlying commodity.
    /// </summary>
    [IsoId("_iJWMrQzwEe2YoLD-1vFj0g")]
    [DisplayName("Quantity Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyUnit")]
    #endif
    [IsoXmlTag("QtyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergyQuantityUnit2Choice_? QuantityUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergyQuantityUnit2Choice_? QuantityUnit { get; init; } 
    #else
    public EnergyQuantityUnit2Choice_? QuantityUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if applicable the price per quantity per delivery time interval.
    /// </summary>
    [IsoId("_iJWMrwzwEe2YoLD-1vFj0g")]
    [DisplayName("Price Time Interval Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTmIntrvlQty")]
    #endif
    [IsoXmlTag("PricTmIntrvlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection106? PriceTimeIntervalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106? PriceTimeIntervalQuantity { get; init; } 
    #else
    public AmountAndDirection106? PriceTimeIntervalQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
