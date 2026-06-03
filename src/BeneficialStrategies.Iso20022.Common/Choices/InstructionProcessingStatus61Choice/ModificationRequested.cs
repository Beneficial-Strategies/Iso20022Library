// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Modification has been requested.</summary>
    [IsoId("f298bf94-acbb-45b5-a64e-2521801d5eda")]
    [DisplayName("Modification Requested")]
    public record ModificationRequested : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ModReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
