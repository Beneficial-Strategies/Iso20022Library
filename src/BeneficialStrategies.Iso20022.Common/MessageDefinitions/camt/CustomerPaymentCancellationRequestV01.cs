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
/// This record is an implementation of the camt.055.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Customer Payment Cancellation Request message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the cancellation of an original payment instruction. The Customer Payment Cancellation Request message is issued by the initiating party to request the cancellation of an initiation payment message previously sent (such as CustomerCreditTransferInitiation or CustomerDirectDebitInitiation).
/// Usage
/// The Customer Payment Cancellation Request message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)
/// - Reject Investigation message when the case assignee is unable or not authorised to perform the requested cancellation
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// A Customer Payment Cancellation Request message concerns one and only one original payment instruction at a time.
/// When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.
/// The processing of a Customer Payment Cancellation Request message case may lead to a Debit Authorisation Request message sent to the creditor by its account servicing institution.
/// The Customer Payment Cancellation Request message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Customer Payment Cancellation Request message and the element ReopenCaseIndication is set to &apos;Yes&apos; or &apos;true&apos;.
/// </summary>
[Description(
    @"Scope|The Customer Payment Cancellation Request message is sent by a case creator/case assigner to a case assignee.|This message is used to request the cancellation of an original payment instruction. The Customer Payment Cancellation Request message is issued by the initiating party to request the cancellation of an initiation payment message previously sent (such as CustomerCreditTransferInitiation or CustomerDirectDebitInitiation).|Usage|The Customer Payment Cancellation Request message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)|- Reject Investigation message when the case assignee is unable or not authorised to perform the requested cancellation|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|A Customer Payment Cancellation Request message concerns one and only one original payment instruction at a time.|When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.|The processing of a Customer Payment Cancellation Request message case may lead to a Debit Authorisation Request message sent to the creditor by its account servicing institution.|The Customer Payment Cancellation Request message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Customer Payment Cancellation Request message and the element ReopenCaseIndication is set to 'Yes' or 'true'."
)]
[IsoId("_RsSUuNE-Ed-BzquC8wXy7w_377163299")]
[DisplayName("Customer Payment Cancellation Request V")]
public record CustomerPaymentCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.055.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.055.001.01";

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
    [IsoId("_RsSUudE-Ed-BzquC8wXy7w_731514639")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment2 Assignment { get; init; }

    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_RsSUutE-Ed-BzquC8wXy7w_377163330")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case2? Case { get; init; }

    /// <summary>
    /// Provides details on the number of transactions and the control sum of the message.
    /// </summary>
    [IsoId("_RsSUu9E-Ed-BzquC8wXy7w_731514361")]
    [DisplayName("Control Data")]
    [IsoXmlTag("CtrlData")]
    public ControlData1? ControlData { get; init; }

    /// <summary>
    /// Identifies the payment instruction to be cancelled.
    /// </summary>
    [IsoId("_RscFsNE-Ed-BzquC8wXy7w_377163639")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required UnderlyingTransaction1 Underlying { get; init; }
}

// Since CustomerPaymentCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomerPaymentCancellationRequestV01.
