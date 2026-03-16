// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus58Choice
{
    /// <summary>
    /// Standing Instruction.
    /// </summary>
    [DisplayName("Standing Instruction")]
    public record StandingInstruction : InstructionProcessingStatus58Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StgInstr")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
