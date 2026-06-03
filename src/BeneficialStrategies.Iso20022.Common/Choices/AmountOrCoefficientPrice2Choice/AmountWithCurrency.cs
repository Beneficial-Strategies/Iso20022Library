// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrCoefficientPrice2Choice
{
    /// <summary>Provides details of the price when expressed with an amount and explicit currency.</summary>
    [IsoId("_XEe5AWhTEeq6Jv5Orh6cCw")]
    [DisplayName("Amount With Currency")]
    public record AmountWithCurrency : AmountOrCoefficientPrice2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AmtWthCcy")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
