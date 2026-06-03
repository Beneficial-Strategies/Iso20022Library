// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Instruction has not been completed.</summary>
    [IsoId("_H9hea68wEfCx2aBifPEdRg")]
    [DisplayName("Pending")]
    public record Pending : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus85Choice_ Value { get; init; }
    }
}
