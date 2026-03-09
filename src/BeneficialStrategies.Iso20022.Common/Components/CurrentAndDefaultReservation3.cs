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
/// Reports on reservations.
/// </summary>
[IsoId("_TjY2tZliEeeE1Ya-LgRsuQ")]
[DisplayName("Current And Default Reservation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrentAndDefaultReservation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Report is given for a current reservation.
    /// </summary>
    [IsoId("_Tr4EU5liEeeE1Ya-LgRsuQ")]
    [DisplayName("Current Reservation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurRsvatn")]
    #endif
    [IsoXmlTag("CurRsvatn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReservationReport5? CurrentReservation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationReport5? CurrentReservation { get; init; } 
    #else
    public ReservationReport5? CurrentReservation { get; set; } 
    #endif
    
    /// <summary>
    /// Report is given for a default reservation.
    /// </summary>
    [IsoId("_Tr4EVZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Default Reservation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltRsvatn")]
    #endif
    [IsoXmlTag("DfltRsvatn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReservationReport5? DefaultReservation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationReport5? DefaultReservation { get; init; } 
    #else
    public ReservationReport5? DefaultReservation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
