// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus77Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus77Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus77Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus77Choice.Repair))]
    [KnownType(typeof(ProcessingStatus77Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus77Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus77Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus77Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus77Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.AcknowledgedAccepted),nameof(ProcessingStatus77Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.PendingProcessing),nameof(ProcessingStatus77Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Rejected),nameof(ProcessingStatus77Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Repair),nameof(ProcessingStatus77Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Cancelled),nameof(ProcessingStatus77Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.PendingCancellation),nameof(ProcessingStatus77Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Proprietary),nameof(ProcessingStatus77Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.CancellationRequested),nameof(ProcessingStatus77Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.ModificationRequested),nameof(ProcessingStatus77Choice.ModificationRequested))]
    [IsoId("_AYE5i_fZEeiNZp_PtLohLw")]
    [DisplayName("Processing Status 77 Choice")]
    public abstract partial record ProcessingStatus77Choice_
    {
    }
}
