// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification84Choice
{
    /// <summary>Additional disclosure account identification.</summary>
    [IsoId("_z4SBEKnOEfC5VNwixU6YfQ")]
    [DisplayName("Identification")]
    public record Identification : AccountIdentification84Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Id")]
        public required IsoMax35Text Value { get; init; }
    }
}
