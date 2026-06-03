// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ProrationBelowMinimumQuantity3Choice
{
    /// <summary>Specifies the proration type as a code.</summary>
    [IsoId("_NpRYIaj5EfCG_LQaXOxwew")]
    [DisplayName("Code")]
    public record Code : ProrationBelowMinimumQuantity3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ProrationBelowMinimumQuantity2Code Value { get; init; }
    }
}
