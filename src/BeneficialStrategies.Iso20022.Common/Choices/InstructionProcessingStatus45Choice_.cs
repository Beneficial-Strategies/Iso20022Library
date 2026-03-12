// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus45Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.ModificationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.PendingProcessing),nameof(InstructionProcessingStatus45Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.CancellationRequested),nameof(InstructionProcessingStatus45Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus45Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.Cancelled),nameof(InstructionProcessingStatus45Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.Generated),nameof(InstructionProcessingStatus45Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.Repair),nameof(InstructionProcessingStatus45Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.PendingCancellation),nameof(InstructionProcessingStatus45Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.ModificationRequested),nameof(InstructionProcessingStatus45Choice.ModificationRequested))]
    [IsoId("_waWtlSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Instruction Processing Status 45 Choice")]
    public abstract partial record InstructionProcessingStatus45Choice_
    {
    }
}
