// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount4Choice
{
    /// <summary>Specifies the price as a rate.</summary>
    [IsoId("_JFkB4TmpEemla4muNfgRrg")]
    [DisplayName("Rate")]
    public record Rate : PriceRateOrAmount4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rate")]
        public required IsoPercentageRate Value { get; init; }
    }
}
