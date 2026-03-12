// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for updated additional information.
/// </summary>
[IsoId("_y2PfPjYnEeGFarbLo5oXPg")]
[DisplayName("Updated Additional Information 5 SD")]
public partial record UpdatedAdditionalInformation5SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_j0sx4FPIEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Total distribution fund rate per share.
    /// 一株あたりの交付金先等の額.
    /// </summary>
    [IsoId("_uFsj9zalEeG9c_thMfkruA")]
    [DisplayName("Distribution Amount Per Share")]
    [IsoXmlTag("DstrbtnAmtPerShr")]
    public RateAndAmountFormat2Choice_? DistributionAmountPerShare { get; init; } 
    
    /// <summary>
    /// Rate information of how much net asset decrease happens as a result of the fund distribution.
    /// </summary>
    [IsoId("_6RimUDLiEeGkgP4mOiMAHQ")]
    [DisplayName("Net Asset Decrease Ratio")]
    [IsoXmlTag("NetAsstDcrRatio")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NetAssetDecreaseRatio { get; init; } 
    
    /// <summary>
    /// Distribution amount of accumulated profit per share.
    /// 一株あたり利益剰余金の額.
    /// </summary>
    [IsoId("_hHelzzeEEeGlwqxdMVcVhg")]
    [DisplayName("Accumulated Profit Per Share")]
    [IsoXmlTag("AcmltdPrftPerShr")]
    public RateAndAmountFormat2Choice_? AccumulatedProfitPerShare { get; init; } 
    
    /// <summary>
    /// Taxable distribution amount of dividend.
    /// 一株あたりみなし配当の額.
    /// </summary>
    [IsoId("_hfUeAzeEEeGlwqxdMVcVhg")]
    [DisplayName("Deemed Dividend Per Share")]
    [IsoXmlTag("DmdDvddPerShr")]
    public RateAndAmountFormat2Choice_? DeemedDividendPerShare { get; init; } 
    
    /// <summary>
    /// Tax exempted distribution amount of dividend. 
    /// 一株あたりみなし譲渡収入の額.
    /// </summary>
    [IsoId("_h9uRWzeEEeGlwqxdMVcVhg")]
    [DisplayName("Residual Distribution Amount Per Share")]
    [IsoXmlTag("RsdlDstrbtnAmtPerShr")]
    public RateAndAmountFormat2Choice_? ResidualDistributionAmountPerShare { get; init; } 
    
    
    #nullable disable
    
}
