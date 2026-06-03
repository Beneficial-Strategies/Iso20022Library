// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument101Choice
{
    /// <summary>Identification of another kind of asset in the holding that is not a security or cash.</summary>
    [IsoId("c86d92d0-d349-47cd-bbcb-702e5719a681")]
    [DisplayName("Other Asset")]
    public record OtherAsset : FinancialInstrument101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrAsst")]
        public required OtherAsset2 Value { get; init; }
    }
}
