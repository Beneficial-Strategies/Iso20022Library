// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition47Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_mzGLofHcEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 47 Choice")]
    [KnownType(typeof(SettlementTransactionCondition47Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition47Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition47Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition47Choice.Proprietary))]
    public abstract record SettlementTransactionCondition47Choice_
    {
    }
}
