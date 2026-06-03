// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat73Choice
{
    /// <summary>Date expressed as an ISO Date.</summary>
    [IsoId("_GUHFRatmEfCqjuqNaaNXgw")]
    [DisplayName("Date")]
    public record Date : DateFormat73Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dt")]
        public required IsoISODate Value { get; init; }
    }
}
