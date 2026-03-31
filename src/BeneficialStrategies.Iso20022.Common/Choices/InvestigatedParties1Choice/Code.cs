// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigatedParties1Choice
{
    /// <summary>
    /// Specifies the investigated parties as a code.
    /// </summary>
    [IsoId("_dCh4RjwTEeGKuZXNQxGH3g")]
    [DisplayName("Code")]
    public record Code : InvestigatedParties1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the investigated parties.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestigatedParties1Code Value { get; init; }
    }
}
