// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition45Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_rfdjMfHTEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 45 Choice")]
    [KnownType(typeof(SettlementTransactionCondition45Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition45Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition45Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition45Choice.Proprietary))]
    public abstract record SettlementTransactionCondition45Choice_
    {
    }
}
