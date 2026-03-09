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
[IsoId("_UmfA-dp-Ed-ak6NoX_4Aeg_1051098621")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral3( ActiveCurrencyAndAmount reqPostHaircutValue,ActiveCurrencyAndAmount reqMarketValue,CollateralType2Code reqCollateralType )
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
    [IsoId("_UmoK4Np-Ed-ak6NoX_4Aeg_-843597326")]
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
    /// Value of the underlying collateral (cash, securities, LoC) based on current market prices.
    /// </summary>
    [IsoId("_UmoK4dp-Ed-ak6NoX_4Aeg_347210571")]
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
    [IsoId("_UmoK4tp-Ed-ak6NoX_4Aeg_2099519852")]
    [DisplayName("Collateral Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTp")]
    #endif
    [IsoXmlTag("CollTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralType2Code CollateralType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralType2Code CollateralType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType2Code CollateralType { get; init; } 
    #else
    public CollateralType2Code CollateralType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
