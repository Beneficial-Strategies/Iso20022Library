// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Credit transfer details.</summary>
    [IsoId("4655456f-9494-4cfc-9dd6-f132f6ad6cbd")]
    [DisplayName("Credit Transfer Details")]
    public record CreditTransferDetails : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CdtTrfDtls")]
        public required CreditTransfer12 Value { get; init; }
    }
}
