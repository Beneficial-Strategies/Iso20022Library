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
    
    #nullable enable
    
    /// <summary>
    /// Identifies the reminder message.
    /// </summary>
    [IsoId("_hnA9-dE8Ed-BzquC8wXy7w_-2083336503")]
    [DisplayName("Reminder Identification")]
    [IsoXmlTag("RmndrId")]
    public required MessageIdentification1 ReminderIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_hnA9-tE8Ed-BzquC8wXy7w_-2083336866")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_hnA9-9E8Ed-BzquC8wXy7w_-2083336924")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_hnA9_NE8Ed-BzquC8wXy7w_-2083336556")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_hnKu8NE8Ed-BzquC8wXy7w_-2083336587")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];
    
    /// <summary>
    /// Identifies the message for which an action is required.
    /// </summary>
    [IsoId("_hnKu8dE8Ed-BzquC8wXy7w_-2083336525")]
    [DisplayName("Message Requiring Action")]
    [IsoXmlTag("MsgReqrngActn")]
    public required MessageIdentification1 MessageRequiringAction { get; init; } 
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_hnKu8tE8Ed-BzquC8wXy7w_-2083336834")]
    [DisplayName("Pending Request For Action")]
    [IsoXmlTag("PdgReqForActn")]
    public required PendingActivity2 PendingRequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since ActionReminderV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ActionReminderV03.

