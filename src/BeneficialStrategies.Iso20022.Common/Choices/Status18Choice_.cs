// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status18Choice.Proprietary))]
    [KnownType(typeof(Status18Choice.MatchingStatus))]
    [KnownType(typeof(Status18Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status18Choice.SettlementStatus))]
    [KnownType(typeof(Status18Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status18Choice.Proprietary),nameof(Status18Choice.Proprietary))]
    [JsonDerivedType(typeof(Status18Choice.MatchingStatus),nameof(Status18Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status18Choice.InferredMatchingStatus),nameof(Status18Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status18Choice.SettlementStatus),nameof(Status18Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status18Choice.InstructionProcessingStatus),nameof(Status18Choice.InstructionProcessingStatus))]
    [IsoId("_gi4k0TnuEeWfSKvvZlhRKg")]
    [DisplayName("Status 18 Choice")]
    public abstract partial record Status18Choice_
    {
    }
}
