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
/// This record is an implementation of the camt.005.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetTransaction message is sent by a member to the transaction administrator.
/// It is used to request information about payment instructions held at the transaction administrator. Payment instructions are either sent by the member, debiting or crediting its account at the transaction administrator or received by the transaction administrator, crediting or debiting the member&apos;s account.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).
/// Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.
/// These requests will concern either all transactions, all transactions with a particular status or a specific transaction.
/// The member can request information about transactions through a series of criteria, corresponding to the known information stored at the transaction administrator, based on the following elements:
/// - provenance or destination of the payment (payment to/payment from)
/// - transaction reference
/// - transfer value date
/// - payment instruction reference
/// - payment instruction status, as registered at the transaction administrator
/// - instructed amount and/or currency
/// - interbank settlement amount and/or currency
/// - credit/debit indicator of the payment instruction/transaction
/// - SWIFT FIN payment message used for the payment instruction
/// - priority of the payment transaction
/// - period in which the payment instruction should be processed (processing validity time)
/// - instructions given, related to the processing of the transaction
/// - type of payment instructed
/// - account identification (entries booked to a specific account)
/// - entry amount and/or currency
/// - entry debit/credit indicator (if absent, all entries should be reported).
/// </summary>
[Description(@"Scope|The GetTransaction message is sent by a member to the transaction administrator.|It is used to request information about payment instructions held at the transaction administrator. Payment instructions are either sent by the member, debiting or crediting its account at the transaction administrator or received by the transaction administrator, crediting or debiting the member's account.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).|Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.|These requests will concern either all transactions, all transactions with a particular status or a specific transaction.|The member can request information about transactions through a series of criteria, corresponding to the known information stored at the transaction administrator, based on the following elements:|- provenance or destination of the payment (payment to/payment from)|- transaction reference|- transfer value date|- payment instruction reference|- payment instruction status, as registered at the transaction administrator|- instructed amount and/or currency|- interbank settlement amount and/or currency|- credit/debit indicator of the payment instruction/transaction|- SWIFT FIN payment message used for the payment instruction|- priority of the payment transaction|- period in which the payment instruction should be processed (processing validity time)|- instructions given, related to the processing of the transaction|- type of payment instructed|- account identification (entries booked to a specific account)|- entry amount and/or currency|- entry debit/credit indicator (if absent, all entries should be reported).")]
[IsoId("_jx3fgQKxEe2rHs6fbn9-0A")]
[DisplayName("Get Transaction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GetTransactionV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.005.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetTx";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.005.001.10";
    
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
    /// Constructs a GetTransactionV10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GetTransactionV10( MessageHeader9 reqMessageHeader )
    {
        MessageHeader = reqMessageHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jx4GlwKxEe2rHs6fbn9-0A")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader9 MessageHeader { get; init; } 
    #else
    public MessageHeader9 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the transaction query criteria.
    /// </summary>
    [IsoId("_jx4GmQKxEe2rHs6fbn9-0A")]
    [DisplayName("Transaction Query Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxQryDef")]
    #endif
    [IsoXmlTag("TxQryDef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionQuery7? TransactionQueryDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionQuery7? TransactionQueryDefinition { get; init; } 
    #else
    public TransactionQuery7? TransactionQueryDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jx4GmwKxEe2rHs6fbn9-0A")]
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


// Since GetTransactionV10Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetTransactionV10.

