// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus2Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus2Choice.CancellationStatus))]
    [JsonDerivedType(
        typeof(InstructionTypeStatus2Choice.InstructionStatus),
        nameof(InstructionTypeStatus2Choice.InstructionStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionTypeStatus2Choice.CancellationStatus),
        nameof(InstructionTypeStatus2Choice.CancellationStatus)
    )]
    [IsoId("_q8cZMV6uEeSyc4g_pm5hbw")]
    [DisplayName("Instruction Type Status 2 Choice")]
    public abstract record InstructionTypeStatus2Choice_ { }
}
