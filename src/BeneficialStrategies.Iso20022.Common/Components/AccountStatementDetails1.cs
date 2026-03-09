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
/// Statement information of an account.
/// </summary>
[IsoId("_RPqrKPGgEeiGNursv3uE_g")]
[DisplayName("Account Statement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountStatementDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountStatementDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountStatementDetails1( System.DateOnly reqTransactionDate )
    {
        TransactionDate = reqTransactionDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the transaction.
    /// </summary>
    [IsoId("_RPqrLPGgEeiGNursv3uE_g")]
    [DisplayName("Transaction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDt")]
    #endif
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TransactionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TransactionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TransactionDate { get; init; } 
    #else
    public System.DateOnly TransactionDate { get; set; } 
    #endif
    
    /// <summary>
    /// True indicates transaction is pending. 
    /// False indicates transaction has already posted.
    /// No default value.
    /// </summary>
    [IsoId("_RPqrLvGgEeiGNursv3uE_g")]
    [DisplayName("Pending Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgInd")]
    #endif
    [IsoXmlTag("PdgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PendingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PendingIndicator { get; init; } 
    #else
    public System.String? PendingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Posting date of the transaction.
    /// </summary>
    [IsoId("_RPqrKvGgEeiGNursv3uE_g")]
    [DisplayName("Transaction Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxPstngDt")]
    #endif
    [IsoXmlTag("TxPstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TransactionPostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TransactionPostingDate { get; init; } 
    #else
    public System.DateOnly? TransactionPostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_RPqrLfGgEeiGNursv3uE_g")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount7? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount7? TransactionAmount { get; init; } 
    #else
    public Amount7? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder billing amount of the transaction.
    /// </summary>
    [IsoId("_IjkLwfGiEeiGNursv3uE_g")]
    [DisplayName("Cardholder Billing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrBllgAmt")]
    #endif
    [IsoXmlTag("CrdhldrBllgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount7? CardholderBillingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount7? CardholderBillingAmount { get; init; } 
    #else
    public Amount7? CardholderBillingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is a credit or debit.
    /// True indicates the transaction is a credit.
    /// False indicates the transaction is a debit.
    /// </summary>
    [IsoId("_RPqrKfGgEeiGNursv3uE_g")]
    [DisplayName("Credit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInd")]
    #endif
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditIndicator { get; init; } 
    #else
    public System.String? CreditIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_RPqrL_GgEeiGNursv3uE_g")]
    [DisplayName("Acceptor Name And Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrNmAndLctn")]
    #endif
    [IsoXmlTag("AccptrNmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? AcceptorNameAndLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcceptorNameAndLocation { get; init; } 
    #else
    public System.String? AcceptorNameAndLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Short transaction description to print or display.
    /// </summary>
    [IsoId("_RPqrK_GgEeiGNursv3uE_g")]
    [DisplayName("Short Transaction Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtTxDesc")]
    #endif
    [IsoXmlTag("ShrtTxDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ShortTransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortTransactionDescription { get; init; } 
    #else
    public System.String? ShortTransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Long transaction description to print or display.
    /// </summary>
    [IsoId("_JGBjIfGjEeiGNursv3uE_g")]
    [DisplayName("Long Transaction Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LngTxDesc")]
    #endif
    [IsoXmlTag("LngTxDesc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? LongTransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LongTransactionDescription { get; init; } 
    #else
    public System.String? LongTransactionDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
