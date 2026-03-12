// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus54Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus54Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus54Choice.Repair))]
    [KnownType(typeof(ProcessingStatus54Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus54Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus54Choice.Denied))]
    [KnownType(typeof(ProcessingStatus54Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.PendingCancellation),nameof(ProcessingStatus54Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Rejected),nameof(ProcessingStatus54Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Repair),nameof(ProcessingStatus54Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.AcknowledgedAccepted),nameof(ProcessingStatus54Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Proprietary),nameof(ProcessingStatus54Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Denied),nameof(ProcessingStatus54Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Cancelled),nameof(ProcessingStatus54Choice.Cancelled))]
    [IsoId("_29-eITp4EeWVrPy0StzzSg")]
    [DisplayName("Processing Status 54 Choice")]
    public abstract partial record ProcessingStatus54Choice_
    {
    }
}
