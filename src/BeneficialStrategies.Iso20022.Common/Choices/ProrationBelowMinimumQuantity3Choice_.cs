// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProrationBelowMinimumQuantity3Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code or proprietary code to specify the proration type below minimum quantity.</summary>
    [IsoId("_Nis2Eaj5EfCG_LQaXOxwew")]
    [DisplayName("Proration Below Minimum Quantity 3 Choice")]
    [KnownType(typeof(ProrationBelowMinimumQuantity3Choice.Code))]
    [KnownType(typeof(ProrationBelowMinimumQuantity3Choice.Proprietary))]
    [JsonDerivedType(typeof(ProrationBelowMinimumQuantity3Choice.Code))]
    [JsonDerivedType(typeof(ProrationBelowMinimumQuantity3Choice.Proprietary))]
    public abstract record ProrationBelowMinimumQuantity3Choice_
    {
    }
}
