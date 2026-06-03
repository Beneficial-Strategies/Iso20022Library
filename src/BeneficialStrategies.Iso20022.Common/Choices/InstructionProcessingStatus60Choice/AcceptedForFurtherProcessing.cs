// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Status information related to an instruction request that is accepted. This means that the instruction has been received, is processable and has been validated for further processing.</summary>
    [IsoId("_rt3LGY74EfCbNJ3GwkFTcw")]
    [DisplayName("Accepted For Further Processing")]
    public record AcceptedForFurtherProcessing : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AccptdForFrthrPrcg")]
        public required AcceptedStatus2 Value { get; init; }
    }
}
