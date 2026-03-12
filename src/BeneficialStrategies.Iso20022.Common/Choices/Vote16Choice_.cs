// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Determines how the voting instructions are specified.
    /// </summary>
    [KnownType(typeof(Vote16Choice.VoteInstruction))]
    [KnownType(typeof(Vote16Choice.GlobalVoteInstruction))]
    [JsonDerivedType(typeof(Vote16Choice.VoteInstruction),nameof(Vote16Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote16Choice.GlobalVoteInstruction),nameof(Vote16Choice.GlobalVoteInstruction))]
    [IsoId("_XGdmEfNoEeqRfth943bvEA")]
    [DisplayName("Vote 16 Choice")]
    public abstract partial record Vote16Choice_
    {
    }
}
