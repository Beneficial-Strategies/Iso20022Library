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
/// This record is an implementation of the tsmt.024.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ActionReminder message is sent by the matching application to a party involved in a transaction that it is expecting to take an action.
/// This message is used to remind a party of an action that it is expected to take.
/// Usage
/// The ActionReminder message can be sent by the matching application to remind a party that it is waiting for
/// - the submission of a transaction initiation message (BaselineReSubmission message),
/// or
/// - the acceptance or rejection of mis-matched data sets (MisMatchAcceptance or MisMatchRejection message),
/// or
/// - the acceptance or rejection of an amendment request (AmendmentAcceptance or AmendmentRejection message),
/// or
/// - the acceptance or rejection of a status change request (StatusChangeRequestAcceptance or StatusChangeRequestRejection message),
/// or
/// - the acceptance or rejection of a status extension request (StatusExtensionAcceptance or StatusExtensionRejection message).
/// - or
/// - the acceptance or rejection of a request to accept role and baseline (RoleAndBaselineAcceptance or RoleAndBaselineRejection message).
/// </summary>
[Description(@"Scope|The ActionReminder message is sent by the matching application to a party involved in a transaction that it is expecting to take an action.|This message is used to remind a party of an action that it is expected to take.|Usage|The ActionReminder message can be sent by the matching application to remind a party that it is waiting for|- the submission of a transaction initiation message (BaselineReSubmission message),|or|- the acceptance or rejection of mis-matched data sets (MisMatchAcceptance or MisMatchRejection message),|or|- the acceptance or rejection of an amendment request (AmendmentAcceptance or AmendmentRejection message),|or|- the acceptance or rejection of a status change request (StatusChangeRequestAcceptance or StatusChangeRequestRejection message),|or|- the acceptance or rejection of a status extension request (StatusExtensionAcceptance or StatusExtensionRejection message).|- or|- the acceptance or rejection of a request to accept role and baseline (RoleAndBaselineAcceptance or RoleAndBaselineRejection message).")]
[IsoId("_hnA9-NE8Ed-BzquC8wXy7w_-2083336927")]
[DisplayName("Action Reminder V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionReminderV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.024.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ActnRmndr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.024.001.03";
    
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
    /// Constructs a ActionReminderV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActionReminderV03( MessageIdentification1 reqReminderIdentification,SimpleIdentificationInformation reqTransactionIdentification,TransactionStatus4 reqTransactionStatus,MessageIdentification1 reqMessageRequiringAction,PendingActivity2 reqPendingRequestForAction )
    {
        ReminderIdentification = reqReminderIdentification;
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        MessageRequiringAction = reqMessageRequiringAction;
        PendingRequestForAction = reqPendingRequestForAction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the reminder message.
    /// </summary>
    [IsoId("_hnA9-dE8Ed-BzquC8wXy7w_-2083336503")]
    [DisplayName("Reminder Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmndrId")]
    #endif
    [IsoXmlTag("RmndrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 ReminderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 ReminderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 ReminderIdentification { get; init; } 
    #else
    public MessageIdentification1 ReminderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_hnA9-tE8Ed-BzquC8wXy7w_-2083336866")]
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
    [IsoId("_hnA9-9E8Ed-BzquC8wXy7w_-2083336924")]
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
    [IsoId("_hnA9_NE8Ed-BzquC8wXy7w_-2083336556")]
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
    [IsoId("_hnKu8NE8Ed-BzquC8wXy7w_-2083336587")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Identifies the message for which an action is required.
    /// </summary>
    [IsoId("_hnKu8dE8Ed-BzquC8wXy7w_-2083336525")]
    [DisplayName("Message Requiring Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgReqrngActn")]
    #endif
    [IsoXmlTag("MsgReqrngActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageRequiringAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageRequiringAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageRequiringAction { get; init; } 
    #else
    public MessageIdentification1 MessageRequiringAction { get; set; } 
    #endif
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_hnKu8tE8Ed-BzquC8wXy7w_-2083336834")]
    [DisplayName("Pending Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgReqForActn")]
    #endif
    [IsoXmlTag("PdgReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PendingActivity2 PendingRequestForAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PendingActivity2 PendingRequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2 PendingRequestForAction { get; init; } 
    #else
    public PendingActivity2 PendingRequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ActionReminderV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ActionReminderV03.

