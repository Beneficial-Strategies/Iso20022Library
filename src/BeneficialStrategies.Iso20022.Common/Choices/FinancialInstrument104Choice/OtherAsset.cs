// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument104Choice
{
    /// <summary>Identification of another kind of asset in the holding that is not a security or cash.</summary>
    [IsoId("6113ce1b-81e5-47e3-a177-487f426a0831")]
    [DisplayName("Other Asset")]
    public record OtherAsset : FinancialInstrument104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrAsst")]
        public required OtherAsset2 Value { get; init; }
    }
}
