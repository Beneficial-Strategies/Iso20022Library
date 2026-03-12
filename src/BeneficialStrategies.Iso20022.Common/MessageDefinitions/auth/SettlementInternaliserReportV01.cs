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
/// This record is an implementation of the auth.072.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SettlementInternaliserReport message is sent by the settlement internalisers to the relevant competent authority to report aggregated information on all securities transactions that they settle outside securities settlement systems, on a quarterly basis. The report contains aggregated information on the value and volume of all internalised settlement instructions (settled and failed) that have been performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
/// 
/// Usage: 
/// This report may be used by settlement internalisers to provide aggregated information (volume and value) on internalised settlement instructions (settled and failed) to their competent authorities.
/// </summary>
[Description(@"The SettlementInternaliserReport message is sent by the settlement internalisers to the relevant competent authority to report aggregated information on all securities transactions that they settle outside securities settlement systems, on a quarterly basis. The report contains aggregated information on the value and volume of all internalised settlement instructions (settled and failed) that have been performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.||Usage: |This report may be used by settlement internalisers to provide aggregated information (volume and value) on internalised settlement instructions (settled and failed) to their competent authorities.")]
[IsoId("_m9MVgO3jEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliserReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.072.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmIntlrRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01";
    
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
    /// Constructs a SettlementInternaliserReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliserReportV01( SettlementInternaliserReportHeader1 reqReportHeader,SettlementInternaliser1 reqSettlementInternaliser,IssuerCSDReport1 reqIssuerCSD )
    {
        ReportHeader = reqReportHeader;
        SettlementInternaliser = reqSettlementInternaliser;
        IssuerCSD = reqIssuerCSD;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies parameters of the report.
    /// </summary>
    [IsoId("_jW2EcO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptHdr")]
    #endif
    [IsoXmlTag("RptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInternaliserReportHeader1 ReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInternaliserReportHeader1 ReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInternaliserReportHeader1 ReportHeader { get; init; } 
    #else
    public SettlementInternaliserReportHeader1 ReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the settlement internaliser for which data is reported.
    /// </summary>
    [IsoId("_lNkVgO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Settlement Internaliser")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmIntlr")]
    #endif
    [IsoXmlTag("SttlmIntlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInternaliser1 SettlementInternaliser { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInternaliser1 SettlementInternaliser { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInternaliser1 SettlementInternaliser { get; init; } 
    #else
    public SettlementInternaliser1 SettlementInternaliser { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies each issuer CSD (central securities depository) included in the report.
    /// </summary>
    [IsoId("_pgDeYO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCSD")]
    #endif
    [IsoXmlTag("IssrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IssuerCSDReport1 IssuerCSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IssuerCSDReport1 IssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerCSDReport1 IssuerCSD { get; init; } 
    #else
    public IssuerCSDReport1 IssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_D1rv0X9xEeiuTa5SlOUnYg")]
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


// Since SettlementInternaliserReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementInternaliserReportV01.

