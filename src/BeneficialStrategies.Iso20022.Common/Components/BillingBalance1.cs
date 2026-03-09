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
/// Provides the balance for the billing services.
/// </summary>
[IsoId("_6SL4XZqlEeGSON8vddiWzQ_313331951")]
[DisplayName("Billing Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingBalance1( BillingBalanceType1Choice_ reqType,AmountAndDirection34 reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the type of balance.
    /// </summary>
    [IsoId("_6SL4XpqlEeGSON8vddiWzQ_1633836895")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingBalanceType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingBalanceType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingBalanceType1Choice_ Type { get; init; } 
    #else
    public BillingBalanceType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Balance value.
    /// </summary>
    [IsoId("_6SVpUJqlEeGSON8vddiWzQ_-315097006")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 Value { get; init; } 
    #else
    public AmountAndDirection34 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the currency type used to report the balance. This is not the ISO code.
    /// </summary>
    [IsoId("_6SVpUZqlEeGSON8vddiWzQ_69385719")]
    [DisplayName("Currency Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyTp")]
    #endif
    [IsoXmlTag("CcyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingCurrencyType1Code? CurrencyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingCurrencyType1Code? CurrencyType { get; init; } 
    #else
    public BillingCurrencyType1Code? CurrencyType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
