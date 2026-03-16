// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Determines how the voting instructions are specified.
    /// </summary>
    [KnownType(typeof(Vote3Choice.VoteInstruction))]
    [KnownType(typeof(Vote3Choice.GlobalVoteInstruction))]
    [JsonDerivedType(typeof(Vote3Choice.VoteInstruction), nameof(Vote3Choice.VoteInstruction))]
    [JsonDerivedType(
        typeof(Vote3Choice.GlobalVoteInstruction),
        nameof(Vote3Choice.GlobalVoteInstruction)
    )]
    [IsoId("_hx10Z166EeSjaerr_EM7AQ")]
    [DisplayName("Vote 3 Choice")]
    public abstract record Vote3Choice_ { }
}
