// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare related energy derivatives attributes.
/// </summary>
[IsoId("_YR3eIVo0Ee23K4GXSpBSeg")]
[DisplayName("Compare Energy Delivery Attribute")]
public partial record CompareEnergyDeliveryAttribute1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the delivery intervals are matching or not.
    /// </summary>
    [IsoId("_YTTokVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Delivery Interval")]
    [IsoXmlTag("NrgyDlvryIntrvl")]
    public CompareTimePeriod2? EnergyDeliveryInterval { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the delivery start date and end date are matching or not.
    /// </summary>
    [IsoId("_YTTok1o0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Date")]
    [IsoXmlTag("NrgyDt")]
    public CompareDatePeriod2? EnergyDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the energy durations are matching or not.
    /// </summary>
    [IsoId("_YTTolVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Duration")]
    [IsoXmlTag("NrgyDrtn")]
    public CompareDurationType1? EnergyDuration { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the week days are matching or not.
    /// </summary>
    [IsoId("_YTTol1o0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Week Day")]
    [IsoXmlTag("NrgyWkDay")]
    public CompareWeekDay1? EnergyWeekDay { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the delivery capacity are matching or not.
    /// </summary>
    [IsoId("_YTTomVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Delivery Capacity")]
    [IsoXmlTag("NrgyDlvryCpcty")]
    public CompareLongFraction19DecimalNumber1? EnergyDeliveryCapacity { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the energy quantity units are matching or not.
    /// </summary>
    [IsoId("_YTTom1o0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Quantity Unit")]
    [IsoXmlTag("NrgyQtyUnit")]
    public CompareEnergyQuantityUnit1? EnergyQuantityUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the price time interval quantity are matching or not.
    /// </summary>
    [IsoId("_YTTonVo0Ee23K4GXSpBSeg")]
    [DisplayName("Energy Price Time Interval Quantity")]
    [IsoXmlTag("NrgyPricTmIntrvlQty")]
    public CompareAmountAndDirection3? EnergyPriceTimeIntervalQuantity { get; init; } 
    
    
    #nullable disable
    
}
