// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradePositionReport7Choice
{
    /// <summary>
    /// Indicates whether position is reported for the first time.
    /// </summary>
    [IsoId("_bWl_gRLBEeqctpBfTmLJnw")]
    [DisplayName("New")]
    public record New : TradePositionReport7Choice_
    {
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_Zi-o4Q1HEeqV4s5SpzR1dQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData21> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_Zi_P8Q1HEeqV4s5SpzR1dQ")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport33 CommonTradeData { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_Zi_P8w1HEeqV4s5SpzR1dQ")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes1? TechnicalAttributes { get; init; }

        /// <summary>
        /// Additional information that cannot be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_Zi_P9Q1HEeqV4s5SpzR1dQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
