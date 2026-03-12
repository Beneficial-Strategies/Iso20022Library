// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction request received.
    /// </summary>
    [KnownType(typeof(InstructionStatus3Choice.GlobalInstructionStatus))]
    [KnownType(typeof(InstructionStatus3Choice.DetailedInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus3Choice.GlobalInstructionStatus),nameof(InstructionStatus3Choice.GlobalInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus3Choice.DetailedInstructionStatus),nameof(InstructionStatus3Choice.DetailedInstructionStatus))]
    [IsoId("_RCpGwtp-Ed-ak6NoX_4Aeg_1720173069")]
    [DisplayName("Instruction Status 3 Choice")]
    public abstract partial record InstructionStatus3Choice_
    {
    }
}
