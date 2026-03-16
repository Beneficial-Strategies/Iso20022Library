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
/// This record is an implementation of the camt.032.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Cancel Case Assignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.
/// Usage
/// The Cancel Case Assignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a Claim Non Receipt message).
/// The Cancel Case Assignment message can be used to stop the processing of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Cancel Case Assignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple Cancel Case Assignment messages must be sent.
/// The Cancel Case Assignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.
/// When an agent re-assigns the Cancel Case Assignment to a subsequent case assignee, this agent must send a Notification Of Case Assignment message to its assigner.
/// When the Cancel Case Assignment instruction has been acted upon by the relevant case assignee, a Resolution Of Investigation message is sent to the case assigner or case creator, in reply.
/// The Cancel Case Assignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a Customer or FIToFI Payment Cancellation Request message must be used, with the case identification of the original Request To Modify Payment message. In this context it is incorrect to use the Cancel Case Assignment message.
/// </summary>
[Description(
    @"Scope|The Cancel Case Assignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.|Usage|The Cancel Case Assignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a Claim Non Receipt message).|The Cancel Case Assignment message can be used to stop the processing of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Cancel Case Assignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple Cancel Case Assignment messages must be sent.|The Cancel Case Assignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.|When an agent re-assigns the Cancel Case Assignment to a subsequent case assignee, this agent must send a Notification Of Case Assignment message to its assigner.|When the Cancel Case Assignment instruction has been acted upon by the relevant case assignee, a Resolution Of Investigation message is sent to the case assigner or case creator, in reply.|The Cancel Case Assignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a Customer or FIToFI Payment Cancellation Request message must be used, with the case identification of the original Request To Modify Payment message. In this context it is incorrect to use the Cancel Case Assignment message."
)]
[IsoId("_sXcGMFkyEeGeoaLUQk__nA_-930975995")]
[DisplayName("Cancel Case Assignment V")]
public record CancelCaseAssignmentV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.032.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclCaseAssgnmt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.032.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_sXcGMVkyEeGeoaLUQk__nA_-410868205")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment3 Assignment { get; init; }

    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_sXvoMFkyEeGeoaLUQk__nA_-1294101492")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case3 Case { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sXvoMVkyEeGeoaLUQk__nA_1037902582")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CancelCaseAssignmentV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelCaseAssignmentV03.
