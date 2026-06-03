// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification3Choice
{
    /// <summary>ISIN used to identify the security to be defined as eligible.</summary>
    [IsoId("_xHPWs2c-EemvNLufWGIVOQ")]
    [DisplayName("Financial Instrument Identification")]
    public record FinancialInstrumentIdentification : EligibilityIdentification3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FinInstrmId")]
        public required IsoISINOct2015Identifier Value { get; init; }
    }
}
