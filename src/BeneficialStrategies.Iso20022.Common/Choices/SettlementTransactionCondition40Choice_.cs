// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition40Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_ES2MAfHOEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 40 Choice")]
    [KnownType(typeof(SettlementTransactionCondition40Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition40Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition40Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition40Choice.Proprietary))]
    public abstract record SettlementTransactionCondition40Choice_
    {
    }
}
