// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument28Choice
{
    /// <summary>Cheque details.</summary>
    [IsoId("0c48a90c-67b0-4a46-a0b9-896c790686e1")]
    [DisplayName("Cheque Details")]
    public record ChequeDetails : PaymentInstrument28Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChqDtls")]
        public required Cheque10 Value { get; init; }
    }
}
