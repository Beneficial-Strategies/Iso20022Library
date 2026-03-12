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


namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginReport message is sent by the central counterparty (CCP) to a clearing member to report on:
/// - the exposure resulting from the trade positions
/// - the value of the collateral held by the CCP (market value of this collateral) and
/// - the resulting difference representing the risk encountered by the CCP.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// There are four possibilities to report the above information. Indeed, the margin report may be structured as follows:
/// - per clearing member: the report will only show the information for the clearing member, or
/// - per clearing member and per financial instrument: the report will show the information for the clearing member, structured by security identification, or
/// - per clearing member and per non clearing member: the report will show the information for the clearing member (that is for global clearing member only) structured by non clearing member(s), or
/// - per clearing member and per non clearing member and per security identification: the report will show the information for the clearing member (global clearing member only) structured by non clearing member(s) and by security identification.
/// </summary>
[Description(@"Scope|The MarginReport message is sent by the central counterparty (CCP) to a clearing member to report on:|- the exposure resulting from the trade positions|- the value of the collateral held by the CCP (market value of this collateral) and|- the resulting difference representing the risk encountered by the CCP.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|There are four possibilities to report the above information. Indeed, the margin report may be structured as follows:|- per clearing member: the report will only show the information for the clearing member, or|- per clearing member and per financial instrument: the report will show the information for the clearing member, structured by security identification, or|- per clearing member and per non clearing member: the report will show the information for the clearing member (that is for global clearing member only) structured by non clearing member(s), or|- per clearing member and per non clearing member and per security identification: the report will show the information for the clearing member (global clearing member only) structured by non clearing member(s) and by security identification.")]
[IsoId("_-hxndaMOEeCojJW5vEuTEQ_-1836673720")]
[DisplayName("Margin Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.005.001.02";
    
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
    /// Constructs a MarginReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginReportV02( ReportParameters3 reqReportParameters,Pagination reqPagination,PartyIdentification35Choice_ reqClearingMember,MarginReport2 reqReportDetails )
    {
        ReportParameters = reqReportParameters;
        Pagination = reqPagination;
        ClearingMember = reqClearingMember;
        ReportDetails = reqReportDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides parameters of the margin report such as the creation date and time, the report currency or the calculation date and time.
    /// </summary>
    [IsoId("_-hxndqMOEeCojJW5vEuTEQ_-1337157018")]
    [DisplayName("Report Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptParams")]
    #endif
    [IsoXmlTag("RptParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportParameters3 ReportParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportParameters3 ReportParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportParameters3 ReportParameters { get; init; } 
    #else
    public ReportParameters3 ReportParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within a report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_-h7YcKMOEeCojJW5vEuTEQ_1347382157")]
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
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_-h7YcaMOEeCojJW5vEuTEQ_1960737925")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ ClearingMember { get; init; } 
    #else
    public PartyIdentification35Choice_ ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_-h7YcqMOEeCojJW5vEuTEQ_-1484768145")]
    [DisplayName("Report Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSummry")]
    #endif
    [IsoXmlTag("RptSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCalculation1? ReportSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCalculation1? ReportSummary { get; init; } 
    #else
    public MarginCalculation1? ReportSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the margin report details.
    /// </summary>
    [IsoId("_-h7Yc6MOEeCojJW5vEuTEQ_963665572")]
    [DisplayName("Report Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtls")]
    #endif
    [IsoXmlTag("RptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginReport2 ReportDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginReport2 ReportDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginReport2 ReportDetails { get; init; } 
    #else
    public MarginReport2 ReportDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can&apos;t be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-h7YdKMOEeCojJW5vEuTEQ_-33406781")]
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


// Since MarginReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginReportV02.

