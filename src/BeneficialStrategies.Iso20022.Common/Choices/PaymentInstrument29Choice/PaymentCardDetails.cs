// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Payment card details.</summary>
    [IsoId("e0ee17da-d172-4709-9eac-75b3b1aa5ff4")]
    [DisplayName("Payment Card Details")]
    public record PaymentCardDetails : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PmtCardDtls")]
        public required PaymentCard34 Value { get; init; }
    }
}
