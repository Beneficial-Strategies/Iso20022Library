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
[IsoId("_bPnyNaoxEemhJ7JnT2LsoQ")]
[DisplayName("Collateral Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralMatchingCriteria3
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
    [IsoId("_bTWboaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Uncollateralised Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UncollsdFlg")]
    #endif
    [IsoXmlTag("UncollsdFlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator2? UncollateralisedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator2? UncollateralisedFlag { get; init; } 
    #else
    public CompareTrueFalseIndicator2? UncollateralisedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_bTWbo6oxEemhJ7JnT2LsoQ")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXpsrCollstnInd")]
    #endif
    [IsoXmlTag("NetXpsrCollstnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator2? NetExposureCollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator2? NetExposureCollateralisationIndicator { get; init; } 
    #else
    public CompareTrueFalseIndicator2? NetExposureCollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_bTWbpaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Collateral Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollValDt")]
    #endif
    [IsoXmlTag("CollValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? CollateralValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? CollateralValueDate { get; init; } 
    #else
    public CompareDate2? CollateralValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the infromation on the component type is matching or not.
    /// </summary>
    [IsoId("_bTWbqaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpntTp")]
    #endif
    [IsoXmlTag("CmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCommodityCash1? ComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCommodityCash1? ComponentType { get; init; } 
    #else
    public SecurityCommodityCash1? ComponentType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as security identification are matching or not.
    /// </summary>
    [IsoId("_bTWbyaoxEemhJ7JnT2LsoQ")]
    [DisplayName("Basket Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktIdr")]
    #endif
    [IsoXmlTag("BsktIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareSecurityIdentification2? BasketIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareSecurityIdentification2? BasketIdentifier { get; init; } 
    #else
    public CompareSecurityIdentification2? BasketIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
