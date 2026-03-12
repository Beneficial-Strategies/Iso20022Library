// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Determines how the voting instructions are specified.
    /// </summary>
    [KnownType(typeof(Vote2Choice.VoteInstruction))]
    [KnownType(typeof(Vote2Choice.GlobalVoteInstruction))]
    [JsonDerivedType(typeof(Vote2Choice.VoteInstruction),nameof(Vote2Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote2Choice.GlobalVoteInstruction),nameof(Vote2Choice.GlobalVoteInstruction))]
    [IsoId("_RDPjudp-Ed-ak6NoX_4Aeg_116941125")]
    [DisplayName("Vote 2 Choice")]
    public abstract partial record Vote2Choice_
    {
    }
}
