// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument102Choice
{
    /// <summary>Identification of another kind of asset in the holding that is not a security or cash.</summary>
    [IsoId("c5b8016e-736b-4733-9af3-49ee54a882c6")]
    [DisplayName("Other Asset")]
    public record OtherAsset : FinancialInstrument102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrAsst")]
        public required OtherAsset2 Value { get; init; }
    }
}
