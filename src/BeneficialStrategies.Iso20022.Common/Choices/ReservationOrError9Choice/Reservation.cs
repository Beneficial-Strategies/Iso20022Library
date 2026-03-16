// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError9Choice
{
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_RYRzgXhdEeidzqjNEfehPg")]
    [DisplayName("Reservation")]
    public record Reservation : ReservationOrError9Choice_
    {
        /// <summary>
        /// Amount of money of the limit, expressed in an eligible currency.
        /// </summary>
        [IsoId("_UFVtM5liEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required Amount2Choice_ Amount { get; init; }

        /// <summary>
        /// Status of the limit, such as enabled or disabled.
        /// </summary>
        [IsoId("_UFVtNZliEeeE1Ya-LgRsuQ")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public ReservationStatus1Choice_? Status { get; init; }

        /// <summary>
        /// Date and time at which the reservation becomes effective.
        /// </summary>
        [IsoId("_UFVtN5liEeeE1Ya-LgRsuQ")]
        [DisplayName("Start Date Time")]
        [IsoXmlTag("StartDtTm")]
        public DateAndDateTime2Choice_? StartDateTime { get; init; }
    }
}
