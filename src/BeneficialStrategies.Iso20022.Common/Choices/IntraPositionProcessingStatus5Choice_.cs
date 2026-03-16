// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus5Choice.Rejected),
        nameof(IntraPositionProcessingStatus5Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus5Choice.Repair),
        nameof(IntraPositionProcessingStatus5Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus5Choice.Cancelled),
        nameof(IntraPositionProcessingStatus5Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted),
        nameof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus5Choice.Proprietary),
        nameof(IntraPositionProcessingStatus5Choice.Proprietary)
    )]
    [IsoId("_DwdiUTnuEeWfSKvvZlhRKg")]
    [DisplayName("Intra Position Processing Status 5 Choice")]
    public abstract record IntraPositionProcessingStatus5Choice_ { }
}
