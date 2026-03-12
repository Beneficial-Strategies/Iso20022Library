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
[IsoId("_b-3nqZjgEeqkLZLH6DK3UQ")]
[DisplayName("Energy Delivery Attribute")]
public partial record EnergyDeliveryAttribute5
{
    #nullable enable
    
    /// <summary>
    /// Time interval for each block or shape.
    /// </summary>
    [IsoId("_b_ddgZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Interval")]
    [IsoXmlTag("DlvryIntrvl")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DeliveryInterval { get; init; } 
    
    /// <summary>
    /// Definition of delivery start datetime and end datetime.
    /// </summary>
    [IsoId("_b_ddg5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Period")]
    [IsoXmlTag("DlvryPrd")]
    public DateTimePeriod1? DeliveryPeriod { get; init; } 
    
    /// <summary>
    /// Start time and end time for each block or shape.
    /// </summary>
    [IsoId("_b_ddhZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Time")]
    [IsoXmlTag("DlvryTm")]
    public TimePeriodDetails1? DeliveryTime { get; init; } 
    
    /// <summary>
    /// Duration of the delivery period.
    /// </summary>
    [IsoId("_b_ddh5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DurationType1Code? Duration { get; init; } 
    
    /// <summary>
    /// Days of the week of the delivery.
    /// </summary>
    [IsoId("_b_ddiZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Week Day")]
    [IsoXmlTag("WkDay")]
    public WeekDay3Code? WeekDay { get; init; } 
    
    /// <summary>
    /// Delivery capacity for each delivery interval specified.
    /// </summary>
    [IsoId("_b_ddi5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Capacity")]
    [IsoXmlTag("DlvryCpcty")]
    public Quantity47Choice_? DeliveryCapacity { get; init; } 
    
    /// <summary>
    /// Daily or hourly quantity in MWh or kWh/d which corresponds to the underlying commodity.
    /// </summary>
    [IsoId("_b_ddjZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Quantity Unit")]
    [IsoXmlTag("QtyUnit")]
    public EnergyQuantityUnit2Choice_? QuantityUnit { get; init; } 
    
    /// <summary>
    /// Indicates if applicable the price per quantity per delivery time interval.
    /// </summary>
    [IsoId("_b_ddj5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Price Time Interval Quantity")]
    [IsoXmlTag("PricTmIntrvlQty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? PriceTimeIntervalQuantity { get; init; } 
    
    
    #nullable disable
    
}
