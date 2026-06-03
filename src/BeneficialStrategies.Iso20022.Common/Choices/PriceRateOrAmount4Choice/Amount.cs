// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount4Choice
{
    /// <summary>Specifies the price as an amount.</summary>
    [IsoId("_JFkB4zmpEemla4muNfgRrg")]
    [DisplayName("Amount")]
    public record Amount : PriceRateOrAmount4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Value { get; init; }
    }
}
