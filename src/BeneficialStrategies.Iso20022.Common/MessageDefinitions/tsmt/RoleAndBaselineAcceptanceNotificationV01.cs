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
/// This record is an implementation of the tsmt.051.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RoleAndBaselineAcceptanceNotification message is sent by the matching application to the primary banks to inform about role and baseline acceptance by a secondary bank.
/// Usage
/// The RoleAndBaselineAcceptanceNotification message is used to inform that a secondary bank has accepted the role and baseline. No response is expected.
/// </summary>
[Description(
    @"Scope|The RoleAndBaselineAcceptanceNotification message is sent by the matching application to the primary banks to inform about role and baseline acceptance by a secondary bank.|Usage|The RoleAndBaselineAcceptanceNotification message is used to inform that a secondary bank has accepted the role and baseline. No response is expected."
)]
[IsoId("_s3o9qNE8Ed-BzquC8wXy7w_1220286611")]
[DisplayName("Role And Baseline Acceptance Notification V")]
public record RoleAndBaselineAcceptanceNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.051.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RoleAndBaselnAccptncNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.051.001.01";

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
    [IsoId("_s3o9qdE8Ed-BzquC8wXy7w_1220286630")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_s3yHkNE8Ed-BzquC8wXy7w_1220287199")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_s3yHkdE8Ed-BzquC8wXy7w_1220286725")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_s3yHktE8Ed-BzquC8wXy7w_-799125810")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_s3yHk9E8Ed-BzquC8wXy7w_1220286880")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Party that has accepted.
    /// </summary>
    [IsoId("_s3yHlNE8Ed-BzquC8wXy7w_-1814999420")]
    [DisplayName("Initiator")]
    [IsoXmlTag("Initr")]
    public required BICIdentification1 Initiator { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_s3yHldE8Ed-BzquC8wXy7w_1220287294")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since RoleAndBaselineAcceptanceNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RoleAndBaselineAcceptanceNotificationV01.
