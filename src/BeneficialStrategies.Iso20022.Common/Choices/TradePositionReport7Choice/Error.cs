// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradePositionReport7Choice
{
    /// <summary>
    /// Indicates a cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to reporting requirements but was reported to a trade repository by mistake.
    /// </summary>
    [IsoId("_bWl_ixLBEeqctpBfTmLJnw")]
    [DisplayName("Error")]
    [IsoXmlTag("Err")]
    public record Error : TradePositionReport7Choice_
    {
        /// <summary>
        /// Counterparty data details.
        /// </summary>
        [IsoId("_bYZ9YRLBEeqctpBfTmLJnw")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Contract and transaction trade data details.
        /// </summary>
        [IsoId("_bYZ9YxLBEeqctpBfTmLJnw")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport34 CommonTradeData { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_bYZ9ZRLBEeqctpBfTmLJnw")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes1? TechnicalAttributes { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_bYZ9ZxLBEeqctpBfTmLJnw")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
