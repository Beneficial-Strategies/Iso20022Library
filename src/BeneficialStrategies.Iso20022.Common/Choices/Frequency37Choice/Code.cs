// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency37Choice
{
    /// <summary>
    /// Frequency expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_GlS6xWoFEearR-CA7eRZXQ")]
    [DisplayName("Code")]
    public record Code : Frequency37Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Frequency10Code Value { get; init; }
    }
}
