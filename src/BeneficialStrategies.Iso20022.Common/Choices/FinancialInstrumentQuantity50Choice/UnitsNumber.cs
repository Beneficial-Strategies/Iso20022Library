// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity50Choice
{
    /// <summary>Quantity expressed as a number of units.</summary>
    [IsoId("2b17d5dd-145d-4179-aa87-f5cb5d5af79e")]
    [DisplayName("Units Number")]
    public record UnitsNumber : FinancialInstrumentQuantity50Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UnitsNb")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
