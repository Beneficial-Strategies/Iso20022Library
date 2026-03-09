// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a statement of investment fund transactions.
/// </summary>
[IsoId("_U2krYNp-Ed-ak6NoX_4Aeg_1424253677")]
[DisplayName("Statement Of Investment Fund Transactions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementOfInvestmentFundTransactions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatementOfInvestmentFundTransactions1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementOfInvestmentFundTransactions1( Pagination reqMessagePagination,SubAccountIdentification4 reqSubAccountDetails )
    {
        MessagePagination = reqMessagePagination;
        SubAccountDetails = reqSubAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_U2krYdp-Ed-ak6NoX_4Aeg_366794221")]
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
    /// General information related to the investment fund statement of transactions that is being cancelled.
    /// </summary>
    [IsoId("_U2krYtp-Ed-ak6NoX_4Aeg_1826589543")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Statement5? StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement5? StatementGeneralDetails { get; init; } 
    #else
    public Statement5? StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_U2krY9p-Ed-ak6NoX_4Aeg_2103646761")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount12? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount12? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount12? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_U2krZNp-Ed-ak6NoX_4Aeg_-2082346451")]
    [DisplayName("Transaction On Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOnAcct")]
    #endif
    [IsoXmlTag("TxOnAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundTransactionsByFund1? TransactionOnAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionsByFund1? TransactionOnAccount { get; init; } 
    #else
    public InvestmentFundTransactionsByFund1? TransactionOnAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_U2krZdp-Ed-ak6NoX_4Aeg_-1749876008")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubAccountIdentification4 SubAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubAccountIdentification4 SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification4 SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification4 SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U2krZtp-Ed-ak6NoX_4Aeg_730156025")]
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
