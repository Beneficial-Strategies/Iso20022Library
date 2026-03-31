// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTradeVenueCriteria1Choice
{
    /// <summary>
    /// Market identifier code of the trading venue.
    /// </summary>
    [IsoId("_a5LOBR3ZEeWNp95x0ENf8w")]
    [DisplayName("MIC")]
    public record MIC : SecuritiesTradeVenueCriteria1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("MIC")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; }
    }
}
