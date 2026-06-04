// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Reuters Instrument Code (RIC) identifier.</summary>
    [IsoId("4c0823c1-e6c9-4976-bee6-76d903c80b9a")]
    [DisplayName("RIC")]
    public record RIC : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RIC")]
        public required IsoRICIdentifier Value { get; init; }
    }
}
