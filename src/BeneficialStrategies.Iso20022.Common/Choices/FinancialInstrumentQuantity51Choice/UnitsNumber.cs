// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity51Choice
{
    /// <summary>Quantity expressed as a number of units.</summary>
    [IsoId("96bf992e-5334-43ab-a902-703e9e4e649e")]
    [DisplayName("Units Number")]
    public record UnitsNumber : FinancialInstrumentQuantity51Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UnitsNb")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
