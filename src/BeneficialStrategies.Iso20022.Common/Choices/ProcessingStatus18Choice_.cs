// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus18Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus18Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus18Choice.Completed))]
    [KnownType(typeof(ProcessingStatus18Choice.Denied))]
    [KnownType(typeof(ProcessingStatus18Choice.Pending))]
    [KnownType(typeof(ProcessingStatus18Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.AcknowledgedAccepted),nameof(ProcessingStatus18Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Rejected),nameof(ProcessingStatus18Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Completed),nameof(ProcessingStatus18Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Denied),nameof(ProcessingStatus18Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Pending),nameof(ProcessingStatus18Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Proprietary),nameof(ProcessingStatus18Choice.Proprietary))]
    [IsoId("_OJMkAf4vEeClUvPNHKL9Zw")]
    [DisplayName("Processing Status 18 Choice")]
    public abstract partial record ProcessingStatus18Choice_
    {
    }
}
