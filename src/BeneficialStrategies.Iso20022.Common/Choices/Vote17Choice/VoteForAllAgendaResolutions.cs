// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Vote17Choice
{
    /// <summary>One single vote instruction is provided to cover all agenda resolutions.</summary>
    [IsoId("_xFjyw6jGEfCzuLlmLrhIvA")]
    [DisplayName("Vote For All Agenda Resolutions")]
    public record VoteForAllAgendaResolutions : Vote17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("VoteForAllAgndRsltns")]
        public required VoteInstructionType3Choice_ Value { get; init; }
    }
}
