// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus69Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus69Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus69Choice.Repair))]
    [KnownType(typeof(ProcessingStatus69Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus69Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus69Choice.Denied))]
    [KnownType(typeof(ProcessingStatus69Choice.Cancelled))]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.PendingCancellation),
        nameof(ProcessingStatus69Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.Rejected),
        nameof(ProcessingStatus69Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.Repair),
        nameof(ProcessingStatus69Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus69Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.Proprietary),
        nameof(ProcessingStatus69Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.Denied),
        nameof(ProcessingStatus69Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus69Choice.Cancelled),
        nameof(ProcessingStatus69Choice.Cancelled)
    )]
    [IsoId("_1m2RQeF7EeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 69 Choice")]
    public abstract record ProcessingStatus69Choice_ { }
}
