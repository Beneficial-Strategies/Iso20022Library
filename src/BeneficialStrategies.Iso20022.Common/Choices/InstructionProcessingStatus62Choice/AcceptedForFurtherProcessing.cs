// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Instruction has been received, is processable and has been validated for further processing.</summary>
    [IsoId("_H9heW68wEfCx2aBifPEdRg")]
    [DisplayName("Accepted For Further Processing")]
    public record AcceptedForFurtherProcessing : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AccptdForFrthrPrcg")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
