// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus14Choice
{
    /// <summary>Status advising that the instruction is pending and advising on the reason for the pending status.</summary>
    [IsoId("_EFISxajVEfCzuLlmLrhIvA")]
    [DisplayName("Pending")]
    public record Pending : InstructionStatus14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus84Choice_ Value { get; init; }
    }
}
