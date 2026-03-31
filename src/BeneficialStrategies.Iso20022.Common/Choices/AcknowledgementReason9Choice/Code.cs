// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason9Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_0jOiAQlIEeGATtfOBToyew_-1213196427")]
    [DisplayName("Code")]
    public record Code : AcknowledgementReason9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason6Code Value { get; init; }
    }
}
