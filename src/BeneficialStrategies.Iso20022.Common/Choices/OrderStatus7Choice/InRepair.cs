// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is in repair.</summary>
    [IsoId("07d5c54d-1cfe-4580-b600-ddf776b3c935")]
    [DisplayName("In Repair")]
    public record InRepair : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InRpr")]
        public required InRepairStatusReason4Choice_ Value { get; init; }
    }
}
