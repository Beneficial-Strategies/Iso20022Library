// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is accepted or already executed or sent to next party or received.</summary>
    [IsoId("9bdb4a0e-5642-4a06-9e84-1f17d9c912b6")]
    [DisplayName("Status")]
    public record Status : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sts")]
        public required OrderStatus4Code Value { get; init; }
    }
}
