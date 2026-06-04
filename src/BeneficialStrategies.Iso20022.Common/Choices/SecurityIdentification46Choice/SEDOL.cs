// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Stock Exchange Daily Official List (SEDOL) identifier.</summary>
    [IsoId("a19ffbd1-7fd5-453c-904d-0d1851517164")]
    [DisplayName("SEDOL")]
    public record SEDOL : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SEDOL")]
        public required IsoSEDOLIdentifier Value { get; init; }
    }
}
