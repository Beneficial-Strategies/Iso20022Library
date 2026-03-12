// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status39Choice.Proprietary))]
    [KnownType(typeof(Status39Choice.MatchingStatus))]
    [KnownType(typeof(Status39Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status39Choice.SettlementStatus))]
    [KnownType(typeof(Status39Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status39Choice.Proprietary),nameof(Status39Choice.Proprietary))]
    [JsonDerivedType(typeof(Status39Choice.MatchingStatus),nameof(Status39Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status39Choice.InferredMatchingStatus),nameof(Status39Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status39Choice.SettlementStatus),nameof(Status39Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status39Choice.InstructionProcessingStatus),nameof(Status39Choice.InstructionProcessingStatus))]
    [IsoId("_gEIFaji8Eeydid5dcNPKvg")]
    [DisplayName("Status 39 Choice")]
    public abstract partial record Status39Choice_
    {
    }
}
