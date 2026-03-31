// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus7Choice.Rejected),
        nameof(IntraPositionProcessingStatus7Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus7Choice.Repair),
        nameof(IntraPositionProcessingStatus7Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus7Choice.Cancelled),
        nameof(IntraPositionProcessingStatus7Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted),
        nameof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus7Choice.Proprietary),
        nameof(IntraPositionProcessingStatus7Choice.Proprietary)
    )]
    [IsoId("_4EhzQewLEeiazoAmcoGsBQ")]
    [DisplayName("Intra Position Processing Status 7 Choice")]
    public abstract record IntraPositionProcessingStatus7Choice_ { }
}
