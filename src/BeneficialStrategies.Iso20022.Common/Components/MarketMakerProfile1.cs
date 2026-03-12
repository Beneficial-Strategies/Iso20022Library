// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Market maker profile.
/// </summary>
[IsoId("_Mtd3oCDWEeWCLu74WLgP4w")]
[DisplayName("Market Maker Profile")]
public partial record MarketMakerProfile1
{
    #nullable enable
    
    /// <summary>
    /// Period of the contract.
    /// </summary>
    [IsoId("_WSwW4CDWEeWCLu74WLgP4w")]
    [DisplayName("Contract Period")]
    [IsoXmlTag("CtrctPrd")]
    public DateTimePeriodDetails1? ContractPeriod { get; init; } 
    
    /// <summary>
    /// Indicates whether the market maker is obligated to comply with the requirements of the contract it holds with the exchange or is exempt from these obligations.
    /// </summary>
    [IsoId("_YTJhUCDWEeWCLu74WLgP4w")]
    [DisplayName("Compliance")]
    [IsoXmlTag("Cmplc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Compliance { get; init; } 
    
    /// <summary>
    /// Percentage of the variation between the maximum accepted minimum and maximum value of an action.
    /// </summary>
    [IsoId("_bAeqQCDWEeWCLu74WLgP4w")]
    [DisplayName("Maximum Spread")]
    [IsoXmlTag("MaxSprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumSpread { get; init; } 
    
    /// <summary>
    /// Rate of discount.
    /// </summary>
    [IsoId("_cvxdoCDWEeWCLu74WLgP4w")]
    [DisplayName("Discount")]
    [IsoXmlTag("Dscnt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Discount { get; init; } 
    
    
    #nullable disable
    
}
