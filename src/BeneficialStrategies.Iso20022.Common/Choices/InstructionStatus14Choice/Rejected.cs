// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus14Choice
{
    /// <summary>Status advising on the rejection of the instruction and on the reason for the rejection.</summary>
    [IsoId("_EFISw6jVEfCzuLlmLrhIvA")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionStatus14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus66Choice_ Value { get; init; }
    }
}
