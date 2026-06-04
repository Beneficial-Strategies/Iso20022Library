// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Digital Token Identifier, as defined in ISO 24165.</summary>
    [IsoId("9c6723a3-b418-4887-8927-6a251d1c4f20")]
    [DisplayName("DTI")]
    public record DTI : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DTI")]
        public required IsoDTI2024Identifier Value { get; init; }
    }
}
