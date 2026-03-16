// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction request received.
    /// </summary>
    [KnownType(typeof(InstructionStatus5Choice.GlobalInstructionStatus))]
    [KnownType(typeof(InstructionStatus5Choice.DetailedInstructionStatus))]
    [JsonDerivedType(
        typeof(InstructionStatus5Choice.GlobalInstructionStatus),
        nameof(InstructionStatus5Choice.GlobalInstructionStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus5Choice.DetailedInstructionStatus),
        nameof(InstructionStatus5Choice.DetailedInstructionStatus)
    )]
    [IsoId("_rZPC4V6uEeSyc4g_pm5hbw")]
    [DisplayName("Instruction Status 5 Choice")]
    public abstract record InstructionStatus5Choice_ { }
}
