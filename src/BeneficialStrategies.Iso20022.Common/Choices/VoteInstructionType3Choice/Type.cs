// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionType3Choice
{
    /// <summary>Vote option expressed as a code.</summary>
    [IsoId("_r1A-wa5vEfCUHaCK5HWOhg")]
    [DisplayName("Type")]
    public record Type : VoteInstructionType3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Tp")]
        public required VoteInstruction6Code Value { get; init; }
    }
}
