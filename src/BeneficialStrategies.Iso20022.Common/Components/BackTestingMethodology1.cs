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
/// Specifies the characteristics of a backtesting methodology used to test the performance of a risk model.
/// </summary>
[IsoId("_4TLUQLC2EeaSl6vJk5Bd8w")]
[DisplayName("Back Testing Methodology")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BackTestingMethodology1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BackTestingMethodology1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BackTestingMethodology1( ModelType1Choice_ reqRiskModelType,System.Decimal reqModelConfidenceLevel,System.String reqVariationMarginCleanIndicator )
    {
        RiskModelType = reqRiskModelType;
        ModelConfidenceLevel = reqModelConfidenceLevel;
        VariationMarginCleanIndicator = reqVariationMarginCleanIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the core model type, excluding any modifications for pro-cyclicality.
    /// </summary>
    [IsoId("_-fqEoLC2EeaSl6vJk5Bd8w")]
    [DisplayName("Risk Model Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskMdlTp")]
    #endif
    [IsoXmlTag("RskMdlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ModelType1Choice_ RiskModelType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ModelType1Choice_ RiskModelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModelType1Choice_ RiskModelType { get; init; } 
    #else
    public ModelType1Choice_ RiskModelType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the confidence interval used on a daily basis to assess the performance of the model.
    /// </summary>
    [IsoId("_N9vjQLC3EeaSl6vJk5Bd8w")]
    [DisplayName("Model Confidence Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdlCnfdncLvl")]
    #endif
    [IsoXmlTag("MdlCnfdncLvl")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate ModelConfidenceLevel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ModelConfidenceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ModelConfidenceLevel { get; init; } 
    #else
    public System.Decimal ModelConfidenceLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the CCP model calculates mark-to-market changes on fixed portfolios when backtesting.
    /// </summary>
    [IsoId("_1WtGoLC3EeaSl6vJk5Bd8w")]
    [DisplayName("Variation Margin Clean Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnCleanInd")]
    #endif
    [IsoXmlTag("VartnMrgnCleanInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator VariationMarginCleanIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String VariationMarginCleanIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String VariationMarginCleanIndicator { get; init; } 
    #else
    public System.String VariationMarginCleanIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Description of backtesting methodology.
    /// </summary>
    [IsoId("_n56ysMBgEeak3I7j2hsibw")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
