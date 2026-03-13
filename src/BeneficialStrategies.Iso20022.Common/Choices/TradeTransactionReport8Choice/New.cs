// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionReport8Choice
{
    /// <summary>
    /// Indicates whether transaction is reported for the first time.
    /// </summary>
    [IsoId("_bRuGkRLBEeqctpBfTmLJnw")]
    [DisplayName("New")]
    public partial record New : TradeTransactionReport8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_VsJZ4Q1KEeqV4s5SpzR1dQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = [];
        
        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_VsJZ4w1KEeqV4s5SpzR1dQ")]
        [DisplayName("Common Trade Data")]
        [IsoXmlTag("CmonTradData")]
        public required CommonTradeDataReport38 CommonTradeData { get; init; } 
        
        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_VsJZ5Q1KEeqV4s5SpzR1dQ")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes1? TechnicalAttributes { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_VsJZ5w1KEeqV4s5SpzR1dQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
