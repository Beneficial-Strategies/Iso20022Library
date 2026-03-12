// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction request received.
    /// </summary>
    [KnownType(typeof(InstructionStatus1Choice.GlobalInstructionStatus))]
    [KnownType(typeof(InstructionStatus1Choice.DetailedInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus1Choice.GlobalInstructionStatus),nameof(InstructionStatus1Choice.GlobalInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus1Choice.DetailedInstructionStatus),nameof(InstructionStatus1Choice.DetailedInstructionStatus))]
    [IsoId("_RWnLp9p-Ed-ak6NoX_4Aeg_1278003297")]
    [DisplayName("Instruction Status 1 Choice")]
    public abstract partial record InstructionStatus1Choice_
    {
    }
}
