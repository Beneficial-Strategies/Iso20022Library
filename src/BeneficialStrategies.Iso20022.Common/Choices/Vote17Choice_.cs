// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Vote17Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between per-resolution and global voting instructions.</summary>
    [IsoId("_w-jL1ajGEfCzuLlmLrhIvA")]
    [DisplayName("Vote 17 Choice")]
    [KnownType(typeof(Vote17Choice.VotePerAgendaResolution))]
    [KnownType(typeof(Vote17Choice.VoteForAllAgendaResolutions))]
    [JsonDerivedType(typeof(Vote17Choice.VotePerAgendaResolution))]
    [JsonDerivedType(typeof(Vote17Choice.VoteForAllAgendaResolutions))]
    public abstract record Vote17Choice_
    {
    }
}
