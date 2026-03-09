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
/// Amount of money to be moved between the debtor and creditor, expressed in the currency of the debtor&apos;s account, and the currency in which the amount is to be moved.
/// </summary>
[IsoId("_P57LM9p-Ed-ak6NoX_4Aeg_853564482")]
[DisplayName("Equivalent Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EquivalentAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EquivalentAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EquivalentAmount2( ActiveOrHistoricCurrencyAndAmount reqAmount,string reqCurrencyOfTransfer )
    {
        Amount = reqAmount;
        CurrencyOfTransfer = reqCurrencyOfTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money to be moved between debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be moved in a different currency.|Usage: The first agent will convert the equivalent amount into the amount to be moved.
    /// </summary>
    [IsoId("_P57LNNp-Ed-ak6NoX_4Aeg_853564730")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency of the to be transferred amount, which is different from the currency of the debtor&apos;s account.
    /// </summary>
    [IsoId("_P57LNdp-Ed-ak6NoX_4Aeg_853564760")]
    [DisplayName("Currency Of Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyOfTrf")]
    #endif
    [IsoXmlTag("CcyOfTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode CurrencyOfTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CurrencyOfTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CurrencyOfTransfer { get; init; } 
    #else
    public string CurrencyOfTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
