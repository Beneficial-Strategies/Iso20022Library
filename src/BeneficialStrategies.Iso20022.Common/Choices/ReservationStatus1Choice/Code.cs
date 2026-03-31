// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationStatus1Choice
{
    /// <summary>
    /// Liquidity transfer request type, in a coded form.
    /// </summary>
    [IsoId("_8JAUFqMgEeCJ6YNENx4h-w_2012662901")]
    [DisplayName("Code")]
    public record Code : ReservationStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the current status of a limit.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ReservationStatus1Code Value { get; init; }
    }
}
