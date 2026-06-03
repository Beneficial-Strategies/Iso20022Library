// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument28Choice
{
    /// <summary>Banker's draft details.</summary>
    [IsoId("7d656f61-5871-4c04-a95d-555814ff960e")]
    [DisplayName("Bankers Draft Details")]
    public record BankersDraftDetails : PaymentInstrument28Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BkrsDrftDtls")]
        public required Cheque10 Value { get; init; }
    }
}
