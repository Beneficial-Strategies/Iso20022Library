// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification22Choice
{
    /// <summary>
    /// Identifier of a security assigned by the Consolidated Tape Association.
    /// </summary>
    [IsoId("_B03cC1hxEeWDI58xzGOTTQ")]
    [DisplayName("CTA")]
    public record CTA : SecurityIdentification22Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier of a security assigned by the Consolidated Tape Association.
        /// </summary>
        [IsoXmlTag("CTA")]
        [IsoSimpleType(IsoSimpleType.ConsolidatedTapeAssociationIdentifier)]
        public required IsoConsolidatedTapeAssociationIdentifier Value { get; init; }
    }
}
