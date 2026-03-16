// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData19Choice
{
    /// <summary>
    /// Information related to trade state reporting.
    /// </summary>
    [IsoId("_nBfoFXg-Eeu3kecHd7QKUQ")]
    [DisplayName("State")]
    public record State : TradeData19Choice_
    {
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_nQXxkXg-Eeu3kecHd7QKUQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData29> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_nQXxk3g-Eeu3kecHd7QKUQ")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport50 CommonTradeData { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_nQXxlXg-Eeu3kecHd7QKUQ")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes4? TechnicalAttributes { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_nQXxl3g-Eeu3kecHd7QKUQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
