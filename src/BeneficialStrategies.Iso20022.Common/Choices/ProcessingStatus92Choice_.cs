// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus92Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus92Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus92Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus92Choice.Repair))]
    [KnownType(typeof(ProcessingStatus92Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus92Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus92Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus92Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus92Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus92Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.PendingProcessing),
        nameof(ProcessingStatus92Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.Rejected),
        nameof(ProcessingStatus92Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.Repair),
        nameof(ProcessingStatus92Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.Cancelled),
        nameof(ProcessingStatus92Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.PendingCancellation),
        nameof(ProcessingStatus92Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.Proprietary),
        nameof(ProcessingStatus92Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.CancellationRequested),
        nameof(ProcessingStatus92Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus92Choice.ModificationRequested),
        nameof(ProcessingStatus92Choice.ModificationRequested)
    )]
    [IsoId("_dsyaRji8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 92 Choice")]
    public abstract record ProcessingStatus92Choice_ { }
}
