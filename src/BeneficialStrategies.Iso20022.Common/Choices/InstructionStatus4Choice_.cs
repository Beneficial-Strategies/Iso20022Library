// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus4Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus4Choice.RejectionStatus))]
    [JsonDerivedType(typeof(InstructionStatus4Choice.ProcessingStatus),nameof(InstructionStatus4Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus4Choice.RejectionStatus),nameof(InstructionStatus4Choice.RejectionStatus))]
    [IsoId("_RCpGxdp-Ed-ak6NoX_4Aeg_-1718693015")]
    [DisplayName("Instruction Status 4 Choice")]
    public abstract partial record InstructionStatus4Choice_
    {
    }
}
