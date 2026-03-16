// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus10Choice.Rejected),
        nameof(IntraPositionProcessingStatus10Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus10Choice.Repair),
        nameof(IntraPositionProcessingStatus10Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus10Choice.Cancelled),
        nameof(IntraPositionProcessingStatus10Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus10Choice.AcknowledgedAccepted),
        nameof(IntraPositionProcessingStatus10Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus10Choice.Proprietary),
        nameof(IntraPositionProcessingStatus10Choice.Proprietary)
    )]
    [IsoId("_cdk0oTi8Eeydid5dcNPKvg")]
    [DisplayName("Intra Position Processing Status 10 Choice")]
    public abstract record IntraPositionProcessingStatus10Choice_ { }
}
