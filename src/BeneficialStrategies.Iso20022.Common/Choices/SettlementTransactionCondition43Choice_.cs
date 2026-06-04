// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition43Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_hZRLwfHSEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 43 Choice")]
    [KnownType(typeof(SettlementTransactionCondition43Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition43Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition43Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition43Choice.Proprietary))]
    public abstract record SettlementTransactionCondition43Choice_
    {
    }
}
