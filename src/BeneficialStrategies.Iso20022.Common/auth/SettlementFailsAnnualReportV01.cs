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
/// This record is an implementation of the auth.101.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SettlementFailsAnnualReport is sent by a central securities depository or by a central bank operating a securities settlement system to the CSD competent authority to provide annual aggregated data on the number and the nature of settlement instructions which failed to settle on their intended settlement day. The report contains annual statistical information on the number and value of overall settlement instructions, settled instructions, and settlement fails that occurred during a specified period and within a given securities settlement system.
/// </summary>
[Description(@"The SettlementFailsAnnualReport is sent by a central securities depository or by a central bank operating a securities settlement system to the CSD competent authority to provide annual aggregated data on the number and the nature of settlement instructions which failed to settle on their intended settlement day. The report contains annual statistical information on the number and value of overall settlement instructions, settled instructions, and settlement fails that occurred during a specified period and within a given securities settlement system.")]
[IsoId("_pq7TsUEXEeqXB_DgAcRqgw")]
[DisplayName("Settlement Fails Annual Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsAnnualReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.101.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmFlsAnlRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.101.001.01";
    
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
    /// Constructs a SettlementFailsAnnualReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsAnnualReportV01( SettlementFailsReportHeader2 reqReportHeader,SettlementFailsData4 reqAnnualAggregate )
    {
        ReportHeader = reqReportHeader;
        AnnualAggregate = reqAnnualAggregate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies parameters of the report.
    /// </summary>
    [IsoId("_pq7Ts0EXEeqXB_DgAcRqgw")]
    [DisplayName("Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptHdr")]
    #endif
    [IsoXmlTag("RptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsReportHeader2 ReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsReportHeader2 ReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsReportHeader2 ReportHeader { get; init; } 
    #else
    public SettlementFailsReportHeader2 ReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregated annual volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_pq7TtUEXEeqXB_DgAcRqgw")]
    [DisplayName("Annual Aggregate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnlAggt")]
    #endif
    [IsoXmlTag("AnlAggt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsData4 AnnualAggregate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsData4 AnnualAggregate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsData4 AnnualAggregate { get; init; } 
    #else
    public SettlementFailsData4 AnnualAggregate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pq7Tt0EXEeqXB_DgAcRqgw")]
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


// Since SettlementFailsAnnualReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementFailsAnnualReportV01.

