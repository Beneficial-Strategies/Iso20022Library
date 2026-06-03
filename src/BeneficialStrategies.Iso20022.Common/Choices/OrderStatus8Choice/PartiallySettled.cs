// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice
{
    /// <summary>Status of the order is partially settled.</summary>
    [IsoId("2255eba7-71a9-4ce3-9b34-c00b45e8b672")]
    [DisplayName("Partially Settled")]
    public record PartiallySettled : OrderStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtlySttld")]
        public required PartiallySettledStatus10 Value { get; init; }
    }
}
