// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument31Choice
{
    /// <summary>Cheque details.</summary>
    [IsoId("4613b0ed-26a6-45db-8c7e-f14a71bb25fb")]
    [DisplayName("Cheque Details")]
    public record ChequeDetails : PaymentInstrument31Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChqDtls")]
        public required Cheque12 Value { get; init; }
    }
}
