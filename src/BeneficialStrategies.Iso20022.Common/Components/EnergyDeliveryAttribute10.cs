// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to energy derivatives attributes.
/// </summary>
[IsoId("_iIa_kQzwEe2YoLD-1vFj0g")]
[DisplayName("Energy Delivery Attribute")]
public partial record EnergyDeliveryAttribute10
{
    #nullable enable
    
    /// <summary>
    /// Time interval for each block or shape.
    /// </summary>
    [IsoId("_iJWMoQzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Interval")]
    [IsoXmlTag("DlvryIntrvl")]
    public TimePeriodDetails1? DeliveryInterval { get; init; } 
    
    /// <summary>
    /// Definition of delivery start date and end date.
    /// </summary>
    [IsoId("_iJWMowzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    public DatePeriod1? DeliveryDate { get; init; } 
    
    /// <summary>
    /// Duration of the delivery period.
    /// </summary>
    [IsoId("_iJWMpwzwEe2YoLD-1vFj0g")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DurationType1Code? Duration { get; init; } 
    
    /// <summary>
    /// Days of the week of the delivery.
    /// </summary>
    [IsoId("_iJWMqQzwEe2YoLD-1vFj0g")]
    [DisplayName("Week Day")]
    [IsoXmlTag("WkDay")]
    public WeekDay3Code? WeekDay { get; init; } 
    
    /// <summary>
    /// Delivery capacity for each delivery interval specified.
    /// </summary>
    [IsoId("_iJWMqwzwEe2YoLD-1vFj0g")]
    [DisplayName("Delivery Capacity")]
    [IsoXmlTag("DlvryCpcty")]
    public Quantity47Choice_? DeliveryCapacity { get; init; } 
    
    /// <summary>
    /// Daily or hourly quantity in MWh or kWh/d which corresponds to the underlying commodity.
    /// </summary>
    [IsoId("_iJWMrQzwEe2YoLD-1vFj0g")]
    [DisplayName("Quantity Unit")]
    [IsoXmlTag("QtyUnit")]
    public EnergyQuantityUnit2Choice_? QuantityUnit { get; init; } 
    
    /// <summary>
    /// Indicates if applicable the price per quantity per delivery time interval.
    /// </summary>
    [IsoId("_iJWMrwzwEe2YoLD-1vFj0g")]
    [DisplayName("Price Time Interval Quantity")]
    [IsoXmlTag("PricTmIntrvlQty")]
    public AmountAndDirection106? PriceTimeIntervalQuantity { get; init; } 
    
    
    #nullable disable
    
}
