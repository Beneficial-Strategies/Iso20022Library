// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus23Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus23Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus23Choice.Repair))]
    [KnownType(typeof(ProcessingStatus23Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus23Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus23Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.AcknowledgedAccepted),nameof(ProcessingStatus23Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.PendingProcessing),nameof(ProcessingStatus23Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.Repair),nameof(ProcessingStatus23Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.PendingCancellation),nameof(ProcessingStatus23Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.Proprietary),nameof(ProcessingStatus23Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.CancellationRequested),nameof(ProcessingStatus23Choice.CancellationRequested))]
    [IsoId("_tTjyYf7sEeCvPoRGOxRobQ")]
    [DisplayName("Processing Status 23 Choice")]
    public abstract partial record ProcessingStatus23Choice_
    {
    }
}
