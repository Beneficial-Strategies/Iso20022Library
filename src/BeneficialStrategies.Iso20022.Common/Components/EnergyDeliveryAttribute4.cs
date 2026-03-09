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
[IsoId("_HJBv0YeIEei3PYANOK_QWA")]
[DisplayName("Energy Delivery Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnergyDeliveryAttribute4
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
    [IsoId("_HWlqsYeIEei3PYANOK_QWA")]
    [DisplayName("Delivery Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryIntrvl")]
    #endif
    [IsoXmlTag("DlvryIntrvl")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? DeliveryInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? DeliveryInterval { get; init; } 
    #else
    public System.TimeOnly? DeliveryInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of delivery start datetime and end datetime.
    /// </summary>
    [IsoId("_HWlqs4eIEei3PYANOK_QWA")]
    [DisplayName("Delivery Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryPrd")]
    #endif
    [IsoXmlTag("DlvryPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? DeliveryPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? DeliveryPeriod { get; init; } 
    #else
    public DateTimePeriod1? DeliveryPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Start time and end time for each block or shape.
    /// </summary>
    [IsoId("_Ue8oEIeIEei3PYANOK_QWA")]
    [DisplayName("Delivery Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTm")]
    #endif
    [IsoXmlTag("DlvryTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimePeriodDetails1? DeliveryTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimePeriodDetails1? DeliveryTime { get; init; } 
    #else
    public TimePeriodDetails1? DeliveryTime { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of the delivery period.
    /// </summary>
    [IsoId("_HWlqtYeIEei3PYANOK_QWA")]
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
    [IsoId("_HWlqt4eIEei3PYANOK_QWA")]
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
    [IsoId("_HWlquYeIEei3PYANOK_QWA")]
    [DisplayName("Delivery Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryCpcty")]
    #endif
    [IsoXmlTag("DlvryCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity46Choice_? DeliveryCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity46Choice_? DeliveryCapacity { get; init; } 
    #else
    public Quantity46Choice_? DeliveryCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Daily or hourly quantity in MWh or kWh/d which corresponds to the underlying commodity.
    /// </summary>
    [IsoId("_HWlqu4eIEei3PYANOK_QWA")]
    [DisplayName("Quantity Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyUnit")]
    #endif
    [IsoXmlTag("QtyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergyQuantityUnit1Choice_? QuantityUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergyQuantityUnit1Choice_? QuantityUnit { get; init; } 
    #else
    public EnergyQuantityUnit1Choice_? QuantityUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if applicable the price per quantity per delivery time interval.
    /// </summary>
    [IsoId("_HWlqvYeIEei3PYANOK_QWA")]
    [DisplayName("Price Time Interval Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTmIntrvlQty")]
    #endif
    [IsoXmlTag("PricTmIntrvlQty")]
    [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction21DecimalNumber? PriceTimeIntervalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PriceTimeIntervalQuantity { get; init; } 
    #else
    public System.UInt64? PriceTimeIntervalQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
