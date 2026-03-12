// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus71Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus71Choice.Pending))]
    [KnownType(typeof(ProcessingStatus71Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus71Choice.Repair))]
    [KnownType(typeof(ProcessingStatus71Choice.Denied))]
    [KnownType(typeof(ProcessingStatus71Choice.Completed))]
    [KnownType(typeof(ProcessingStatus71Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.AcknowledgedAccepted),nameof(ProcessingStatus71Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Pending),nameof(ProcessingStatus71Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Rejected),nameof(ProcessingStatus71Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Repair),nameof(ProcessingStatus71Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Denied),nameof(ProcessingStatus71Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Completed),nameof(ProcessingStatus71Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Proprietary),nameof(ProcessingStatus71Choice.Proprietary))]
    [IsoId("_mZpJceGKEeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 71 Choice")]
    public abstract partial record ProcessingStatus71Choice_
    {
    }
}
