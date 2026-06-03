// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat73Choice
{
    /// <summary>Date not specified, for example, the date is unknown.</summary>
    [IsoId("_GUHFUatmEfCqjuqNaaNXgw")]
    [DisplayName("Not Specified Date")]
    public record NotSpecifiedDate : DateFormat73Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NotSpcfdDt")]
        public required DateType8Code Value { get; init; }
    }
}
