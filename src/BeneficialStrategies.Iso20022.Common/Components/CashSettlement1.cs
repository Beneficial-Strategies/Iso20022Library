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
/// Cash settlement parties and accounts.
/// </summary>
[IsoId("_F6-JkCCpEeWJd9HF2tO7BA")]
[DisplayName("Cash Settlement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashSettlement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Account to credit or debit. When this is an account to debit, this is for the payment of a subscription to an investment fund, a savings plan payment, the purchase of securities or the payment of charges. When this is an account to credit, this is for the payment of an amount as a result of a redemption of investment fund units, the sale of securities, interest and dividend payments. A single account may be specified for all cash movements on the account or cash accounts may be specified for specific types of transactions on the account.
    /// </summary>
    [IsoId("_XPN4kCCpEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctDtls")]
    #endif
    [IsoXmlTag("CshAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount33? CashAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount33? CashAccountDetails { get; init; } 
    #else
    public CashAccount33? CashAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Method of payment other than a cash account.
    /// </summary>
    [IsoId("_aQxlECCpEeWJd9HF2tO7BA")]
    [DisplayName("Other Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCshSttlmDtls")]
    #endif
    [IsoXmlTag("OthrCshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument13? OtherCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument13? OtherCashSettlementDetails { get; init; } 
    #else
    public PaymentInstrument13? OtherCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
