// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RateFormat32Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a rate format expressed as a rate or a not specified rate.</summary>
    [IsoId("_k18KsakHEfCG_LQaXOxwew")]
    [DisplayName("Rate Format 32 Choice")]
    [KnownType(typeof(RateFormat32Choice.Rate))]
    [KnownType(typeof(RateFormat32Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat32Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat32Choice.NotSpecifiedRate))]
    public abstract record RateFormat32Choice_
    {
    }
}
