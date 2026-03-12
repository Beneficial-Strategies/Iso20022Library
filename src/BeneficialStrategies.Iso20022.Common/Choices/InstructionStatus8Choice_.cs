// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus8Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus8Choice.Rejected))]
    [KnownType(typeof(InstructionStatus8Choice.Pending))]
    [JsonDerivedType(typeof(InstructionStatus8Choice.ProcessingStatus),nameof(InstructionStatus8Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus8Choice.Rejected),nameof(InstructionStatus8Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionStatus8Choice.Pending),nameof(InstructionStatus8Choice.Pending))]
    [IsoId("_8v5Era-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Status 8 Choice")]
    public abstract partial record InstructionStatus8Choice_
    {
    }
}
