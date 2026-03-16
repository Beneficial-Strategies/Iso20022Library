// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus60Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus60Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus60Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus60Choice.Repair))]
    [KnownType(typeof(ProcessingStatus60Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus60Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus60Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus60Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus60Choice.ModificationRequested))]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus60Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.PendingProcessing),
        nameof(ProcessingStatus60Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.Rejected),
        nameof(ProcessingStatus60Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.Repair),
        nameof(ProcessingStatus60Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.Cancelled),
        nameof(ProcessingStatus60Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.PendingCancellation),
        nameof(ProcessingStatus60Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.Proprietary),
        nameof(ProcessingStatus60Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.CancellationRequested),
        nameof(ProcessingStatus60Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus60Choice.ModificationRequested),
        nameof(ProcessingStatus60Choice.ModificationRequested)
    )]
    [IsoId("_6P-MWZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 60 Choice")]
    public abstract record ProcessingStatus60Choice_ { }
}
