// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus83Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus83Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus83Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus83Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus83Choice.Repair))]
    [KnownType(typeof(ProcessingStatus83Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus83Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus83Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus83Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.PendingCancellation),nameof(ProcessingStatus83Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.AcknowledgedAccepted),nameof(ProcessingStatus83Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.PendingProcessing),nameof(ProcessingStatus83Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Rejected),nameof(ProcessingStatus83Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Repair),nameof(ProcessingStatus83Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Cancelled),nameof(ProcessingStatus83Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Proprietary),nameof(ProcessingStatus83Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.CancellationRequested),nameof(ProcessingStatus83Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.ModificationRequested),nameof(ProcessingStatus83Choice.ModificationRequested))]
    [IsoId("_MnoZgStVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 83 Choice")]
    public abstract partial record ProcessingStatus83Choice_
    {
    }
}
