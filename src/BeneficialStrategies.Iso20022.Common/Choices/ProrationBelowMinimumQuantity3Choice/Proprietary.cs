// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProrationBelowMinimumQuantity3Choice
{
    /// <summary>Specifies the proration type as a proprietary value.</summary>
    [IsoId("_NpRYI6j5EfCG_LQaXOxwew")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProrationBelowMinimumQuantity3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
