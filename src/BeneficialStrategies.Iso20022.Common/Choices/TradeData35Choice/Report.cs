// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TradeData35Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_hSAnI8K4EeuFNp8LZAnorg")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : TradeData35Choice_
    #else
    public partial class Report : TradeData35Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Information about accepted and rejected reports and the reasons of rejection.
        /// </summary>
        [IsoId("_hTXSAcK4EeuFNp8LZAnorg")]
        [DisplayName("Report Statistics")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptSttstcs")]
        #endif
        [IsoXmlTag("RptSttstcs")]
        public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = new ValueList<DetailedReportStatistics5>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _hTXSAcK4EeuFNp8LZAnorg
        
        /// <summary>
        /// Information about accepted and rejected transactions and the reasons of rejection.
        /// </summary>
        [IsoId("_hTXSA8K4EeuFNp8LZAnorg")]
        [DisplayName("Transaction Statistics")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxSttstcs")]
        #endif
        [IsoXmlTag("TxSttstcs")]
        public ValueList<DetailedTransactionStatistics2Choice_> TransactionStatistics { get; init; } = new ValueList<DetailedTransactionStatistics2Choice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _hTXSA8K4EeuFNp8LZAnorg
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_hTXSBcK4EeuFNp8LZAnorg")]
        [DisplayName("Supplementary Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryData")]
        #endif
        [IsoXmlTag("SplmtryData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
