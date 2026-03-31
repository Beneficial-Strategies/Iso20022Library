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
/// This record is an implementation of the tsmt.045.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForwardIntentToPayNotification message is forwarded by the matching application from one primary bank to the other primary bank in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The ForwardIntentToPayNotification message is a copy of the IntentToPayNotification message received by the matching application and forwarded to the other primary bank for information. No response is expected.
/// </summary>
[Description(
    @"Scope|The ForwardIntentToPayNotification message is forwarded by the matching application from one primary bank to the other primary bank in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The ForwardIntentToPayNotification message is a copy of the IntentToPayNotification message received by the matching application and forwarded to the other primary bank for information. No response is expected."
)]
[IsoId("_hEp5QRVaEeOCqpkCrPgk4g")]
[DisplayName("Forward Intent To Pay Notification V")]
public record ForwardIntentToPayNotificationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.045.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FwdInttToPayNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.02";

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
    [IsoId("_hEp5QxVaEeOCqpkCrPgk4g")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_hEp5RRVaEeOCqpkCrPgk4g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_hEp5RxVaEeOCqpkCrPgk4g")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_hEp5SRVaEeOCqpkCrPgk4g")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for the financial institutions involved in this transaction.
    /// </summary>
    [IsoId("_hEp5SxVaEeOCqpkCrPgk4g")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_hEp5TRVaEeOCqpkCrPgk4g")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; }

    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_hEp5TxVaEeOCqpkCrPgk4g")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; }

    /// <summary>
    /// Provides the details of the intention to pay.
    /// </summary>
    [IsoId("_hEp5URVaEeOCqpkCrPgk4g")]
    [DisplayName("Intent To Pay")]
    [IsoXmlTag("InttToPay")]
    public required IntentToPay2 IntentToPay { get; init; }

    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_hEp5UxVaEeOCqpkCrPgk4g")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since ForwardIntentToPayNotificationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForwardIntentToPayNotificationV02.
