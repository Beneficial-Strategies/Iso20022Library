// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition7Choice
{
    /// <summary>
    /// Processing position expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_n8yzoznYEeWLJsP1cO-amg")]
    [DisplayName("Code")]
    public record Code : ProcessingPosition7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing position.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingPosition3Code Value { get; init; }
    }
}
