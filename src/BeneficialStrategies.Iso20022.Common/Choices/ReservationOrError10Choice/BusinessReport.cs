// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError10Choice
{
    /// <summary>
    /// Reports on reservations.
    /// </summary>
    [IsoId("_eIHT8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Business Report")]
    public record BusinessReport : ReservationOrError10Choice_
    {
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
    }
}
