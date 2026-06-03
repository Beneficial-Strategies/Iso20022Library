// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Electronic money product that provides the cardholder with a portable and specialised computer device.</summary>
    [IsoId("d7ab995d-253f-4cc6-ae81-21f1d8aadad2")]
    [DisplayName("Payment Card Details")]
    public record PaymentCardDetails : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PmtCardDtls")]
        public required PaymentCard34 Value { get; init; }
    }
}
