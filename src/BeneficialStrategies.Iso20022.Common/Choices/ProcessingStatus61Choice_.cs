// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus61Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus61Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus61Choice.Repair))]
    [KnownType(typeof(ProcessingStatus61Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus61Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus61Choice.Denied))]
    [KnownType(typeof(ProcessingStatus61Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.PendingCancellation),nameof(ProcessingStatus61Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Rejected),nameof(ProcessingStatus61Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Repair),nameof(ProcessingStatus61Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.AcknowledgedAccepted),nameof(ProcessingStatus61Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Proprietary),nameof(ProcessingStatus61Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Denied),nameof(ProcessingStatus61Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Cancelled),nameof(ProcessingStatus61Choice.Cancelled))]
    [IsoId("_6QDryZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 61 Choice")]
    public abstract partial record ProcessingStatus61Choice_
    {
    }
}
