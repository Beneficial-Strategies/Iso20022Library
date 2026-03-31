// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyRole4Choice
{
    /// <summary>
    /// Role expressed as a code.
    /// </summary>
    [IsoId("_XzOvwV92EeS7xuKaq75oiQ")]
    [DisplayName("Code")]
    public record Code : PartyRole4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundRole7Code Value { get; init; }
    }
}
