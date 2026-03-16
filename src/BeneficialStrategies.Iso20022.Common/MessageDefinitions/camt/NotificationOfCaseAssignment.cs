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
/// This record is an implementation of the camt.030.001.01 ISO standard message type.
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
/// - must not be used in place of a Resolution Of Investigation or a Case Status Report message.
/// </summary>
[Description(
    @"Scope|The Notification Of Case Assignment message is sent by a case assignee to a case creator/case assigner.|This message is used to inform the case assigner that:|- the assignee is reassigning the case to the next agent in the transaction processing chain for further action|- the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point|Usage|The Notification Of Case Assignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Notification Of Case Assignment message|- covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent|- except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator|- must not be used in place of a Resolution Of Investigation or a Case Status Report message."
)]
[IsoId("_JvSziNE_Ed-BzquC8wXy7w_1651385282")]
[DisplayName("Notification Of Case Assignment")]
public record NotificationOfCaseAssignment : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.030.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.030.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.030.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies generic information about the notification.|The receiver of a notification is necessarily the party which assigned the case to the sender.
    /// </summary>
    [IsoId("_JvSzidE_Ed-BzquC8wXy7w_-896449818")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required ReportHeader Header { get; init; }

    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_JvckgNE_Ed-BzquC8wXy7w_-710886689")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case Case { get; init; }

    /// <summary>
    /// Identifies the current assignment of the case. ||The Assigner must be the emitter of the notification.|The Assignee must be another Party in the payment chain.
    /// </summary>
    [IsoId("_JvckgdE_Ed-BzquC8wXy7w_-367336847")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment Assignment { get; init; }

    /// <summary>
    /// Information about the type of action taken.
    /// </summary>
    [IsoId("_JvckgtE_Ed-BzquC8wXy7w_-354409827")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public required CaseForwardingNotification Notification { get; init; }
}

// Since NotificationOfCaseAssignmentDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NotificationOfCaseAssignment.
