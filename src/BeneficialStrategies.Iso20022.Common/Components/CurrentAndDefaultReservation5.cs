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
[IsoId("_eIHT9dcZEeqRFcf2R4bPBw")]
[DisplayName("Current And Default Reservation")]
public partial record CurrentAndDefaultReservation5
{
    #nullable enable
    
    /// <summary>
    /// Report is given for a current reservation.
    /// </summary>
    [IsoId("_eJZtYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Current Reservation")]
    [IsoXmlTag("CurRsvatn")]
    public ReservationReport7? CurrentReservation { get; init; } 
    
    /// <summary>
    /// Report is given for a default reservation.
    /// </summary>
    [IsoId("_eJZtY9cZEeqRFcf2R4bPBw")]
    [DisplayName("Default Reservation")]
    [IsoXmlTag("DfltRsvatn")]
    public ReservationReport7? DefaultReservation { get; init; } 
    
    
    #nullable disable
    
}
