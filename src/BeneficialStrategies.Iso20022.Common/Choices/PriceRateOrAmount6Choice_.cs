// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount6Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats for the price.</summary>
    [IsoId("_5J49gWeiEeqY_MU7lK4HCA")]
    [DisplayName("Price Rate Or Amount 6 Choice")]
    [KnownType(typeof(PriceRateOrAmount6Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmount6Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmount6Choice.AmountWithCurrency))]
    [JsonDerivedType(typeof(PriceRateOrAmount6Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmount6Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmount6Choice.AmountWithCurrency))]
    public abstract record PriceRateOrAmount6Choice_
    {
    }
}
