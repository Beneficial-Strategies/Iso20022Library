// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus50Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus50Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus50Choice.Completed))]
    [KnownType(typeof(ProcessingStatus50Choice.Denied))]
    [KnownType(typeof(ProcessingStatus50Choice.Pending))]
    [KnownType(typeof(ProcessingStatus50Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingStatus50Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus50Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus50Choice.Rejected),
        nameof(ProcessingStatus50Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus50Choice.Completed),
        nameof(ProcessingStatus50Choice.Completed)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus50Choice.Denied),
        nameof(ProcessingStatus50Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus50Choice.Pending),
        nameof(ProcessingStatus50Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus50Choice.Proprietary),
        nameof(ProcessingStatus50Choice.Proprietary)
    )]
    [IsoId("_iSz08TnvEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status 50 Choice")]
    public abstract record ProcessingStatus50Choice_ { }
}
