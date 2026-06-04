// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Vote17Choice
{
    /// <summary>Vote instruction is provided individually for each agenda resolution.</summary>
    [IsoId("_xFjywajGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Per Agenda Resolution")]
    public record VotePerAgendaResolution : Vote17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("VotePerAgndRsltn")]
        public required Vote18Choice_ Value { get; init; }
    }
}
