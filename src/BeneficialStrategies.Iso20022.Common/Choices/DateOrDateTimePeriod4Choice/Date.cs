// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod4Choice
{
    /// <summary>Period expressed with dates.</summary>
    [IsoId("84312226-1543-4c3e-94f6-d8bbc30e9721")]
    [DisplayName("Date")]
    public record Date : DateOrDateTimePeriod4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dt")]
        public required DatePeriod2 Value { get; init; }
    }
}
