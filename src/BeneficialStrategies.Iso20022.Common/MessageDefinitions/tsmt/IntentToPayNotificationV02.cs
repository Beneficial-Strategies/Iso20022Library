// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.044.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.
/// The message is unsolicited, that is, it is not sent in response to another message.
/// </summary>
[Description(@"Scope|The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.|The message is unsolicited, that is, it is not sent in response to another message.")]
[IsoId("_YyxioRVaEeOCqpkCrPgk4g")]
[DisplayName("Intent To Pay Notification V")]
public partial record IntentToPayNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.044.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InttToPayNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.044.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_YyxioxVaEeOCqpkCrPgk4g")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_YyxipRVaEeOCqpkCrPgk4g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_YyxipxVaEeOCqpkCrPgk4g")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC. |.
    /// </summary>
    [IsoId("_YyxiqRVaEeOCqpkCrPgk4g")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC. |.
    /// </summary>
    [IsoId("_YyxiqxVaEeOCqpkCrPgk4g")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Provides the details of the intention to pay.
    /// </summary>
    [IsoId("_YyxirRVaEeOCqpkCrPgk4g")]
    [DisplayName("Intent To Pay")]
    [IsoXmlTag("InttToPay")]
    public required IntentToPay2 IntentToPay { get; init; } 
    
    
    #nullable disable
    
}


// Since IntentToPayNotificationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntentToPayNotificationV02.

