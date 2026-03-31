// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A regulator or an intermediary sends the RegulatoryTransactionReportStatus to a reporting institution to provide the status of a RegulatoryTransactionReport previously sent by the reporting institution.
/// Usage
/// The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:
/// - Completed, or,
/// - Pending, or,
/// - Rejected.
/// If the status is rejected, then reason for the rejection must be specified.
/// </summary>
[Description(
    @"Scope|A regulator or an intermediary sends the RegulatoryTransactionReportStatus to a reporting institution to provide the status of a RegulatoryTransactionReport previously sent by the reporting institution.|Usage|The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:|- Completed, or,|- Pending, or,|- Rejected.|If the status is rejected, then reason for the rejection must be specified."
)]
[IsoId("_gJ-K8MIFEeGllrOKQRUTYA_-1798409708")]
[DisplayName("Regulatory Transaction Report Status V")]
public record RegulatoryTransactionReportStatusV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.010.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRptStsV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.010.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of the RegulatoryTransactionReportStatus document.
    /// </summary>
    [IsoId("_gJ-K8cIFEeGllrOKQRUTYA_-1414225965")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// Identification of the firm that is legally responsible for sending the transaction report.
    /// </summary>
    [IsoId("_gJ-K8sIFEeGllrOKQRUTYA_1208200865")]
    [DisplayName("Reporting Institution")]
    [IsoXmlTag("RptgInstn")]
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; }

    /// <summary>
    /// Provides the status of the entire RegulatoryTransactionReport that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_gJ-K88IFEeGllrOKQRUTYA_963266001")]
    [DisplayName("Report Status")]
    [IsoXmlTag("RptSts")]
    public required ReportStatusAndReason1 ReportStatus { get; init; }

    /// <summary>
    /// Provides the status of one or more transactions that were previously sent within a RegulatoryTransactionReport by the reporting institution.
    /// </summary>
    [IsoId("_gJ-K9MIFEeGllrOKQRUTYA_1351125442")]
    [DisplayName("Individual Transaction Status")]
    [IsoXmlTag("IndvTxSts")]
    public required TradeTransactionStatusAndReason1 IndividualTransactionStatus { get; init; }
}

// Since RegulatoryTransactionReportStatusV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RegulatoryTransactionReportStatusV01.
