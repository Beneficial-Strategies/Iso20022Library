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
/// This record is an implementation of the semt.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountingStatementOfHoldings message is sent by an account servicer to the account owner or the account owner&apos;s designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message provides, at a specified moment in time, valuations of the portfolio together with details of each financial instrument holding.
/// The information in the message can be audited or un-audited.
/// Usage
/// The AccountingStatementOfHoldings message can be sent:
/// - At a frequency agreed bi-laterally between the Sender and the Receiver
/// - As a response to a request for statement sent by the account owner. The request for statement message will be developed at a later stage.
/// This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at
/// - the main account level, or
/// - the sub-account level.
/// This message can be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// The AccountingStatementOfHoldings message must not be used to reconcile the books of the account owner and the account servicer. The CustodyStatementOfHoldings message is used for reconciliation purposes.
/// The AccountingStatementOfHoldings message must not be used for trading purposes.
/// Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.
/// </summary>
[Description(@"Scope|The AccountingStatementOfHoldings message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.|This message provides, at a specified moment in time, valuations of the portfolio together with details of each financial instrument holding.|The information in the message can be audited or un-audited.|Usage|The AccountingStatementOfHoldings message can be sent:|- At a frequency agreed bi-laterally between the Sender and the Receiver|- As a response to a request for statement sent by the account owner. The request for statement message will be developed at a later stage.|This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at|- the main account level, or|- the sub-account level.|This message can be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.|The AccountingStatementOfHoldings message must not be used to reconcile the books of the account owner and the account servicer. The CustodyStatementOfHoldings message is used for reconciliation purposes.|The AccountingStatementOfHoldings message must not be used for trading purposes.|Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.")]
[IsoId("_MXEzfdFSEd-BzquC8wXy7w_970546686")]
[DisplayName("Accounting Statement Of Holdings")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountingStatementOfHoldings : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.003.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.003.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.01";
    
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
    /// Constructs a AccountingStatementOfHoldings instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountingStatementOfHoldings( Pagination reqMessagePagination,Statement4 reqStatementGeneralDetails,SafekeepingAccount1 reqAccountDetails )
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
    [IsoId("_MXEzftFSEd-BzquC8wXy7w_1496951408")]
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
    [IsoId("_MXOkcNFSEd-BzquC8wXy7w_1583764706")]
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
    [IsoId("_MXOkcdFSEd-BzquC8wXy7w_604083927")]
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
    /// General information related to the accounting statement of holdings.
    /// </summary>
    [IsoId("_MXOkctFSEd-BzquC8wXy7w_2129954320")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement4 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement4 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement4 StatementGeneralDetails { get; init; } 
    #else
    public Statement4 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MXOkc9FSEd-BzquC8wXy7w_1943011592")]
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
    [IsoId("_MXOkdNFSEd-BzquC8wXy7w_-1564192387")]
    [DisplayName("Balance For Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForAcct")]
    #endif
    [IsoXmlTag("BalForAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation2? BalanceForAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation2? BalanceForAccount { get; init; } 
    #else
    public AggregateBalanceInformation2? BalanceForAccount { get; set; } 
    #endif
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_MXOkddFSEd-BzquC8wXy7w_-1553108612")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccountIdentification2? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification2? SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification2? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MXOkdtFSEd-BzquC8wXy7w_-2016983772")]
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
    [IsoId("_MXOkd9FSEd-BzquC8wXy7w_-34086064")]
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


// Since AccountingStatementOfHoldingsDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountingStatementOfHoldings.

