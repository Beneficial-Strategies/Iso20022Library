// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason4Choice
{
    /// <summary>
    /// Standard code to specify additional information about the processed instruction.
    /// </summary>
    [IsoId("_JeX6oSz3EeOsiuMH68so7Q")]
    [DisplayName("Code")]
    public record Code : AcceptedReason4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason8Code Value { get; init; }
    }
}
