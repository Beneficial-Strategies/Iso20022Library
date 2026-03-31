// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError11Choice
{
    /// <summary>
    /// Business Report.
    /// </summary>
    [DisplayName("Business Report")]
    public record BusinessReport : ReservationOrError11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BizRpt")]
        public required CurrentAndDefaultReservation6 Value { get; init; }
    }
}
