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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.032.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelCaseAssignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.
/// Usage
/// The CancelCaseAssignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a ClaimNonReceipt message).
/// The CancelCaseAssignment message can be used to stop the processing of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The CancelCaseAssignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple CancelCaseAssignment messages must be sent.
/// The CancelCaseAssignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.
/// When an agent re-assigns the CancelCaseAssignment to a subsequent case assignee, this agent must send a NotificationOfCaseAssignment message to its assigner.
/// When the CancelCaseAssignment instruction has been acted upon by the relevant case assignee, a ResolutionOfInvestigation message is sent to the case assigner or case creator, in reply.
/// The CancelCaseAssignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message must be used, with the case identification of the original RequestToModifyPayment message. In this context it is incorrect to use the CancelCaseAssignment message.
/// </summary>
[Description(@"Scope|The CancelCaseAssignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.|Usage|The CancelCaseAssignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a ClaimNonReceipt message).|The CancelCaseAssignment message can be used to stop the processing of a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The CancelCaseAssignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple CancelCaseAssignment messages must be sent.|The CancelCaseAssignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.|When an agent re-assigns the CancelCaseAssignment to a subsequent case assignee, this agent must send a NotificationOfCaseAssignment message to its assigner.|When the CancelCaseAssignment instruction has been acted upon by the relevant case assignee, a ResolutionOfInvestigation message is sent to the case assigner or case creator, in reply.|The CancelCaseAssignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message must be used, with the case identification of the original RequestToModifyPayment message. In this context it is incorrect to use the CancelCaseAssignment message.")]
[IsoId("_eX_OnW2PEei3KuUgpx7Xcw")]
[DisplayName("Cancel Case Assignment V")]
public partial record CancelCaseAssignmentV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.032.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclCaseAssgnmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.032.001.04";
    
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
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_On22PEei3KuUgpx7Xcw")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment5 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_OoW2PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case5 Case { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_Oo22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since CancelCaseAssignmentV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelCaseAssignmentV04.

