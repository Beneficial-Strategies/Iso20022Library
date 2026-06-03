// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Status information related to a pending instruction.</summary>
    [IsoId("_rt3LK474EfCbNJ3GwkFTcw")]
    [DisplayName("Pending")]
    public record Pending : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus3 Value { get; init; }
    }
}
