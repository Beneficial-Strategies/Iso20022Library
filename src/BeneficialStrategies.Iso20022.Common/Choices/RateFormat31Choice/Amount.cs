// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RateFormat31Choice
{
    /// <summary>Specifies the amount.</summary>
    [IsoId("_IJ18AKjuEfCG_LQaXOxwew")]
    [DisplayName("Amount")]
    public record Amount : RateFormat31Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Value { get; init; }
    }
}
