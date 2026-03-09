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
/// Specifies parameters of the report 
/// </summary>
[IsoId("_rJ-pkO3kEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliserReportHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInternaliserReportHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliserReportHeader1( System.DateTime reqCreationDateTime,System.DateOnly reqReportingDate,string reqCurrency,TransactionOperationType4Code reqReportStatus )
    {
        CreationDateTime = reqCreationDateTime;
        ReportingDate = reqReportingDate;
        Currency = reqCurrency;
        ReportStatus = reqReportStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the reporting timestamp, when the report was submitted from the Settlement Internaliser to the Competent Authority.
    /// </summary>
    [IsoId("_2Xg5AO3kEeaWjpoyrnG6Rw")]
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
    /// Last day of the reporting period.
    /// </summary>
    [IsoId("_4oFNcO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDt")]
    #endif
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReportingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReportingDate { get; init; } 
    #else
    public System.DateOnly ReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency of the reported transactions.
    /// </summary>
    [IsoId("_641IEO3kEeaWjpoyrnG6Rw")]
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
    [IsoId("_eVMmQHBLEeeD5_FeE1GEtw")]
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
    
    
    #nullable disable
    
}
