// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification1Choice
{
    /// <summary>
    /// Identification used where reporting entity uses a market identification code (MIC).
    /// </summary>
    [IsoId("_3sh9ExtGEeWhp-Wous5jzA")]
    [DisplayName("Market Identification Code")]
    public record MarketIdentificationCode : TradingVenueIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("MktIdCd")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; }
    }
}
