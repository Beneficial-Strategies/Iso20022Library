// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is cancelled.</summary>
    [IsoId("0473d890-5e01-486b-b39e-92b2f66fdb83")]
    [DisplayName("Cancelled")]
    public record Cancelled : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatusReason16 Value { get; init; }
    }
}
