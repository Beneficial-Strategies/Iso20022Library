// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus84Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus84Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus84Choice.Repair))]
    [KnownType(typeof(ProcessingStatus84Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus84Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus84Choice.Denied))]
    [KnownType(typeof(ProcessingStatus84Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.PendingCancellation),nameof(ProcessingStatus84Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Rejected),nameof(ProcessingStatus84Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Repair),nameof(ProcessingStatus84Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.AcknowledgedAccepted),nameof(ProcessingStatus84Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Proprietary),nameof(ProcessingStatus84Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Denied),nameof(ProcessingStatus84Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Cancelled),nameof(ProcessingStatus84Choice.Cancelled))]
    [IsoId("_mC22sStVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 84 Choice")]
    public abstract partial record ProcessingStatus84Choice_
    {
    }
}
