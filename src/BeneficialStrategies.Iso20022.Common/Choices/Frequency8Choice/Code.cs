// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency8Choice
{
    /// <summary>
    /// Frequency expressed in coded form.
    /// </summary>
    [IsoId("_m_7dcPNBEeCuA5Tr22BnwA_122827409")]
    [DisplayName("Code")]
    public record Code : Frequency8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventFrequency1Code Value { get; init; }
    }
}
