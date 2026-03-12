// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus49Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus49Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus49Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus49Choice.Repair))]
    [KnownType(typeof(ProcessingStatus49Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus49Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus49Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus49Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus49Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.AcknowledgedAccepted),nameof(ProcessingStatus49Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.PendingProcessing),nameof(ProcessingStatus49Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.Rejected),nameof(ProcessingStatus49Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.Repair),nameof(ProcessingStatus49Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.Cancelled),nameof(ProcessingStatus49Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.PendingCancellation),nameof(ProcessingStatus49Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.Proprietary),nameof(ProcessingStatus49Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.CancellationRequested),nameof(ProcessingStatus49Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus49Choice.ModificationRequested),nameof(ProcessingStatus49Choice.ModificationRequested))]
    [IsoId("_kHsvdznuEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status 49 Choice")]
    public abstract partial record ProcessingStatus49Choice_
    {
    }
}
