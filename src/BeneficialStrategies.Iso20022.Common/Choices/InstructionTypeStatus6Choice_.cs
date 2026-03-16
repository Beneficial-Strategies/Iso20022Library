// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Type Status6Choice.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus6Choice.CancellationStatus))]
    [KnownType(typeof(InstructionTypeStatus6Choice.InstructionStatus))]
    [JsonDerivedType(
        typeof(InstructionTypeStatus6Choice.CancellationStatus),
        nameof(InstructionTypeStatus6Choice.CancellationStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionTypeStatus6Choice.InstructionStatus),
        nameof(InstructionTypeStatus6Choice.InstructionStatus)
    )]
    [IsoId("_Yn8aEVx1Ee6fgZt44_IqFA")]
    [DisplayName("Instruction Type Status6Choice")]
    public abstract record InstructionTypeStatus6Choice_ { }
}
