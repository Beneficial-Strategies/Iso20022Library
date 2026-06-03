// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity49Choice
{
    /// <summary>Quantity expressed as a number of units.</summary>
    [IsoId("57b20e7d-8efa-4d43-9506-8caf5dedb077")]
    [DisplayName("Units Number")]
    public record UnitsNumber : FinancialInstrumentQuantity49Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UnitsNb")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
