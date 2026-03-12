// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionReport8Choice
{
    /// <summary>
    /// Indicates that the report is correcting the erroneous data fields of a previously submitted report.
    /// </summary>
    [IsoId("_bRuGlRLBEeqctpBfTmLJnw")]
    [DisplayName("Correction")]
    public partial record Correction : TradeTransactionReport8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Counterparty data details.
        /// </summary>
        [IsoId("_bYZ9YRLBEeqctpBfTmLJnw")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = new ValueList<CounterpartySpecificData22>(){};
        
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
        
        
        #nullable disable
        
    }
}
