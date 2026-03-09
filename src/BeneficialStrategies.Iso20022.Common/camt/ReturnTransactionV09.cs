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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.006.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReturnTransaction message is sent by the transaction administrator to a member of the system.
/// It is used to provide information on transactions and booked entries held at the transaction administrator.
/// The Return Transaction message can be sent as a response to a related GetTransaction message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected or settled).
/// Members of a system need to receive information about the payments queue(s) and must have the ability to take action (that is, cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// At any time during operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.
/// These requests will concern either all transactions, all transactions within a particular status or a specific transaction.
/// The member can request information about transactions through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.
/// The transaction administrator may also send a ReturnTransaction message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.
/// The message from the transaction administrator can contain information based on the following elements:
/// - provenance or destination of the payment (payment to/payment from)
/// - transaction reference
/// - transfer value date
/// - payment instruction reference
/// - payment instruction status, as registered at the transaction administrator
/// - instructed amount and/or currency
/// - interbank settlement amount and/or currency
/// - credit/debit indicator of the payment instruction/transaction
/// - message used for the payment instruction
/// - priority of the payment transaction
/// - period in which the payment instruction should be processed (processing validity time)
/// - instructions given, related to the processing of the transaction
/// - type of payment instructed
/// - account identification (entries booked to a specific account)
/// - entry amount and/or currency
/// - entry debit/credit indicator (if absent, all entries should be reported)
/// - status of the entry (pending, booked.)
/// - entry date and time
/// - currency of the account
/// - type of the account
/// - entry reference
/// - entry date
/// - transfer reason
/// - details related to the status of the payment instruction
/// An element that is particular to the Get/Return Transaction pair is the Statement Report. When a GetTransaction message is sent requesting a statement report, the related ReturnTransaction message will provide a pre-defined set of return criteria per transaction. The information returned contains the following details for each transaction:
/// - value date
/// - entry date
/// - debit/credit code
/// - entry amount
/// - method of payment (payment instrument or message type)
/// - entry reference
/// - transaction reference
/// - supplementary details
/// Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The ReturnTransaction message is sent by the transaction administrator to a member of the system.|It is used to provide information on transactions and booked entries held at the transaction administrator.|The Return Transaction message can be sent as a response to a related GetTransaction message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected or settled).|Members of a system need to receive information about the payments queue(s) and must have the ability to take action (that is, cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|At any time during operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.|These requests will concern either all transactions, all transactions within a particular status or a specific transaction.|The member can request information about transactions through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.|The transaction administrator may also send a ReturnTransaction message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.|The message from the transaction administrator can contain information based on the following elements:|- provenance or destination of the payment (payment to/payment from)|- transaction reference|- transfer value date|- payment instruction reference|- payment instruction status, as registered at the transaction administrator|- instructed amount and/or currency|- interbank settlement amount and/or currency|- credit/debit indicator of the payment instruction/transaction|- message used for the payment instruction|- priority of the payment transaction|- period in which the payment instruction should be processed (processing validity time)|- instructions given, related to the processing of the transaction|- type of payment instructed|- account identification (entries booked to a specific account)|- entry amount and/or currency|- entry debit/credit indicator (if absent, all entries should be reported)|- status of the entry (pending, booked.)|- entry date and time|- currency of the account|- type of the account|- entry reference|- entry date|- transfer reason|- details related to the status of the payment instruction|An element that is particular to the Get/Return Transaction pair is the Statement Report. When a GetTransaction message is sent requesting a statement report, the related ReturnTransaction message will provide a pre-defined set of return criteria per transaction. The information returned contains the following details for each transaction:|- value date|- entry date|- debit/credit code|- entry amount|- method of payment (payment instrument or message type)|- entry reference|- transaction reference|- supplementary details|Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
[IsoId("_ThWhy9b6Eeq_l4BJLVUF2Q")]
[DisplayName("Return Transaction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnTransactionV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.006.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrTx";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.006.001.09";
    
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
    /// Constructs a ReturnTransactionV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReturnTransactionV09( MessageHeader8 reqMessageHeader,TransactionReportOrError5Choice_ reqReportOrError )
    {
        MessageHeader = reqMessageHeader;
        ReportOrError = reqReportOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThWh1db6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader8 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader8 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader8 MessageHeader { get; init; } 
    #else
    public MessageHeader8 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Reports on transactions.
    /// </summary>
    [IsoId("_ThWh19b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Report Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptOrErr")]
    #endif
    [IsoXmlTag("RptOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionReportOrError5Choice_ ReportOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionReportOrError5Choice_ ReportOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReportOrError5Choice_ ReportOrError { get; init; } 
    #else
    public TransactionReportOrError5Choice_ ReportOrError { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThWh2db6Eeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ReturnTransactionV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReturnTransactionV09.

