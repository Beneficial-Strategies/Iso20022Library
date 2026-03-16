// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification100Choice
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, for example, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_vr0GAYFvEeWtPe6Crjmeug")]
    [DisplayName("Any BIC")]
    public record AnyBIC : PartyIdentification100Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Value { get; init; }
    }
}
