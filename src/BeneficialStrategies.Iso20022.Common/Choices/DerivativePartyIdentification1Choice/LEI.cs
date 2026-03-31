// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DerivativePartyIdentification1Choice
{
    /// <summary>
    /// Identification of the reference party through Legal entity identifier.
    /// </summary>
    [IsoId("_unMS4EW8EeWaZZ6gWK8UVw")]
    [DisplayName("LEI")]
    public record LEI : DerivativePartyIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Legal Entity Identifier is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Value { get; init; }
    }
}
