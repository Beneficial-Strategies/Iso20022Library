// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Instruction is accepted.</summary>
    [IsoId("_H9heUa8wEfCx2aBifPEdRg")]
    [DisplayName("Accepted")]
    public record Accepted : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Accptd")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
