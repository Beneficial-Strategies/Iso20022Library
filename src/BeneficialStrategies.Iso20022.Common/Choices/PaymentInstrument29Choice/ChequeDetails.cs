// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Cheque details.</summary>
    [IsoId("13da0c15-50b2-4278-b616-a242e0cb6f2a")]
    [DisplayName("Cheque Details")]
    public record ChequeDetails : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChqDtls")]
        public required Cheque10 Value { get; init; }
    }
}
