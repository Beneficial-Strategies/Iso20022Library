// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradePositionReport7Choice
{
    /// <summary>
    /// Indicates that reported position is an early termination of an existing contract.
    /// </summary>
    [IsoId("_bWl_hxLBEeqctpBfTmLJnw")]
    [DisplayName("Early Termination")]
    public record EarlyTermination : TradePositionReport7Choice_
    {
        /// <summary>
        /// Counterparty data details.
        /// </summary>
        [IsoId("_SVL6kQ1JEeqV4s5SpzR1dQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Contract and transaction trade data details.
        /// </summary>
        [IsoId("_SVL6kw1JEeqV4s5SpzR1dQ")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport35 CommonTradeData { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_SVL6lQ1JEeqV4s5SpzR1dQ")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes1? TechnicalAttributes { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_SVL6lw1JEeqV4s5SpzR1dQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
