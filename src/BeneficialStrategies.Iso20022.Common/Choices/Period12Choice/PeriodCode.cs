// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Period12Choice
{
    /// <summary>Specifies the period as a code.</summary>
    [IsoId("_qUrwi6tmEfCqjuqNaaNXgw")]
    [DisplayName("Period Code")]
    public record PeriodCode : Period12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrdCd")]
        public required DateType8Code Value { get; init; }
    }
}
