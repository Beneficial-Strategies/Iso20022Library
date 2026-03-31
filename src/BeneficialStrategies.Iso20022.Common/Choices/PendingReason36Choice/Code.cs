// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason36Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    [IsoId("_5SGOjZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : PendingReason36Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason10Code Value { get; init; }
    }
}
