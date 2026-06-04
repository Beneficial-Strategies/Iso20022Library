// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Belgian identifier.</summary>
    [IsoId("638ff3aa-692c-47da-b721-d3d0fd0d3e0c")]
    [DisplayName("Belgian")]
    public record Belgian : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Belgn")]
        public required IsoBelgianIdentifier Value { get; init; }
    }
}
