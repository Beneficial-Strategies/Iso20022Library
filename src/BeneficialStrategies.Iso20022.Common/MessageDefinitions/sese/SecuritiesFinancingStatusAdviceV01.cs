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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.034.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.
/// The status advice may be sent as a response to the request of the account owner or not.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants
/// - an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or
/// - a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or|- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_wEI2ONE5Ed-BzquC8wXy7w_973932339")]
[DisplayName("Securities Financing Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.034.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.034.001.01";
    
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
    /// Constructs a SecuritiesFinancingStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesFinancingStatusAdviceV01( DocumentIdentification11 reqIdentification,TransactionIdentifications1 reqTransactionIdentification )
    {
        Identification = reqIdentification;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies a SecuritiesFinancingStatusAdvice message as known by the account servicer.
    /// </summary>
    [IsoId("_wEI2OdE5Ed-BzquC8wXy7w_166394532")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification11 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification11 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification11 Identification { get; init; } 
    #else
    public DocumentIdentification11 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_wESAINE5Ed-BzquC8wXy7w_913523423")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifications1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifications1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifications1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Processing status of the transaction.
    /// </summary>
    [IsoId("_wESAIdE5Ed-BzquC8wXy7w_-197879501")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus3Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus3Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus3Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_wESAItE5Ed-BzquC8wXy7w_1433122152")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus3Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus3Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus3Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_wESAI9E5Ed-BzquC8wXy7w_1465444894")]
    [DisplayName("Inferred Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IfrrdMtchgSts")]
    #endif
    [IsoXmlTag("IfrrdMtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus3Choice_? InferredMatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus3Choice_? InferredMatchingStatus { get; init; } 
    #else
    public MatchingStatus3Choice_? InferredMatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_wESAJNE5Ed-BzquC8wXy7w_-299402165")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementStatus2Choice_? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus2Choice_? SettlementStatus { get; init; } 
    #else
    public SettlementStatus2Choice_? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_wESAJdE5Ed-BzquC8wXy7w_-315101621")]
    [DisplayName("Repo Call Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RepoCallReqSts")]
    #endif
    [IsoXmlTag("RepoCallReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoCallRequestStatus2Choice_? RepoCallRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoCallRequestStatus2Choice_? RepoCallRequestStatus { get; init; } 
    #else
    public RepoCallRequestStatus2Choice_? RepoCallRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_wESAJtE5Ed-BzquC8wXy7w_-73888920")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesFinancingTransactionDetails2? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesFinancingTransactionDetails2? TransactionDetails { get; init; } 
    #else
    public SecuritiesFinancingTransactionDetails2? TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_wEbxINE5Ed-BzquC8wXy7w_-319050464")]
    [DisplayName("Message Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgOrgtr")]
    #endif
    [IsoXmlTag("MsgOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? MessageOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? MessageOriginator { get; init; } 
    #else
    public PartyIdentification10Choice_? MessageOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_wEbxIdE5Ed-BzquC8wXy7w_-221156252")]
    [DisplayName("Message Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRcpt")]
    #endif
    [IsoXmlTag("MsgRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? MessageRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? MessageRecipient { get; init; } 
    #else
    public PartyIdentification10Choice_? MessageRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wEbxItE5Ed-BzquC8wXy7w_-351374884")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension2? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension2? Extension { get; init; } 
    #else
    public Extension2? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SecuritiesFinancingStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingStatusAdviceV01.

