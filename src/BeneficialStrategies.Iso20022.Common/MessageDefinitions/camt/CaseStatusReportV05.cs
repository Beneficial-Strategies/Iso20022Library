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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.039.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CaseStatusReport message is sent by a case assignee to a case creator or case assigner.
/// This message is used to report on the status of a case.
/// Usage
/// A CaseStatusReport message is sent in reply to a CaseStatusReportRequest message. This message
/// - covers one and only one case at a time. (If a case assignee needs to report on several cases, then multiple CaseStatusReport messages must be sent);
/// - may be forwarded to subsequent case assigner(s) until it reaches the end point;
/// - is able to indicate the fact that a case has been assigned to a party downstream in the payment processing chain;
/// - may not be used in place of a ResolutionOfInvestigation (except for the condition given in the next bullet point) or NotificationOfCaseAssignment message;
/// - may be skipped and replaced by a ResolutionOfInvestigation message when the request for a investigation status is received at the time the assigner has resolved the case. (In this case a ResolutionOfInvestigation message can be sent instead of a CaseStatusReport and the case may be closed).
/// </summary>
[Description(
    @"Scope|The CaseStatusReport message is sent by a case assignee to a case creator or case assigner.|This message is used to report on the status of a case.|Usage|A CaseStatusReport message is sent in reply to a CaseStatusReportRequest message. This message|- covers one and only one case at a time. (If a case assignee needs to report on several cases, then multiple CaseStatusReport messages must be sent);|- may be forwarded to subsequent case assigner(s) until it reaches the end point;|- is able to indicate the fact that a case has been assigned to a party downstream in the payment processing chain;|- may not be used in place of a ResolutionOfInvestigation (except for the condition given in the next bullet point) or NotificationOfCaseAssignment message;|- may be skipped and replaced by a ResolutionOfInvestigation message when the request for a investigation status is received at the time the assigner has resolved the case. (In this case a ResolutionOfInvestigation message can be sent instead of a CaseStatusReport and the case may be closed)."
)]
[IsoId("_eYI_PW2PEei3KuUgpx7Xcw")]
[DisplayName("Case Status Report V")]
public record CaseStatusReportV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.039.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CaseStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.039.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies generic information about an investigation report.
    /// </summary>
    [IsoId("_eYI_P22PEei3KuUgpx7Xcw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required ReportHeader5 Header { get; init; }

    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eYI_QW2PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case5 Case { get; init; }

    /// <summary>
    /// Defines the status of the case.
    /// </summary>
    [IsoId("_eYI_Q22PEei3KuUgpx7Xcw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CaseStatus2 Status { get; init; }

    /// <summary>
    /// Identifies the change of an assignment for an investigation case from an assigner to a new assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eYI_RW2PEei3KuUgpx7Xcw")]
    [DisplayName("New Assignment")]
    [IsoXmlTag("NewAssgnmt")]
    public CaseAssignment5? NewAssignment { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_R22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CaseStatusReportV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CaseStatusReportV05.
