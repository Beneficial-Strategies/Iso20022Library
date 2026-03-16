// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status29Choice.Proprietary))]
    [KnownType(typeof(Status29Choice.MatchingStatus))]
    [KnownType(typeof(Status29Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status29Choice.SettlementStatus))]
    [KnownType(typeof(Status29Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status29Choice.Proprietary), nameof(Status29Choice.Proprietary))]
    [JsonDerivedType(typeof(Status29Choice.MatchingStatus), nameof(Status29Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status29Choice.InferredMatchingStatus),
        nameof(Status29Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status29Choice.SettlementStatus),
        nameof(Status29Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status29Choice.InstructionProcessingStatus),
        nameof(Status29Choice.InstructionProcessingStatus)
    )]
    [IsoId("_IYQ_QdB7EeihG9bKfarOOA")]
    [DisplayName("Status 29 Choice")]
    public abstract record Status29Choice_ { }
}
