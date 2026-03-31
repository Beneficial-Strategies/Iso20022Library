// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus90Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus90Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus90Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus90Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus90Choice.Repair))]
    [KnownType(typeof(ProcessingStatus90Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus90Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus90Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus90Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.PendingCancellation),
        nameof(ProcessingStatus90Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus90Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.PendingProcessing),
        nameof(ProcessingStatus90Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.Rejected),
        nameof(ProcessingStatus90Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.Repair),
        nameof(ProcessingStatus90Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.Cancelled),
        nameof(ProcessingStatus90Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.Proprietary),
        nameof(ProcessingStatus90Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.CancellationRequested),
        nameof(ProcessingStatus90Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus90Choice.ModificationRequested),
        nameof(ProcessingStatus90Choice.ModificationRequested)
    )]
    [IsoId("_ddARWji8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 90 Choice")]
    public abstract record ProcessingStatus90Choice_ { }
}
