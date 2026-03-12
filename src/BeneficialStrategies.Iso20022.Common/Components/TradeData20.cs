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
[IsoId("_R_kY3O3tEemV1LTEADuPBQ")]
[DisplayName("Trade Data")]
public partial record TradeData20
{
    #nullable enable
    
    /// <summary>
    /// Information about accepted and rejected reports and the reasons of rejection.
    /// </summary>
    [IsoId("_R_kY3u3tEemV1LTEADuPBQ")]
    [DisplayName("Report Statistics")]
    [IsoXmlTag("RptSttstcs")]
    public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = new ValueList<DetailedReportStatistics5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R_kY3u3tEemV1LTEADuPBQ
    
    /// <summary>
    /// Information about accepted and rejected transactions and the reasons of rejection.
    /// </summary>
    [IsoId("_R_kY3-3tEemV1LTEADuPBQ")]
    [DisplayName("Transaction Statistics")]
    [IsoXmlTag("TxSttstcs")]
    public ValueList<DetailedTransactionStatistics10> TransactionStatistics { get; init; } = new ValueList<DetailedTransactionStatistics10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R_kY3-3tEemV1LTEADuPBQ
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_R_kY3e3tEemV1LTEADuPBQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
