// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status15Choice.Proprietary))]
    [KnownType(typeof(Status15Choice.MatchingStatus))]
    [KnownType(typeof(Status15Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status15Choice.SettlementStatus))]
    [KnownType(typeof(Status15Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status15Choice.Proprietary), nameof(Status15Choice.Proprietary))]
    [JsonDerivedType(typeof(Status15Choice.MatchingStatus), nameof(Status15Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status15Choice.InferredMatchingStatus),
        nameof(Status15Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status15Choice.SettlementStatus),
        nameof(Status15Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status15Choice.InstructionProcessingStatus),
        nameof(Status15Choice.InstructionProcessingStatus)
    )]
    [IsoId("_D9pP0yRhEeO8sskhVI3IDA")]
    [DisplayName("Status 15 Choice")]
    public abstract record Status15Choice_ { }
}
