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
[IsoId("_OR7VUIp7EeS3NqNpgnMh2w")]
[DisplayName("ATM Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransactionAmounts2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the limits, if different from the requested amount.
    /// </summary>
    [IsoId("_dck6kIp7EeS3NqNpgnMh2w")]
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
    /// Maximum amount allowed in the authorised currency if the withdrawal was not approved.
    /// </summary>
    [IsoId("_h2EDUIp7EeS3NqNpgnMh2w")]
    [DisplayName("Maximum Authorisable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAuthsbAmt")]
    #endif
    [IsoXmlTag("MaxAuthsbAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumAuthorisableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumAuthorisableAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumAuthorisableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount allowed for a withdrawal in the authorised currency.
    /// </summary>
    [IsoId("_lZwMgIp7EeS3NqNpgnMh2w")]
    [DisplayName("Minimum Allowed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinAllwdAmt")]
    #endif
    [IsoXmlTag("MinAllwdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MinimumAllowedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MinimumAllowedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MinimumAllowedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount allowed for a withdrawal in the authorised currency.
    /// </summary>
    [IsoId("_oWjU0Ip7EeS3NqNpgnMh2w")]
    [DisplayName("Maximum Allowed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAllwdAmt")]
    #endif
    [IsoXmlTag("MaxAllwdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumAllowedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumAllowedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumAllowedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining daily amount of the customer totals after the withdrawal.
    /// </summary>
    [IsoId("_q-fncIp7EeS3NqNpgnMh2w")]
    [DisplayName("Daily Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DalyBal")]
    #endif
    [IsoXmlTag("DalyBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? DailyBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? DailyBalance { get; init; } 
    #else
    public DetailedAmount4? DailyBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining weekly amount of the customer totals after the withdrawal.
    /// </summary>
    [IsoId("_tYRiQIp7EeS3NqNpgnMh2w")]
    [DisplayName("Weekly Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WklyBal")]
    #endif
    [IsoXmlTag("WklyBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? WeeklyBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? WeeklyBalance { get; init; } 
    #else
    public DetailedAmount4? WeeklyBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining monthly amount of the customer totals after the withdrawal.
    /// </summary>
    [IsoId("_vXmVsIp7EeS3NqNpgnMh2w")]
    [DisplayName("Monthly Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyBal")]
    #endif
    [IsoXmlTag("MnthlyBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? MonthlyBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? MonthlyBalance { get; init; } 
    #else
    public DetailedAmount4? MonthlyBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
