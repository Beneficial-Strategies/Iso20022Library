// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus22Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.PendingProcessing),
        nameof(InstructionProcessingStatus22Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.CancellationRequested),
        nameof(InstructionProcessingStatus22Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.AcknowledgedAccepted),
        nameof(InstructionProcessingStatus22Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.Cancelled),
        nameof(InstructionProcessingStatus22Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.Generated),
        nameof(InstructionProcessingStatus22Choice.Generated)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.Repair),
        nameof(InstructionProcessingStatus22Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.PendingCancellation),
        nameof(InstructionProcessingStatus22Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus22Choice.ModificationRequested),
        nameof(InstructionProcessingStatus22Choice.ModificationRequested)
    )]
    [IsoId("_hEW6STnuEeWfSKvvZlhRKg")]
    [DisplayName("Instruction Processing Status 22 Choice")]
    public abstract record InstructionProcessingStatus22Choice_ { }
}
