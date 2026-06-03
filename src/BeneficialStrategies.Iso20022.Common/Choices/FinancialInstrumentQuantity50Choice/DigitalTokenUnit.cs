// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity50Choice
{
    /// <summary>Quantity expressed as a number of digital token units.</summary>
    [IsoId("16dd88a9-e2dc-4c4f-960d-cc4255ab379a")]
    [DisplayName("Digital Token Unit")]
    public record DigitalTokenUnit : FinancialInstrumentQuantity50Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlTknUnit")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
