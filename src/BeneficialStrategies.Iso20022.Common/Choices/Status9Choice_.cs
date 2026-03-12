// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status9Choice.Proprietary))]
    [KnownType(typeof(Status9Choice.MatchingStatus))]
    [KnownType(typeof(Status9Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status9Choice.SettlementStatus))]
    [KnownType(typeof(Status9Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status9Choice.Proprietary),nameof(Status9Choice.Proprietary))]
    [JsonDerivedType(typeof(Status9Choice.MatchingStatus),nameof(Status9Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status9Choice.InferredMatchingStatus),nameof(Status9Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status9Choice.SettlementStatus),nameof(Status9Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status9Choice.InstructionProcessingStatus),nameof(Status9Choice.InstructionProcessingStatus))]
    [IsoId("_4BGc4f8dEeCrw_OT0uBMXQ")]
    [DisplayName("Status 9 Choice")]
    public abstract partial record Status9Choice_
    {
    }
}
