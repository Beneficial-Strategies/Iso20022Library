// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification258Choice
{
    /// <summary>
    /// Any BIC.
    /// </summary>
    [DisplayName("Any BIC")]
    public record AnyBIC : PartyIdentification258Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AnyBIC")]
        public required IsoAnyBICDec2014Identifier Value { get; init; }
    }
}
