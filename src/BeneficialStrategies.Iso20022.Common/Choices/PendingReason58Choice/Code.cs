// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason58Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    [IsoId("_B-kRUQpIEeup4r-PFG2T5Q")]
    [DisplayName("Code")]
    public record Code : PendingReason58Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason21Code Value { get; init; }
    }
}
