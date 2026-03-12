// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Rejected),nameof(IntraPositionProcessingStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Repair),nameof(IntraPositionProcessingStatus3Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Cancelled),nameof(IntraPositionProcessingStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus3Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Proprietary),nameof(IntraPositionProcessingStatus3Choice.Proprietary))]
    [IsoId("_ifpDQf4wEeClUvPNHKL9Zw")]
    [DisplayName("Intra Position Processing Status 3 Choice")]
    public abstract partial record IntraPositionProcessingStatus3Choice_
    {
    }
}
