// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Instructed units are returned or partially returned to the instructing party.</summary>
    [IsoId("_H9heea8wEfCx2aBifPEdRg")]
    [DisplayName("Returned")]
    public record Returned : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rtrd")]
        public required ReturnedStatus2Choice_ Value { get; init; }
    }
}
