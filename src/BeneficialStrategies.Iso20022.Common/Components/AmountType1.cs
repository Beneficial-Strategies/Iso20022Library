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
/// Specifies ranged amounts, for a specific currency and type of amount.
/// </summary>
[IsoId("_dqmJYKHfEeagRbKvRt3LnA")]
[DisplayName("Amount Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountType1( TypeOfAmount9Code reqType,ImpliedCurrencyAndAmount reqFromAmount,ImpliedCurrencyAndAmount reqToAmount )
    {
        Type = reqType;
        FromAmount = reqFromAmount;
        ToAmount = reqToAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of amount.
    /// </summary>
    [IsoId("_vw3LMKHfEeagRbKvRt3LnA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount9Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount9Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount9Code Type { get; init; } 
    #else
    public TypeOfAmount9Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency code of the ranged amount.
    /// </summary>
    [IsoId("_CPG9QKHiEeagRbKvRt3LnA")]
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
    /// Specifies the lowest amount value.
    /// </summary>
    [IsoId("_IYpuYKHiEeagRbKvRt3LnA")]
    [DisplayName("From Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrAmt")]
    #endif
    [IsoXmlTag("FrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount FromAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount FromAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount FromAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount FromAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the highest amount value.
    /// </summary>
    [IsoId("_Xyci4KHiEeagRbKvRt3LnA")]
    [DisplayName("To Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToAmt")]
    #endif
    [IsoXmlTag("ToAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ToAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ToAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ToAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ToAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
