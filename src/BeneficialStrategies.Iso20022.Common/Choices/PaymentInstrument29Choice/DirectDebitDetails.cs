// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Direct debit details.</summary>
    [IsoId("2f96354f-f64a-45a3-ae4b-fc7754e0b724")]
    [DisplayName("Direct Debit Details")]
    public record DirectDebitDetails : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DrctDbtDtls")]
        public required DirectDebitMandate9 Value { get; init; }
    }
}
