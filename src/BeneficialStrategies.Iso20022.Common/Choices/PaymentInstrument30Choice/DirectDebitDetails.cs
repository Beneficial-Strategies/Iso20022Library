// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Direct debit details.</summary>
    [IsoId("d0d78763-1344-4421-ad1e-957bcd78cdd2")]
    [DisplayName("Direct Debit Details")]
    public record DirectDebitDetails : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DrctDbtDtls")]
        public required DirectDebitMandate9 Value { get; init; }
    }
}
