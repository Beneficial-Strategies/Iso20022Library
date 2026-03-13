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
/// This record is an implementation of the tsmt.036.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusExtensionRequestNotification message is sent by the matching application to the party requested to accept or reject a request to extend the status of a transaction.
/// This message is used to notify the request to extend the status of a transaction.
/// Usage
/// The StatusExtensionRequestNotification message can be sent by the matching application to pass on information about the request to extend the status of a transaction that it has obtained through the receipt of a StatusExtensionRequest message.
/// </summary>
[Description(@"Scope|The StatusExtensionRequestNotification message is sent by the matching application to the party requested to accept or reject a request to extend the status of a transaction.|This message is used to notify the request to extend the status of a transaction.|Usage|The StatusExtensionRequestNotification message can be sent by the matching application to pass on information about the request to extend the status of a transaction that it has obtained through the receipt of a StatusExtensionRequest message.")]
[IsoId("_zU2RotE8Ed-BzquC8wXy7w_883782458")]
[DisplayName("Status Extension Request Notification V")]
public partial record StatusExtensionRequestNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.036.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnReqNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.036.001.03";
    
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
    /// Identifies the notification.
    /// </summary>
    [IsoId("_zU2Ro9E8Ed-BzquC8wXy7w_883782725")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_zU2RpNE8Ed-BzquC8wXy7w_883782820")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_zU2RpdE8Ed-BzquC8wXy7w_883782976")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_zU2RptE8Ed-BzquC8wXy7w_883783295")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];
    
    /// <summary>
    /// Identifies the status for which an extension of the validity period has been requested.
    /// </summary>
    [IsoId("_zU2Rp9E8Ed-BzquC8wXy7w_883782906")]
    [DisplayName("Status To Be Extended")]
    [IsoXmlTag("StsToBeXtnded")]
    public required TransactionStatus5 StatusToBeExtended { get; init; } 
    
    /// <summary>
    /// Party that has requested the status extension.
    /// </summary>
    [IsoId("_zU2RqNE8Ed-BzquC8wXy7w_-2036986967")]
    [DisplayName("Initiator")]
    [IsoXmlTag("Initr")]
    public required BICIdentification1 Initiator { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_zU_bkNE8Ed-BzquC8wXy7w_883783390")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since StatusExtensionRequestNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusExtensionRequestNotificationV03.

