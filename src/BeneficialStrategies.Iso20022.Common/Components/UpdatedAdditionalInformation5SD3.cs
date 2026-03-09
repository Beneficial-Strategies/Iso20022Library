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
/// Extension for updated additional information.
/// </summary>
[IsoId("_X9K4QaXREeOkjarA2DHHxg")]
[DisplayName("Updated Additional Information 5 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdatedAdditionalInformation5SD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_YYUjM6XREeOkjarA2DHHxg")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Total distribution fund rate per share.
    /// 一株あたりの交付金先等の額.
    /// </summary>
    [IsoId("_YYUjNaXREeOkjarA2DHHxg")]
    [DisplayName("Distribution Amount Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnAmtPerShr")]
    #endif
    [IsoXmlTag("DstrbtnAmtPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat36Choice_? DistributionAmountPerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat36Choice_? DistributionAmountPerShare { get; init; } 
    #else
    public RateAndAmountFormat36Choice_? DistributionAmountPerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Rate information of how much net asset decrease happens as a result of the fund distribution.
    /// </summary>
    [IsoId("_YYUjN6XREeOkjarA2DHHxg")]
    [DisplayName("Net Asset Decrease Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAsstDcrRatio")]
    #endif
    [IsoXmlTag("NetAsstDcrRatio")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NetAssetDecreaseRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NetAssetDecreaseRatio { get; init; } 
    #else
    public System.Decimal? NetAssetDecreaseRatio { get; set; } 
    #endif
    
    /// <summary>
    /// Distribution amount of accumulated profit per share.
    /// 一株あたり利益剰余金の額.
    /// </summary>
    [IsoId("_YYUjOaXREeOkjarA2DHHxg")]
    [DisplayName("Accumulated Profit Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltdPrftPerShr")]
    #endif
    [IsoXmlTag("AcmltdPrftPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat36Choice_? AccumulatedProfitPerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat36Choice_? AccumulatedProfitPerShare { get; init; } 
    #else
    public RateAndAmountFormat36Choice_? AccumulatedProfitPerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Taxable distribution amount of dividend.
    /// 一株あたりみなし配当の額.
    /// </summary>
    [IsoId("_YYUjO6XREeOkjarA2DHHxg")]
    [DisplayName("Deemed Dividend Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdDvddPerShr")]
    #endif
    [IsoXmlTag("DmdDvddPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat36Choice_? DeemedDividendPerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat36Choice_? DeemedDividendPerShare { get; init; } 
    #else
    public RateAndAmountFormat36Choice_? DeemedDividendPerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Tax exempted distribution amount of dividend. 
    /// 一株あたりみなし譲渡収入の額.
    /// </summary>
    [IsoId("_YYUjPaXREeOkjarA2DHHxg")]
    [DisplayName("Residual Distribution Amount Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlDstrbtnAmtPerShr")]
    #endif
    [IsoXmlTag("RsdlDstrbtnAmtPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat36Choice_? ResidualDistributionAmountPerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat36Choice_? ResidualDistributionAmountPerShare { get; init; } 
    #else
    public RateAndAmountFormat36Choice_? ResidualDistributionAmountPerShare { get; set; } 
    #endif
    
    
    #nullable disable
    
}
