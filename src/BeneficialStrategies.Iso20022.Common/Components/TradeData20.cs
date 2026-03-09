// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reported trade transactions.
/// </summary>
[IsoId("_R_kY3O3tEemV1LTEADuPBQ")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData20
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
    [IsoId("_R_kY3u3tEemV1LTEADuPBQ")]
    [DisplayName("Report Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSttstcs")]
    #endif
    [IsoXmlTag("RptSttstcs")]
    public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = new ValueList<DetailedReportStatistics5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R_kY3u3tEemV1LTEADuPBQ
    
    /// <summary>
    /// Information about accepted and rejected transactions and the reasons of rejection.
    /// </summary>
    [IsoId("_R_kY3-3tEemV1LTEADuPBQ")]
    [DisplayName("Transaction Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSttstcs")]
    #endif
    [IsoXmlTag("TxSttstcs")]
    public ValueList<DetailedTransactionStatistics10> TransactionStatistics { get; init; } = new ValueList<DetailedTransactionStatistics10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R_kY3-3tEemV1LTEADuPBQ
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_R_kY3e3tEemV1LTEADuPBQ")]
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
