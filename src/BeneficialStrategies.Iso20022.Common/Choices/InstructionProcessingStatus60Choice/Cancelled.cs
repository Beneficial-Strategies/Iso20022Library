// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Status and quantity information related to a cancelled instruction request.</summary>
    [IsoId("_rt3LEY74EfCbNJ3GwkFTcw")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatus5 Value { get; init; }
    }
}
