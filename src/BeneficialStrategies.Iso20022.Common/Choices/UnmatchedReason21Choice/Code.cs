// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason21Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_JNzfETqOEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : UnmatchedReason21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnmatchedReason11Code Value { get; init; }
    }
}
