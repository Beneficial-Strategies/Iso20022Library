// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecuritiesDistributionTypeFormat19Choice
{
    /// <summary>Standard code specifying the type of intermediate securities distribution.</summary>
    [IsoId("_qdHOxaRKEfC9EJoPPbbyNQ")]
    [DisplayName("Code")]
    public record Code : IntermediateSecuritiesDistributionTypeFormat19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required IntermediateSecurityDistributionType6Code Value { get; init; }
    }
}
