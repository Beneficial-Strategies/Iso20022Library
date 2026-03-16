// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus27Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_Y5m_4TqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : MatchingStatus27Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the matching status of the instruction at the time the settlement instruction was sent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MatchingStatus1Code Value { get; init; }
    }
}
