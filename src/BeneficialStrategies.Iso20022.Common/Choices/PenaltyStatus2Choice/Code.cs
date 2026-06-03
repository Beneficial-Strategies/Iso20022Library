// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PenaltyStatus2Choice
{
    /// <summary>Penalty status, in a coded form.</summary>
    [IsoId("_-L6hUR-LEeuwwezkzufkMw")]
    [DisplayName("Code")]
    public record Code : PenaltyStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PenaltyStatus2Code Value { get; init; }
    }
}
