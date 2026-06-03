// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Banker's draft details.</summary>
    [IsoId("ac988b12-7cd8-4842-b8cc-9f67699195f9")]
    [DisplayName("Bankers Draft Details")]
    public record BankersDraftDetails : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BkrsDrftDtls")]
        public required Cheque10 Value { get; init; }
    }
}
