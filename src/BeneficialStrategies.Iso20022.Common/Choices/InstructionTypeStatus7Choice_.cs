// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Type Status7Choice.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus7Choice.CancellationStatus))]
    [KnownType(typeof(InstructionTypeStatus7Choice.InstructionStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus7Choice.CancellationStatus),nameof(InstructionTypeStatus7Choice.CancellationStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus7Choice.InstructionStatus),nameof(InstructionTypeStatus7Choice.InstructionStatus))]
    [IsoId("_pb7TQYYQEe-9jM3-w7OB3g")]
    [DisplayName("Instruction Type Status7Choice")]
    public abstract partial record InstructionTypeStatus7Choice_
    {
    }
}
