// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Determines how the voting instructions are specified.
    /// </summary>
    [KnownType(typeof(Vote4Choice.VoteInstruction))]
    [KnownType(typeof(Vote4Choice.GlobalVoteInstruction))]
    [JsonDerivedType(typeof(Vote4Choice.VoteInstruction), nameof(Vote4Choice.VoteInstruction))]
    [JsonDerivedType(
        typeof(Vote4Choice.GlobalVoteInstruction),
        nameof(Vote4Choice.GlobalVoteInstruction)
    )]
    [IsoId("_YoEpa64cEemG7MmivSuE5g")]
    [DisplayName("Vote 4 Choice")]
    public abstract record Vote4Choice_ { }
}
