// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport32Choice
{
    /// <summary>
    /// Indicates a compression of the reported contract.
    /// </summary>
    [IsoId("__fyLbWEUEe2P-L9DBerEgA")]
    [DisplayName("Compression")]
    [IsoXmlTag("Cmprssn")]
    public record Compression : TradeReport32Choice_
    {
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_2yMwMWEUEe2P-L9DBerEgA")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData36> CounterpartySpecificData { get; init; } = [];

        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_2yMwM2EUEe2P-L9DBerEgA")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport69 CommonTradeData { get; init; }

        /// <summary>
        /// Information concerning the reported transaction level type.
        /// Usage: The absence of the code will imply the default value Transaction (TCTN).
        /// </summary>
        [IsoId("_2yMwNWEUEe2P-L9DBerEgA")]
        [DisplayName("Level")]
        [IsoXmlTag("Lvl")]
        public ModificationLevel1Code? Level { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_2yMwN2EUEe2P-L9DBerEgA")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes5? TechnicalAttributes { get; init; }

        /// <summary>
        /// Information regarding the public dissemination of trade data.
        /// </summary>
        [IsoId("_2yMwOWEUEe2P-L9DBerEgA")]
        [DisplayName("Public Dissemination Data")]
        [IsoXmlTag("PblcDssmntnData")]
        public DisseminationData1? PublicDisseminationData { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_2yMwO2EUEe2P-L9DBerEgA")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
