// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument103Choice
{
    /// <summary>Identification of another kind of asset in the holding that is not a security or cash.</summary>
    [IsoId("204caace-b233-43a2-ba7a-4cd4c70ea350")]
    [DisplayName("Other Asset")]
    public record OtherAsset : FinancialInstrument103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrAsst")]
        public required OtherAsset2 Value { get; init; }
    }
}
