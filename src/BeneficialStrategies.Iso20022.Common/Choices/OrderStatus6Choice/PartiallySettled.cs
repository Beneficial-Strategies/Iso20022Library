// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is partially settled.</summary>
    [IsoId("e10b620b-2cf4-477b-a77e-fe2bce4fdac6")]
    [DisplayName("Partially Settled")]
    public record PartiallySettled : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtlySttld")]
        public required PartiallySettledStatus10 Value { get; init; }
    }
}
