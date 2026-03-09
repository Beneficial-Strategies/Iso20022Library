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
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("__KPDEZZ8EeWuSaWgzo19MQ")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of purchase goods and services without tax.
    /// </summary>
    [IsoId("_MknkkJZ9EeWuSaWgzo19MQ")]
    [DisplayName("Amount Goods And Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtGoodsAndSvcs")]
    #endif
    [IsoXmlTag("AmtGoodsAndSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AmountGoodsAndServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AmountGoodsAndServices { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AmountGoodsAndServices { get; set; } 
    #endif
    
    /// <summary>
    /// Cash-back amount.
    /// </summary>
    [IsoId("__WKmQZZ8EeWuSaWgzo19MQ")]
    [DisplayName("Cash Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshBck")]
    #endif
    [IsoXmlTag("CshBck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CashBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CashBack { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CashBack { get; set; } 
    #endif
    
    /// <summary>
    /// Gratuity amount.
    /// </summary>
    [IsoId("__WKmQ5Z8EeWuSaWgzo19MQ")]
    [DisplayName("Gratuity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grtty")]
    #endif
    [IsoXmlTag("Grtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Gratuity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Gratuity { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Gratuity { get; set; } 
    #endif
    
    /// <summary>
    /// Fees amount.
    /// </summary>
    [IsoId("__WKmRZZ8EeWuSaWgzo19MQ")]
    [DisplayName("Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fees")]
    #endif
    [IsoXmlTag("Fees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? Fees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? Fees { get; init; } 
    #else
    public DetailedAmount4? Fees { get; set; } 
    #endif
    
    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// </summary>
    [IsoId("__WKmR5Z8EeWuSaWgzo19MQ")]
    [DisplayName("Rebate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rbt")]
    #endif
    [IsoXmlTag("Rbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? Rebate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? Rebate { get; init; } 
    #else
    public DetailedAmount4? Rebate { get; set; } 
    #endif
    
    /// <summary>
    /// Value added tax amount.
    /// </summary>
    [IsoId("__WKmSZZ8EeWuSaWgzo19MQ")]
    [DisplayName("Value Added Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTax")]
    #endif
    [IsoXmlTag("ValAddedTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? ValueAddedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? ValueAddedTax { get; init; } 
    #else
    public DetailedAmount4? ValueAddedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Additional charge paid by the cardholder. For example airline credit card surcharge.
    /// </summary>
    [IsoId("__WKmS5Z8EeWuSaWgzo19MQ")]
    [DisplayName("Surcharge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Srchrg")]
    #endif
    [IsoXmlTag("Srchrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? Surcharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? Surcharge { get; init; } 
    #else
    public DetailedAmount4? Surcharge { get; set; } 
    #endif
    
    
    #nullable disable
    
}
