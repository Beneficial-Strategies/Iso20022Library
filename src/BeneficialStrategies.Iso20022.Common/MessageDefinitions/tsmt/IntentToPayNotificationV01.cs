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
/// This record is an implementation of the tsmt.044.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.
/// The message is unsolicited, that is, it is not sent in response to another message.
/// </summary>
[Description(
    @"Scope|The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.|The message is unsolicited, that is, it is not sent in response to another message."
)]
[IsoId("_qS03gtE8Ed-BzquC8wXy7w_-674719643")]
[DisplayName("Intent To Pay Notification V")]
public record IntentToPayNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.044.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InttToPayNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.044.001.01";

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
    [IsoId("_qS03g9E8Ed-BzquC8wXy7w_163901085")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_qS03hNE8Ed-BzquC8wXy7w_152820680")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_qS03hdE8Ed-BzquC8wXy7w_1332333857")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC. |.
    /// </summary>
    [IsoId("_qS03htE8Ed-BzquC8wXy7w_-1244476424")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; }

    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC. |.
    /// </summary>
    [IsoId("_qS03h9E8Ed-BzquC8wXy7w_-1235239055")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; }

    /// <summary>
    /// Provides the details of the intention to pay.
    /// </summary>
    [IsoId("_qS03iNE8Ed-BzquC8wXy7w_-1879861996")]
    [DisplayName("Intent To Pay")]
    [IsoXmlTag("InttToPay")]
    public required IntentToPay1 IntentToPay { get; init; }
}

// Since IntentToPayNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntentToPayNotificationV01.
