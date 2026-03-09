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
/// Provides the current and market value of the collateral held.
/// </summary>
[IsoId("_-dm5JqMOEeCojJW5vEuTEQ_455413091")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral6( ActiveCurrencyAndAmount reqPostHaircutValue,ActiveCurrencyAndAmount reqMarketValue,CollateralType1Code reqCollateralType )
    {
        PostHaircutValue = reqPostHaircutValue;
        MarketValue = reqMarketValue;
        CollateralType = reqCollateralType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the collateral after deduction of a percentage (the haircut) that reflects the perceived risk associated with holding this collateral.
    /// </summary>
    [IsoId("_-dm5J6MOEeCojJW5vEuTEQ_341574025")]
    [DisplayName("Post Haircut Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstHrcutVal")]
    #endif
    [IsoXmlTag("PstHrcutVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PostHaircutValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PostHaircutValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PostHaircutValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount PostHaircutValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the underlying collateral (cash, securities, Letter of credit.) based on current market prices.
    /// </summary>
    [IsoId("_-dm5KKMOEeCojJW5vEuTEQ_-541659262")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MarketValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MarketValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the type of collateral, such as securities or cash.
    /// </summary>
    [IsoId("_-dm5KaMOEeCojJW5vEuTEQ_-655498328")]
    [DisplayName("Collateral Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTp")]
    #endif
    [IsoXmlTag("CollTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralType1Code CollateralType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralType1Code CollateralType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType1Code CollateralType { get; init; } 
    #else
    public CollateralType1Code CollateralType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
