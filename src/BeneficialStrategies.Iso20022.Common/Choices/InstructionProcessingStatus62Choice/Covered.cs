// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Protect instruction has been fully covered.</summary>
    [IsoId("_H9heda8wEfCx2aBifPEdRg")]
    [DisplayName("Covered")]
    public record Covered : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cvrd")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
