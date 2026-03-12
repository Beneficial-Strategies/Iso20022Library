// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus37Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus37Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus37Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus37Choice.Repair))]
    [KnownType(typeof(ProcessingStatus37Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus37Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus37Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus37Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus37Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.AcknowledgedAccepted),nameof(ProcessingStatus37Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.PendingProcessing),nameof(ProcessingStatus37Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Rejected),nameof(ProcessingStatus37Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Repair),nameof(ProcessingStatus37Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Cancelled),nameof(ProcessingStatus37Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.PendingCancellation),nameof(ProcessingStatus37Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Proprietary),nameof(ProcessingStatus37Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.CancellationRequested),nameof(ProcessingStatus37Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.ModificationRequested),nameof(ProcessingStatus37Choice.ModificationRequested))]
    [IsoId("_F0ajsSwuEeOEV5XHD-BKpw")]
    [DisplayName("Processing Status 37 Choice")]
    public abstract partial record ProcessingStatus37Choice_
    {
    }
}
