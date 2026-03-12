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
/// This record is an implementation of the tsmt.006.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendmentAcceptanceNotification message is sent by the matching application to the requester of an amendment.
/// This message is used to notify the acceptance of an amendment request.
/// Usage
/// The AmendmentAcceptanceNotification message can be sent by the matching application to pass on information about the acceptance of an amendment request that it has obtained through the receipt of an AmendmentAcceptance message.
/// In order to pass on information about the rejection of an amendment request the matching application sends an AmendmentRejectionNotification message.
/// </summary>
[Description(@"Scope|The AmendmentAcceptanceNotification message is sent by the matching application to the requester of an amendment.|This message is used to notify the acceptance of an amendment request.|Usage|The AmendmentAcceptanceNotification message can be sent by the matching application to pass on information about the acceptance of an amendment request that it has obtained through the receipt of an AmendmentAcceptance message.|In order to pass on information about the rejection of an amendment request the matching application sends an AmendmentRejectionNotification message.")]
[IsoId("_jX9-MNE8Ed-BzquC8wXy7w_-872944832")]
[DisplayName("Amendment Acceptance Notification V")]
public partial record AmendmentAcceptanceNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.006.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdmntAccptncNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.006.001.03";
    
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
    [IsoId("_jX9-MdE8Ed-BzquC8wXy7w_-872944488")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_jX9-MtE8Ed-BzquC8wXy7w_-872943498")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_jX9-M9E8Ed-BzquC8wXy7w_-872943919")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_jX9-NNE8Ed-BzquC8wXy7w_-872944308")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_jX9-NdE8Ed-BzquC8wXy7w_-872943841")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Reference to the identification of the delta report that contained the amendment.
    /// </summary>
    [IsoId("_jX9-NtE8Ed-BzquC8wXy7w_-872944806")]
    [DisplayName("Delta Report Reference")]
    [IsoXmlTag("DltaRptRef")]
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    
    /// <summary>
    /// Sequence number of the accepted baseline amendment.
    /// </summary>
    [IsoId("_jX9-N9E8Ed-BzquC8wXy7w_-872944231")]
    [DisplayName("Accepted Amendment Number")]
    [IsoXmlTag("AccptdAmdmntNb")]
    public required Count1 AcceptedAmendmentNumber { get; init; } 
    
    /// <summary>
    /// Party that has accepted the amendment.
    /// </summary>
    [IsoId("_jYHvMNE8Ed-BzquC8wXy7w_-381632140")]
    [DisplayName("Initiator")]
    [IsoXmlTag("Initr")]
    public required BICIdentification1 Initiator { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_jYHvMdE8Ed-BzquC8wXy7w_-872944386")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since AmendmentAcceptanceNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentAcceptanceNotificationV03.

