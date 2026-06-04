// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData13Choice
{
    /// <summary>Underlying data expressed as other proprietary reference details.</summary>
    [IsoId("98ac0816-44b9-4b48-be6f-edc85ab98698")]
    [DisplayName("Other")]
    public record Other : UnderlyingData13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Othr")]
        public required GenericIdentification1 Value { get; init; }
    }
}
