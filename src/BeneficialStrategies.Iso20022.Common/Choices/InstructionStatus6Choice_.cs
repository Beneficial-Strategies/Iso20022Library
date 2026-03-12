// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus6Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus6Choice.RejectionStatus))]
    [JsonDerivedType(typeof(InstructionStatus6Choice.ProcessingStatus),nameof(InstructionStatus6Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus6Choice.RejectionStatus),nameof(InstructionStatus6Choice.RejectionStatus))]
    [IsoId("_r15wx16uEeSyc4g_pm5hbw")]
    [DisplayName("Instruction Status 6 Choice")]
    public abstract partial record InstructionStatus6Choice_
    {
    }
}
