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
/// This record is an implementation of the tsmt.034.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusExtensionRejectionNotification message is sent by the matching application to the submitter of a request to extend the status of a transaction.
/// This message is used to inform about the rejection of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionRejectionNotification message can be sent by the matching application to pass on information about the rejection of a request to extend the status of a transaction that it has obtained through the receipt of a StatusExtensionRejection message.
/// In order to pass on information about the acceptance of a request to extend the status of a transaction the matching application sends a StatusExtensionNotification message.
/// </summary>
[Description(
    @"Scope|The StatusExtensionRejectionNotification message is sent by the matching application to the submitter of a request to extend the status of a transaction.|This message is used to inform about the rejection of a request to extend the status of a transaction.|Usage|The StatusExtensionRejectionNotification message can be sent by the matching application to pass on information about the rejection of a request to extend the status of a transaction that it has obtained through the receipt of a StatusExtensionRejection message.|In order to pass on information about the acceptance of a request to extend the status of a transaction the matching application sends a StatusExtensionNotification message."
)]
[IsoId("_yZ1a6NE8Ed-BzquC8wXy7w_474408796")]
[DisplayName("Status Extension Rejection Notification V")]
public record StatusExtensionRejectionNotificationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.034.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnRjctnNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.034.001.03";

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
    [IsoId("_yZ1a6dE8Ed-BzquC8wXy7w_474408832")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_yZ1a6tE8Ed-BzquC8wXy7w_474409127")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_yZ_L4NE8Ed-BzquC8wXy7w_474409728")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction that is not extended.
    /// </summary>
    [IsoId("_yZ_L4dE8Ed-BzquC8wXy7w_474409548")]
    [DisplayName("Non Extended Status")]
    [IsoXmlTag("NonXtndedSts")]
    public required TransactionStatus4 NonExtendedStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_yZ_L4tE8Ed-BzquC8wXy7w_474409823")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Reason why the user cannot accept the request.
    /// </summary>
    [IsoId("_yZ_L49E8Ed-BzquC8wXy7w_474409205")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required Reason2 RejectionReason { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_yZ_L5NE8Ed-BzquC8wXy7w_474410135")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since StatusExtensionRejectionNotificationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusExtensionRejectionNotificationV03.
