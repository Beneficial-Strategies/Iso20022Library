// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition46Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the settlement transaction conditions.</summary>
    [IsoId("_mjnCUfHVEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition 46 Choice")]
    [KnownType(typeof(SettlementTransactionCondition46Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition46Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition46Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition46Choice.Proprietary))]
    public abstract record SettlementTransactionCondition46Choice_
    {
    }
}
