// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    [IsoId("_UZXyANp-Ed-ak6NoX_4Aeg_-1812988032")]
    [DisplayName("Code")]
    public record Code : PendingProcessingReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason1Code Value { get; init; }
    }
}
