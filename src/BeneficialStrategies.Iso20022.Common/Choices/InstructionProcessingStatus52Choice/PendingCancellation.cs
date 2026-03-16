// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus52Choice
{
    /// <summary>
    /// Pending Cancellation.
    /// </summary>
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus52Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus7Choice_ Value { get; init; }
    }
}
