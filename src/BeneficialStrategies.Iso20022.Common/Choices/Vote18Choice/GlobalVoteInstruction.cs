// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Vote18Choice
{
    /// <summary>Instruction specifying a vote instruction per resolution for the entire entitlement.</summary>
    [IsoId("_xMNNVajGEfCzuLlmLrhIvA")]
    [DisplayName("Global Vote Instruction")]
    public record GlobalVoteInstruction : Vote18Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GblVoteInstr")]
        public required Vote15 Value { get; init; }
    }
}
