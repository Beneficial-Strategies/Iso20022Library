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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.015.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketOvernightIndexSwapsStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report the daily overnight index swaps (OIS) transactions.
/// </summary>
[Description(@"The MoneyMarketOvernightIndexSwapsStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report the daily overnight index swaps (OIS) transactions.")]
[IsoId("_Ap9m0cEPEea7jLfvGi1PDw")]
[DisplayName("Money Market Overnight Index Swaps Statistical Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MoneyMarketOvernightIndexSwapsStatisticalReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.015.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktOvrnghtIndxSwpsSttstclRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.015.001.02";
    
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
    /// Constructs a MoneyMarketOvernightIndexSwapsStatisticalReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MoneyMarketOvernightIndexSwapsStatisticalReportV02( MoneyMarketReportHeader1 reqReportHeader,OvernightIndexSwap4Choice_ reqOvernightIndexSwapsReport )
    {
        ReportHeader = reqReportHeader;
        OvernightIndexSwapsReport = reqOvernightIndexSwapsReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_Ap9m08EPEea7jLfvGi1PDw")]
    [DisplayName("Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptHdr")]
    #endif
    [IsoXmlTag("RptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MoneyMarketReportHeader1 ReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MoneyMarketReportHeader1 ReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyMarketReportHeader1 ReportHeader { get; init; } 
    #else
    public MoneyMarketReportHeader1 ReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the overnight index swaps segment.
    /// </summary>
    [IsoId("_Ap9m1cEPEea7jLfvGi1PDw")]
    [DisplayName("Overnight Index Swaps Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrnghtIndxSwpsRpt")]
    #endif
    [IsoXmlTag("OvrnghtIndxSwpsRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OvernightIndexSwap4Choice_ OvernightIndexSwapsReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OvernightIndexSwap4Choice_ OvernightIndexSwapsReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OvernightIndexSwap4Choice_ OvernightIndexSwapsReport { get; init; } 
    #else
    public OvernightIndexSwap4Choice_ OvernightIndexSwapsReport { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Ap9m18EPEea7jLfvGi1PDw")]
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


// Since MoneyMarketOvernightIndexSwapsStatisticalReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MoneyMarketOvernightIndexSwapsStatisticalReportV02.

