// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReport15Choice
{
    /// <summary>
    /// Indicates a derivative contract that is to be reported as a new trade and also included in a separate position report on the same day.
    /// </summary>
    [IsoId("_oZRTWXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Position Component")]
    public partial record PositionComponent : TradeReport15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_onQE8Xg-Eeu3kecHd7QKUQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData29> CounterpartySpecificData { get; init; } = new ValueList<CounterpartySpecificData29>(){};
        
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
        
        
        #nullable disable
        
    }
}
