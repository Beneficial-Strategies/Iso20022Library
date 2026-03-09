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
/// Tangible items of value to a business.
/// </summary>
[IsoId("_MQz4EZJOEeuAlLVx8pyt3w")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument97
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instrument which represents a title of ownership in a company, ie, the shareholder is entitled to a part of the company&apos;s profit - usually by payment of a dividend - and to voting rights, if any. Each company issues generally different classes of shares, eg, ordinary or common shares, which have no guaranteed amount of dividend but carry voting rights, or preferred shares, which receive dividends before ordinary shares but have no voting right.
    /// </summary>
    [IsoId("_MS6w4ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Equity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Eqty")]
    #endif
    [IsoXmlTag("Eqty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Equity3? Equity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Equity3? Equity { get; init; } 
    #else
    public Equity3? Equity { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument that gives the holder the right to purchase shares or bonds at a given price within a specified time.
    /// </summary>
    [IsoId("_MS6w45JOEeuAlLVx8pyt3w")]
    [DisplayName("Warrant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Warrt")]
    #endif
    [IsoXmlTag("Warrt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Warrant4? Warrant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Warrant4? Warrant { get; init; } 
    #else
    public Warrant4? Warrant { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments evidencing moneys owed by the issuer to the holder on terms as specified.
    /// </summary>
    [IsoId("_MS6w5ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Debt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Debt")]
    #endif
    [IsoXmlTag("Debt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Debt5? Debt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Debt5? Debt { get; init; } 
    #else
    public Debt5? Debt { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between type of derivatives.
    /// </summary>
    [IsoId("_MS6w55JOEeuAlLVx8pyt3w")]
    [DisplayName("Derivative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Deriv")]
    #endif
    [IsoXmlTag("Deriv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Derivative4? Derivative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Derivative4? Derivative { get; init; } 
    #else
    public Derivative4? Derivative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
