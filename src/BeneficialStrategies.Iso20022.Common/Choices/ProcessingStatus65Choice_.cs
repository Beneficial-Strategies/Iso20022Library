// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus65Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus65Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus65Choice.Repair))]
    [KnownType(typeof(ProcessingStatus65Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus65Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus65Choice.Denied))]
    [KnownType(typeof(ProcessingStatus65Choice.Cancelled))]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.PendingCancellation),
        nameof(ProcessingStatus65Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.Rejected),
        nameof(ProcessingStatus65Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.Repair),
        nameof(ProcessingStatus65Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus65Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.Proprietary),
        nameof(ProcessingStatus65Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.Denied),
        nameof(ProcessingStatus65Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus65Choice.Cancelled),
        nameof(ProcessingStatus65Choice.Cancelled)
    )]
    [IsoId("_8SdA-5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 65 Choice")]
    public abstract record ProcessingStatus65Choice_ { }
}
