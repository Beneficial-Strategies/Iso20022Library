// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus47Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Uncovered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Accepted),nameof(InstructionProcessingStatus47Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Cancelled),nameof(InstructionProcessingStatus47Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus47Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Rejected),nameof(InstructionProcessingStatus47Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Pending),nameof(InstructionProcessingStatus47Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.PendingCancellation),nameof(InstructionProcessingStatus47Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Covered),nameof(InstructionProcessingStatus47Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Uncovered),nameof(InstructionProcessingStatus47Choice.Uncovered))]
    [IsoId("_J-0HaRn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Processing Status 47 Choice")]
    public abstract partial record InstructionProcessingStatus47Choice_
    {
    }
}
