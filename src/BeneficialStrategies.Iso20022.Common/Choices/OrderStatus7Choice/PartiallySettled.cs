// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is partially settled.</summary>
    [IsoId("791a8cc9-5874-4a3f-ad53-3d93d67ed206")]
    [DisplayName("Partially Settled")]
    public record PartiallySettled : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtlySttld")]
        public required PartiallySettledStatus10 Value { get; init; }
    }
}
