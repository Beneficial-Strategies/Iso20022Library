// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus6Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus6Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus6Choice.Repair))]
    [KnownType(typeof(ProcessingStatus6Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus6Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus6Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.AcknowledgedAccepted),nameof(ProcessingStatus6Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.PendingProcessing),nameof(ProcessingStatus6Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.Repair),nameof(ProcessingStatus6Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.PendingCancellation),nameof(ProcessingStatus6Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.Proprietary),nameof(ProcessingStatus6Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.CancellationRequested),nameof(ProcessingStatus6Choice.CancellationRequested))]
    [IsoId("_UVMcpNp-Ed-ak6NoX_4Aeg_-399020300")]
    [DisplayName("Processing Status 6 Choice")]
    public abstract partial record ProcessingStatus6Choice_
    {
    }
}
