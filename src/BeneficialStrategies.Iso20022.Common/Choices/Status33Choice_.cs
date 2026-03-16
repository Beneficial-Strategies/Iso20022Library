// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status33Choice.Proprietary))]
    [KnownType(typeof(Status33Choice.MatchingStatus))]
    [KnownType(typeof(Status33Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status33Choice.SettlementStatus))]
    [KnownType(typeof(Status33Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status33Choice.Proprietary), nameof(Status33Choice.Proprietary))]
    [JsonDerivedType(typeof(Status33Choice.MatchingStatus), nameof(Status33Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status33Choice.InferredMatchingStatus),
        nameof(Status33Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status33Choice.SettlementStatus),
        nameof(Status33Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status33Choice.InstructionProcessingStatus),
        nameof(Status33Choice.InstructionProcessingStatus)
    )]
    [IsoId("_waWF8yAeEeuyDZ-ukt4YRg")]
    [DisplayName("Status 33 Choice")]
    public abstract record Status33Choice_ { }
}
