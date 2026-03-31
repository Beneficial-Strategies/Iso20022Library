// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Registration11Choice
{
    /// <summary>
    /// Registration information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5TJ-u5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : Registration11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether registration should occur upon receipt.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Registration1Code Value { get; init; }
    }
}
