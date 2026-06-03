// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecuritiesDistributionTypeFormat19Choice
{
    /// <summary>Proprietary identification of the type of intermediate securities distribution.</summary>
    [IsoId("_qdHOy6RKEfC9EJoPPbbyNQ")]
    [DisplayName("Proprietary")]
    public record Proprietary : IntermediateSecuritiesDistributionTypeFormat19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
