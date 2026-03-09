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
/// Bank account used by a central counterparty to allow for the convenient settlement of obligations between a central counterparty and a clearing member, typically in commercial bank money.
/// </summary>
[IsoId("_gOkuQBXsEeejf-cbr8l5qw")]
[DisplayName("Payment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentAccount1( string reqCurrency,AmountAndDirection86 reqNetPayment,System.String reqLatePaymentConfirmation )
    {
        Currency = reqCurrency;
        NetPayment = reqNetPayment;
        LatePaymentConfirmation = reqLatePaymentConfirmation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the currency of the account
    /// </summary>
    [IsoId("_ps1YcBXsEeejf-cbr8l5qw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of actual flows to and from clearing members via payment banks in the embedded system in each currency.
    /// </summary>
    [IsoId("_EicI8BXtEeejf-cbr8l5qw")]
    [DisplayName("Net Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPmt")]
    #endif
    [IsoXmlTag("NetPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection86 NetPayment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection86 NetPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection86 NetPayment { get; init; } 
    #else
    public AmountAndDirection86 NetPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Number of payment bank account pay‐ins breaching the allowed time between instruction and confirmation. Usage: nil returns to be included for late payment confirmations in all cleared currencies.
    /// </summary>
    [IsoId("_U8pRkBXtEeejf-cbr8l5qw")]
    [DisplayName("Late Payment Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatePmtConf")]
    #endif
    [IsoXmlTag("LatePmtConf")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10NumericText LatePaymentConfirmation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LatePaymentConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LatePaymentConfirmation { get; init; } 
    #else
    public System.String LatePaymentConfirmation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
