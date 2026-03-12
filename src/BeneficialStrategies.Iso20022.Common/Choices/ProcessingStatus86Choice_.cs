// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus86Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus86Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus86Choice.Repair))]
    [KnownType(typeof(ProcessingStatus86Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus86Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus86Choice.Denied))]
    [KnownType(typeof(ProcessingStatus86Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.PendingCancellation),nameof(ProcessingStatus86Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Rejected),nameof(ProcessingStatus86Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Repair),nameof(ProcessingStatus86Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.AcknowledgedAccepted),nameof(ProcessingStatus86Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Proprietary),nameof(ProcessingStatus86Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Denied),nameof(ProcessingStatus86Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Cancelled),nameof(ProcessingStatus86Choice.Cancelled))]
    [IsoId("_oYBXVytVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 86 Choice")]
    public abstract partial record ProcessingStatus86Choice_
    {
    }
}
