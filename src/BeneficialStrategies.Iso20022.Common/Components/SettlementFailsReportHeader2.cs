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
/// Specifies parameters of the report.
/// </summary>
[IsoId("_h8xRgR2yEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsReportHeader2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsReportHeader2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsReportHeader2( System.DateTime reqCreationDateTime,DatePeriod2 reqReportingPeriod,string reqCurrency,TransactionOperationType4Code reqReportStatus,SecuritiesSettlementSystemIdentification2 reqSecuritiesSettlementSystem )
    {
        CreationDateTime = reqCreationDateTime;
        ReportingPeriod = reqReportingPeriod;
        Currency = reqCurrency;
        ReportStatus = reqReportStatus;
        SecuritiesSettlementSystem = reqSecuritiesSettlementSystem;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the reporting timestamp, when the report was submitted from the CSD to the Competent Authority.
    /// </summary>
    [IsoId("_h-xcoR2yEeqF2P5v-Rtejg")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Period covered by the report.
    /// </summary>
    [IsoId("_h-xcox2yEeqF2P5v-Rtejg")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriod2 ReportingPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DatePeriod2 ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod2 ReportingPeriod { get; init; } 
    #else
    public DatePeriod2 ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency used to report the aggregated values of the transactions.
    /// Usage: this is the currency in which the values have to be reported, when no explicit currency is provided.
    /// </summary>
    [IsoId("_h-xcpR2yEeqF2P5v-Rtejg")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the report.
    /// </summary>
    [IsoId("_h-xcpx2yEeqF2P5v-Rtejg")]
    [DisplayName("Report Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSts")]
    #endif
    [IsoXmlTag("RptSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionOperationType4Code ReportStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionOperationType4Code ReportStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOperationType4Code ReportStatus { get; init; } 
    #else
    public TransactionOperationType4Code ReportStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the securities settlement system used in a settlement process.
    /// </summary>
    [IsoId("_h-xcqR2yEeqF2P5v-Rtejg")]
    [DisplayName("Securities Settlement System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSttlmSys")]
    #endif
    [IsoXmlTag("SctiesSttlmSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSettlementSystemIdentification2 SecuritiesSettlementSystem { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesSettlementSystemIdentification2 SecuritiesSettlementSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSettlementSystemIdentification2 SecuritiesSettlementSystem { get; init; } 
    #else
    public SecuritiesSettlementSystemIdentification2 SecuritiesSettlementSystem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
