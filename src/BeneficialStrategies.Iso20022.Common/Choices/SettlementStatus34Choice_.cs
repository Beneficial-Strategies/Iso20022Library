// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementStatus34Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement status.</summary>
    [IsoId("_Xhm_1-SkEe-qVZLXW4RRBw")]
    [DisplayName("Settlement Status 34 Choice")]
    [KnownType(typeof(SettlementStatus34Choice.Pending))]
    [KnownType(typeof(SettlementStatus34Choice.Failing))]
    [KnownType(typeof(SettlementStatus34Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus34Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus34Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus34Choice.Proprietary))]
    public abstract record SettlementStatus34Choice_
    {
    }
}
