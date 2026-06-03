// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice
{
    /// <summary>Modification request is accepted but in repair.</summary>
    [IsoId("db49bf33-d1e2-40f0-b5ff-f98752e643b1")]
    [DisplayName("Repaired")]
    public record Repaired : ModificationProcessingStatus13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rprd")]
        public required RepairStatus13Choice_ Value { get; init; }
    }
}
