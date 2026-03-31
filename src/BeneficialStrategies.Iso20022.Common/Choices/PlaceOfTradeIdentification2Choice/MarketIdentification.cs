// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification2Choice
{
    /// <summary>
    /// Exchange or Multilateral Trading Facility (MTF) on which the transaction is executed.
    /// </summary>
    [IsoId("_TCfepdp-Ed-ak6NoX_4Aeg_-1823256759")]
    [DisplayName("Market Identification")]
    public record MarketIdentification : PlaceOfTradeIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("MktId")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; }
    }
}
