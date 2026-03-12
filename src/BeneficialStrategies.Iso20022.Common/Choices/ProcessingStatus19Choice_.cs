// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus19Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus19Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus19Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus19Choice.Repair))]
    [KnownType(typeof(ProcessingStatus19Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus19Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus19Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus19Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus19Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.AcknowledgedAccepted),nameof(ProcessingStatus19Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.PendingProcessing),nameof(ProcessingStatus19Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.Rejected),nameof(ProcessingStatus19Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.Repair),nameof(ProcessingStatus19Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.Cancelled),nameof(ProcessingStatus19Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.PendingCancellation),nameof(ProcessingStatus19Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.Proprietary),nameof(ProcessingStatus19Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.CancellationRequested),nameof(ProcessingStatus19Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus19Choice.ModificationRequested),nameof(ProcessingStatus19Choice.ModificationRequested))]
    [IsoId("__qPVMf4wEeClUvPNHKL9Zw")]
    [DisplayName("Processing Status 19 Choice")]
    public abstract partial record ProcessingStatus19Choice_
    {
    }
}
