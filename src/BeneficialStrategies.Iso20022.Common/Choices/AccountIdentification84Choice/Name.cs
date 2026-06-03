// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification84Choice
{
    /// <summary>Additional disclosure account name.</summary>
    [IsoId("_lWvqQKnOEfC5VNwixU6YfQ")]
    [DisplayName("Name")]
    public record Name : AccountIdentification84Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Nm")]
        public required IsoMax70Text Value { get; init; }
    }
}
