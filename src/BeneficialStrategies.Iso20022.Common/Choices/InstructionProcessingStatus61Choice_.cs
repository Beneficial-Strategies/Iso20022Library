// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus61Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus61Choice.ModificationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.PendingProcessing), nameof(InstructionProcessingStatus61Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.CancellationRequested), nameof(InstructionProcessingStatus61Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.AcknowledgedAccepted), nameof(InstructionProcessingStatus61Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.Cancelled), nameof(InstructionProcessingStatus61Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.Generated), nameof(InstructionProcessingStatus61Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.Repair), nameof(InstructionProcessingStatus61Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.PendingCancellation), nameof(InstructionProcessingStatus61Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus61Choice.ModificationRequested), nameof(InstructionProcessingStatus61Choice.ModificationRequested))]
    [IsoId("b4de1baa-0198-4d85-b954-9b9ef0ebbb2c")]
    [DisplayName("Instruction Processing Status 61 Choice")]
    public abstract record InstructionProcessingStatus61Choice_ { }
}
