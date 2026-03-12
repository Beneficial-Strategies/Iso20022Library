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
/// This record is an implementation of the semt.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustodyStatementOfHoldings message is sent by an account servicer to the account owner or the account owner&apos;s designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message reports, at a specified moment in time, the quantity and identification of financial instruments that an account servicer holds for the account owner.
/// This message is used to reconcile the books of the account owner and the account servicer for the specified account or sub-account.
/// This message can also report availability and/or the location of security holdings to facilitate trading and minimise settlement issues. The reporting is per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holding for all locations can be provided.
/// Usage
/// The CustodyStatementOfHoldings message can be sent:
/// - At a frequency agreed bi-laterally between the Sender and the Receiver
/// - As a response to a request for statement sent by the account owner.
/// This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.
/// The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at
/// - the main account level, or
/// - the sub-account level.
/// This message can be also be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// This message must not be used to report audited positions. Audited positions are reported using the AccountingStatementOfHoldings message.
/// Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.
/// </summary>
[Description(@"Scope|The CustodyStatementOfHoldings message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.|This message reports, at a specified moment in time, the quantity and identification of financial instruments that an account servicer holds for the account owner.|This message is used to reconcile the books of the account owner and the account servicer for the specified account or sub-account.|This message can also report availability and/or the location of security holdings to facilitate trading and minimise settlement issues. The reporting is per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holding for all locations can be provided.|Usage|The CustodyStatementOfHoldings message can be sent:|- At a frequency agreed bi-laterally between the Sender and the Receiver|- As a response to a request for statement sent by the account owner.|This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.|The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at|- the main account level, or|- the sub-account level.|This message can be also be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.|This message must not be used to report audited positions. Audited positions are reported using the AccountingStatementOfHoldings message.|Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.")]
[IsoId("_MWx4gNFSEd-BzquC8wXy7w_650597621")]
[DisplayName("Custody Statement Of Holdings")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustodyStatementOfHoldings : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.002.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.01";
    
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
    /// Constructs a CustodyStatementOfHoldings instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustodyStatementOfHoldings( Pagination reqMessagePagination,Statement3 reqStatementGeneralDetails,SafekeepingAccount1 reqAccountDetails )
    {
        MessagePagination = reqMessagePagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MW7pgNFSEd-BzquC8wXy7w_1818905401")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PreviousReference { get; init; } 
    #else
    public AdditionalReference2? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MW7pgdFSEd-BzquC8wXy7w_1810591867")]
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
    [IsoId("_MW7pgtFSEd-BzquC8wXy7w_-1884866352")]
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
    /// General information related to the custody statement of holdings.
    /// </summary>
    [IsoId("_MW7pg9FSEd-BzquC8wXy7w_500773271")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement3 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement3 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement3 StatementGeneralDetails { get; init; } 
    #else
    public Statement3 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MW7phNFSEd-BzquC8wXy7w_-1316963479")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccount1 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccount1 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount1 AccountDetails { get; init; } 
    #else
    public SafekeepingAccount1 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_MW7phdFSEd-BzquC8wXy7w_-2003208951")]
    [DisplayName("Balance For Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForAcct")]
    #endif
    [IsoXmlTag("BalForAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation1? BalanceForAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation1? BalanceForAccount { get; init; } 
    #else
    public AggregateBalanceInformation1? BalanceForAccount { get; set; } 
    #endif
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_MW7phtFSEd-BzquC8wXy7w_1776832052")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccountIdentification1? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification1? SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification1? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MW7ph9FSEd-BzquC8wXy7w_1111399368")]
    [DisplayName("Total Values")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVals")]
    #endif
    [IsoXmlTag("TtlVals")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    #else
    public TotalValueInPageAndStatement? TotalValues { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MXEzcNFSEd-BzquC8wXy7w_-143061138")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CustodyStatementOfHoldingsDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustodyStatementOfHoldings.

