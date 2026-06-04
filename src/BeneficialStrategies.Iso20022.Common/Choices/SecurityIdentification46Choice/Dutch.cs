// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Dutch identifier.</summary>
    [IsoId("fff15e36-e19e-47bd-bfcf-21bc8e6d2e93")]
    [DisplayName("Dutch")]
    public record Dutch : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dtch")]
        public required IsoDutchIdentifier Value { get; init; }
    }
}
