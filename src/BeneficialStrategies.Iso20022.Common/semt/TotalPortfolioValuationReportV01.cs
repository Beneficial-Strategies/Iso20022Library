// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.024.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a TotalPortfolioValuationReport to an account owner to provide detailed valuation information for a portfolio.
/// Usage
/// The TotalPortfolioValuationReport will be sent by the account servicer to the account owner on an agreed basis. The report may also be requested using a SecuritiesStatementQuery.
/// The TotalPortfolioValuationReport is used to report on a portfolio without Investment Funds; or to report on a portfolio when an investment fund is regarded as a portfolio containing, only one or multiple investment funds
/// The TotalPortfolioValuationReport may also be used to:
/// - re-send a message previously sent (the CopyDuplicate value is DUPL),
/// - provide a third party with a copy of a message for information (the CopyDuplicate value is COPY),
/// - re-send to a third party a copy of a message for information (the CopyDuplicate value is CODU).
/// </summary>
[Description(@"Scope|An account servicer sends a TotalPortfolioValuationReport to an account owner to provide detailed valuation information for a portfolio.|Usage|The TotalPortfolioValuationReport will be sent by the account servicer to the account owner on an agreed basis. The report may also be requested using a SecuritiesStatementQuery.|The TotalPortfolioValuationReport is used to report on a portfolio without Investment Funds; or to report on a portfolio when an investment fund is regarded as a portfolio containing, only one or multiple investment funds|The TotalPortfolioValuationReport may also be used to:|- re-send a message previously sent (the CopyDuplicate value is DUPL),|- provide a third party with a copy of a message for information (the CopyDuplicate value is COPY),|- re-send to a third party a copy of a message for information (the CopyDuplicate value is CODU).")]
[IsoId("_Fyx0CdHWEd-BzquC8wXy7w_-475830186")]
[DisplayName("Total Portfolio Valuation Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalPortfolioValuationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.024.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TtlPrtflValtnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.024.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalPortfolioValuationReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalPortfolioValuationReportV01( Pagination reqPagination,Report4 reqReportGeneralDetails,SecuritiesAccount21 reqAccountDetails,TotalPortfolioValuation1 reqTotalPortfolioValuation )
    {
        Pagination = reqPagination;
        ReportGeneralDetails = reqReportGeneralDetails;
        AccountDetails = reqAccountDetails;
        TotalPortfolioValuation = reqTotalPortfolioValuation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within the report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_Fyx0C9HWEd-BzquC8wXy7w_822256636")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the total portfolio valuation report.
    /// </summary>
    [IsoId("_Fyx0DNHWEd-BzquC8wXy7w_-958164327")]
    [DisplayName("Report General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptGnlDtls")]
    #endif
    [IsoXmlTag("RptGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Report4 ReportGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Report4 ReportGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Report4 ReportGeneralDetails { get; init; } 
    #else
    public Report4 ReportGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the account. The account may represent an investment portfolio or a fund.
    /// </summary>
    [IsoId("_Fy7lANHWEd-BzquC8wXy7w_-1255643998")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount21 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount21 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount21 AccountDetails { get; init; } 
    #else
    public SecuritiesAccount21 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation information of the portfolio. In some markets a fund of funds or an investment fund is regarded as a portfolio.
    /// </summary>
    [IsoId("_Fy7lAdHWEd-BzquC8wXy7w_-658833918")]
    [DisplayName("Total Portfolio Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrtflValtn")]
    #endif
    [IsoXmlTag("TtlPrtflValtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TotalPortfolioValuation1 TotalPortfolioValuation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TotalPortfolioValuation1 TotalPortfolioValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalPortfolioValuation1 TotalPortfolioValuation { get; init; } 
    #else
    public TotalPortfolioValuation1 TotalPortfolioValuation { get; set; } 
    #endif
    
    /// <summary>
    /// Balance breakdown information.
    /// </summary>
    [IsoId("_Fy7lAtHWEd-BzquC8wXy7w_-1598852057")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PortfolioBalance1? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PortfolioBalance1? Balance { get; init; } 
    #else
    public PortfolioBalance1? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_s1GtwGtdEeCY4-KZ9JEyUQ_-1722914512")]
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


// Since TotalPortfolioValuationReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TotalPortfolioValuationReportV01.

