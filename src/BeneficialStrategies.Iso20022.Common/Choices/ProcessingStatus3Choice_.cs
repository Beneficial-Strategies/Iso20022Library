// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus3Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus3Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus3Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus3Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus3Choice.Repair))]
    [KnownType(typeof(ProcessingStatus3Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus3Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus3Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus3Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.PendingCancellation),nameof(ProcessingStatus3Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.AcknowledgedAccepted),nameof(ProcessingStatus3Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.PendingProcessing),nameof(ProcessingStatus3Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Rejected),nameof(ProcessingStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Repair),nameof(ProcessingStatus3Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Cancelled),nameof(ProcessingStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Proprietary),nameof(ProcessingStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.CancellationRequested),nameof(ProcessingStatus3Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.ModificationRequested),nameof(ProcessingStatus3Choice.ModificationRequested))]
    [IsoId("_UVy5ltp-Ed-ak6NoX_4Aeg_-1628943211")]
    [DisplayName("Processing Status 3 Choice")]
    public abstract partial record ProcessingStatus3Choice_
    {
    }
}
