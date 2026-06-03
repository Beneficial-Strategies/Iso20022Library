// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Status applying globally to the instruction received.</summary>
    [KnownType(typeof(InstructionStatus14Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus14Choice.ProcessingStatus), nameof(InstructionStatus14Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus14Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionStatus14Choice.Rejected), nameof(InstructionStatus14Choice.Rejected))]
    [KnownType(typeof(InstructionStatus14Choice.Pending))]
    [JsonDerivedType(typeof(InstructionStatus14Choice.Pending), nameof(InstructionStatus14Choice.Pending))]
    [IsoId("_D98Fq6jVEfCzuLlmLrhIvA")]
    [DisplayName("Instruction Status 14 Choice")]
    public abstract record InstructionStatus14Choice_ { }
}
