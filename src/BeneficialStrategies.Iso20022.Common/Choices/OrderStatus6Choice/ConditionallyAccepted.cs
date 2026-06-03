// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is conditionally accepted.</summary>
    [IsoId("177ec04f-1574-47c3-a395-27e30cc6f7b9")]
    [DisplayName("Conditionally Accepted")]
    public record ConditionallyAccepted : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CondlyAccptd")]
        public required ConditionallyAcceptedStatus3Choice_ Value { get; init; }
    }
}
