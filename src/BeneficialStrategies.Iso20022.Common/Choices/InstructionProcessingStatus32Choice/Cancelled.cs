// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus32Choice
{
    /// <summary>
    /// Instruction cancelled by client cancellation instruction.
    /// </summary>
    [IsoId("_BfFOBbtTEeilsanBGAzy4A")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus32Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatus12Choice_ Value { get; init; }
    }
}
