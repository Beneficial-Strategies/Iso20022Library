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
/// This record is an implementation of the tsmt.032.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusExtensionNotification message is sent by the matching application to the parties involved in a request to extend the status of a transaction.
/// This message is used to inform about the acceptance of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionNotification message can be sent by the matching application
/// - to the submitter of a request to extend the status of a transaction to pass on information about the acceptance of the request that it has obtained through the receipt of an StatusExtensionAcceptance message.
/// - to the accepter of a request to extend the status of a transaction to inform about the actual status of the transaction in response to a StatusExtensionAcceptance message.
/// In order to pass on information about the rejection of a request to extend the status of a transaction the matching application sends a StatusExtensionRejectionNotification message.
/// </summary>
[Description(@"Scope|The StatusExtensionNotification message is sent by the matching application to the parties involved in a request to extend the status of a transaction.|This message is used to inform about the acceptance of a request to extend the status of a transaction.|Usage|The StatusExtensionNotification message can be sent by the matching application|- to the submitter of a request to extend the status of a transaction to pass on information about the acceptance of the request that it has obtained through the receipt of an StatusExtensionAcceptance message.|- to the accepter of a request to extend the status of a transaction to inform about the actual status of the transaction in response to a StatusExtensionAcceptance message.|In order to pass on information about the rejection of a request to extend the status of a transaction the matching application sends a StatusExtensionRejectionNotification message.")]
[IsoId("_x_BHItE8Ed-BzquC8wXy7w_-321664507")]
[DisplayName("Status Extension Notification V")]
public partial record StatusExtensionNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.032.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.032.001.03";
    
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
    [IsoId("_x_BHI9E8Ed-BzquC8wXy7w_-321664471")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_x_BHJNE8Ed-BzquC8wXy7w_-321663919")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_x_BHJdE8Ed-BzquC8wXy7w_-321664394")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_x_BHJtE8Ed-BzquC8wXy7w_-321664004")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];
    
    /// <summary>
    /// Identifies the status that is being rolled over.
    /// </summary>
    [IsoId("_x_BHJ9E8Ed-BzquC8wXy7w_-321664316")]
    [DisplayName("Extended Status")]
    [IsoXmlTag("XtndedSts")]
    public required TransactionStatus5 ExtendedStatus { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_x_BHKNE8Ed-BzquC8wXy7w_-321663576")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since StatusExtensionNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusExtensionNotificationV03.

