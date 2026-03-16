// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification95Choice
{
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_VyhSA5qLEeWcAIE4lEkF_Q")]
    [DisplayName("Any BIC")]
    public record AnyBIC : PartyIdentification95Choice_
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
