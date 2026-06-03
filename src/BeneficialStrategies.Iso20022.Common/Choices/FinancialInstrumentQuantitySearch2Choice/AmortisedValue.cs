// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantitySearch2Choice
{
    /// <summary>Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.</summary>
    [IsoId("_emN9m2qWEemz04WrKJaMEA")]
    [DisplayName("Amortised Value")]
    public record AmortisedValue : FinancialInstrumentQuantitySearch2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AmtsdVal")]
        public required ImpliedCurrencyAmountRange1Choice_ Value { get; init; }
    }
}
