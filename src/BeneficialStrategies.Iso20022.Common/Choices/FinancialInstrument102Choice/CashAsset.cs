// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument102Choice
{
    /// <summary>Identification of the cash asset.</summary>
    [IsoId("3b7afbaa-480f-448c-b651-d17b4ff69dc5")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAsst")]
        public required CashAsset2 Value { get; init; }
    }
}
