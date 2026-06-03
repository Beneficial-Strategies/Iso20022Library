// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Cheque details.</summary>
    [IsoId("f6f46e24-0359-4ec4-8fe6-7ed61c0f9b1d")]
    [DisplayName("Cheque Details")]
    public record ChequeDetails : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChqDtls")]
        public required Cheque10 Value { get; init; }
    }
}
