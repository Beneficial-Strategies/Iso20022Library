// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Registration6Choice
{
    /// <summary>
    /// Registration information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AZjk9dokEeC60axPepSq7g_-99947924")]
    [DisplayName("Code")]
    public record Code : Registration6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether registration should occur upon receipt.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Registration1Code Value { get; init; }
    }
}
