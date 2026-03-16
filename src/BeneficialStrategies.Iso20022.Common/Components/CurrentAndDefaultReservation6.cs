// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Current And Default Reservation6.
/// </summary>
[IsoId("_6zrQETEyEe6g-ffJsqGiSA")]
[DisplayName("Current And Default Reservation6")]
public partial record CurrentAndDefaultReservation6
{
    #nullable enable

    /// <summary>
    /// Current Reservation.
    /// </summary>
    [DisplayName("Current Reservation")]
    [IsoXmlTag("CurRsvatn")]
    public ValueList<ReservationReport8> CurrentReservation { get; init; } = [];

    /// <summary>
    /// Default Reservation.
    /// </summary>
    [DisplayName("Default Reservation")]
    [IsoXmlTag("DfltRsvatn")]
    public ValueList<ReservationReport8> DefaultReservation { get; init; } = [];

    
    #nullable disable
    
}
