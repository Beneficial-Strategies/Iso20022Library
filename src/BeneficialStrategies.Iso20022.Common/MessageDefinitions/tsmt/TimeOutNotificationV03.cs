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
[Description(@"Scope|The TimeOutNotification message is sent by the matching application to a party involved in a transaction.|This message is used to inform that a transaction will be closed within a given span of time if no action is taken.|Usage|The TimeOutNotification message can be sent by the matching application to inform the parties that a transaction will be closed within a given span of time if no action is taken by either party because|- no activity for the transaction has taken place within a specified span of time,or|- a significant date is reached, for example latest shipment date.")]
[IsoId("_1eFPCNE8Ed-BzquC8wXy7w_1723275077")]
[DisplayName("Time Out Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimeOutNotificationV03 : IOuterRecord
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TimeOutNotificationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TimeOutNotificationV03( MessageIdentification1 reqNotificationIdentification,SimpleIdentificationInformation reqTransactionIdentification,TransactionStatus4 reqTransactionStatus,TimeOutResult2 reqTimeOutDescription )
    {
        NotificationIdentification = reqNotificationIdentification;
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        TimeOutDescription = reqTimeOutDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_1ePAANE8Ed-BzquC8wXy7w_1723275540")]
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
    [IsoId("_1ePAAdE8Ed-BzquC8wXy7w_1723275201")]
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
    [IsoId("_1ePAAtE8Ed-BzquC8wXy7w_1723275262")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3? EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_1ePAA9E8Ed-BzquC8wXy7w_1723275088")]
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
    [IsoId("_1ePABNE8Ed-BzquC8wXy7w_1723275231")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Describes the time-out consequences.
    /// </summary>
    [IsoId("_1ePABdE8Ed-BzquC8wXy7w_1723275139")]
    [DisplayName("Time Out Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmOutDesc")]
    #endif
    [IsoXmlTag("TmOutDesc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TimeOutResult2 TimeOutDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TimeOutResult2 TimeOutDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeOutResult2 TimeOutDescription { get; init; } 
    #else
    public TimeOutResult2 TimeOutDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_1ePABtE8Ed-BzquC8wXy7w_1723275170")]
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


// Since TimeOutNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TimeOutNotificationV03.

