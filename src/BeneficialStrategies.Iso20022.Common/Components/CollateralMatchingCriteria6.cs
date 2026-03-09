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
/// Compares information related to both sides of a collateral.
/// </summary>
[IsoId("_A0ExqcK3EeuFNp8LZAnorg")]
[DisplayName("Collateral Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralMatchingCriteria6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_A1bcg8K3EeuFNp8LZAnorg")]
    [DisplayName("Uncollateralised Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UncollsdFlg")]
    #endif
    [IsoXmlTag("UncollsdFlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator3? UncollateralisedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator3? UncollateralisedFlag { get; init; } 
    #else
    public CompareTrueFalseIndicator3? UncollateralisedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_A1bchcK3EeuFNp8LZAnorg")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXpsrCollstnInd")]
    #endif
    [IsoXmlTag("NetXpsrCollstnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator3? NetExposureCollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator3? NetExposureCollateralisationIndicator { get; init; } 
    #else
    public CompareTrueFalseIndicator3? NetExposureCollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_A1bch8K3EeuFNp8LZAnorg")]
    [DisplayName("Collateral Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollValDt")]
    #endif
    [IsoXmlTag("CollValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? CollateralValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? CollateralValueDate { get; init; } 
    #else
    public CompareDate3? CollateralValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the component type is matching or not.
    /// </summary>
    [IsoId("_A1bcicK3EeuFNp8LZAnorg")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCommodityCash4? AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCommodityCash4? AssetType { get; init; } 
    #else
    public SecurityCommodityCash4? AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as security identification are matching or not.
    /// </summary>
    [IsoId("_A1bci8K3EeuFNp8LZAnorg")]
    [DisplayName("Basket Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktIdr")]
    #endif
    [IsoXmlTag("BsktIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareSecurityIdentification4? BasketIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareSecurityIdentification4? BasketIdentifier { get; init; } 
    #else
    public CompareSecurityIdentification4? BasketIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
