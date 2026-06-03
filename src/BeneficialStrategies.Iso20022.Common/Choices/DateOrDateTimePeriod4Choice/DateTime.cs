// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod4Choice
{
    /// <summary>Period expressed with dates and times.</summary>
    [IsoId("9a8cdeba-2d64-4edd-a0a6-074a0c2e87ba")]
    [DisplayName("Date Time")]
    public record DateTime : DateOrDateTimePeriod4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtTm")]
        public required DateTimePeriod1 Value { get; init; }
    }
}
