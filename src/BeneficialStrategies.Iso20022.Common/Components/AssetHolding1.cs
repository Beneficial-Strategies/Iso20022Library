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
/// Holding of a financial asset as collateral.
/// </summary>
[IsoId("_4DvF8K_5EeaE9YROwd69hA")]
[DisplayName("Asset Holding")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AssetHolding1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AssetHolding1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AssetHolding1( ActiveCurrencyAnd24Amount reqPostHaircutValue,AssetHolding1Choice_ reqAssetType,CollateralAccountType3Code reqCollateralRequirement )
    {
        PostHaircutValue = reqPostHaircutValue;
        AssetType = reqAssetType;
        CollateralRequirement = reqCollateralRequirement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Mark-to-market post-haircut value of the collateral asset holding.
    /// </summary>
    [IsoId("_bH-r0K_6EeaE9YROwd69hA")]
    [DisplayName("Post Haircut Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstHrcutVal")]
    #endif
    [IsoXmlTag("PstHrcutVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd24Amount PostHaircutValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd24Amount PostHaircutValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd24Amount PostHaircutValue { get; init; } 
    #else
    public ActiveCurrencyAnd24Amount PostHaircutValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies financial instrument pledged as collateral.
    /// </summary>
    [IsoId("_BrEMkK_6EeaE9YROwd69hA")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetHolding1Choice_ AssetType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetHolding1Choice_ AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetHolding1Choice_ AssetType { get; init; } 
    #else
    public AssetHolding1Choice_ AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether collateral relates to default fund requirements or initial margin requirements.
    /// </summary>
    [IsoId("_6pTkAbbeEeaqL_M7XFD7PQ")]
    [DisplayName("Collateral Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollRqrmnt")]
    #endif
    [IsoXmlTag("CollRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAccountType3Code CollateralRequirement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAccountType3Code CollateralRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccountType3Code CollateralRequirement { get; init; } 
    #else
    public CollateralAccountType3Code CollateralRequirement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
