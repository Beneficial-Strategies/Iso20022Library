// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus53Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus53Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus53Choice.Repair))]
    [KnownType(typeof(ProcessingStatus53Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus53Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus53Choice.Denied))]
    [KnownType(typeof(ProcessingStatus53Choice.Cancelled))]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.PendingCancellation),
        nameof(ProcessingStatus53Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.Rejected),
        nameof(ProcessingStatus53Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.Repair),
        nameof(ProcessingStatus53Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus53Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.Proprietary),
        nameof(ProcessingStatus53Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.Denied),
        nameof(ProcessingStatus53Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus53Choice.Cancelled),
        nameof(ProcessingStatus53Choice.Cancelled)
    )]
    [IsoId("_2dJB8Tp4EeWVrPy0StzzSg")]
    [DisplayName("Processing Status 53 Choice")]
    public abstract record ProcessingStatus53Choice_ { }
}
