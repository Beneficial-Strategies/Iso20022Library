// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status38Choice.Proprietary))]
    [KnownType(typeof(Status38Choice.MatchingStatus))]
    [KnownType(typeof(Status38Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status38Choice.SettlementStatus))]
    [KnownType(typeof(Status38Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status38Choice.Proprietary), nameof(Status38Choice.Proprietary))]
    [JsonDerivedType(typeof(Status38Choice.MatchingStatus), nameof(Status38Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status38Choice.InferredMatchingStatus),
        nameof(Status38Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status38Choice.SettlementStatus),
        nameof(Status38Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status38Choice.InstructionProcessingStatus),
        nameof(Status38Choice.InstructionProcessingStatus)
    )]
    [IsoId("_cOdm5SW-EeygjNFjAlVoPA")]
    [DisplayName("Status 38 Choice")]
    public abstract record Status38Choice_ { }
}
