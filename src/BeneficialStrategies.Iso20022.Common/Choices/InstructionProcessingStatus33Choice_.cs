// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus33Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.PendingProcessing),
        nameof(InstructionProcessingStatus33Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.CancellationRequested),
        nameof(InstructionProcessingStatus33Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.AcknowledgedAccepted),
        nameof(InstructionProcessingStatus33Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.Cancelled),
        nameof(InstructionProcessingStatus33Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.Generated),
        nameof(InstructionProcessingStatus33Choice.Generated)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.Repair),
        nameof(InstructionProcessingStatus33Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.PendingCancellation),
        nameof(InstructionProcessingStatus33Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus33Choice.ModificationRequested),
        nameof(InstructionProcessingStatus33Choice.ModificationRequested)
    )]
    [IsoId("_IuIhmdB7EeihG9bKfarOOA")]
    [DisplayName("Instruction Processing Status 33 Choice")]
    public abstract record InstructionProcessingStatus33Choice_ { }
}
