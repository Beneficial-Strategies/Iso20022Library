// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Vote18Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Determines how the voting instructions are specified.</summary>
    [IsoId("_xFkZ0ajGEfCzuLlmLrhIvA")]
    [DisplayName("Vote 18 Choice")]
    [KnownType(typeof(Vote18Choice.VoteInstruction))]
    [KnownType(typeof(Vote18Choice.GlobalVoteInstruction))]
    [JsonDerivedType(typeof(Vote18Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote18Choice.GlobalVoteInstruction))]
    public abstract record Vote18Choice_
    {
    }
}
