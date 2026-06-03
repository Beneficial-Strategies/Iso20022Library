// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut8Choice
{
    /// <summary>Payment instrument for the cash-out flow.</summary>
    [IsoId("dd4c185a-8da3-484c-867a-64d85a65683f")]
    [DisplayName("Cash Out Payment Instrument")]
    public record CashOutPaymentInstrument : CashInOrOut8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshOutPmtInstrm")]
        public required PaymentInstrument28Choice_ Value { get; init; }
    }
}
