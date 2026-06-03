// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Banker's draft details.</summary>
    [IsoId("cbc31698-85b6-4b22-ac3d-5640d2927b06")]
    [DisplayName("Bankers Draft Details")]
    public record BankersDraftDetails : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BkrsDrftDtls")]
        public required Cheque10 Value { get; init; }
    }
}
