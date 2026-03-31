// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status32Choice.Proprietary))]
    [KnownType(typeof(Status32Choice.MatchingStatus))]
    [KnownType(typeof(Status32Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status32Choice.SettlementStatus))]
    [KnownType(typeof(Status32Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status32Choice.Proprietary), nameof(Status32Choice.Proprietary))]
    [JsonDerivedType(typeof(Status32Choice.MatchingStatus), nameof(Status32Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status32Choice.InferredMatchingStatus),
        nameof(Status32Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status32Choice.SettlementStatus),
        nameof(Status32Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status32Choice.InstructionProcessingStatus),
        nameof(Status32Choice.InstructionProcessingStatus)
    )]
    [IsoId("_A4MfIQpIEeup4r-PFG2T5Q")]
    [DisplayName("Status 32 Choice")]
    public abstract record Status32Choice_ { }
}
