// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus27Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.ModificationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.PendingProcessing),nameof(InstructionProcessingStatus27Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.CancellationRequested),nameof(InstructionProcessingStatus27Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus27Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.Cancelled),nameof(InstructionProcessingStatus27Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.Generated),nameof(InstructionProcessingStatus27Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.Repair),nameof(InstructionProcessingStatus27Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.PendingCancellation),nameof(InstructionProcessingStatus27Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.ModificationRequested),nameof(InstructionProcessingStatus27Choice.ModificationRequested))]
    [IsoId("_8VJItZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Status 27 Choice")]
    public abstract partial record InstructionProcessingStatus27Choice_
    {
    }
}
