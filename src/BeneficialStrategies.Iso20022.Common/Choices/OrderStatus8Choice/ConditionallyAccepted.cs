// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice
{
    /// <summary>Status of the order is conditionally accepted.</summary>
    [IsoId("48fb6b28-5c01-4dbd-97d6-1724c0327290")]
    [DisplayName("Conditionally Accepted")]
    public record ConditionallyAccepted : OrderStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CondlyAccptd")]
        public required ConditionallyAcceptedStatus3Choice_ Value { get; init; }
    }
}
