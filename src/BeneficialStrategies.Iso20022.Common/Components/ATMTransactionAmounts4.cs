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
/// Withdrawal limits for the account.
/// </summary>
[IsoId("_umPyoYq6EeSHjtO_wHA7PQ")]
[DisplayName("ATM Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransactionAmounts4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// True if limits may be displayed on the ATM to the customer.
    /// </summary>
    [IsoId("__XeUIIq6EeSHjtO_wHA7PQ")]
    [DisplayName("Display Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispFlg")]
    #endif
    [IsoXmlTag("DispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DisplayFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisplayFlag { get; init; } 
    #else
    public System.String? DisplayFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Amount available for withdrawal on the account.
    /// </summary>
    [IsoId("_uzXBl4q6EeSHjtO_wHA7PQ")]
    [DisplayName("Available Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblAmt")]
    #endif
    [IsoXmlTag("AvlblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AvailableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AvailableAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AvailableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining daily amount of the customer totals for withdrawals on the account.
    /// </summary>
    [IsoId("_uzXBmYq6EeSHjtO_wHA7PQ")]
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
    /// Remaining weekly amount of the customer totals for withdrawals on the account.
    /// </summary>
    [IsoId("_uzXBm4q6EeSHjtO_wHA7PQ")]
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
    /// Remaining monthly amount of the customer totals for withdrawals on the account.
    /// </summary>
    [IsoId("_uzXBnYq6EeSHjtO_wHA7PQ")]
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
