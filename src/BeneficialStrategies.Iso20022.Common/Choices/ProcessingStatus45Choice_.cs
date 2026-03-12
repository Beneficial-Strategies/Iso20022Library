// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus45Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus45Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus45Choice.Repair))]
    [KnownType(typeof(ProcessingStatus45Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus45Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus45Choice.Denied))]
    [KnownType(typeof(ProcessingStatus45Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.PendingCancellation),nameof(ProcessingStatus45Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Rejected),nameof(ProcessingStatus45Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Repair),nameof(ProcessingStatus45Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.AcknowledgedAccepted),nameof(ProcessingStatus45Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Proprietary),nameof(ProcessingStatus45Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Denied),nameof(ProcessingStatus45Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Cancelled),nameof(ProcessingStatus45Choice.Cancelled))]
    [IsoId("_iZ9xMVhgEeS8HfHHd4stCA")]
    [DisplayName("Processing Status 45 Choice")]
    public abstract partial record ProcessingStatus45Choice_
    {
    }
}
