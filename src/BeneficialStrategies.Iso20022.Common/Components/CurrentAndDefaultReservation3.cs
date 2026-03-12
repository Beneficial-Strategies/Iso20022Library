// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on reservations.
/// </summary>
[IsoId("_TjY2tZliEeeE1Ya-LgRsuQ")]
[DisplayName("Current And Default Reservation")]
public partial record CurrentAndDefaultReservation3
{
    #nullable enable
    
    /// <summary>
    /// Report is given for a current reservation.
    /// </summary>
    [IsoId("_Tr4EU5liEeeE1Ya-LgRsuQ")]
    [DisplayName("Current Reservation")]
    [IsoXmlTag("CurRsvatn")]
    public ReservationReport5? CurrentReservation { get; init; } 
    
    /// <summary>
    /// Report is given for a default reservation.
    /// </summary>
    [IsoId("_Tr4EVZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Default Reservation")]
    [IsoXmlTag("DfltRsvatn")]
    public ReservationReport5? DefaultReservation { get; init; } 
    
    
    #nullable disable
    
}
