// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantitySearch2Choice
{
    /// <summary>Quantity expressed as an amount representing the face amount, that is the principal, of a debt instrument.</summary>
    [IsoId("_emN9mWqWEemz04WrKJaMEA")]
    [DisplayName("Face Amount")]
    public record FaceAmount : FinancialInstrumentQuantitySearch2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FaceAmt")]
        public required ImpliedCurrencyAmountRange1Choice_ Value { get; init; }
    }
}
