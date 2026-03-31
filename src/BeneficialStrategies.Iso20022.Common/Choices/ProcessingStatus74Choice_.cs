// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus74Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus74Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus74Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus74Choice.Repair))]
    [KnownType(typeof(ProcessingStatus74Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus74Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus74Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus74Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus74Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus74Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.PendingProcessing),
        nameof(ProcessingStatus74Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.Rejected),
        nameof(ProcessingStatus74Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.Repair),
        nameof(ProcessingStatus74Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.Cancelled),
        nameof(ProcessingStatus74Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.PendingCancellation),
        nameof(ProcessingStatus74Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.Proprietary),
        nameof(ProcessingStatus74Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.CancellationRequested),
        nameof(ProcessingStatus74Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus74Choice.ModificationRequested),
        nameof(ProcessingStatus74Choice.ModificationRequested)
    )]
    [IsoId("_GLFV8dB7EeihG9bKfarOOA")]
    [DisplayName("Processing Status 74 Choice")]
    public abstract record ProcessingStatus74Choice_ { }
}
