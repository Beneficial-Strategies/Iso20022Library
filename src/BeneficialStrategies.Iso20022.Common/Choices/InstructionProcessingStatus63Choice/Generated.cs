// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Transaction was created by the account servicer or a third party.</summary>
    [IsoId("_9ENHwQNrEfG_3cM8uyJ20w")]
    [DisplayName("Generated")]
    public record Generated : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Gnrtd")]
        public required GeneratedStatus7Choice_ Value { get; init; }
    }
}
