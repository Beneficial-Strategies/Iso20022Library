// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument102Choice
{
    /// <summary>Identification of the security.</summary>
    [IsoId("4fa97e60-c7bf-4279-a6e2-09c96dfc97e9")]
    [DisplayName("Security")]
    public record Security : FinancialInstrument102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Scty")]
        public required FinancialInstrumentIdentification8 Value { get; init; }
    }
}
