// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Instructed units are returned or partially returned to the instructing party.</summary>
    [IsoId("_rt3LM474EfCbNJ3GwkFTcw")]
    [DisplayName("Returned")]
    public record Returned : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rtrd")]
        public required ReturnedStatus1 Value { get; init; }
    }
}
