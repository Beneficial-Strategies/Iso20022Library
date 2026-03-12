// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus62Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus62Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus62Choice.Repair))]
    [KnownType(typeof(ProcessingStatus62Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus62Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus62Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.AcknowledgedAccepted),nameof(ProcessingStatus62Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.PendingProcessing),nameof(ProcessingStatus62Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.Repair),nameof(ProcessingStatus62Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.PendingCancellation),nameof(ProcessingStatus62Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.Proprietary),nameof(ProcessingStatus62Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.CancellationRequested),nameof(ProcessingStatus62Choice.CancellationRequested))]
    [IsoId("_6d7vh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 62 Choice")]
    public abstract partial record ProcessingStatus62Choice_
    {
    }
}
