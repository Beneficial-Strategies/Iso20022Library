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
/// This record is an implementation of the semt.022.002.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.
/// 
/// Usage
/// The message may also be used to: 
/// - re-send a message sent by the market infrastructure to the direct participant,
/// - provide a third party with a copy of a message being sent by the market infrastructure for information,
/// - re-send to a third party a copy of a message being sent by the market infrastructure for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.||Usage|The message may also be used to: |- re-send a message sent by the market infrastructure to the direct participant,|- provide a third party with a copy of a message being sent by the market infrastructure for information,|- re-send to a third party a copy of a message being sent by the market infrastructure for information using the relevant elements in the Business Application Header.")]
[IsoId("_ukeLF_fXEeiNZp_PtLohLw")]
[DisplayName("Securities Settlement Transaction Audit Trail Report 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionAuditTrailReport002V04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.022.002.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAudtTrlRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.022.002.04";
    
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
    /// Constructs a SecuritiesSettlementTransactionAuditTrailReport002V04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionAuditTrailReport002V04( Pagination1 reqPagination,SecuritiesAccount37 reqSafekeepingAccount )
    {
        Pagination = reqPagination;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_ukeLGffXEeiNZp_PtLohLw")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination1 Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination1 Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1 Pagination { get; init; } 
    #else
    public Pagination1 Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the SecuritiesStatusQuery message sent to request this report.
    /// </summary>
    [IsoId("_ukeLG_fXEeiNZp_PtLohLw")]
    [DisplayName("Query Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRef")]
    #endif
    [IsoXmlTag("QryRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Identification16? QueryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification16? QueryReference { get; init; } 
    #else
    public Identification16? QueryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_ukeLHffXEeiNZp_PtLohLw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifications34? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications34? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifications34? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ukeLH_fXEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount37 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount37 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount37 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount37 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ukeLIffXEeiNZp_PtLohLw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification156? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification156? AccountOwner { get; init; } 
    #else
    public PartyIdentification156? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    ///  Provides the history of status and reasons for a pending, posted or cancelled transaction.
    /// </summary>
    [IsoId("_ukeLI_fXEeiNZp_PtLohLw")]
    [DisplayName("Status Trail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsTrl")]
    #endif
    [IsoXmlTag("StsTrl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusTrail9? StatusTrail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusTrail9? StatusTrail { get; init; } 
    #else
    public StatusTrail9? StatusTrail { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SecuritiesSettlementTransactionAuditTrailReport002V04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionAuditTrailReport002V04.

