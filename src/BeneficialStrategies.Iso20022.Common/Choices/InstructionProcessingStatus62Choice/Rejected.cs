// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Instruction rejected by the receiver.</summary>
    [IsoId("_H9heY68wEfCx2aBifPEdRg")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus58Choice_ Value { get; init; }
    }
}
