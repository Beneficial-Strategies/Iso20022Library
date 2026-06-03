// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument104Choice
{
    /// <summary>Identification of the security.</summary>
    [IsoId("726904dd-be75-46cd-a072-752c80e27789")]
    [DisplayName("Security")]
    public record Security : FinancialInstrument104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Scty")]
        public required FinancialInstrumentIdentification11 Value { get; init; }
    }
}
