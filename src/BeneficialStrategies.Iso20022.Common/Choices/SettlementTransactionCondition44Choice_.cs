// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition44Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_EMWwMfHTEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 44 Choice")]
    [KnownType(typeof(SettlementTransactionCondition44Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition44Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition44Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition44Choice.Proprietary))]
    public abstract record SettlementTransactionCondition44Choice_
    {
    }
}
