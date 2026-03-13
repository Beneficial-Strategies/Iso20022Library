// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reported trade transactions.
/// </summary>
[IsoId("_hSAnJcK4EeuFNp8LZAnorg")]
[DisplayName("Trade Data")]
public partial record TradeData29
{
    #nullable enable
    
    /// <summary>
    /// Information about accepted and rejected reports and the reasons of rejection.
    /// </summary>
    [IsoId("_hTXSAcK4EeuFNp8LZAnorg")]
    [DisplayName("Report Statistics")]
    [IsoXmlTag("RptSttstcs")]
    public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = [];
    // ID for the above is _hTXSAcK4EeuFNp8LZAnorg
    
    /// <summary>
    /// Information about accepted and rejected transactions and the reasons of rejection.
    /// </summary>
    [IsoId("_hTXSA8K4EeuFNp8LZAnorg")]
    [DisplayName("Transaction Statistics")]
    [IsoXmlTag("TxSttstcs")]
    public ValueList<DetailedTransactionStatistics2Choice_> TransactionStatistics { get; init; } = [];
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
