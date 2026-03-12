// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus10Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus10Choice.Rejected))]
    [KnownType(typeof(InstructionStatus10Choice.Pending))]
    [JsonDerivedType(typeof(InstructionStatus10Choice.ProcessingStatus),nameof(InstructionStatus10Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus10Choice.Rejected),nameof(InstructionStatus10Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionStatus10Choice.Pending),nameof(InstructionStatus10Choice.Pending))]
    [IsoId("_btxejfNfEeqRfth943bvEA")]
    [DisplayName("Instruction Status 10 Choice")]
    public abstract partial record InstructionStatus10Choice_
    {
    }
}
