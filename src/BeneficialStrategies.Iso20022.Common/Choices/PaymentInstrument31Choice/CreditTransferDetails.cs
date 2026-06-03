// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument31Choice
{
    /// <summary>Credit transfer details.</summary>
    [IsoId("40322fcc-d11a-48d9-9d86-84c2545f9b99")]
    [DisplayName("Credit Transfer Details")]
    public record CreditTransferDetails : PaymentInstrument31Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CdtTrfDtls")]
        public required CreditTransfer13 Value { get; init; }
    }
}
