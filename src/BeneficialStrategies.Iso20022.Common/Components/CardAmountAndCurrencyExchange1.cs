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
/// Provides details on the detailed or original amount and currency.
/// </summary>
[IsoId("_Y95TJ_wLEeGHDMP28rpT3g_903585548")]
[DisplayName("Card Amount And Currency Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAmountAndCurrencyExchange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardAmountAndCurrencyExchange1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardAmountAndCurrencyExchange1( ActiveCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_Y95TKPwLEeGHDMP28rpT3g_789746482")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_Y95TKfwLEeGHDMP28rpT3g_-207325871")]
    [DisplayName("Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyXchg")]
    #endif
    [IsoXmlTag("CcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange3? CurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange3? CurrencyExchange { get; init; } 
    #else
    public CurrencyExchange3? CurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Identification or qualification of the type of amount.
    /// </summary>
    [IsoId("_Y-DEIPwLEeGHDMP28rpT3g_-1204398224")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount3Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount3Code? Type { get; init; } 
    #else
    public TypeOfAmount3Code? Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
