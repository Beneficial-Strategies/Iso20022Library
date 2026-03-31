// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError8Choice
{
    /// <summary>
    /// Reports on reservations.
    /// </summary>
    [IsoId("_DXEK4W4-EeiU9cctagi5ow")]
    [DisplayName("Business Report")]
    [IsoXmlTag("BizRpt")]
    public record BusinessReport : ReservationOrError8Choice_
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
}
