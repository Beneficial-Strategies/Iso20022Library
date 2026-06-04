// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Quantity83Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between E-money token settlement quantity and network fee quantity.</summary>
    [IsoId("_oLJNEJZdEfCShM_qO0U4ig")]
    [DisplayName("Quantity 83 Choice")]
    [KnownType(typeof(Quantity83Choice.ElectronicMoneyTokenSettlementQuantity))]
    [KnownType(typeof(Quantity83Choice.NetworkFeeQuantity))]
    [JsonDerivedType(typeof(Quantity83Choice.ElectronicMoneyTokenSettlementQuantity))]
    [JsonDerivedType(typeof(Quantity83Choice.NetworkFeeQuantity))]
    public abstract record Quantity83Choice_
    {
    }
}
