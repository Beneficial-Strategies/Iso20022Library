// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradePositionReport7Choice
{
    /// <summary>
    /// Indicates any other amendment to the terms or details of a previously reported position.
    /// </summary>
    [IsoId("_bWl_jRLBEeqctpBfTmLJnw")]
    [DisplayName("Other")]
    public partial record Other : TradePositionReport7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Counterparty data details.
        /// </summary>
        [IsoId("_EPVkwQ1KEeqV4s5SpzR1dQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = [];
        
        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_EPVkww1KEeqV4s5SpzR1dQ")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport37 CommonTradeData { get; init; } 
        
        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_EPVkxQ1KEeqV4s5SpzR1dQ")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes1? TechnicalAttributes { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_EPVkxw1KEeqV4s5SpzR1dQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
