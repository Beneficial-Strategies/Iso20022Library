// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is accepted or already executed or sent to next party or received.</summary>
    [IsoId("a651dee8-8f24-41a5-8d26-9d6169a859a8")]
    [DisplayName("Status")]
    public record Status : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sts")]
        public required OrderStatus4Code Value { get; init; }
    }
}
