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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A regulator or an intermediary sends the RegulatoryTransactionReportCancellationStatus to a reporting institution to provide the status of a RegulatoryTransactionReportCancellationRequest previously sent by the reporting institution.
/// Usage
/// The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:
/// - Completed, or,
/// - Pending, or,
/// - Rejected.
/// If the status is rejected, then reason for the rejection must be specified.
/// </summary>
[Description(@"Scope|A regulator or an intermediary sends the RegulatoryTransactionReportCancellationStatus to a reporting institution to provide the status of a RegulatoryTransactionReportCancellationRequest previously sent by the reporting institution.|Usage|The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:|- Completed, or,|- Pending, or,|- Rejected.|If the status is rejected, then reason for the rejection must be specified.")]
[IsoId("_gJrQAcIFEeGllrOKQRUTYA_-231568037")]
[DisplayName("Regulatory Transaction Report Cancellation Status V")]
public partial record RegulatoryTransactionReportCancellationStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRptCxlStsV01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.011.001.01";
    
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
    /// Identification of the RegulatoryTransactionReportCancellationStatus document.
    /// </summary>
    [IsoId("_gJrQAsIFEeGllrOKQRUTYA_1165719728")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Identification of the firm that executed the transaction.
    /// </summary>
    [IsoId("_gJrQA8IFEeGllrOKQRUTYA_1815879851")]
    [DisplayName("Reporting Institution")]
    [IsoXmlTag("RptgInstn")]
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    
    /// <summary>
    /// Provides the status of the entire RegulatoryTransactionReportCancellationRequest document that was previously sent by a reporting institution.||.
    /// </summary>
    [IsoId("_gJrQBMIFEeGllrOKQRUTYA_-1473248173")]
    [DisplayName("Report Cancellation Status")]
    [IsoXmlTag("RptCxlSts")]
    public required ReportStatusAndReason2 ReportCancellationStatus { get; init; } 
    
    /// <summary>
    /// Provides the cancellation status of one or more transactions within a RegulatoryTransactionReportCancellationRequest that was previously sent by a reporting institution.
    /// </summary>
    [IsoId("_gJrQBcIFEeGllrOKQRUTYA_-1483406141")]
    [DisplayName("Individual Transaction Cancellation Status")]
    [IsoXmlTag("IndvTxCxlSts")]
    public required TradeTransactionStatusAndReason2 IndividualTransactionCancellationStatus { get; init; } 
    
    
    #nullable disable
    
}


// Since RegulatoryTransactionReportCancellationStatusV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RegulatoryTransactionReportCancellationStatusV01.

