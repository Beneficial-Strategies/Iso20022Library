// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount6Choice
{
    /// <summary>Specifies the price as an amount.</summary>
    [IsoId("_xuxKUmhTEeq6Jv5Orh6cCw")]
    [DisplayName("Amount")]
    public record Amount : PriceRateOrAmount6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Amt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
