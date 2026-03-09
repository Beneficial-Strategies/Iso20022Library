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
/// This record is an implementation of the semt.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent sends the StatementOfInvestmentFundTransactions message to the account owner, for example, an investment manager or its authorised representative to provide detailed transactions (increases and decreases) of holdings which occurred during a specified period of time.
/// Usage
/// The StatementOfInvestmentFundTransactions message is used to list the holdings transactions of a single (master) account or several sub-accounts.
/// This message should be used at a frequency agreed bi-laterally between the account servicer and the account owner.
/// This message must not be used in place of confirmation messages.
/// </summary>
[Description(@"Scope|An account servicer, for example, a transfer agent sends the StatementOfInvestmentFundTransactions message to the account owner, for example, an investment manager or its authorised representative to provide detailed transactions (increases and decreases) of holdings which occurred during a specified period of time.|Usage|The StatementOfInvestmentFundTransactions message is used to list the holdings transactions of a single (master) account or several sub-accounts.|This message should be used at a frequency agreed bi-laterally between the account servicer and the account owner.|This message must not be used in place of confirmation messages.")]
[IsoId("_MccbotFSEd-BzquC8wXy7w_1866614208")]
[DisplayName("Statement Of Investment Fund Transactions V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementOfInvestmentFundTransactionsV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StmtOfInvstmtFndTxsV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.006.001.02";
    
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
    /// Constructs a StatementOfInvestmentFundTransactionsV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementOfInvestmentFundTransactionsV02( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination,Statement8 reqStatementGeneralDetails,InvestmentAccount25 reqInvestmentAccountDetails )
    {
        MessageIdentification = reqMessageIdentification;
        MessagePagination = reqMessagePagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Mccbo9FSEd-BzquC8wXy7w_-1980444025")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MccbpNFSEd-BzquC8wXy7w_1866614228")]
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
    [IsoId("_MccbpdFSEd-BzquC8wXy7w_1866614269")]
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
    [IsoId("_MccbptFSEd-BzquC8wXy7w_1866614630")]
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
    /// General information related to the investment fund statement of transactions.
    /// </summary>
    [IsoId("_Mccbp9FSEd-BzquC8wXy7w_1866614287")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement8 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement8 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement8 StatementGeneralDetails { get; init; } 
    #else
    public Statement8 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an investment account.
    /// </summary>
    [IsoId("_MccbqNFSEd-BzquC8wXy7w_1866614322")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount25 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount25 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount25 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount25 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_McllkNFSEd-BzquC8wXy7w_1866614707")]
    [DisplayName("Transaction On Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOnAcct")]
    #endif
    [IsoXmlTag("TxOnAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundTransactionsByFund2? TransactionOnAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionsByFund2? TransactionOnAccount { get; init; } 
    #else
    public InvestmentFundTransactionsByFund2? TransactionOnAccount { get; set; } 
    #endif
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_McllkdFSEd-BzquC8wXy7w_1866614364")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccountIdentification6? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification6? SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification6? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_McllktFSEd-BzquC8wXy7w_1866614672")]
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


// Since StatementOfInvestmentFundTransactionsV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatementOfInvestmentFundTransactionsV02.

