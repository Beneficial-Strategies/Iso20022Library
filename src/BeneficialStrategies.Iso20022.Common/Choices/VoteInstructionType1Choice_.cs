// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a predefined code value or a proprietary code value for a vote instruction type.
    /// </summary>
    [KnownType(typeof(VoteInstructionType1Choice.Type))]
    [KnownType(typeof(VoteInstructionType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(VoteInstructionType1Choice.Type),
        nameof(VoteInstructionType1Choice.Type)
    )]
    [JsonDerivedType(
        typeof(VoteInstructionType1Choice.Proprietary),
        nameof(VoteInstructionType1Choice.Proprietary)
    )]
    [IsoId("_93OiQK4JEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction Type 1 Choice")]
    public abstract record VoteInstructionType1Choice_ { }
}
