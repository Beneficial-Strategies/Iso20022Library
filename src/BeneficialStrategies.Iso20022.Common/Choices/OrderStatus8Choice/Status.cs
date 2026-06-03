// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice
{
    /// <summary>Status of all the orders in the order message. There is no reason attached.</summary>
    [IsoId("3d1882c4-a7a2-49c7-b9b1-192846595217")]
    [DisplayName("Status")]
    public record Status : OrderStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sts")]
        public required OrderStatus4Code Value { get; init; }
    }
}
