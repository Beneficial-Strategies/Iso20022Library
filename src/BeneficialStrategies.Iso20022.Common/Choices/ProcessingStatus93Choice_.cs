// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus93Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus93Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus93Choice.Repair))]
    [KnownType(typeof(ProcessingStatus93Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus93Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus93Choice.Denied))]
    [KnownType(typeof(ProcessingStatus93Choice.Cancelled))]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.PendingCancellation),
        nameof(ProcessingStatus93Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.Rejected),
        nameof(ProcessingStatus93Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.Repair),
        nameof(ProcessingStatus93Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus93Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.Proprietary),
        nameof(ProcessingStatus93Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.Denied),
        nameof(ProcessingStatus93Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus93Choice.Cancelled),
        nameof(ProcessingStatus93Choice.Cancelled)
    )]
    [IsoId("_ds1dYTi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 93 Choice")]
    public abstract record ProcessingStatus93Choice_ { }
}
