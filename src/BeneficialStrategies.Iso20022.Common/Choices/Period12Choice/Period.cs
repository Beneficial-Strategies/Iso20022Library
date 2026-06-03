// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Period12Choice
{
    /// <summary>Specifies the period.</summary>
    [IsoId("_qUrwhatmEfCqjuqNaaNXgw")]
    [DisplayName("Period")]
    public record Period : Period12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prd")]
        public required Period18 Value { get; init; }
    }
}
