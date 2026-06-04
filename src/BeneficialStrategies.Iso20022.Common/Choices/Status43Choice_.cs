// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Status43Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for a settlement transaction status.</summary>
    [IsoId("a8030c2e-e699-48b8-8c7c-1c42dd7ecbae")]
    [DisplayName("Status 43 Choice")]
    [KnownType(typeof(Status43Choice.Proprietary))]
    [KnownType(typeof(Status43Choice.MatchingStatus))]
    [KnownType(typeof(Status43Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status43Choice.SettlementStatus))]
    [KnownType(typeof(Status43Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status43Choice.Proprietary))]
    [JsonDerivedType(typeof(Status43Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status43Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status43Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status43Choice.InstructionProcessingStatus))]
    public abstract record Status43Choice_
    {
    }
}
