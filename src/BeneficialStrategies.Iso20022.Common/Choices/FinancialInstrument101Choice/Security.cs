// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument101Choice
{
    /// <summary>Identification of the security.</summary>
    [IsoId("64495029-266c-457d-84d7-67b21490005e")]
    [DisplayName("Security")]
    public record Security : FinancialInstrument101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Scty")]
        public required FinancialInstrumentIdentification6 Value { get; init; }
    }
}
