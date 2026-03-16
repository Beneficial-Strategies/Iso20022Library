// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status2Choice.Proprietary))]
    [KnownType(typeof(Status2Choice.MatchingStatus))]
    [KnownType(typeof(Status2Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status2Choice.SettlementStatus))]
    [KnownType(typeof(Status2Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status2Choice.Proprietary), nameof(Status2Choice.Proprietary))]
    [JsonDerivedType(typeof(Status2Choice.MatchingStatus), nameof(Status2Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status2Choice.InferredMatchingStatus),
        nameof(Status2Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status2Choice.SettlementStatus),
        nameof(Status2Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status2Choice.InstructionProcessingStatus),
        nameof(Status2Choice.InstructionProcessingStatus)
    )]
    [IsoId("_UaQi09p-Ed-ak6NoX_4Aeg_1627831869")]
    [DisplayName("Status 2 Choice")]
    public abstract record Status2Choice_ { }
}
