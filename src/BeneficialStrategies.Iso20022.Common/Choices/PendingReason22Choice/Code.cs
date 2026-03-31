// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason22Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [IsoId("_TEt8USdxEeOXAt_43VmZGw")]
    [DisplayName("Code")]
    public record Code : PendingReason22Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason11Code Value { get; init; }
    }
}
