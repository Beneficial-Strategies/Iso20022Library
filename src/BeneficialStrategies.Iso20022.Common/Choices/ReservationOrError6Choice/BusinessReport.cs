// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError6Choice
{
    /// <summary>
    /// Reports on reservations.
    /// </summary>
    [IsoId("_TjY2sZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Report")]
    public record BusinessReport : ReservationOrError6Choice_
    {
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
    }
}
