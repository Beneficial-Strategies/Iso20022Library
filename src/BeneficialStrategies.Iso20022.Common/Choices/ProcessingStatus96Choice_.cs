// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus96Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus96Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus96Choice.Repair))]
    [KnownType(typeof(ProcessingStatus96Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus96Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus96Choice.Denied))]
    [KnownType(typeof(ProcessingStatus96Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.PendingCancellation),nameof(ProcessingStatus96Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.Rejected),nameof(ProcessingStatus96Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.Repair),nameof(ProcessingStatus96Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.AcknowledgedAccepted),nameof(ProcessingStatus96Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.Proprietary),nameof(ProcessingStatus96Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.Denied),nameof(ProcessingStatus96Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus96Choice.Cancelled),nameof(ProcessingStatus96Choice.Cancelled))]
    [IsoId("_gBzJZzi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 96 Choice")]
    public abstract partial record ProcessingStatus96Choice_
    {
    }
}
