// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity48Choice
{
    /// <summary>Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.</summary>
    [IsoId("6baf5e77-2fe1-4550-a460-d2811c98437f")]
    [DisplayName("Digital Token Unit")]
    public record DigitalTokenUnit : FinancialInstrumentQuantity48Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlTknUnit")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
