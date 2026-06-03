// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity51Choice
{
    /// <summary>Quantity expressed as a number of digital token units.</summary>
    [IsoId("dafcf91a-d3d6-46fd-b572-e0cfb2cf9857")]
    [DisplayName("Digital Token Unit")]
    public record DigitalTokenUnit : FinancialInstrumentQuantity51Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlTknUnit")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
