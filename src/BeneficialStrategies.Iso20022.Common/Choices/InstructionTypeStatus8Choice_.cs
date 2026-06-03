// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of instruction type status.</summary>
    [KnownType(typeof(InstructionTypeStatus8Choice.InstructionStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus8Choice.InstructionStatus), nameof(InstructionTypeStatus8Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus8Choice.CancellationStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus8Choice.CancellationStatus), nameof(InstructionTypeStatus8Choice.CancellationStatus))]
    [IsoId("_DunQMajVEfCzuLlmLrhIvA")]
    [DisplayName("Instruction Type Status 8 Choice")]
    public abstract record InstructionTypeStatus8Choice_ { }
}
