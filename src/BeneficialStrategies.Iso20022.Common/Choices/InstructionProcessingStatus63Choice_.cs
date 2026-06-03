// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between different processing statuses for a settlement instruction.</summary>
    [KnownType(typeof(InstructionProcessingStatus63Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.PendingProcessing), nameof(InstructionProcessingStatus63Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.CancellationRequested), nameof(InstructionProcessingStatus63Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.AcknowledgedAccepted), nameof(InstructionProcessingStatus63Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.Cancelled), nameof(InstructionProcessingStatus63Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.Generated), nameof(InstructionProcessingStatus63Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.Repair), nameof(InstructionProcessingStatus63Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.PendingCancellation), nameof(InstructionProcessingStatus63Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus63Choice.ModificationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus63Choice.ModificationRequested), nameof(InstructionProcessingStatus63Choice.ModificationRequested))]
    [IsoId("_9BSWnwNrEfG_3cM8uyJ20w")]
    [DisplayName("Instruction Processing Status 63 Choice")]
    public abstract record InstructionProcessingStatus63Choice_ { }
}
