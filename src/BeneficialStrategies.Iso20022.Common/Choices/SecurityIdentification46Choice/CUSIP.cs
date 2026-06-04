// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Committee on Uniform Securities Identification Procedures (CUSIP) identifier.</summary>
    [IsoId("b9b0e0ad-2b61-4ac3-afb6-61bf36464ac2")]
    [DisplayName("CUSIP")]
    public record CUSIP : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CUSIP")]
        public required IsoCUSIPIdentifier Value { get; init; }
    }
}
