// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport15Choice
{
    /// <summary>
    /// Indicates an update of a contract valuation or collateral.
    /// </summary>
    [IsoId("_oZRTW3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Valuation Update")]
    [IsoXmlTag("ValtnUpd")]
    public record ValuationUpdate : TradeReport15Choice_
    {
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_onQE8Xg-Eeu3kecHd7QKUQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData29> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_onQE83g-Eeu3kecHd7QKUQ")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport49 CommonTradeData { get; init; }

        /// <summary>
        /// Information concerning the reported transaction level type.
        /// Usage: The absence of the code will imply the default value Transaction (TCTN).
        /// </summary>
        [IsoId("_onQE9Xg-Eeu3kecHd7QKUQ")]
        [DisplayName("Level")]
        [IsoXmlTag("Lvl")]
        public ModificationLevel1Code? Level { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_onQE93g-Eeu3kecHd7QKUQ")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes4? TechnicalAttributes { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_onQE-Xg-Eeu3kecHd7QKUQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
