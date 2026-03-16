// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationType2Choice
{
    /// <summary>
    /// Liquidity transfer request type, in a coded form.
    /// </summary>
    [IsoId("_5xhOIRUNEeusI4XK3oQSyg")]
    [DisplayName("Code")]
    public record Code : ReservationType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of reservation, as published in an external reservation type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalReservationType1Code Value { get; init; }
    }
}
