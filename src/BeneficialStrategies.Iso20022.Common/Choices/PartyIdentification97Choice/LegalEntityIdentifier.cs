// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification97Choice
{
    /// <summary>
    /// Identification of the party with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_XN4h0SVJEeWI0orciOKunQ")]
    [DisplayName("Legal Entity Identifier")]
    public record LegalEntityIdentifier : PartyIdentification97Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Legal Entity Identifier is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Value { get; init; }
    }
}
