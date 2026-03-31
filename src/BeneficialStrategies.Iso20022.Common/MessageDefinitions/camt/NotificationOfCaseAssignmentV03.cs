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
/// This record is an implementation of the camt.030.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Notification Of Case Assignment message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform the case assigner that:
/// - the assignee is reassigning the case to the next agent in the transaction processing chain for further action
/// - the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point
/// Usage
/// The Notification Of Case Assignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Notification Of Case Assignment message
/// - covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent
/// - except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator
/// - must not be used in place of a Resolution Of Investigation or a Case Status Report message
/// When the assignee does not reassign the case to another party (that is responding with a Notification Of Case Assignment message with notification MINE - The case is processed by the assignee), the case assignment should contain the case assignment elements as received in the original query.
/// </summary>
[Description(
    @"Scope|The Notification Of Case Assignment message is sent by a case assignee to a case creator/case assigner.|This message is used to inform the case assigner that:|- the assignee is reassigning the case to the next agent in the transaction processing chain for further action|- the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point|Usage|The Notification Of Case Assignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Notification Of Case Assignment message|- covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent|- except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator|- must not be used in place of a Resolution Of Investigation or a Case Status Report message|When the assignee does not reassign the case to another party (that is responding with a Notification Of Case Assignment message with notification MINE - The case is processed by the assignee), the case assignment should contain the case assignment elements as received in the original query."
)]
[IsoId("_KtIUxdE_Ed-BzquC8wXy7w_-2097745661")]
[DisplayName("Notification Of Case Assignment V")]
public record NotificationOfCaseAssignmentV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.030.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnOfCaseAssgnmt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.030.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies generic information about the notification.|The receiver of a notification must be the party which assigned the case to the sender.
    /// </summary>
    [IsoId("_KtIUxtE_Ed-BzquC8wXy7w_-239673952")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required ReportHeader2 Header { get; init; }

    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_KtIUx9E_Ed-BzquC8wXy7w_-239674352")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case2 Case { get; init; }

    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_KtIUyNE_Ed-BzquC8wXy7w_-239674321")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment2 Assignment { get; init; }

    /// <summary>
    /// Information about the type of action taken.
    /// </summary>
    [IsoId("_KtIUydE_Ed-BzquC8wXy7w_-2097745596")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public required CaseForwardingNotification3 Notification { get; init; }
}

// Since NotificationOfCaseAssignmentV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NotificationOfCaseAssignmentV03.
