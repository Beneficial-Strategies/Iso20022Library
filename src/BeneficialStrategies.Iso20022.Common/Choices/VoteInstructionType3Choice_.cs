// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.VoteInstructionType3Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a predefined code value or a proprietary code value for a vote instruction type.</summary>
    [IsoId("_rukYga5vEfCUHaCK5HWOhg")]
    [DisplayName("Vote Instruction Type 3 Choice")]
    [KnownType(typeof(VoteInstructionType3Choice.Type))]
    [KnownType(typeof(VoteInstructionType3Choice.Proprietary))]
    [JsonDerivedType(typeof(VoteInstructionType3Choice.Type))]
    [JsonDerivedType(typeof(VoteInstructionType3Choice.Proprietary))]
    public abstract record VoteInstructionType3Choice_
    {
    }
}
