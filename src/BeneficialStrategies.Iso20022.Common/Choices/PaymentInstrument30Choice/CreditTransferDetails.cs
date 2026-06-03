// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Credit transfer details.</summary>
    [IsoId("e0179a41-dce3-4c02-a479-1c2d235ccb19")]
    [DisplayName("Credit Transfer Details")]
    public record CreditTransferDetails : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CdtTrfDtls")]
        public required CreditTransfer12 Value { get; init; }
    }
}
