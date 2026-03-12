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
/// This record is an implementation of the semt.021.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesStatementQuery to an account servicer to request any existing securities statement.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository or another settlement market infrastructure.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|An account owner sends a SecuritiesStatementQuery to an account servicer to request any existing securities statement.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository or another settlement market infrastructure.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_MhD14tFSEd-BzquC8wXy7w_1554511240")]
[DisplayName("Securities Statement Query V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesStatementQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.021.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesStmtQry";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.021.001.01";
    
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
    /// Constructs a SecuritiesStatementQueryV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesStatementQueryV01( DocumentIdentification11 reqIdentification,DocumentNumber1 reqStatementRequested,SecuritiesAccount13 reqSafekeepingAccount )
    {
        Identification = reqIdentification;
        StatementRequested = reqStatementRequested;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies a SecuritiesStatementQuery message as know by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_MhD149FSEd-BzquC8wXy7w_217543485")]
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
    /// Description of the statement requested.
    /// </summary>
    [IsoId("_MhD15NFSEd-BzquC8wXy7w_-1060547405")]
    [DisplayName("Statement Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtReqd")]
    #endif
    [IsoXmlTag("StmtReqd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentNumber1 StatementRequested { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentNumber1 StatementRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber1 StatementRequested { get; init; } 
    #else
    public DocumentNumber1 StatementRequested { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to report.
    /// </summary>
    [IsoId("_MhD15dFSEd-BzquC8wXy7w_833531263")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Statement16? StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement16? StatementGeneralDetails { get; init; } 
    #else
    public Statement16? StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_MhD15tFSEd-BzquC8wXy7w_1479071344")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification13Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification13Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification13Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_MhD159FSEd-BzquC8wXy7w_1516933925")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount13 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional specific query criteria.
    /// </summary>
    [IsoId("_MhD16NFSEd-BzquC8wXy7w_-249593211")]
    [DisplayName("Additional Query Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQryParams")]
    #endif
    [IsoXmlTag("AddtlQryParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalQueryParameters1? AdditionalQueryParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalQueryParameters1? AdditionalQueryParameters { get; init; } 
    #else
    public AdditionalQueryParameters1? AdditionalQueryParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_MhNm4NFSEd-BzquC8wXy7w_1773533674")]
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
    [IsoId("_MhNm4dFSEd-BzquC8wXy7w_1767067089")]
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
    [IsoId("_MhNm4tFSEd-BzquC8wXy7w_-1947152215")]
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


// Since SecuritiesStatementQueryV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesStatementQueryV01.

