// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Identifier of a security assigned by the Bloomberg organisation.
    /// </summary>
    [IsoId("_Qdr_ldp-Ed-ak6NoX_4Aeg_1064399388")]
    [DisplayName("Bloomberg")]
    public record Bloomberg : SecurityIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// An identifier of a security assigned by the Bloomberg organisation.
        /// </summary>
        [IsoXmlTag("Blmbrg")]
        [IsoSimpleType(IsoSimpleType.BloombergIdentifier)]
        public required IsoBloombergIdentifier Value { get; init; }
    }
}
