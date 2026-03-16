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
/// This record is an implementation of the tsmt.048.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SpecialNotification message is sent by the matching application to parties to the transaction, following the receipt of a SpecialRequest message.
/// The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.
/// Usage
/// The SpecialNotification message is sent to the parties to the transaction so that they can take appropriate action.
/// </summary>
[Description(
    @"Scope|The SpecialNotification message is sent by the matching application to parties to the transaction, following the receipt of a SpecialRequest message.|The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.|Usage|The SpecialNotification message is sent to the parties to the transaction so that they can take appropriate action."
)]
[IsoId("_uldKWNE8Ed-BzquC8wXy7w_-3505275")]
[DisplayName("Special Notification V")]
public record SpecialNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.048.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SpclNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01";

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
    [IsoId("_ulm7UNE8Ed-BzquC8wXy7w_7576915")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_ulm7UdE8Ed-BzquC8wXy7w_8501968")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_ulm7UtE8Ed-BzquC8wXy7w_8499489")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_ulm7U9E8Ed-BzquC8wXy7w_8500107")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for the financial institution that is the sender of the acknowledged message.
    /// </summary>
    [IsoId("_ulm7VNE8Ed-BzquC8wXy7w_8502400")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Party that has sent the special request.
    /// </summary>
    [IsoId("_ulm7VdE8Ed-BzquC8wXy7w_1354069290")]
    [DisplayName("Initiator")]
    [IsoXmlTag("Initr")]
    public required BICIdentification1 Initiator { get; init; }

    /// <summary>
    /// Notification received by the matching application and forwarded to another party.
    /// </summary>
    [IsoId("_ulm7VtE8Ed-BzquC8wXy7w_1253406214")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public required Notification1 Notification { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_ulm7V9E8Ed-BzquC8wXy7w_8500865")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since SpecialNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SpecialNotificationV01.
