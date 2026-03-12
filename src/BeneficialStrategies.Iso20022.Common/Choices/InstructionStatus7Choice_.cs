// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction request received.
    /// </summary>
    [KnownType(typeof(InstructionStatus7Choice.GlobalInstructionStatus))]
    [KnownType(typeof(InstructionStatus7Choice.DetailedInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus7Choice.GlobalInstructionStatus),nameof(InstructionStatus7Choice.GlobalInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus7Choice.DetailedInstructionStatus),nameof(InstructionStatus7Choice.DetailedInstructionStatus))]
    [IsoId("_8GFSpa-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Status 7 Choice")]
    public abstract partial record InstructionStatus7Choice_
    {
    }
}
