// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is suspended.</summary>
    [IsoId("abbb28d3-cf5b-41a8-a6d1-d47d7f50a421")]
    [DisplayName("Suspended")]
    public record Suspended : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sspd")]
        public required SuspendedStatusReason4Choice_ Value { get; init; }
    }
}
