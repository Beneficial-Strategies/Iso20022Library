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
/// This record is an implementation of the tsmt.028.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.
/// This message is used to notify the request of a change in the status of a transaction.
/// Usage
/// The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message.
/// </summary>
[Description(
    @"Scope|The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.|This message is used to notify the request of a change in the status of a transaction.|Usage|The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message."
)]
[IsoId("_wSYmONE8Ed-BzquC8wXy7w_439569273")]
[DisplayName("Status Change Request Notification V")]
public record StatusChangeRequestNotificationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.028.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReqNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.028.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_wSiXMNE8Ed-BzquC8wXy7w_439570377")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_wSiXMdE8Ed-BzquC8wXy7w_439570119")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_wSiXMtE8Ed-BzquC8wXy7w_439570205")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_wSiXM9E8Ed-BzquC8wXy7w_439569698")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_wSiXNNE8Ed-BzquC8wXy7w_439569386")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Specifies the status that is proposed by the other party.
    /// </summary>
    [IsoId("_wSiXNdE8Ed-BzquC8wXy7w_439569777")]
    [DisplayName("Proposed Status Change")]
    [IsoXmlTag("PropsdStsChng")]
    public required TransactionStatus3 ProposedStatusChange { get; init; }

    /// <summary>
    /// Specifies the reason for the request to change status.
    /// </summary>
    [IsoId("_wSiXNtE8Ed-BzquC8wXy7w_439570689")]
    [DisplayName("Request Reason")]
    [IsoXmlTag("ReqRsn")]
    public Reason2? RequestReason { get; init; }

    /// <summary>
    /// Party that has requested the status change.
    /// </summary>
    [IsoId("_wSiXN9E8Ed-BzquC8wXy7w_1643841205")]
    [DisplayName("Initiator")]
    [IsoXmlTag("Initr")]
    public required BICIdentification1 Initiator { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_wSiXONE8Ed-BzquC8wXy7w_439569309")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since StatusChangeRequestNotificationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusChangeRequestNotificationV03.
