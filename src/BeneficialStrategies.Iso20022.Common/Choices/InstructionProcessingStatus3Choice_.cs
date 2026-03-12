// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus3Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.ModificationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.PendingProcessing),nameof(InstructionProcessingStatus3Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.CancellationRequested),nameof(InstructionProcessingStatus3Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus3Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.Cancelled),nameof(InstructionProcessingStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.Generated),nameof(InstructionProcessingStatus3Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.Repair),nameof(InstructionProcessingStatus3Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.PendingCancellation),nameof(InstructionProcessingStatus3Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.ModificationRequested),nameof(InstructionProcessingStatus3Choice.ModificationRequested))]
    [IsoId("_UZXyCNp-Ed-ak6NoX_4Aeg_-1794343112")]
    [DisplayName("Instruction Processing Status 3 Choice")]
    public abstract partial record InstructionProcessingStatus3Choice_
    {
    }
}
