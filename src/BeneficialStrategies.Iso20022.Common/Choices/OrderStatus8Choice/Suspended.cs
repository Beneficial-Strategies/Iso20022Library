// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice
{
    /// <summary>Status of the order is suspended.</summary>
    [IsoId("49a11f18-812d-45b4-b0a3-21d1879c42e5")]
    [DisplayName("Suspended")]
    public record Suspended : OrderStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sspd")]
        public required SuspendedStatusReason4Choice_ Value { get; init; }
    }
}
