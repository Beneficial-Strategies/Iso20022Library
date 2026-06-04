// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Vote18Choice
{
    /// <summary>Instruction specifying the instructed quantity of voting rights per resolution.</summary>
    [IsoId("_xMNNU6jGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Instruction")]
    public record VoteInstruction : Vote18Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("VoteInstr")]
        public required Vote21 Value { get; init; }
    }
}
