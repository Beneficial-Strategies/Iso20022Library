// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TechnicalIdentification2Choice
{
    /// <summary>
    /// Technical address of the party is defined as a financial institution business identifier code.
    /// </summary>
    [IsoId("_YD53kb11Eeiut6mmSKzDFQ")]
    [DisplayName("BICFI")]
    public record BICFI : TechnicalIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362: 2014 - &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
        public required IsoBICFIDec2014Identifier Value { get; init; }
    }
}
