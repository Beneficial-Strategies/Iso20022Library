// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus57Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus57Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus57Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus57Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus57Choice.Repair))]
    [KnownType(typeof(ProcessingStatus57Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus57Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus57Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus57Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.PendingCancellation),nameof(ProcessingStatus57Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.AcknowledgedAccepted),nameof(ProcessingStatus57Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.PendingProcessing),nameof(ProcessingStatus57Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.Rejected),nameof(ProcessingStatus57Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.Repair),nameof(ProcessingStatus57Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.Cancelled),nameof(ProcessingStatus57Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.Proprietary),nameof(ProcessingStatus57Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.CancellationRequested),nameof(ProcessingStatus57Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus57Choice.ModificationRequested),nameof(ProcessingStatus57Choice.ModificationRequested))]
    [IsoId("_6BE0V5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 57 Choice")]
    public abstract partial record ProcessingStatus57Choice_
    {
    }
}
