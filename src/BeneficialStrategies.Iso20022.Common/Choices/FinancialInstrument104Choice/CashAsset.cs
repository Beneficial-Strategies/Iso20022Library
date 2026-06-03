// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument104Choice
{
    /// <summary>Identification of the cash asset.</summary>
    [IsoId("f40877a9-f27b-47f2-9367-68ab672a80bd")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAsst")]
        public required CashAsset2 Value { get; init; }
    }
}
