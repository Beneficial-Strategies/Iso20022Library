// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut8Choice
{
    /// <summary>Payment instrument for the cash-in flow.</summary>
    [IsoId("90da441f-054a-4a0b-a51e-39541e371e71")]
    [DisplayName("Cash In Payment Instrument")]
    public record CashInPaymentInstrument : CashInOrOut8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshInPmtInstrm")]
        public required PaymentInstrument30Choice_ Value { get; init; }
    }
}
