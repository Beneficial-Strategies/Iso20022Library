// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantitySearch2Choice
{
    /// <summary>Quantity expressed as a number, for example a number of shares.</summary>
    [IsoId("_emN9kWqWEemz04WrKJaMEA")]
    [DisplayName("Unit")]
    public record Unit : FinancialInstrumentQuantitySearch2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Unit")]
        public required QuantityRange1Choice_ Value { get; init; }
    }
}
