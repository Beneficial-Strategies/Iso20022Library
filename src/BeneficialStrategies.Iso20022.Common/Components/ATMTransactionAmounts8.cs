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
/// Limit of amounts for the customer.
/// </summary>
[IsoId("_ucGeUa-VEeWJvLRJ8PsD_w")]
[DisplayName("ATM Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransactionAmounts8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Default currency of the limits.
    /// </summary>
    [IsoId("_uoeGYa-VEeWJvLRJ8PsD_w")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount allowed for a transaction in the service.
    /// </summary>
    [IsoId("_uoeGY6-VEeWJvLRJ8PsD_w")]
    [DisplayName("Maximum Possible Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxPssblAmt")]
    #endif
    [IsoXmlTag("MaxPssblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumPossibleAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumPossibleAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumPossibleAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount allowed for a transaction in the service.
    /// </summary>
    [IsoId("_uoeGZa-VEeWJvLRJ8PsD_w")]
    [DisplayName("Minimum Possible Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinPssblAmt")]
    #endif
    [IsoXmlTag("MinPssblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MinimumPossibleAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MinimumPossibleAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MinimumPossibleAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount that may be displayed to the customer, for instance the daily limit or the daily balance for the service.
    /// </summary>
    [IsoId("_uoeGZ6-VEeWJvLRJ8PsD_w")]
    [DisplayName("Additional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmt")]
    #endif
    [IsoXmlTag("AddtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts7? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts7? AdditionalAmount { get; init; } 
    #else
    public ATMTransactionAmounts7? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Limit of deposited media for the customer.
    /// </summary>
    [IsoId("_3g-YIK-VEeWJvLRJ8PsD_w")]
    [DisplayName("Deposit Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstLmts")]
    #endif
    [IsoXmlTag("DpstLmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts9? DepositLimits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts9? DepositLimits { get; init; } 
    #else
    public ATMTransactionAmounts9? DepositLimits { get; set; } 
    #endif
    
    
    #nullable disable
    
}
