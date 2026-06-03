// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice
{
    /// <summary>Status of the order is cancelled.</summary>
    [IsoId("4c52b330-d93d-4688-8d84-a247ffa15233")]
    [DisplayName("Cancelled")]
    public record Cancelled : OrderStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatusReason16 Value { get; init; }
    }
}
