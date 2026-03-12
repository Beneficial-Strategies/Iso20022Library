// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to book the executions of a trade.
/// </summary>
[IsoId("_S7fe0dp-Ed-ak6NoX_4Aeg_200823651")]
[DisplayName("Booking")]
public partial record Booking1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not automatic booking can occur.
    /// </summary>
    [IsoId("_S7fe0tp-Ed-ak6NoX_4Aeg_239609654")]
    [DisplayName("Day Booking")]
    [IsoXmlTag("DayBookg")]
    public DayBookingInstruction1Code? DayBooking { get; init; } 
    
    /// <summary>
    /// Indicates what constitutes a bookable unit, ie, a partial execution, or an aggregated execution.
    /// </summary>
    [IsoId("_S7fe09p-Ed-ak6NoX_4Aeg_239609671")]
    [DisplayName("Booking Unit")]
    [IsoXmlTag("BookgUnit")]
    public BookingUnit1Choice_? BookingUnit { get; init; } 
    
    /// <summary>
    /// Indicates the method of preallocation.
    /// </summary>
    [IsoId("_S7fe1Np-Ed-ak6NoX_4Aeg_1917594065")]
    [DisplayName("Pre Allocation Method")]
    [IsoXmlTag("PreAllcnMtd")]
    public PreAllocationMethod1Code? PreAllocationMethod { get; init; } 
    
    /// <summary>
    /// Method for booking out an order.
    /// </summary>
    [IsoId("_S7fe1dp-Ed-ak6NoX_4Aeg_-573735757")]
    [DisplayName("Booking Type")]
    [IsoXmlTag("BookgTp")]
    public BookingType1Code? BookingType { get; init; } 
    
    
    #nullable disable
    
}
