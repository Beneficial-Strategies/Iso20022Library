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
/// This record is an implementation of the camt.008.002.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Request To Cancel Payment message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the cancellation of an original payment instruction.
/// Usage
/// The Request To Cancel Payment message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)
/// - Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested cancellation
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// A Request To Cancel Payment message concerns one and only one original payment instruction at a time. If several original payment instructions need to be cancelled, then multiple Request To Cancel Payment messages must be sent.
/// When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.
/// The processing of a request to cancel payment case may end with a Debit Authorisation Request message sent to the creditor by its account servicing institution.
/// The Request To Cancel Payment message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Request To Modify Payment message and the element ReopenCaseIndication is set to &apos;Yes&apos; or &apos;true&apos;.
/// </summary>
[Description(
    @"Scope|The Request To Cancel Payment message is sent by a case creator/case assigner to a case assignee.|This message is used to request the cancellation of an original payment instruction.|Usage|The Request To Cancel Payment message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)|- Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested cancellation|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|A Request To Cancel Payment message concerns one and only one original payment instruction at a time. If several original payment instructions need to be cancelled, then multiple Request To Cancel Payment messages must be sent.|When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.|The processing of a request to cancel payment case may end with a Debit Authorisation Request message sent to the creditor by its account servicing institution.|The Request To Cancel Payment message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Request To Modify Payment message and the element ReopenCaseIndication is set to 'Yes' or 'true'."
)]
[IsoId("_SsPgaNE_Ed-BzquC8wXy7w_-319126459")]
[DisplayName("Request To Cancel Payment")]
public record RequestToCancelPayment : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.008.002.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.008.002.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.008.002.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the assignment of a case from an assigner to an assignee.
    /// </summary>
    [IsoId("_SsPgadE_Ed-BzquC8wXy7w_402186084")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment Assignment { get; init; }

    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_SsZRYNE_Ed-BzquC8wXy7w_70459884")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case Case { get; init; }

    /// <summary>
    /// Identifies the payment instruction to be cancelled.
    /// </summary>
    [IsoId("_SsZRYdE_Ed-BzquC8wXy7w_74152854")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required PaymentInstructionExtract Underlying { get; init; }

    /// <summary>
    /// Defines the reason for requesting the cancellation.
    /// </summary>
    [IsoId("_SsZRYtE_Ed-BzquC8wXy7w_341710652")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required DebitAuthorisationDetails Justification { get; init; }
}

// Since RequestToCancelPaymentDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToCancelPayment.
