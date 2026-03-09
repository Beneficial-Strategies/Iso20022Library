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
/// Amount of money to be transferred between the debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be transferred into a different currency.
/// </summary>
[IsoId("_PrBzkNp-Ed-ak6NoX_4Aeg_-2010101113")]
[DisplayName("Equivalent Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EquivalentAmount
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EquivalentAmount instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EquivalentAmount( CurrencyAndAmount reqAmount,string reqCurrencyOfTransfer )
    {
        Amount = reqAmount;
        CurrencyOfTransfer = reqCurrencyOfTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money to be transferred between debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be transferred in a different currency. ||Usage: Currency of the amount is expressed in the currency of the debtor&apos;s account, but the amount to be transferred is in another currency. The first agent will convert the amount and currency to the to be transferred amount and currency, eg, &apos;pay equivalent of 100000 EUR in JPY&apos;(and account is in EUR).
    /// </summary>
    [IsoId("_PrBzkdp-Ed-ak6NoX_4Aeg_-1963000912")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency of the to be transferred amount, which is different from the currency of the debtor&apos;s account.
    /// </summary>
    [IsoId("_PrBzktp-Ed-ak6NoX_4Aeg_1183764992")]
    [DisplayName("Currency Of Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyOfTrf")]
    #endif
    [IsoXmlTag("CcyOfTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode CurrencyOfTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CurrencyOfTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CurrencyOfTransfer { get; init; } 
    #else
    public string CurrencyOfTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
