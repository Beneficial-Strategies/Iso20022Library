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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmendmentAcceptanceNotificationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmendmentAcceptanceNotificationV03( MessageIdentification1 reqNotificationIdentification,SimpleIdentificationInformation reqTransactionIdentification,DocumentIdentification3 reqEstablishedBaselineIdentification,TransactionStatus4 reqTransactionStatus,MessageIdentification1 reqDeltaReportReference,Count1 reqAcceptedAmendmentNumber,BICIdentification1 reqInitiator )
    {
        NotificationIdentification = reqNotificationIdentification;
        TransactionIdentification = reqTransactionIdentification;
        EstablishedBaselineIdentification = reqEstablishedBaselineIdentification;
        TransactionStatus = reqTransactionStatus;
        DeltaReportReference = reqDeltaReportReference;
        AcceptedAmendmentNumber = reqAcceptedAmendmentNumber;
        Initiator = reqInitiator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_jX9-MdE8Ed-BzquC8wXy7w_-872944488")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 NotificationIdentification { get; init; } 
    #else
    public MessageIdentification1 NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_jX9-MtE8Ed-BzquC8wXy7w_-872943498")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_jX9-M9E8Ed-BzquC8wXy7w_-872943919")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3 EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_jX9-NNE8Ed-BzquC8wXy7w_-872944308")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 TransactionStatus { get; init; } 
    #else
    public TransactionStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_jX9-NdE8Ed-BzquC8wXy7w_-872943841")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Reference to the identification of the delta report that contained the amendment.
    /// </summary>
    [IsoId("_jX9-NtE8Ed-BzquC8wXy7w_-872944806")]
    [DisplayName("Delta Report Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DltaRptRef")]
    #endif
    [IsoXmlTag("DltaRptRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 DeltaReportReference { get; init; } 
    #else
    public MessageIdentification1 DeltaReportReference { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence number of the accepted baseline amendment.
    /// </summary>
    [IsoId("_jX9-N9E8Ed-BzquC8wXy7w_-872944231")]
    [DisplayName("Accepted Amendment Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdAmdmntNb")]
    #endif
    [IsoXmlTag("AccptdAmdmntNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Count1 AcceptedAmendmentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Count1 AcceptedAmendmentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Count1 AcceptedAmendmentNumber { get; init; } 
    #else
    public Count1 AcceptedAmendmentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Party that has accepted the amendment.
    /// </summary>
    [IsoId("_jYHvMNE8Ed-BzquC8wXy7w_-381632140")]
    [DisplayName("Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Initr")]
    #endif
    [IsoXmlTag("Initr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 Initiator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 Initiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 Initiator { get; init; } 
    #else
    public BICIdentification1 Initiator { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_jYHvMdE8Ed-BzquC8wXy7w_-872944386")]
    [DisplayName("Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForActn")]
    #endif
    [IsoXmlTag("ReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? RequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? RequestForAction { get; init; } 
    #else
    public PendingActivity2? RequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AmendmentAcceptanceNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentAcceptanceNotificationV03.

