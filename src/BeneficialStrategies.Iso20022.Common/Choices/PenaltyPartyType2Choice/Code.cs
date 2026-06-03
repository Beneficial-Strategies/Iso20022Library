// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PenaltyPartyType2Choice
{
    /// <summary>Penalty party type, in a coded form.</summary>
    [IsoId("_-JKIAQAUEeqOHNEXayM0Mg")]
    [DisplayName("Code")]
    public record Code : PenaltyPartyType2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalPenaltyPartyType1Code Value { get; init; }
    }
}
