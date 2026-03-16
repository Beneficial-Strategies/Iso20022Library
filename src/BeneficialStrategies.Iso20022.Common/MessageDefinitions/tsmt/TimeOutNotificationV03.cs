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
/// This record is an implementation of the tsmt.040.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TimeOutNotification message is sent by the matching application to a party involved in a transaction.
/// This message is used to inform that a transaction will be closed within a given span of time if no action is taken.
/// Usage
/// The TimeOutNotification message can be sent by the matching application to inform the parties that a transaction will be closed within a given span of time if no action is taken by either party because
/// - no activity for the transaction has taken place within a specified span of time,or
/// - a significant date is reached, for example latest shipment date.
/// </summary>
[Description(
    @"Scope|The TimeOutNotification message is sent by the matching application to a party involved in a transaction.|This message is used to inform that a transaction will be closed within a given span of time if no action is taken.|Usage|The TimeOutNotification message can be sent by the matching application to inform the parties that a transaction will be closed within a given span of time if no action is taken by either party because|- no activity for the transaction has taken place within a specified span of time,or|- a significant date is reached, for example latest shipment date."
)]
[IsoId("_1eFPCNE8Ed-BzquC8wXy7w_1723275077")]
[DisplayName("Time Out Notification V")]
public record TimeOutNotificationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.040.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TmOutNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.040.001.03";

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
    [IsoId("_1ePAANE8Ed-BzquC8wXy7w_1723275540")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_1ePAAdE8Ed-BzquC8wXy7w_1723275201")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_1ePAAtE8Ed-BzquC8wXy7w_1723275262")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_1ePAA9E8Ed-BzquC8wXy7w_1723275088")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_1ePABNE8Ed-BzquC8wXy7w_1723275231")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Describes the time-out consequences.
    /// </summary>
    [IsoId("_1ePABdE8Ed-BzquC8wXy7w_1723275139")]
    [DisplayName("Time Out Description")]
    [IsoXmlTag("TmOutDesc")]
    public required TimeOutResult2 TimeOutDescription { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_1ePABtE8Ed-BzquC8wXy7w_1723275170")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since TimeOutNotificationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TimeOutNotificationV03.
