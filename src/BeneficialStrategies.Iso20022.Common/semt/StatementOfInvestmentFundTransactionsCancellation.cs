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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatementOfInvestmentFundTransactionsCancellation message is sent by an account servicer to the account owner or the account owner&apos;s designated agent. The account servicer may be a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message is used to cancel a previously sent StatementOfInvestmentFundTransactions message.
/// Usage
/// The StatementOfInvestmentFundTransactionsCancellation message is sent by an account servicer to the account owner to cancel a previously sent StatementOfInvestmentFundTransactions message.
/// This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(@"Scope|The StatementOfInvestmentFundTransactionsCancellation message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a fund administrator or fund intermediary, trustee or registrar, etc.|This message is used to cancel a previously sent StatementOfInvestmentFundTransactions message.|Usage|The StatementOfInvestmentFundTransactionsCancellation message is sent by an account servicer to the account owner to cancel a previously sent StatementOfInvestmentFundTransactions message.|This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.")]
[IsoId("_MX-LWNFSEd-BzquC8wXy7w_953864526")]
[DisplayName("Statement Of Investment Fund Transactions Cancellation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementOfInvestmentFundTransactionsCancellation : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.007.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.007.001.01";
    
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
    /// Constructs a StatementOfInvestmentFundTransactionsCancellation instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementOfInvestmentFundTransactionsCancellation( AdditionalReference2 reqPreviousReference,Pagination reqMessagePagination )
    {
        PreviousReference = reqPreviousReference;
        MessagePagination = reqMessagePagination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MX-LWdFSEd-BzquC8wXy7w_1237385407")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference2 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 PreviousReference { get; init; } 
    #else
    public AdditionalReference2 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MX-LWtFSEd-BzquC8wXy7w_1242003243")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? RelatedReference { get; init; } 
    #else
    public AdditionalReference2? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MX-LW9FSEd-BzquC8wXy7w_1077848759")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination MessagePagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination MessagePagination { get; init; } 
    #else
    public Pagination MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// The Statement of Investment Fund Transactions message to cancel.
    /// </summary>
    [IsoId("_MX-LXNFSEd-BzquC8wXy7w_1536922196")]
    [DisplayName("Statement To Be Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtToBeCanc")]
    #endif
    [IsoXmlTag("StmtToBeCanc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementOfInvestmentFundTransactions1? StatementToBeCancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementOfInvestmentFundTransactions1? StatementToBeCancelled { get; init; } 
    #else
    public StatementOfInvestmentFundTransactions1? StatementToBeCancelled { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since StatementOfInvestmentFundTransactionsCancellationDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatementOfInvestmentFundTransactionsCancellation.

