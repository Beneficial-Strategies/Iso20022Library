// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>International Securities Identification Number (ISIN).</summary>
    [IsoId("256a59be-1564-4e1b-b0ed-604c6acbb3df")]
    [DisplayName("ISIN")]
    public record ISIN : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ISIN")]
        public required IsoISINOct2015Identifier Value { get; init; }
    }
}
