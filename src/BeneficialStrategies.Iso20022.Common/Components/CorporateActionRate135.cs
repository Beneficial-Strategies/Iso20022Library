// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate135.
/// </summary>
[IsoId("_nLgdeZt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Rate135")]
public partial record CorporateActionRate135
{
    #nullable enable

    /// <summary>
    /// Bid Interval.
    /// </summary>
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat73Choice_? BidInterval { get; init; } 

    /// <summary>
    /// Declared Rate.
    /// </summary>
    [DisplayName("Declared Rate")]
    [IsoXmlTag("DclrdRate")]
    public RateAndAmountFormat74Choice_? DeclaredRate { get; init; } 

    /// <summary>
    /// Index Factor.
    /// </summary>
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat57Choice_? IndexFactor { get; init; } 

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public RateAndAmountFormat72Choice_? InterestRate { get; init; } 

    /// <summary>
    /// Interest Shortfall.
    /// </summary>
    [DisplayName("Interest Shortfall")]
    [IsoXmlTag("IntrstShrtfll")]
    public RateAndAmountFormat74Choice_? InterestShortfall { get; init; } 

    /// <summary>
    /// Next Factor.
    /// </summary>
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat12Choice_? NextFactor { get; init; } 

    /// <summary>
    /// Percentage Sought.
    /// </summary>
    [DisplayName("Percentage Sought")]
    [IsoXmlTag("PctgSght")]
    public RateFormat25Choice_? PercentageSought { get; init; } 

    /// <summary>
    /// Previous Factor.
    /// </summary>
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat12Choice_? PreviousFactor { get; init; } 

    /// <summary>
    /// Realised Loss.
    /// </summary>
    [DisplayName("Realised Loss")]
    [IsoXmlTag("RealsdLoss")]
    public RateAndAmountFormat74Choice_? RealisedLoss { get; init; } 

    /// <summary>
    /// Reinvestment Discount Rate To Market.
    /// </summary>
    [DisplayName("Reinvestment Discount Rate To Market")]
    [IsoXmlTag("RinvstmtDscntRateToMkt")]
    public RateFormat24Choice_? ReinvestmentDiscountRateToMarket { get; init; } 

    /// <summary>
    /// Related Index.
    /// </summary>
    [DisplayName("Related Index")]
    [IsoXmlTag("RltdIndx")]
    public RateFormat24Choice_? RelatedIndex { get; init; } 

    /// <summary>
    /// Spread.
    /// </summary>
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public RateFormat24Choice_? Spread { get; init; } 

    
    #nullable disable
    
}
