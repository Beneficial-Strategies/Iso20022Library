// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Cover protect instruction accepted but has not fully covered the protect instruction.</summary>
    [IsoId("_H9hed68wEfCx2aBifPEdRg")]
    [DisplayName("Uncovered")]
    public record Uncovered : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Ucvrd")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
