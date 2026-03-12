// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData35Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_hSAnI8K4EeuFNp8LZAnorg")]
    [DisplayName("Report")]
    public partial record Report : TradeData35Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Information about accepted and rejected reports and the reasons of rejection.
        /// </summary>
        [IsoId("_hTXSAcK4EeuFNp8LZAnorg")]
        [DisplayName("Report Statistics")]
        [IsoXmlTag("RptSttstcs")]
        public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = new ValueList<DetailedReportStatistics5>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _hTXSAcK4EeuFNp8LZAnorg
        
        /// <summary>
        /// Information about accepted and rejected transactions and the reasons of rejection.
        /// </summary>
        [IsoId("_hTXSA8K4EeuFNp8LZAnorg")]
        [DisplayName("Transaction Statistics")]
        [IsoXmlTag("TxSttstcs")]
        public ValueList<DetailedTransactionStatistics2Choice_> TransactionStatistics { get; init; } = new ValueList<DetailedTransactionStatistics2Choice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _hTXSA8K4EeuFNp8LZAnorg
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_hTXSBcK4EeuFNp8LZAnorg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
