// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a predefined code value or a proprietary code value for a vote instruction type.
    /// </summary>
    [KnownType(typeof(VoteInstructionType2Choice.Type))]
    [KnownType(typeof(VoteInstructionType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(VoteInstructionType2Choice.Type),
        nameof(VoteInstructionType2Choice.Type)
    )]
    [JsonDerivedType(
        typeof(VoteInstructionType2Choice.Proprietary),
        nameof(VoteInstructionType2Choice.Proprietary)
    )]
    [IsoId("_XuyKVfNoEeqRfth943bvEA")]
    [DisplayName("Vote Instruction Type 2 Choice")]
    public abstract record VoteInstructionType2Choice_ { }
}
