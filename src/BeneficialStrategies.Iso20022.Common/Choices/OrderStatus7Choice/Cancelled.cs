// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is cancelled.</summary>
    [IsoId("8e52995c-f249-4176-a182-fd887c47d809")]
    [DisplayName("Cancelled")]
    public record Cancelled : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatusReason16 Value { get; init; }
    }
}
