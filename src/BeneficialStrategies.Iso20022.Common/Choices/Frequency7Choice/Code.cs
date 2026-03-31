// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency7Choice
{
    /// <summary>
    /// Frequency expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AbzAoNokEeC60axPepSq7g_-435143370")]
    [DisplayName("Code")]
    public record Code : Frequency7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventFrequency3Code Value { get; init; }
    }
}
