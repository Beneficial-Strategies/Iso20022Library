// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Unit1Choice
{
    /// <summary>Quantity expressed as a number of digital token units.</summary>
    [IsoId("9e68fec5-b4c6-428c-b733-07867fef6d4d")]
    [DisplayName("Digital Token Unit")]
    public record DigitalTokenUnit : Unit1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlTknUnit")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
