// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to energy derivatives attributes.
/// </summary>
[IsoId("_HJBv0YeIEei3PYANOK_QWA")]
[DisplayName("Energy Delivery Attribute")]
public record EnergyDeliveryAttribute4
{
    /// <summary>
    /// Time interval for each block or shape.
    /// </summary>
    [IsoId("_HWlqsYeIEei3PYANOK_QWA")]
    [DisplayName("Delivery Interval")]
    [IsoXmlTag("DlvryIntrvl")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DeliveryInterval { get; init; }

    /// <summary>
    /// Definition of delivery start datetime and end datetime.
    /// </summary>
    [IsoId("_HWlqs4eIEei3PYANOK_QWA")]
    [DisplayName("Delivery Period")]
    [IsoXmlTag("DlvryPrd")]
    public DateTimePeriod1? DeliveryPeriod { get; init; }

    /// <summary>
    /// Start time and end time for each block or shape.
    /// </summary>
    [IsoId("_Ue8oEIeIEei3PYANOK_QWA")]
    [DisplayName("Delivery Time")]
    [IsoXmlTag("DlvryTm")]
    public TimePeriodDetails1? DeliveryTime { get; init; }

    /// <summary>
    /// Duration of the delivery period.
    /// </summary>
    [IsoId("_HWlqtYeIEei3PYANOK_QWA")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public DurationType1Code? Duration { get; init; }

    /// <summary>
    /// Days of the week of the delivery.
    /// </summary>
    [IsoId("_HWlqt4eIEei3PYANOK_QWA")]
    [DisplayName("Week Day")]
    [IsoXmlTag("WkDay")]
    public WeekDay3Code? WeekDay { get; init; }

    /// <summary>
    /// Delivery capacity for each delivery interval specified.
    /// </summary>
    [IsoId("_HWlquYeIEei3PYANOK_QWA")]
    [DisplayName("Delivery Capacity")]
    [IsoXmlTag("DlvryCpcty")]
    public Quantity46Choice_? DeliveryCapacity { get; init; }

    /// <summary>
    /// Daily or hourly quantity in MWh or kWh/d which corresponds to the underlying commodity.
    /// </summary>
    [IsoId("_HWlqu4eIEei3PYANOK_QWA")]
    [DisplayName("Quantity Unit")]
    [IsoXmlTag("QtyUnit")]
    public EnergyQuantityUnit1Choice_? QuantityUnit { get; init; }

    /// <summary>
    /// Indicates if applicable the price per quantity per delivery time interval.
    /// </summary>
    [IsoId("_HWlqvYeIEei3PYANOK_QWA")]
    [DisplayName("Price Time Interval Quantity")]
    [IsoXmlTag("PricTmIntrvlQty")]
    [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
    public IsoLongFraction21DecimalNumber? PriceTimeIntervalQuantity { get; init; }
}
