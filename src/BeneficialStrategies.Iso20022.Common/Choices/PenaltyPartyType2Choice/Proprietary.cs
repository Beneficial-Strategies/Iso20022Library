// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PenaltyPartyType2Choice
{
    /// <summary>Penalty party type, in a proprietary form.</summary>
    [IsoId("_-JKIAwAUEeqOHNEXayM0Mg")]
    [DisplayName("Proprietary")]
    public record Proprietary : PenaltyPartyType2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
