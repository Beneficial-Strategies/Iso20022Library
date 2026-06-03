// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus59Choice
{
    /// <summary>Provides status information related to a pending instruction.</summary>
    [IsoId("_j-yrqd75Ee-NrtAAlrBEgQ")]
    [DisplayName("Pending")]
    public record Pending : InstructionProcessingStatus59Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus78Choice_ Value { get; init; }
    }
}
