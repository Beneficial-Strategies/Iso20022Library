// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is conditionally accepted.</summary>
    [IsoId("b76fb905-ed7c-409e-9d29-712d2238a6b4")]
    [DisplayName("Conditionally Accepted")]
    public record ConditionallyAccepted : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CondlyAccptd")]
        public required ConditionallyAcceptedStatus3Choice_ Value { get; init; }
    }
}
