// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData58Choice
{
    /// <summary>
    /// Information related to trade state reporting.
    /// </summary>
    [IsoId("_CA8442EbEe2P-L9DBerEgA")]
    [DisplayName("State")]
    public record State : TradeData58Choice_
    {
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_CCB28WEbEe2P-L9DBerEgA")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData36> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_CCB282EbEe2P-L9DBerEgA")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport70 CommonTradeData { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_CCB29WEbEe2P-L9DBerEgA")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes5? TechnicalAttributes { get; init; }

        /// <summary>
        /// Information regarding the public dissemination of trade data.
        /// </summary>
        [IsoId("_CCB292EbEe2P-L9DBerEgA")]
        [DisplayName("Public Dissemination Data")]
        [IsoXmlTag("PblcDssmntnData")]
        public DisseminationData1? PublicDisseminationData { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_CCB2-WEbEe2P-L9DBerEgA")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
