// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Determines how the voting instructions are specified.
    /// </summary>
    [KnownType(typeof(Vote1Choice.VoteInstruction))]
    [KnownType(typeof(Vote1Choice.GlobalVoteInstruction))]
    [JsonDerivedType(typeof(Vote1Choice.VoteInstruction), nameof(Vote1Choice.VoteInstruction))]
    [JsonDerivedType(
        typeof(Vote1Choice.GlobalVoteInstruction),
        nameof(Vote1Choice.GlobalVoteInstruction)
    )]
    [IsoId("_Rb-Mx9p-Ed-ak6NoX_4Aeg_4445857")]
    [DisplayName("Vote 1 Choice")]
    public abstract record Vote1Choice_ { }
}
