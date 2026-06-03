// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity49Choice
{
    /// <summary>Quantity expressed as a number of digital token units.</summary>
    [IsoId("fac880ee-15a4-4b32-b9c2-0ca6ff0a9195")]
    [DisplayName("Digital Token Unit")]
    public record DigitalTokenUnit : FinancialInstrumentQuantity49Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlTknUnit")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
