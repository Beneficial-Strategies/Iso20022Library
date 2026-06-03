// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus59Choice
{
    /// <summary>Provides status information related to an instruction request rejected for further processing due to system reasons.</summary>
    [IsoId("_j-yrod75Ee-NrtAAlrBEgQ")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionProcessingStatus59Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus63Choice_ Value { get; init; }
    }
}
