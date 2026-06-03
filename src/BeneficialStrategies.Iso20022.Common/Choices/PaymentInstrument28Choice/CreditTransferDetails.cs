// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument28Choice
{
    /// <summary>Credit transfer details.</summary>
    [IsoId("d5197593-8e5c-46ce-bce6-c747be5f33fb")]
    [DisplayName("Credit Transfer Details")]
    public record CreditTransferDetails : PaymentInstrument28Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CdtTrfDtls")]
        public required CreditTransfer12 Value { get; init; }
    }
}
