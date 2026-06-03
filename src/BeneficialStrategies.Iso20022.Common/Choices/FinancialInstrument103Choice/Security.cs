// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument103Choice
{
    /// <summary>Identification of the security.</summary>
    [IsoId("93c88c7f-3a87-478e-9f5a-f9a87587a4c3")]
    [DisplayName("Security")]
    public record Security : FinancialInstrument103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Scty")]
        public required FinancialInstrumentIdentification11 Value { get; init; }
    }
}
