// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount4Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats for the price.</summary>
    [IsoId("_I4l84TmpEemla4muNfgRrg")]
    [DisplayName("Price Rate Or Amount 4 Choice")]
    [KnownType(typeof(PriceRateOrAmount4Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmount4Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmount4Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmount4Choice.Amount))]
    public abstract record PriceRateOrAmount4Choice_
    {
    }
}
