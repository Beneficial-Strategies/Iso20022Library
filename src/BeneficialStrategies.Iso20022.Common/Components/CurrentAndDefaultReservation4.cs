// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on reservations.
/// </summary>
[IsoId("_DXEK5W4-EeiU9cctagi5ow")]
[DisplayName("Current And Default Reservation")]
public record CurrentAndDefaultReservation4
{
    /// <summary>
    /// Report is given for a current reservation.
    /// </summary>
    [IsoId("_DgmhY24-EeiU9cctagi5ow")]
    [DisplayName("Current Reservation")]
    [IsoXmlTag("CurRsvatn")]
    public ReservationReport6? CurrentReservation { get; init; }

    /// <summary>
    /// Report is given for a default reservation.
    /// </summary>
    [IsoId("_DgmhZW4-EeiU9cctagi5ow")]
    [DisplayName("Default Reservation")]
    [IsoXmlTag("DfltRsvatn")]
    public ReservationReport6? DefaultReservation { get; init; }
}
