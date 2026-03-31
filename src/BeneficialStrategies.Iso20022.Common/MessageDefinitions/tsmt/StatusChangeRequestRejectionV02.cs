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

namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.029.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusChangeRequestRejection message is sent by the party requested to accept or reject the request of a change in the status of a transaction to the matching application.
/// This message is used to inform about the rejection of a request to change the status of a transaction.
/// Usage
/// The StatusChangeRequestRejection message can be sent by the party requested to accept or reject a request to change the status of a transaction to inform that it rejects the request.
/// The message can be sent in response to a StatusChangeRequestNotification message.
/// The acceptance of a request to change the status of a transaction can be achieved by sending a StatusChangeRequestAcceptance message.
/// </summary>
[Description(
    @"Scope|The StatusChangeRequestRejection message is sent by the party requested to accept or reject the request of a change in the status of a transaction to the matching application.|This message is used to inform about the rejection of a request to change the status of a transaction.|Usage|The StatusChangeRequestRejection message can be sent by the party requested to accept or reject a request to change the status of a transaction to inform that it rejects the request.|The message can be sent in response to a StatusChangeRequestNotification message.|The acceptance of a request to change the status of a transaction can be achieved by sending a StatusChangeRequestAcceptance message."
)]
[IsoId("_xILlyNE8Ed-BzquC8wXy7w_-544947479")]
[DisplayName("Status Change Request Rejection V")]
public record StatusChangeRequestRejectionV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.029.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReqRjctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.029.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the rejection message.
    /// </summary>
    [IsoId("_xIUvsNE8Ed-BzquC8wXy7w_-544947476")]
    [DisplayName("Rejection Identification")]
    [IsoXmlTag("RjctnId")]
    public required MessageIdentification1 RejectionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_xIUvsdE8Ed-BzquC8wXy7w_-544947355")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_xIUvstE8Ed-BzquC8wXy7w_-544947447")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Specifies the status rejected.
    /// </summary>
    [IsoId("_xIUvs9E8Ed-BzquC8wXy7w_-544947416")]
    [DisplayName("Rejected Status Change")]
    [IsoXmlTag("RjctdStsChng")]
    public required TransactionStatus3 RejectedStatusChange { get; init; }

    /// <summary>
    /// Reason why the user cannot accept the request.
    /// </summary>
    [IsoId("_xIUvtNE8Ed-BzquC8wXy7w_-544947386")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required Reason2 RejectionReason { get; init; }
}

// Since StatusChangeRequestRejectionV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusChangeRequestRejectionV02.
