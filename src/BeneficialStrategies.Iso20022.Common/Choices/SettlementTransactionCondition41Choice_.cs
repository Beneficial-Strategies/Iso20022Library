// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition41Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_KTpbYfHPEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 41 Choice")]
    [KnownType(typeof(SettlementTransactionCondition41Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition41Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition41Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition41Choice.Proprietary))]
    public abstract record SettlementTransactionCondition41Choice_
    {
    }
}
