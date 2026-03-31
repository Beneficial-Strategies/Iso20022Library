// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification129Choice
{
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_TRuNgLXLEeiTob_PrFFUxA")]
    [DisplayName("LEI")]
    public record LEI : PartyIdentification129Choice_
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
