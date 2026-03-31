// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus48Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus48Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus48Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus48Choice.Repair))]
    [KnownType(typeof(ProcessingStatus48Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus48Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus48Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus48Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus48Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus48Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.PendingProcessing),
        nameof(ProcessingStatus48Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.Rejected),
        nameof(ProcessingStatus48Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.Repair),
        nameof(ProcessingStatus48Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.Cancelled),
        nameof(ProcessingStatus48Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.PendingCancellation),
        nameof(ProcessingStatus48Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.Proprietary),
        nameof(ProcessingStatus48Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.CancellationRequested),
        nameof(ProcessingStatus48Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus48Choice.ModificationRequested),
        nameof(ProcessingStatus48Choice.ModificationRequested)
    )]
    [IsoId("_jGFhcTnuEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status 48 Choice")]
    public abstract record ProcessingStatus48Choice_ { }
}
