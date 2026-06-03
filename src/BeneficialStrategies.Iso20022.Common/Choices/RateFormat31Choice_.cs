// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RateFormat31Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a rate format expressed as a rate, a not specified rate, or an amount.</summary>
    [IsoId("__AIlgajtEfCG_LQaXOxwew")]
    [DisplayName("Rate Format 31 Choice")]
    [KnownType(typeof(RateFormat31Choice.Rate))]
    [KnownType(typeof(RateFormat31Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat31Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat31Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat31Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat31Choice.Amount))]
    public abstract record RateFormat31Choice_
    {
    }
}
