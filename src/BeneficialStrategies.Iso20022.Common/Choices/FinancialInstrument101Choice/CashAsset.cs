// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument101Choice
{
    /// <summary>Identification of the cash asset.</summary>
    [IsoId("28d4e3e2-75b8-41ff-8f73-1ed96c839a7a")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAsst")]
        public required CashAsset3 Value { get; init; }
    }
}
