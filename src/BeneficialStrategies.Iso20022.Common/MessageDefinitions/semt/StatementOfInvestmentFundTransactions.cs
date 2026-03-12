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



namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatementOfInvestmentFundTransactions is sent by an account servicer to the account owner or the account owner&apos;s designated agent. The account servicer may be a fund administrator or fund intermediary, trustee or registrar.
/// This message provides the details of increases and decreases of holdings which occurred during a specified period.
/// This message can also be used for information purposes, eg, tax information.
/// Usage
/// The StatementOfInvestmentFundTransactions message can be sent:
/// - At a frequency agreed bi-laterally between the Sender and the Receiver and/or
/// - As a response to a request for statement sent by the account owner.
/// The StatementOfInvestmentFundTransactions message can only be used to list the transactions of a single (master) account. However, it is possible to break down these transactions into one or several sub-accounts. Therefore, the message can be used to either specify transactions at
/// - the main account level, or
/// - the sub-account level.
/// This message must not be used in place of confirmation messages.
/// Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.
/// </summary>
[Description(@"Scope|The StatementOfInvestmentFundTransactions is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a fund administrator or fund intermediary, trustee or registrar.|This message provides the details of increases and decreases of holdings which occurred during a specified period.|This message can also be used for information purposes, eg, tax information.|Usage|The StatementOfInvestmentFundTransactions message can be sent:|- At a frequency agreed bi-laterally between the Sender and the Receiver and/or|- As a response to a request for statement sent by the account owner.|The StatementOfInvestmentFundTransactions message can only be used to list the transactions of a single (master) account. However, it is possible to break down these transactions into one or several sub-accounts. Therefore, the message can be used to either specify transactions at|- the main account level, or|- the sub-account level.|This message must not be used in place of confirmation messages.|Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.")]
[IsoId("_MXrQa9FSEd-BzquC8wXy7w_1518243761")]
[DisplayName("Statement Of Investment Fund Transactions")]
public partial record StatementOfInvestmentFundTransactions : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.006.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.006.001.01";
    
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
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MXrQbNFSEd-BzquC8wXy7w_1597856875")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MXrQbdFSEd-BzquC8wXy7w_1600624521")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MX0aUNFSEd-BzquC8wXy7w_1926109415")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// General information related to the investment fund statement of transactions.
    /// </summary>
    [IsoId("_MX0aUdFSEd-BzquC8wXy7w_-406122479")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement5 StatementGeneralDetails { get; init; } 
    
    /// <summary>
    /// Information related to an investment account.
    /// </summary>
    [IsoId("_MX0aUtFSEd-BzquC8wXy7w_-1794049021")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount12 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_MX0aU9FSEd-BzquC8wXy7w_-591358864")]
    [DisplayName("Transaction On Account")]
    [IsoXmlTag("TxOnAcct")]
    public InvestmentFundTransactionsByFund1? TransactionOnAccount { get; init; } 
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_MX0aVNFSEd-BzquC8wXy7w_-645201789")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification4? SubAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MX0aVdFSEd-BzquC8wXy7w_364441815")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since StatementOfInvestmentFundTransactionsDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatementOfInvestmentFundTransactions.

