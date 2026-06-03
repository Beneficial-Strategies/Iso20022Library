// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount6Choice
{
    /// <summary>Specifies the price as an amount with currency.</summary>
    [IsoId("_xuxKU2hTEeq6Jv5Orh6cCw")]
    [DisplayName("Amount With Currency")]
    public record AmountWithCurrency : PriceRateOrAmount6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AmtWthCcy")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
