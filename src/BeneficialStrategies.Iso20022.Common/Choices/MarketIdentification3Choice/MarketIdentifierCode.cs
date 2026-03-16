// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketIdentification3Choice
{
    /// <summary>
    /// Market Identifier Code. Identification of a financial market, as stipulated in the norm ISO 10383 &quot;Codes for exchanges and market identifications&quot;.
    /// </summary>
    [IsoId("_Acing9okEeC60axPepSq7g_164820185")]
    [DisplayName("Market Identifier Code")]
    public record MarketIdentifierCode : MarketIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("MktIdrCd")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; }
    }
}
