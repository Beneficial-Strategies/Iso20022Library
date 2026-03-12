// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus38Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus38Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus38Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus38Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus38Choice.Repair))]
    [KnownType(typeof(ProcessingStatus38Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus38Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus38Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus38Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.PendingCancellation),nameof(ProcessingStatus38Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.AcknowledgedAccepted),nameof(ProcessingStatus38Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.PendingProcessing),nameof(ProcessingStatus38Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Rejected),nameof(ProcessingStatus38Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Repair),nameof(ProcessingStatus38Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Cancelled),nameof(ProcessingStatus38Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Proprietary),nameof(ProcessingStatus38Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.CancellationRequested),nameof(ProcessingStatus38Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.ModificationRequested),nameof(ProcessingStatus38Choice.ModificationRequested))]
    [IsoId("_tHuVkSwvEeOEV5XHD-BKpw")]
    [DisplayName("Processing Status 38 Choice")]
    public abstract partial record ProcessingStatus38Choice_
    {
    }
}
