// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.QuantitySearch2Choice
{
    /// <summary>Specifies the quantity.</summary>
    [IsoId("_eaw7gWqWEemz04WrKJaMEA")]
    [DisplayName("Quantity")]
    public record Quantity : QuantitySearch2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantitySearch2Choice_ Value { get; init; }
    }
}
