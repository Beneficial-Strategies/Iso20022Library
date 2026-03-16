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
/// This record is an implementation of the tsmt.025.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusChangeNotification message is sent by the matching application to the parties involved in the change of the status of a transaction.
/// This message is used to inform about the change of a status.
/// Usage
/// The StatusChangeNotification message can be sent by the matching application
/// - to the submitter of the request to change the status of a transaction to pass on the information about the acceptance of the request that it has obtained through the receipt of an StatusChangeRequestAcceptance message.
/// - to the accepter of a request to change the status of a transaction inform about the actual status of the transaction in response to a StatusChangeRequestAcceptance message.
/// - to either party involved in the establishment of a transaction to inform about the change of the status of the transaction to the status close. This can be done when the limit of possible attempts to establish the transaction has been reached or when unilaterally requested by one of the parties involved in the not yet established transaction.
/// - to either party involved in a transaction to inform about the change of the status of the transaction as announced in a TimeOutNotification message sent by the matching application prior to the StatusChangeNotification message.
/// </summary>
[Description(
    @"Scope|The StatusChangeNotification message is sent by the matching application to the parties involved in the change of the status of a transaction.|This message is used to inform about the change of a status.|Usage|The StatusChangeNotification message can be sent by the matching application|- to the submitter of the request to change the status of a transaction to pass on the information about the acceptance of the request that it has obtained through the receipt of an StatusChangeRequestAcceptance message.|- to the accepter of a request to change the status of a transaction inform about the actual status of the transaction in response to a StatusChangeRequestAcceptance message.|- to either party involved in the establishment of a transaction to inform about the change of the status of the transaction to the status close. This can be done when the limit of possible attempts to establish the transaction has been reached or when unilaterally requested by one of the parties involved in the not yet established transaction.|- to either party involved in a transaction to inform about the change of the status of the transaction as announced in a TimeOutNotification message sent by the matching application prior to the StatusChangeNotification message."
)]
[IsoId("_vbs12NE8Ed-BzquC8wXy7w_-1030664392")]
[DisplayName("Status Change Notification V")]
public record StatusChangeNotificationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.025.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.025.001.03";

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
    [IsoId("_vbs12dE8Ed-BzquC8wXy7w_-1030664113")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_vbs12tE8Ed-BzquC8wXy7w_-1030664082")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_vb1_wNE8Ed-BzquC8wXy7w_-1030664360")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_vb1_wdE8Ed-BzquC8wXy7w_-1030663959")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_vb1_wtE8Ed-BzquC8wXy7w_-1030664021")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_vb1_w9E8Ed-BzquC8wXy7w_-1030664051")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since StatusChangeNotificationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusChangeNotificationV03.
