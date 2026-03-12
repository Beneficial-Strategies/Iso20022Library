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
    
    #nullable enable
    
    /// <summary>
    /// Provides parameters of the margin report such as the creation date and time, the report currency or the calculation date and time.
    /// </summary>
    [IsoId("_-hxndqMOEeCojJW5vEuTEQ_-1337157018")]
    [DisplayName("Report Parameters")]
    [IsoXmlTag("RptParams")]
    public required ReportParameters3 ReportParameters { get; init; } 
    
    /// <summary>
    /// Page number of the message (within a report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_-h7YcKMOEeCojJW5vEuTEQ_1347382157")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; } 
    
    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_-h7YcaMOEeCojJW5vEuTEQ_1960737925")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_-h7YcqMOEeCojJW5vEuTEQ_-1484768145")]
    [DisplayName("Report Summary")]
    [IsoXmlTag("RptSummry")]
    public MarginCalculation1? ReportSummary { get; init; } 
    
    /// <summary>
    /// Provides the margin report details.
    /// </summary>
    [IsoId("_-h7Yc6MOEeCojJW5vEuTEQ_963665572")]
    [DisplayName("Report Details")]
    [IsoXmlTag("RptDtls")]
    public required MarginReport2 ReportDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can&apos;t be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-h7YdKMOEeCojJW5vEuTEQ_-33406781")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MarginReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginReportV02.

