// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus35Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.ModificationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.PendingProcessing),nameof(InstructionProcessingStatus35Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.CancellationRequested),nameof(InstructionProcessingStatus35Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus35Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.Cancelled),nameof(InstructionProcessingStatus35Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.Generated),nameof(InstructionProcessingStatus35Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.Repair),nameof(InstructionProcessingStatus35Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.PendingCancellation),nameof(InstructionProcessingStatus35Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.ModificationRequested),nameof(InstructionProcessingStatus35Choice.ModificationRequested))]
    [IsoId("_iE4Oe_fZEeiNZp_PtLohLw")]
    [DisplayName("Instruction Processing Status 35 Choice")]
    public abstract partial record InstructionProcessingStatus35Choice_
    {
    }
}
