// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Modification has been requested.</summary>
    [IsoId("_9ENHzQNrEfG_3cM8uyJ20w")]
    [DisplayName("Modification Requested")]
    public record ModificationRequested : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ModReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
