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
/// Information used to book the executions of a trade.
/// </summary>
[IsoId("_S7fe0dp-Ed-ak6NoX_4Aeg_200823651")]
[DisplayName("Booking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Booking1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not automatic booking can occur.
    /// </summary>
    [IsoId("_S7fe0tp-Ed-ak6NoX_4Aeg_239609654")]
    [DisplayName("Day Booking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayBookg")]
    #endif
    [IsoXmlTag("DayBookg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DayBookingInstruction1Code? DayBooking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DayBookingInstruction1Code? DayBooking { get; init; } 
    #else
    public DayBookingInstruction1Code? DayBooking { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates what constitutes a bookable unit, ie, a partial execution, or an aggregated execution.
    /// </summary>
    [IsoId("_S7fe09p-Ed-ak6NoX_4Aeg_239609671")]
    [DisplayName("Booking Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgUnit")]
    #endif
    [IsoXmlTag("BookgUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BookingUnit1Choice_? BookingUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BookingUnit1Choice_? BookingUnit { get; init; } 
    #else
    public BookingUnit1Choice_? BookingUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the method of preallocation.
    /// </summary>
    [IsoId("_S7fe1Np-Ed-ak6NoX_4Aeg_1917594065")]
    [DisplayName("Pre Allocation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreAllcnMtd")]
    #endif
    [IsoXmlTag("PreAllcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreAllocationMethod1Code? PreAllocationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreAllocationMethod1Code? PreAllocationMethod { get; init; } 
    #else
    public PreAllocationMethod1Code? PreAllocationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Method for booking out an order.
    /// </summary>
    [IsoId("_S7fe1dp-Ed-ak6NoX_4Aeg_-573735757")]
    [DisplayName("Booking Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgTp")]
    #endif
    [IsoXmlTag("BookgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BookingType1Code? BookingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BookingType1Code? BookingType { get; init; } 
    #else
    public BookingType1Code? BookingType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
