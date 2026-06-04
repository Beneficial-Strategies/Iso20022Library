// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition42Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_KYhCYfHREfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 42 Choice")]
    [KnownType(typeof(SettlementTransactionCondition42Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition42Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition42Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition42Choice.Proprietary))]
    public abstract record SettlementTransactionCondition42Choice_
    {
    }
}
