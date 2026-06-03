// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument103Choice
{
    /// <summary>Identification of the cash asset.</summary>
    [IsoId("9ee32154-c997-4e83-b09c-9f4b20a085fe")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAsst")]
        public required CashAsset3 Value { get; init; }
    }
}
